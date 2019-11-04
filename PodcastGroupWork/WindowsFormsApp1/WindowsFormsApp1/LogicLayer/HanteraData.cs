using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;

namespace WindowsFormsApp1.LogicLayer
{
    public interface IsendReadCategory {
        List<string> sendXmlCategory();
    }

    class HanteraLasKategori : IsendReadCategory
    {
        LasSkrivData lasSkrivData = new LasSkrivData();

        public List<string> sendXmlCategory()
        {

            var catItems = lasSkrivData.readXmlCategory();

            return catItems;

        }

    }

    class HanteraData
    {
        LasSkrivData lasSkrivData = new LasSkrivData();

        public ListViewItem add(String name, String frek, String category, String url)
        {
            String avsnitt = "0";
            String[] row = { name, frek, category, url, avsnitt };

            ListViewItem item = new ListViewItem(row);

            return item;
           

        }

        public void getCategoryItems(ListBox.ObjectCollection items) {

            lasSkrivData.writeXmlCategory(items);

        }

        public void getFeedItems(ListView.ListViewItemCollection items)
        {

            lasSkrivData.writeXmlFeed(items);

        }

        public List<ListViewItem> sendXmlFeed(string sort)
        {
            lasSkrivData.getBase = false;

            var feedItems = lasSkrivData.readXmlFeed(sort);

            return feedItems;

        }

        public List<ListViewItem> sendXmlFeedSorted(string sort)
        {
            lasSkrivData.getBase = true;

            var feedItems = lasSkrivData.readXmlFeed(sort);

            return feedItems;

        }

        public String[,] sendRssData(string url)
        {
            var rssData = lasSkrivData.getRssData(url).Result;

            return rssData;
        }
    }
}
