using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace NTPVize
{
    public partial class Form1 : Form

    {

        string hava_durumu_link = "https://www.mgm.gov.tr/FTPDATA/analiz/sonSOA.xml";
        public Form1()
        {
            InitializeComponent();
        }
  
        private void btnHavaDurumuBilgileriniAl_Click(object sender, EventArgs e)

            
        {


            XmlDocument document1 = new XmlDocument();
            document1.Load(hava_durumu_link);
            XmlElement root = document1.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("sehirler");
            foreach (XmlNode node in nodes)
            {
                string ili = node["ili"].InnerText;
                string durum = node["Durum"].InnerText;
                string maks_sicaklik = node["Mak"].InnerText;
                string min_sicaklik = node["Min"].InnerText;

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = ili;
                row.Cells[1].Value = durum;
                row.Cells[2].Value = maks_sicaklik;
                row.Cells[3].Value = min_sicaklik;
                dataGridView1.Rows.Add(row);


            }

            Cursor.Current = Cursors.WaitCursor;
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "txt dosyası|0.txt";
            sf.FileName = "Veriler.txt";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(sf.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string İller = dataGridView1.Rows[i].Cells["İller"].Value.ToString();
                    string Durum = dataGridView1.Rows[i].Cells["Durum"].Value.ToString();
                    string Max_Sicaklik = dataGridView1.Rows[i].Cells["Maksimum Sıcaklık"].Value.ToString();
                    string Min_Sicaklik = dataGridView1.Rows[i].Cells["Minimum Sıcaklık"].Value.ToString();
                    string icerik = İller + "\t|\t" + Durum + "\t|\t" + Max_Sicaklik + "\t|\t" + Min_Sicaklik;
                    File.AppendAllText(sf.FileName, icerik + Environment.NewLine);

                }
            }


            Cursor.Current = Cursors.Default;

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow secili_satir in dataGridView1.Rows)
            {
                if (Convert.ToInt32(secili_satir.Cells[2].Value)>20)
                {
                    secili_satir.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

    }


}
