using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApp1.DataAccess
{
    class LasXmlFeed {

        public virtual List<ListViewItem> readXmlFeed(string sort)
        {
            
            var feedItem = new List<ListViewItem>();
            XElement element = XElement.Load("feedfile.xml");
            foreach (var dm in element.Descendants("Item"))
            {
                if (dm.Element("Kategori").Value == sort)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        dm.Element("Namn").Value,
                        dm.Element("Frekvens").Value,
                        dm.Element("Kategori").Value,
                        dm.Element("URL").Value,
                        ""
                    }
                    );
                    feedItem.Add(item);
                }
            }
            return feedItem;
        }

    }

    class LasSkrivData : LasXmlFeed
	{
        public bool getBase { get; set; }

        public override List<ListViewItem> readXmlFeed(string sort) {

            if (getBase)
            {
                return base.readXmlFeed(sort);
            }
            else
            {
                var feedItem = new List<ListViewItem>();
                XElement element = XElement.Load("feedfile.xml");
                foreach (var dm in element.Descendants("Item"))
                {
                        ListViewItem item = new ListViewItem(new string[]
                            {
                        dm.Element("Namn").Value,
                        dm.Element("Frekvens").Value,
                        dm.Element("Kategori").Value,
                        dm.Element("URL").Value,
                        ""
                            }
                            );
                        feedItem.Add(item);
                    
                }
                return feedItem;

            }
        }

        public List<string> readXmlCategory()
        {

            var catItems = new List<string>();
            XElement element = XElement.Load("savefile.xml");
            foreach (XElement item in element.Elements("Item"))
            {
                catItems.Add(item.Value);
            }
            return catItems;

        }

        public void writeXmlCategory(ListBox.ObjectCollection items) {
            XmlTextWriter xwriter = new XmlTextWriter("savefile.xml", Encoding.Unicode);
            xwriter.WriteStartDocument();
            xwriter.WriteStartElement("XMLFILE");
            xwriter.WriteStartElement("Title");
            xwriter.WriteString("Kategorier");
            xwriter.WriteEndElement();
            foreach (String item in items)

            {
                xwriter.WriteStartElement("Item");
                xwriter.WriteString(item);
                xwriter.WriteEndElement();
            }
            xwriter.WriteEndElement();
            xwriter.WriteEndDocument();

            xwriter.Close();
            MessageBox.Show("Sparat!");
        }

        public void writeXmlFeed(ListView.ListViewItemCollection items) {
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true, IndentChars = "  " };

            using (XmlWriter writer = XmlWriter.Create(Directory.GetCurrentDirectory() + @"\feedfile.xml", settings))

            {

                writer.WriteStartDocument();

                writer.WriteStartElement("Title");

                foreach (ListViewItem one in items)

                {

                    writer.WriteStartElement("Item");

                    writer.WriteElementString("Namn", one.SubItems[0].Text);

                    writer.WriteElementString("Frekvens", one.SubItems[1].Text);

                    writer.WriteElementString("Kategori", one.SubItems[2].Text);

                    writer.WriteElementString("URL", one.SubItems[3].Text);

                    writer.WriteElementString("Avsnitt", one.SubItems[4].Text);

                    writer.WriteEndElement();

                }

                writer.WriteEndElement();

                MessageBox.Show("Sparat!");

            }

        }

        public async Task<String[,]> getRssData(String channel)
        {
            System.Net.WebRequest  myRequest = System.Net.WebRequest.Create(channel);
            System.Net.WebResponse myResponse = myRequest.GetResponse();

            Stream rssStream = myResponse.GetResponseStream();
            XmlDocument rssDoc = new XmlDocument();

            rssDoc.Load(rssStream);

            XmlNodeList rssItems = rssDoc.SelectNodes("rss/channel/item");

            String[,] tempRssData = new String[1000, 3];

            for (int i = 0; i < rssItems.Count; i++)
            {
                XmlNode rssNode;

                rssNode = rssItems.Item(i).SelectSingleNode("title");
                if (rssNode != null)
                {
                    tempRssData[i, 0] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 0] = "";
                }

                rssNode = rssItems.Item(i).SelectSingleNode("description");
                if (rssNode != null)
                {
                    tempRssData[i, 1] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 1] = "";
                }

                rssNode = rssItems.Item(i).SelectSingleNode("link");
                if (rssNode != null)
                {
                    tempRssData[i, 2] = rssNode.InnerText;
                }
                else
                {
                    tempRssData[i, 2] = "";
                }
            }
            return tempRssData;
        }

    }
}
