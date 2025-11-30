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
    public partial class ComboBoxKontrolu : Form
    {
        public ComboBoxKontrolu()
        {
            InitializeComponent();
        }

        private void btn_dersSec_Click(object sender, EventArgs e)
        {
            //lbl_secilen.Text ="Seçilen Ders= " + cb_dersler.SelectedItem.ToString();
            lbl_secilen.Text = "Seçilen Ders= " + cb_dersler.Text.ToString();
        }

        private void cb_dersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Çalıştı");
            lbl_secilen.Text = "Seçilen Ders= " + cb_dersler.SelectedItem.ToString();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_dersAdi.Text))
            {
                cb_dersler.Items.Add(tb_dersAdi.Text);
            }
            else
            {
                MessageBox.Show("Ders Adı girilmelidir");
            }
        }
    }
}
