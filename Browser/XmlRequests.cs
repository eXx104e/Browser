using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.LinkLabel;

namespace Browser
{
    internal class XmlRequests
    {
        /// <summary>
        /// Добавляет новую запись в xml файл с историей поиска
        /// </summary>
        /// <param name="link"></param>
        /// <param name="date"></param>
        public static void AddToRecordsHistory(string link, DateTime date)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"./../../History.xml");
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            // создаем новый элемент record
            XmlElement recordElem = xmlDoc.CreateElement("record");

            // создаем элементы link и date
            XmlElement linkElem = xmlDoc.CreateElement("link");
            XmlElement dateElem = xmlDoc.CreateElement("date");

            // создаем текстовые значения для элементов
            XmlText linkText = xmlDoc.CreateTextNode(link);
            XmlText dateText = xmlDoc.CreateTextNode(date.ToString());

            //добавляем узлы
            linkElem.AppendChild(linkText);
            dateElem.AppendChild(dateText);

            // добавляем элементы link и date
            recordElem.AppendChild(linkElem);
            recordElem.AppendChild(dateElem);

            // добавляем в корневой элемент новый элемент record
            xmlRoot.AppendChild(recordElem);

            // сохраняем изменения xml-документа в файл
            xmlDoc.Save(@"./../../History.xml");
        }


        /// <summary>
        /// Возвращает список записей посещения сайтов, где каждый элемент состоит из двух (0 - ссылка(string), 1 - дата(string))
        /// </summary>
        /// <returns></returns>
        public static List<string[]> GetOfRecordsHistory()
        {
            List<string[]> listLinkAndDate = new List<string[]>();
            // ссылка и дата посещения страницы

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"./../../History.xml");
            // получим корневой элемент
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            if (xmlRoot != null)
            {
                // обход всех узлов в корневом элементе
                foreach (XmlElement xmlNode in xmlRoot)
                {
                    string this_link = "";
                    string this_date = "";

                    // обходим все дочерние узлы элемента record
                    foreach (XmlNode childnode in xmlNode.ChildNodes)
                    {
                        // если узел - link
                        if (childnode.Name == "link")
                        {
                            this_link = childnode.InnerText;
                        }
                        // если узел date
                        if (childnode.Name == "date")
                        {
                            this_date = childnode.InnerText;
                        }

                        if (!this_link.Equals("") && !this_date.Equals(""))
                        {
                            listLinkAndDate.Add(new string[] { this_link, this_date });
                        }
                    }
                }
            }
            return listLinkAndDate;
        }


        /// <summary>
        /// Удаляет из истории поиска запись с указанным индексом
        /// </summary>
        /// <param name="index"></param>
        public static void DeleteRecordFromHistory(int index)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"./../../History.xml");
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            xmlRoot.RemoveChild(xmlRoot.ChildNodes[index]);
            xmlDoc.Save(@"./../../History.xml");
        }


        /// <summary>
        /// Удаляет из истории поиска все, все записи позднее недели считая от нынешнего дня
        /// </summary>
        public static void DeleteHistoryAfterWeekHistory()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"./../../History.xml");
            // получим корневой элемент
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            if (xmlRoot != null)
            {
                // обход всех узлов в корневом элементе
                foreach (XmlElement xmlNode in xmlRoot)
                {
                    // обходим все дочерние узлы элемента record
                    for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                    {
                        // если узел date
                        if (xmlNode.ChildNodes[i].Name == "date")
                        {
                            DateTime dateRecord = DateTime.Parse(xmlNode.ChildNodes[i].InnerText.ToString());

                            TimeSpan sevenDays = new TimeSpan(7, 0, 0, 0);

                            if (dateRecord - DateTime.Now > sevenDays)
                            {
                                xmlRoot.RemoveChild(xmlRoot.ChildNodes[i]);
                            }
                        }
                    } 
                }
            }
            xmlDoc.Save(@"./../../History.xml");
        }


        /// <summary>
        /// Добавить новую закладку
        /// </summary>
        /// <param name="link"></param>
        public static void AddNewBookmark(string link)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"./../../Bookmarks.xml");
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            // создаем новый элемент record
            XmlElement recordElem = xmlDoc.CreateElement("record");

            // создаем элементы link и date
            XmlElement linkElem = xmlDoc.CreateElement("link");

            // создаем текстовые значения для элементов
            XmlText linkText = xmlDoc.CreateTextNode(link);

            //добавляем узлы
            linkElem.AppendChild(linkText);

            // добавляем элементы link и date
            recordElem.AppendChild(linkElem);

            // добавляем в корневой элемент новый элемент record
            xmlRoot.AppendChild(recordElem);

            // сохраняем изменения xml-документа в файл
            xmlDoc.Save(@"./../../Bookmarks.xml");
        }


        /// <summary>
        /// Удаляет запись с подходящим индексом
        /// </summary>
        /// <param name="index"></param>
        public static void DeleteBookmark(int index)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"./../../Bookmarks.xml");
            // получим корневой элемент
            XmlElement xmlRoot = xmlDoc.DocumentElement;


            xmlRoot.RemoveChild(xmlRoot.ChildNodes[index]);

            if (xmlRoot != null)
            {
                // обход всех узлов в корневом элементе
                foreach (XmlElement xmlNode in xmlRoot)
                {
                    //xmlRoot.RemoveChild(xmlRoot.ChildNodes[index]);


                    /*

                    // обходим все дочерние узлы элемента record
                    for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
                    {
                        // если узел date
                        if (xmlNode.ChildNodes[i].Name == "link")
                        {
                            if (xmlNode.ChildNodes[i].InnerText.Equals(link))
                            {
                                xmlRoot.RemoveChild(xmlRoot.ChildNodes[i]);
                            }
                        }
                    }

                    */
                }
            }
            xmlDoc.Save(@"./../../Bookmarks.xml");
        }



        /// <summary>
        /// Возвращает список ссылок избранный сайтов
        /// </summary>
        /// <returns></returns>
        public static List<string> GetOfRecordsBookmarks()
        {
            List<string> listLink = new List<string>();
            // ссылка и дата посещения страницы

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"./../../Bookmarks.xml");
            // получим корневой элемент
            XmlElement xmlRoot = xmlDoc.DocumentElement;

            if (xmlRoot != null)
            {
                // обход всех узлов в корневом элементе
                foreach (XmlElement xmlNode in xmlRoot)
                {
                    // обходим все дочерние узлы элемента record
                    foreach (XmlNode childnode in xmlNode.ChildNodes)
                    {
                        // если узел - link
                        if (childnode.Name == "link")
                        {
                            listLink.Add(childnode.InnerText);
                        }
                    }
                }
            }
            return listLink;
        }
    }
}
