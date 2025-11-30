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
    public partial class DateTimeVeTarihKontrolleri : Form
    {
        public DateTimeVeTarihKontrolleri()
        {
            InitializeComponent();
            DateTime dt_tarih = new DateTime(2009,04,12);//herhangi bir tarih

            DateTime dt_guncelTarih = DateTime.Now;//Şu anki tarih

            lbl_herhangitarih.Text = dt_tarih.ToString();

            lbl_gunceltarih.Text = dt_guncelTarih.ToString();

            lbl_yil.Text ="Yıl="+ dt_guncelTarih.Year.ToString();
            lbl_ay.Text = "Ay=" + dt_guncelTarih.Month.ToString();
            lbl_gun.Text = "Gün=" + dt_guncelTarih.Day.ToString();
            lbl_saat.Text = "Saat=" + dt_guncelTarih.Hour.ToString();
            lbl_dakika.Text = "Dakika=" + dt_guncelTarih.Minute.ToString();
            lbl_saniye.Text = "Saniye=" + dt_guncelTarih.Second.ToString();
            lbl_gunadi.Text = "Günlerden = " + dt_guncelTarih.DayOfWeek.ToString();
            lbl_kacinciGun.Text = "Yılın = " + dt_guncelTarih.DayOfYear.ToString() + ". günü";

            lbl_KisaTarih1.Text = dt_guncelTarih.ToString("yyyy/mm/dd");
            lbl_KisaTarih2.Text = dt_guncelTarih.ToShortDateString();
            lbl_uzunTarih1.Text = dt_guncelTarih.ToString("dd MMM yyyy dddd");

            TakvimiBicimlendir();
        }

        private void btn_getir1_Click(object sender, EventArgs e)
        {
            lbl_gelen1.Text = monthCalendar1.SelectionRange.Start.ToString();

            DateTime baslangic = monthCalendar1.SelectionStart;
            lbl_baslangic.Text = baslangic.ToString();

            DateTime bitis = monthCalendar1.SelectionEnd;
            lbl_bitis.Text = bitis.ToString();
        }
        public void TakvimiBicimlendir()
        {
            monthCalendar1.ShowToday = true;
            monthCalendar1.ShowTodayCircle = false;
            monthCalendar1.ShowWeekNumbers = true;
            monthCalendar1.MaxSelectionCount = 5;
            monthCalendar1.FirstDayOfWeek = Day.Default;
            monthCalendar1.ForeColor = Color.Orange;
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            DateTime dt_secilen = dateTimePicker1.Value;
            lbl_secilen.Text = dt_secilen.ToShortDateString();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dt_baslangic.Value;
            DateTime bitis = dt_bitis.Value;

            TimeSpan fark = bitis - baslangic;
            lbl_hesaplanmisGun.Text = fark.TotalHours.ToString();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            DateTime dt_secilen = dtp_sec.Value;
            string tarih = dt_secilen.ToShortDateString();
            tarih += " " + nu_saat.Value;
            tarih += ":" + Nu_dakika.Value;
            DateTime olusturulan = Convert.ToDateTime(tarih);
            lbl_olusturulan.Text = olusturulan.ToString();
        }
    }
}
