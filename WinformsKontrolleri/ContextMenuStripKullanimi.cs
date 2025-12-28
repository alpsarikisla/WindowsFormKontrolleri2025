using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformsKontrolleri.Model;

namespace WinformsKontrolleri
{
    public partial class ContextMenuStripKullanimi : Form
    {
        int secilenID = -1;
        public ContextMenuStripKullanimi()
        {
            InitializeComponent();
            GridDoldur();
        }
        public void GridDoldur()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand komut = baglanti.CreateCommand();
            komut.CommandText = "SELECT Description, CategoryID, CategoryName FROM Categories";
            baglanti.Open();
            SqlDataReader okuyucu = komut.ExecuteReader();
            List<Category> kategoriler = new List<Category>();
            while (okuyucu.Read())
            {
                Category c = new Category();
                c.ID = okuyucu.GetInt32(1);
                c.Aciklama = okuyucu.GetString(0);
                c.Isim = okuyucu.GetString(2);
                kategoriler.Add(c);
            }
            dataGridView1.DataSource = kategoriler;
            baglanti.Close();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (DataGridViewRow item in dataGridView1.SelectedRows)
                {
                    item.Selected = false;
                }

                contextMenuStrip1.Show(dataGridView1,new Point(e.X, e.Y));
                var test = dataGridView1.HitTest(e.X, e.Y);
                int satirNo = test.RowIndex;
                dataGridView1.Rows[satirNo].Selected = true;
                secilenID = Convert.ToInt32(dataGridView1.Rows[satirNo].Cells[0].Value);
            }
        }

        private void TSMI_Duzenle_Click(object sender, EventArgs e)
        {
            Category c = KategoriGetir(secilenID);
            tb_aciklama.Text = c.Aciklama;
            tb_isim.Text = c.Isim;
        }

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Urunler_Click(object sender, EventArgs e)
        {

        }

        public Category KategoriGetir(int id)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlCommand komut = baglanti.CreateCommand();
            komut.CommandText = "SELECT CategoryID, CategoryName, Description FROM Categories WHERE CategoryID=@id";
            komut.Parameters.AddWithValue("@id", id);
            baglanti.Open();
            SqlDataReader okuyucu = komut.ExecuteReader();
            Category c = new Category();
            while (okuyucu.Read())
            {
                c.ID = okuyucu.GetInt32(0);
                c.Isim = okuyucu.GetString(1);
                c.Aciklama = okuyucu.GetString(2);
            }
            baglanti.Close();
            return c;
        }
    }
}
