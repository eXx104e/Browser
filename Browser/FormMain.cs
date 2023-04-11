using Browser.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Browser
{
    public partial class FormMain : Form
    {
        static int index = -1;
        static List<string> thisListRecordsHistory = new List<string>();

        static List<Button> listButtonsHistory = new List<Button>();
        static List<Button> listButtonsBookmarks = new List<Button>();

        static List<Panel> listPanelsRecordsHistory = new List<Panel>();
        static List<Panel> listPanelsRecordsBookmarks = new List<Panel>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            XmlRequests.DeleteHistoryAfterWeekHistory();

            toolStripButtonBack.Enabled = false;
            toolStripButtonGo.Enabled = false;
            toolStripButtonUpdate.Enabled = false;
            toolStripButtonStop.Enabled = false;
            toolStripButtonAddInBookmarks.Enabled = false;

            toolStripTextBoxNavigation.Visible = false;

            panelHistory.Visible = false;
            panelBookmarks.Visible = false;

            panelStart.ContextMenuStrip = contextMenuStripBrowser;
        }

        private void textBoxStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (String.IsNullOrEmpty(textBoxStart.Text))
                {
                    MessageBox.Show("Вы ничего не ввели");
                }
                else
                {
                    toolStripButtonUpdate.Enabled = true;
                    toolStripButtonStop.Enabled = true;
                    toolStripTextBoxNavigation.Visible = true;
                    toolStripButtonAddInBookmarks.Enabled = true;
                    panelStart.Visible = false;

                    webBrowserFormMain.Navigate(textBoxStart.Text);

                    XmlRequests.AddToRecordsHistory(textBoxStart.Text, DateTime.Now);

                    index++;
                    thisListRecordsHistory.Add(textBoxStart.Text);
                }
            }
        }

        private void toolStripButtonBack_Click(object sender, EventArgs e)
        {
            webBrowserFormMain.GoBack();
            index--;

            if (index == 0)
            {
                toolStripButtonBack.Enabled = false;
            }

            if (index < thisListRecordsHistory.Count && !toolStripButtonGo.Enabled)
            {
                toolStripButtonGo.Enabled = true;
            }
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            webBrowserFormMain.GoForward();
            index++;

            if (index == thisListRecordsHistory.Count - 1)
            {
                toolStripButtonGo.Enabled = false;
            }

            if (index >= 0 && !toolStripButtonBack.Enabled)
            {
                toolStripButtonBack.Enabled = true;
            }
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            webBrowserFormMain.Refresh();
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            webBrowserFormMain.Stop();
        }

        private void toolStripButtonAddInBookmarks_Click(object sender, EventArgs e)
        {
            XmlRequests.AddNewBookmark(thisListRecordsHistory[index]);
        }

        private void toolStripButtonHistory_Click(object sender, EventArgs e)
        {
            webBrowserFormMain.Visible = false;
            panelBookmarks.Visible = false;
            panelStart.Visible = true;
            panelHistory.Visible = true;

            List<string[]> records = XmlRequests.GetOfRecordsHistory();

            for (int i = 0; i < records.Count; i++)
            {
                TextBox textBoxUrl = new TextBox
                {
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                    Location = new Point(176, 5),
                    Name = $"textBoxUrl{i}",
                    Size = new Size(700, 26),
                    TabIndex = i,
                    Text = records[i][0].ToString()
                };


                Label labelDate = new Label
                {
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                    Location = new Point(13, 9),
                    Name = $"labelDate{i}",
                    Size = new Size(140, 18),
                    TabIndex = i + 1,
                    Text = records[i][1].ToString()
                };


                Button buttonDeleteRecord = new Button
                {
                    Location = new Point(882, 6),
                    Name = $"buttonDeleteRecord{i}",
                    Size = new Size(65, 23),
                    TabIndex = i + 2,
                    Text = "Удалить",
                    UseVisualStyleBackColor = true,
                    Tag = i
                };
                buttonDeleteRecord.Click += buttonDeleteRecordHistory_Click;
                listButtonsHistory.Add(buttonDeleteRecord);


                Panel panel = new Panel
                {
                    Location = new Point(9, 45 + (45 * i)),
                    Name = $"panel{i}",
                    Size = new Size(963, 39),
                    TabIndex = i + 3,
                    Tag = i
                };
                panel.Controls.Add(labelDate);
                panel.Controls.Add(textBoxUrl);
                panel.Controls.Add(buttonDeleteRecord);

                panelHistory.Controls.Add(panel);
                listPanelsRecordsHistory.Add(panel);
            }
        }

        private void toolStripButtonBookmars_Click(object sender, EventArgs e)
        {
            webBrowserFormMain.Visible = false;
            panelStart.Visible = true;
            panelHistory.Visible = true;
            panelBookmarks.Visible = true;

            List<string> records = XmlRequests.GetOfRecordsBookmarks();

            for (int i = 0; i < records.Count; i++)
            {
                LinkLabel linkLabelUrl = new LinkLabel
                {
                    ActiveLinkColor = Color.Black,
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                    LinkColor = Color.Black,
                    Location = new Point(176, 5),
                    Name = $"linkLabelUrl{i}",
                    Size = new Size(50, 15),
                    TabIndex = i,
                    Tag = i,
                    TabStop = true,
                    Text = $"http://{records[i]}"
                };
                linkLabelUrl.LinkClicked += linkLabelUrl_LinkClicked;


                TextBox textBoxShortUrl = new TextBox
                {
                    AutoSize = true,
                    Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                    Location = new Point(13, 9),
                    Name = $"labelDate{i}",
                    Size = new Size(140, 18),
                    TabIndex = i + 1,
                    Text = records[i].ToString()
                };


                Button buttonDeleteRecord = new Button
                {
                    Location = new Point(882, 6),
                    Name = $"buttonDeleteRecord{i}",
                    Size = new Size(65, 23),
                    TabIndex = i + 2,
                    Text = "Удалить",
                    UseVisualStyleBackColor = true,
                    Tag = i
                };
                buttonDeleteRecord.Click += buttonDeleteRecordBookmarks_Click;
                listButtonsBookmarks.Add(buttonDeleteRecord);


                Panel panel = new Panel
                {
                    Location = new Point(9, 45 + (45 * i)),
                    Name = $"panel{i}",
                    Size = new Size(963, 39),
                    TabIndex = i + 3,
                    Tag = i
                };
                panel.Controls.Add(linkLabelUrl);
                panel.Controls.Add(textBoxShortUrl);
                panel.Controls.Add(buttonDeleteRecord);

                panelBookmarks.Controls.Add(panel);
                listPanelsRecordsBookmarks.Add(panel);
            }
        }

        private void toolStripTextBoxNavigation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (String.IsNullOrEmpty(textBoxStart.Text))
                {
                    MessageBox.Show("Вы ничего не ввели");
                }
                else
                {
                    webBrowserFormMain.Navigate(toolStripTextBoxNavigation.Text);
                    XmlRequests.AddToRecordsHistory(toolStripTextBoxNavigation.Text, DateTime.Now);

                    thisListRecordsHistory.Add(toolStripTextBoxNavigation.Text);
                    index++;

                    if (index > 0)
                    {
                        toolStripButtonBack.Enabled = true;
                    }
                }
            }
        }

        private void linkLabelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelHistory.Visible = false;
            webBrowserFormMain.Visible = true;
            
            for (int i = 0; i < listPanelsRecordsHistory.Count; i++)
            {
                listPanelsRecordsHistory[i].Dispose();
            }
            listPanelsRecordsHistory.Clear();
        }

        private void buttonDeleteRecordHistory_Click(object sender, EventArgs e)
        {
            int this_Tag = int.Parse(((Button)sender).Tag.ToString());

            for (int i = this_Tag + 1; i < listPanelsRecordsHistory.Count; i++)
            {
                listPanelsRecordsHistory[i].Location = new Point(listPanelsRecordsHistory[i].Location.X, listPanelsRecordsHistory[i].Location.Y - 45);
                listButtonsHistory[i].Tag = i - 1;
                listPanelsRecordsHistory[i].Tag = i - 1;
            }
            listPanelsRecordsHistory[this_Tag].Dispose();
            listButtonsHistory.RemoveAt(this_Tag);
            listPanelsRecordsHistory.RemoveAt(this_Tag);
            

            XmlRequests.DeleteRecordFromHistory(this_Tag);
        }


        private void buttonDeleteRecordBookmarks_Click(object sender, EventArgs e)
        {
            int this_Tag = int.Parse(((Button)sender).Tag.ToString());

            for (int i = this_Tag + 1; i < listPanelsRecordsBookmarks.Count; i++)
            {
                listPanelsRecordsBookmarks[i].Location = new Point(listPanelsRecordsBookmarks[i].Location.X, listPanelsRecordsBookmarks[i].Location.Y - 45);
                listButtonsBookmarks[i].Tag = i - 1;
                listPanelsRecordsBookmarks[i].Tag = i - 1;
            }
            listPanelsRecordsBookmarks[this_Tag].Dispose();
            listPanelsRecordsBookmarks.RemoveAt(this_Tag);
            listButtonsBookmarks.RemoveAt(this_Tag);

            XmlRequests.DeleteBookmark(this_Tag);
        }


        private void linkLabelBookmarsBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelHistory.Visible = false;
            panelBookmarks.Visible = false;
            panelStart.Visible = true;
        }

        private void linkLabelClearAllHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < listPanelsRecordsHistory.Count; i++)
            {
                listPanelsRecordsHistory[i].Dispose();
                XmlRequests.DeleteRecordFromHistory(0);
            }
            listPanelsRecordsHistory.Clear();
        }

        private void сохранитьНаДискеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowserFormMain.ShowSaveAsDialog();
        }

        private void linkLabelUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int this_Tag = int.Parse(((LinkLabel)sender).Tag.ToString());
            List<string> records = XmlRequests.GetOfRecordsBookmarks();

            panelBookmarks.Visible = false;
            panelHistory.Visible = false;
            panelStart.Visible = false;
            webBrowserFormMain.Visible = true;

            webBrowserFormMain.Navigate($"http://{records[this_Tag]}");
        }
    }
}
