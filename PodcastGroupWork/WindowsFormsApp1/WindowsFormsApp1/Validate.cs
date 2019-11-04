using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
        public class Validering
        {
            public static bool urlValidation(string tbUrl)
            {
            bool kollaBool = false;
                try
                {
                    //Den försöker ladda ner länken, om inte den är valid så fungerar den ej. 
                    var xmlFile = "";
                using (var client = new System.Net.WebClient())
                {
                    client.Encoding = Encoding.UTF8;
                    xmlFile = client.DownloadString(tbUrl);
                    if (tbUrl.ToLower().Contains("feed") || tbUrl.ToLower().Contains("xml") || tbUrl.ToLower().Contains("rss"))
                    {
                        kollaBool = true;
                    }
                    else {
                        MessageBox.Show("Vänligen knappa in giltig URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    return kollaBool;

                }

                }
                catch (Exception)
                {
                    MessageBox.Show("Vänligen knappa in giltig URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return kollaBool;
                }
            }

            public static bool validateCategory(ComboBox cbKategori)
            {
                if (cbKategori.Text == "")
                {
                    MessageBox.Show("Kategori behöver vara ifylld", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public static bool intervalBoxNotEmpty(ComboBox cbFrekvens)
            {
                if (cbFrekvens.Text == "")
                {
                    MessageBox.Show("Välj en intervall.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public static bool TxtBoxIsEmpty(TextBox tbNamn)
            {
                if (tbNamn.Text == "")
                {
                    MessageBox.Show("Namn är ej ifylld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                else
                {
                    return true;
                }
            }

        public static bool CategoryPicked(int valdKat)
        {
            if (valdKat >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Kategori ej vald.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        public static bool CategoryTxtBox(string tbKatNamn)
        {
            if (tbKatNamn == "")
            {
                MessageBox.Show("Namn är ej ifylld.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
