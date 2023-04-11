namespace Browser
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripNavigation = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAddInBookmarks = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBookmars = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxNavigation = new System.Windows.Forms.ToolStripTextBox();
            this.webBrowserFormMain = new System.Windows.Forms.WebBrowser();
            this.contextMenuStripBrowser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьНаДискеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelStart = new System.Windows.Forms.Panel();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.panelBookmarks = new System.Windows.Forms.Panel();
            this.labelBookmars = new System.Windows.Forms.Label();
            this.linkLabelBookmarsBack = new System.Windows.Forms.LinkLabel();
            this.labelHistory = new System.Windows.Forms.Label();
            this.linkLabelClearAllHistory = new System.Windows.Forms.LinkLabel();
            this.linkLabelBack = new System.Windows.Forms.LinkLabel();
            this.textBoxStart = new System.Windows.Forms.TextBox();
            this.labelSearchStart = new System.Windows.Forms.Label();
            this.toolStripNavigation.SuspendLayout();
            this.contextMenuStripBrowser.SuspendLayout();
            this.panelStart.SuspendLayout();
            this.panelHistory.SuspendLayout();
            this.panelBookmarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripNavigation
            // 
            this.toolStripNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonBack,
            this.toolStripButtonGo,
            this.toolStripButtonUpdate,
            this.toolStripButtonStop,
            this.toolStripButtonAddInBookmarks,
            this.toolStripButtonHistory,
            this.toolStripButtonBookmars,
            this.toolStripTextBoxNavigation});
            this.toolStripNavigation.Location = new System.Drawing.Point(0, 0);
            this.toolStripNavigation.Name = "toolStripNavigation";
            this.toolStripNavigation.Size = new System.Drawing.Size(1107, 25);
            this.toolStripNavigation.TabIndex = 0;
            this.toolStripNavigation.Text = "toolStrip1";
            // 
            // toolStripButtonBack
            // 
            this.toolStripButtonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.toolStripButtonBack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBack.Image")));//
            this.toolStripButtonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBack.Name = "toolStripButtonBack";
            this.toolStripButtonBack.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBack.Text = "<";
            this.toolStripButtonBack.Click += new System.EventHandler(this.toolStripButtonBack_Click);
            // 
            // toolStripButtonGo
            // 
            this.toolStripButtonGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.toolStripButtonGo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGo.Image")));//
            this.toolStripButtonGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGo.Name = "toolStripButtonGo";
            this.toolStripButtonGo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGo.Text = ">";
            this.toolStripButtonGo.Click += new System.EventHandler(this.toolStripButtonGo_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));//
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonUpdate.Text = "Обновить";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));//
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonStop.Text = "X";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripButtonAddInBookmarks
            // 
            this.toolStripButtonAddInBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.toolStripButtonAddInBookmarks.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddInBookmarks.Image")));
            this.toolStripButtonAddInBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddInBookmarks.Name = "toolStripButtonAddInBookmarks";
            this.toolStripButtonAddInBookmarks.Size = new System.Drawing.Size(124, 22);
            this.toolStripButtonAddInBookmarks.Text = "Добавить в закладки";
            this.toolStripButtonAddInBookmarks.Click += new System.EventHandler(this.toolStripButtonAddInBookmarks_Click);
            // 
            // toolStripButtonHistory
            // 
            this.toolStripButtonHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.toolStripButtonHistory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHistory.Image")));
            this.toolStripButtonHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHistory.Name = "toolStripButtonHistory";
            this.toolStripButtonHistory.Size = new System.Drawing.Size(58, 22);
            this.toolStripButtonHistory.Text = "История";
            this.toolStripButtonHistory.Click += new System.EventHandler(this.toolStripButtonHistory_Click);
            // 
            // toolStripButtonBookmars
            // 
            this.toolStripButtonBookmars.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            //this.toolStripButtonBookmars.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBookmars.Image")));
            this.toolStripButtonBookmars.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripButtonBookmars.Name = "toolStripButtonBookmars";
            this.toolStripButtonBookmars.Size = new System.Drawing.Size(62, 22);
            this.toolStripButtonBookmars.Text = "Закладки";
            this.toolStripButtonBookmars.Click += new System.EventHandler(this.toolStripButtonBookmars_Click);
            // 
            // toolStripTextBoxNavigation
            // 
            this.toolStripTextBoxNavigation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripTextBoxNavigation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxNavigation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxNavigation.Name = "toolStripTextBoxNavigation";
            this.toolStripTextBoxNavigation.Size = new System.Drawing.Size(600, 25);
            this.toolStripTextBoxNavigation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBoxNavigation_KeyPress);
            // 
            // webBrowserFormMain
            // 
            this.webBrowserFormMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserFormMain.ContextMenuStrip = this.contextMenuStripBrowser;
            this.webBrowserFormMain.IsWebBrowserContextMenuEnabled = false;
            this.webBrowserFormMain.Location = new System.Drawing.Point(0, 28);
            this.webBrowserFormMain.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserFormMain.Name = "webBrowserFormMain";
            this.webBrowserFormMain.Size = new System.Drawing.Size(1107, 640);
            this.webBrowserFormMain.TabIndex = 2;
            // 
            // contextMenuStripBrowser
            // 
            this.contextMenuStripBrowser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьНаДискеToolStripMenuItem});
            this.contextMenuStripBrowser.Name = "contextMenuStripBrowser";
            this.contextMenuStripBrowser.Size = new System.Drawing.Size(182, 26);
            // 
            // сохранитьНаДискеToolStripMenuItem
            // 
            this.сохранитьНаДискеToolStripMenuItem.Name = "сохранитьНаДискеToolStripMenuItem";
            this.сохранитьНаДискеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.сохранитьНаДискеToolStripMenuItem.Text = "сохранить на диске";
            this.сохранитьНаДискеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьНаДискеToolStripMenuItem_Click);
            // 
            // panelStart
            // 
            this.panelStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStart.Controls.Add(this.panelHistory);
            this.panelStart.Controls.Add(this.textBoxStart);
            this.panelStart.Controls.Add(this.labelSearchStart);
            this.panelStart.Location = new System.Drawing.Point(0, 28);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(1107, 640);
            this.panelStart.TabIndex = 3;
            // 
            // panelHistory
            // 
            this.panelHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHistory.AutoScroll = true;
            this.panelHistory.Controls.Add(this.panelBookmarks);
            this.panelHistory.Controls.Add(this.labelHistory);
            this.panelHistory.Controls.Add(this.linkLabelClearAllHistory);
            this.panelHistory.Controls.Add(this.linkLabelBack);
            this.panelHistory.Location = new System.Drawing.Point(3, 0);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(1104, 640);
            this.panelHistory.TabIndex = 2;
            // 
            // panelBookmarks
            // 
            this.panelBookmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBookmarks.Controls.Add(this.labelBookmars);
            this.panelBookmarks.Controls.Add(this.linkLabelBookmarsBack);
            this.panelBookmarks.Location = new System.Drawing.Point(-3, 0);
            this.panelBookmarks.Name = "panelBookmarks";
            this.panelBookmarks.Size = new System.Drawing.Size(1107, 640);
            this.panelBookmarks.TabIndex = 3;
            // 
            // labelBookmars
            // 
            this.labelBookmars.AutoSize = true;
            this.labelBookmars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBookmars.Location = new System.Drawing.Point(13, 9);
            this.labelBookmars.Name = "labelBookmars";
            this.labelBookmars.Size = new System.Drawing.Size(107, 25);
            this.labelBookmars.TabIndex = 5;
            this.labelBookmars.Text = "Закладки";
            // 
            // linkLabelBookmarsBack
            // 
            this.linkLabelBookmarsBack.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelBookmarsBack.AutoSize = true;
            this.linkLabelBookmarsBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelBookmarsBack.LinkColor = System.Drawing.Color.Black;
            this.linkLabelBookmarsBack.Location = new System.Drawing.Point(990, 10);
            this.linkLabelBookmarsBack.Name = "linkLabelBookmarsBack";
            this.linkLabelBookmarsBack.Size = new System.Drawing.Size(105, 24);
            this.linkLabelBookmarsBack.TabIndex = 4;
            this.linkLabelBookmarsBack.TabStop = true;
            this.linkLabelBookmarsBack.Text = "Вернуться";
            this.linkLabelBookmarsBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBookmarsBack_LinkClicked);
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHistory.Location = new System.Drawing.Point(9, 9);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(153, 24);
            this.labelHistory.TabIndex = 2;
            this.labelHistory.Text = "История поиска";
            // 
            // linkLabelClearAllHistory
            // 
            this.linkLabelClearAllHistory.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelClearAllHistory.AutoSize = true;
            this.linkLabelClearAllHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelClearAllHistory.LinkColor = System.Drawing.Color.Black;
            this.linkLabelClearAllHistory.Location = new System.Drawing.Point(442, 12);
            this.linkLabelClearAllHistory.Name = "linkLabelClearAllHistory";
            this.linkLabelClearAllHistory.Size = new System.Drawing.Size(152, 20);
            this.linkLabelClearAllHistory.TabIndex = 1;
            this.linkLabelClearAllHistory.TabStop = true;
            this.linkLabelClearAllHistory.Text = "Очистить историю";
            this.linkLabelClearAllHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearAllHistory_LinkClicked);
            // 
            // linkLabelBack
            // 
            this.linkLabelBack.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelBack.AutoSize = true;
            this.linkLabelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelBack.LinkColor = System.Drawing.Color.Black;
            this.linkLabelBack.Location = new System.Drawing.Point(987, 10);
            this.linkLabelBack.Name = "linkLabelBack";
            this.linkLabelBack.Size = new System.Drawing.Size(105, 24);
            this.linkLabelBack.TabIndex = 0;
            this.linkLabelBack.TabStop = true;
            this.linkLabelBack.Text = "Вернуться";
            this.linkLabelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelBack_LinkClicked);
            // 
            // textBoxStart
            // 
            this.textBoxStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStart.Location = new System.Drawing.Point(361, 281);
            this.textBoxStart.Name = "textBoxStart";
            this.textBoxStart.Size = new System.Drawing.Size(413, 29);
            this.textBoxStart.TabIndex = 1;
            this.textBoxStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_KeyPress);
            // 
            // labelSearchStart
            // 
            this.labelSearchStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSearchStart.AutoSize = true;
            this.labelSearchStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearchStart.Location = new System.Drawing.Point(506, 206);
            this.labelSearchStart.Name = "labelSearchStart";
            this.labelSearchStart.Size = new System.Drawing.Size(105, 37);
            this.labelSearchStart.TabIndex = 0;
            this.labelSearchStart.Text = "Поиск";
            // 
            // FormMain
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1107, 667);
            this.Controls.Add(this.panelStart);
            this.Controls.Add(this.webBrowserFormMain);
            this.Controls.Add(this.toolStripNavigation);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStripNavigation.ResumeLayout(false);
            this.toolStripNavigation.PerformLayout();
            this.contextMenuStripBrowser.ResumeLayout(false);
            this.panelStart.ResumeLayout(false);
            this.panelStart.PerformLayout();
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            this.panelBookmarks.ResumeLayout(false);
            this.panelBookmarks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripNavigation;
        private System.Windows.Forms.ToolStripButton toolStripButtonBack;
        private System.Windows.Forms.ToolStripButton toolStripButtonGo;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddInBookmarks;
        private System.Windows.Forms.ToolStripButton toolStripButtonHistory;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxNavigation;
        private System.Windows.Forms.WebBrowser webBrowserFormMain;
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.TextBox textBoxStart;
        private System.Windows.Forms.Label labelSearchStart;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.LinkLabel linkLabelBack;
        private System.Windows.Forms.LinkLabel linkLabelClearAllHistory;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.Panel panelBookmarks;
        private System.Windows.Forms.ToolStripButton toolStripButtonBookmars;
        private System.Windows.Forms.Label labelBookmars;
        private System.Windows.Forms.LinkLabel linkLabelBookmarsBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBrowser;
        private System.Windows.Forms.ToolStripMenuItem сохранитьНаДискеToolStripMenuItem;
    }
}

