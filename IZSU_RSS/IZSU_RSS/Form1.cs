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
using System.Xml.Linq;

namespace IZSU_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument xmlDoc = new XmlDocument();
        XmlDocument xmlDock = new XmlDocument();
        XmlDocument xmlDoch = new XmlDocument();
        XmlNodeList descriptionListk;
        XmlNodeList haberdescriptionList;

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            xmlDoc.Load("http://www.izsu.gov.tr/pages/rss.aspx?rssId=3");
            XmlNodeList titlelist = xmlDoc.SelectNodes("//channel/item/title");
            XmlNodeList descriptionList = xmlDoc.SelectNodes("//channel/item/description");
            XmlNodeList dateList = xmlDoc.SelectNodes("//channel/item/pubDate");
            baraj.tarih = Convert.ToDateTime(dateList[0].InnerText);
            label1.Text = "Tarih :" + baraj.tarih.ToString("dd/MM/yyyy");
           
            xmlDock.Load("http://www.izsu.gov.tr/pages/rss.aspx?rssId=2");
            XmlNodeList kesintilist = xmlDock.SelectNodes("//channel/item/title");
            XmlNodeList kesdateList = xmlDock.SelectNodes("//channel/item/pubDate");
           descriptionListk = xmlDock.SelectNodes("//channel/item/description");

            xmlDoch.Load("http://www.izsu.gov.tr/pages/rss.aspx?rssId=1");
            XmlNodeList haberlist = xmlDoch.SelectNodes("//channel/item/title");
           haberdescriptionList = xmlDoch.SelectNodes("//channel/item/description");
            XmlNodeList haberdateList = xmlDoch.SelectNodes("//channel/item/pubDate");

            for (int i = 0; i < titlelist.Count; i++)
            {
                baraj b = new baraj(titlelist[i].InnerText, descriptionList[i].InnerText);
                listBox1.Items.Add(b);

            }
            for (int i = 0; i < kesintilist.Count; i++)
            {
                SuKesintisi kes = new SuKesintisi(kesintilist[i].InnerText, kesdateList[i].InnerText);
                ListBSuKesintileri.Items.Add(kes);
            }
            for (int i = 0; i < haberlist.Count; i++)
            {
                haberler h = new haberler(haberlist[i].InnerText, haberdateList[i].InnerText);
                ListBhaberler.Items.Add(h);
            }
           
        }

        private void ListBSuKesintileri_DoubleClick(object sender, EventArgs e)
        {
            int i = ListBSuKesintileri.SelectedIndex;
            webBrowser1.DocumentText = descriptionListk[i].InnerText;
        }

        private void ListBhaberler_DoubleClick(object sender, EventArgs e)
        {
            int i = ListBhaberler.SelectedIndex;
            webBrowser1.DocumentText = haberdescriptionList[i].InnerText;
        }

        
    }
}
