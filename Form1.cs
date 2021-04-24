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



        }
    }
}
