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
    public partial class PictureBoxKontrolu : Form
    {
        public PictureBoxKontrolu()
        {
            InitializeComponent();
            pictureBox1.ImageLocation = "../../Resimler/frog.jpg";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string secilen = comboBox1.SelectedItem.ToString();
            switch(secilen)
            {
                case "Normal":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case "Otomatik Boyut":
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break;
                case "Resmi Esnet":
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Resmi Ortala":
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case "Sıgdır":
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }
        }
    }
}
