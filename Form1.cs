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



        }
    }
}
