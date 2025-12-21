using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsKontrolleri
{
    public partial class WebBrowserKontrolu : Form
    {
        public WebBrowserKontrolu()
        {
            InitializeComponent();
        }

        private void TSB_Git_Click(object sender, EventArgs e)
        {
            string adres = TSTB_Adres.Text;
            if (adres[0] != 'h')
            {
                adres = "http://" + adres;
            }
            TSTB_Adres.Text = adres;
            Uri adresUri = new Uri(adres);
            webBrowser1.Url = adresUri;
        }
        private void TSB_Yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
        private void TSB_Geri_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }
        private void TSB_Ileri_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }
    }
}
