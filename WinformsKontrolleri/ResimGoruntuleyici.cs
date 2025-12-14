using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsKontrolleri
{
    public partial class ResimGoruntuleyici : Form
    {
        public ResimGoruntuleyici()
        {
            InitializeComponent();
            ListeDoldur();
        }
        public void ListeDoldur()
        {
            string yol = "../../Resimler";
            DirectoryInfo di = new DirectoryInfo(yol);
            List<FileInfo> Resimler = di.GetFiles().ToList();
            //for (int i = 0; i < Resimler.Count; i++)
            //{
            //    lb_liste.Items.Add(Resimler[i].Name);
            //}
            foreach (FileInfo resim in Resimler)
            {
                lb_liste.Items.Add(resim.Name);
            }
        }

        private void lb_liste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_liste.SelectedItem != null)
            {
                string resimYol = "../../Resimler/" + lb_liste.SelectedItem.ToString();
                pictureBox1.ImageLocation = resimYol;
            }
           
        }

        private void cb_tur_SelectedIndexChanged(object sender, EventArgs e)
        {

            string secilen = cb_tur.SelectedItem.ToString();
            if (secilen == "Normal")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
            if (secilen == "AutoSize")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            if (secilen == "Strecth Image")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (secilen == "Center Image")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            if (secilen == "Zoom")
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
