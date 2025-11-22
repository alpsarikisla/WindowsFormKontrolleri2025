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
    public partial class CokKullanilanKontroller : Form
    {
        public CokKullanilanKontroller()
        {
            InitializeComponent();
            rb_kadin.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_mesaj.Text = "Sana Tıklama Demedik mi";
        }

        private void dortislem_Yap (object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(tb_sayi1.Text);
            double sayi2 = Convert.ToDouble(tb_sayi2.Text);
            double sonuc = 0;

            Button btn = (Button)sender;
            if(btn.Text == "Toplam")
            {
                sonuc = sayi1 + sayi2;
            }
            if (btn.Text == "Fark")
            {
                sonuc = sayi1 - sayi2;
            }
            if (btn.Text == "Çarpım")
            {
                sonuc = sayi1 * sayi2;
            }
            if (btn.Text == "Bölüm")
            {
                sonuc = sayi1 / sayi2;
            }
            tb_sonuc.Text = Convert.ToString(sonuc);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            bool sozlesmeOnay = cb_sozlesme.Checked;
            if (!sozlesmeOnay)
            {
                MessageBox.Show("Kullanıcı Sözleşmesini onaylamanız gerekmektedir!");
            }
            else
            {
                MessageBox.Show("Kayıt Tamamlandı");
            }
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            string cinsiyet = "Belirtilmemiş";
            if (rb_kadin.Checked)
            {
                cinsiyet = "Kadın";
            }
            if(rb_erkek.Checked)
            {
                cinsiyet = "Erkek";
            }
            lbl_sonuc.Text = "Cinsiyet = " + cinsiyet;
        }
    }
}
