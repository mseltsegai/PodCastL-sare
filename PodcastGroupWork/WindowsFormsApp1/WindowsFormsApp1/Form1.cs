using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.LogicLayer;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        static System.Timers.Timer timer;
        String[,] rssDataForTimer = null;
        String[,] rssData = null;


        HanteraLasKategori lasKategori = new HanteraLasKategori();
        HanteraData hanteraData = new HanteraData();

        public Form1()
        {
			InitializeComponent();

            this.Text = "Podcast";
            UppdateraKatCombo();
            LaddaKategori();
            LaddaFeedXML();
            lasInTidUrl();
            
        }

        private void delete() {
            try
            {
                if (MessageBox.Show("Är du säker?", "Ta Bort", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    lvPodLista.Items.RemoveAt(lvPodLista.SelectedIndices[0]);
                }
            }catch(ArgumentOutOfRangeException eFeedNotSelected)
            {
                MessageBox.Show("Ej valt en feed att ändra på.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Error: {0}", eFeedNotSelected.Message);
            }
        }

        public void lasInTidUrl()
        {
            foreach (ListViewItem lvitem in lvPodLista.Items)
            {
                string taTid = lvitem.SubItems[1].Text;
                string taUrl = lvitem.SubItems[3].Text;

                Task.Run(() => frekvensAvsnitt(taTid, taUrl));

            }
        }

        public void frekvensAvsnitt(string tid, string url)
        {   //Räknar just nu i sekunder (ska räkna i minuter)
                    timer = new System.Timers.Timer(int.Parse(tid) * 1000);
                    timer.Elapsed += (sender, e) => countEpisodes(e, url);
                    timer.Start();
        }

        public void countEpisodes( EventArgs e, string url)
        {
            
            rssDataForTimer = hanteraData.sendRssData(url);

            int rakna = 0;
            for (int i = 0; i < rssDataForTimer.GetLength(0); i++)
            {
                if (rssDataForTimer[i, 0] != null)
                {
                    rakna++;
                }
            }
            
            updateEpisodes(url,rakna);
        }

        private void updateEpisodes( string url, int episoder) {
          
           if (lvPodLista.InvokeRequired)
              {
                 lvPodLista.Invoke((MethodInvoker)delegate
                 {
                     try
                     {
                         lvPodLista.FindItemWithText(url, true, 0, false).SubItems[4].Text = episoder.ToString();
                     }
                     catch (NullReferenceException eFeedGone){
                         //Har försökt använda CancellationToken eller avsluta Timer men programmet hakar upp sig eller så fungerar det inte.
                         Console.WriteLine("Error: {0}", eFeedGone.Message);
                     }
                 });
              }
             
        }

        private void LaddaFeedXML()
        {
            
           lvPodLista.Items.AddRange(hanteraData.sendXmlFeed(cbKategori.Text).ToArray());
            
        }
        private void LaddaFeedMedKategori()
        {
                lvPodLista.Items.AddRange(hanteraData.sendXmlFeedSorted(cbKategori.Text).ToArray());
        }
        private void LaddaKategori()
        {
            if (lasKategori is IsendReadCategory)
            {
                lbKategori.Items.AddRange(lasKategori.sendXmlCategory().OrderBy(x => x.Length).ToArray());
            }
            else {
                MessageBox.Show("Finns inget att hämta från interface.");
            }
        }
        private void UppdateraKatCombo()
        {
            cbKategori.Items.Clear();
            if (lasKategori is IsendReadCategory)
            {
                cbKategori.Items.AddRange(lasKategori.sendXmlCategory().OrderBy(x => x.Length).ToArray());
            }
            else {
                MessageBox.Show("Finns inget att hämta från interface.");
            }
        }

        private void btnNyPodcast_Click(object sender, EventArgs e)
        {
                if (Validering.urlValidation(tbUrl.Text) == false || Validering.validateCategory(cbKategori) == false || Validering.intervalBoxNotEmpty(cbFrekvens) == false || Validering.TxtBoxIsEmpty(tbNamn) == false)
                {

                }
                else
                {
                    lvPodLista.Items.Add(hanteraData.add(tbNamn.Text, cbFrekvens.Text, cbKategori.Text, tbUrl.Text));
                }
        }

        private void cbAvsnitt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rssData[cbAvsnitt.SelectedIndex, 2] != null)
                tbAvsnittsInfo.Text = rssData[cbAvsnitt.SelectedIndex, 1];
            if (rssData[cbAvsnitt.SelectedIndex, 2] != null)
                llLankTill.Text = "Gå till länk: " + rssData[cbAvsnitt.SelectedIndex, 0];
        }

        private void llLankTill_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (rssData[cbAvsnitt.SelectedIndex, 2] != null)
                System.Diagnostics.Process.Start(rssData[cbAvsnitt.SelectedIndex, 2]);
        }

        private async void lvPodLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPodLista.SelectedItems.Count == 0)
            {
               //Inget ska hända när selectedindex är 0
            }
            else {
                try
                {
                    cbAvsnitt.Items.Clear();
                    await Task.Run(() =>
                    {
                        if (lvPodLista.InvokeRequired)
                        {
                            lvPodLista.Invoke((MethodInvoker)delegate
                            { rssData = hanteraData.sendRssData(lvPodLista.SelectedItems[0].SubItems[3].Text); });
                        }
                    });
                    addTitelToCombobox(rssData);
                }
                catch (ArgumentOutOfRangeException outOfRange)
                {
                    Console.WriteLine("Error: {0}", outOfRange.Message);
                }
            }
        }

        private void addTitelToCombobox(String[,] rssData) {

            int rakna = 0;
            for (int i = 0; i < rssData.GetLength(0); i++)
            {

                if (rssData[i, 0] != null)
                {
                    cbAvsnitt.Items.Add(rssData[i, 0]);
                    rakna++;
                }

            }
            cbAvsnitt.SelectedIndex = 0;
            addEpisodeCount(rakna);
        }

        private void addEpisodeCount(int episodes) {
            lvPodLista.SelectedItems[0].SubItems[4].Text = episodes.ToString();
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnTaBortPodcast_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnNyKategori_Click(object sender, EventArgs e)
        {
            if (Validering.CategoryTxtBox(tbKategori.Text))
            {
                lbKategori.Items.Add(tbKategori.Text);
                tbKategori.Clear();
            }
            
        }

        private void btnTaBortKategori_Click(object sender, EventArgs e)
        {
            if (Validering.CategoryPicked(lbKategori.SelectedIndex))
            {
                lbKategori.Items.RemoveAt(lbKategori.SelectedIndex);
                
            }
            
        }

        private void btnSparaKategori_Click(object sender, EventArgs e)
        {
            hanteraData.getCategoryItems(lbKategori.Items);
            UppdateraKatCombo();
        }

        private void btnSparaPodcast_Click(object sender, EventArgs e)
        {
            hanteraData.getFeedItems(lvPodLista.Items);
        }

        private void btnEditFeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validering.validateCategory(cbKategori) == false || Validering.intervalBoxNotEmpty(cbFrekvens) == false || Validering.TxtBoxIsEmpty(tbNamn) == false)
                {

                }
                else
                {
                    lvPodLista.SelectedItems[0].SubItems[2].Text = cbKategori.Text;
                    lvPodLista.SelectedItems[0].SubItems[1].Text = cbFrekvens.Text;
                    lvPodLista.SelectedItems[0].SubItems[0].Text = tbNamn.Text;
                }
            }
            catch (ArgumentOutOfRangeException noSelectedFeed) {
                MessageBox.Show("Ej valt en feed att ändra på.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("Error: {0}", noSelectedFeed.Message);
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
                if (Validering.CategoryPicked(lbKategori.SelectedIndex) && Validering.CategoryTxtBox(tbKategori.Text)) {
                    int editRow = lbKategori.SelectedIndex;

                    lbKategori.Items.RemoveAt(editRow);
                    lbKategori.Items.Insert(editRow, tbKategori.Text);
                    tbKategori.Clear();
                }
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            if (Validering.validateCategory(cbKategori))
            {
                lvPodLista.Items.Clear();
                LaddaFeedMedKategori();
            }
        }

        private void btnGetAllFeeds_Click(object sender, EventArgs e)
        {
            lvPodLista.Items.Clear();
            LaddaFeedXML();
        }
    }
}
