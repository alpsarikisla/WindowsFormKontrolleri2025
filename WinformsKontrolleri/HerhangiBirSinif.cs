using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsKontrolleri
{
    internal class HerhangiBirSinif:Form
    {
        public HerhangiBirSinif()
        {
            KontrolleriHazirla();
        }

        private void KontrolleriHazirla()
        {
            this.Text = "Sınıftan Form";

            Label lbl_yazi = new Label();
            lbl_yazi.Text = "Murtaza adını bu form'a kazıdı";
            lbl_yazi.AutoSize = true;
            // lbl_yazi.Size = new Size(300, 100);
            lbl_yazi.BackColor = Color.DeepPink;
            lbl_yazi.ForeColor = Color.White;
            //Point p = new Point();
            //p.X = 10;
            //p.Y = 60;
            lbl_yazi.Location = new Point(10, 10);
            this.Controls.Add(lbl_yazi);

            TextBox tb_isim = new TextBox();
            tb_isim.Location = new Point(10, 30);
            this.Controls.Add(tb_isim);

            //Control[] kontroller = new Control[2];
            //kontroller[0] = lbl_yazi;
            //kontroller[1] = tb_isim;

            //this.Controls.AddRange(kontroller);
        }
    }
}
