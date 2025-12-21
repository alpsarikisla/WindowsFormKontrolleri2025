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
    public partial class MenuVeToolStrip : Form
    {
        public MenuVeToolStrip()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TSMI_aracKutusu1_Click(object sender, EventArgs e)
        {
            //toolStrip1.Visible = !toolStrip1.Visible;
            if (toolStrip1.Visible)
            {
                toolStrip1.Visible = false;
                TSMI_aracKutusu1.Image = null;
            }
            else
            {
                toolStrip1.Visible = true;
                Image resim = Image.FromFile("../../Resimler/check.png");
                TSMI_aracKutusu1.Image = resim;
            }
        }

        private void TSMI_aracKutusu2_Click(object sender, EventArgs e)
        {
            if (toolStrip2.Visible)
            {
                toolStrip2.Visible = false;
                TSMI_aracKutusu2.Image = null;
            }
            else
            {
                toolStrip2.Visible = true;
                Image resim = Image.FromFile("../../Resimler/check.png");
                TSMI_aracKutusu2.Image = resim;
            }
        }
    }
}
