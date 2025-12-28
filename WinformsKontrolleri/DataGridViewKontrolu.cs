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
    public partial class DataGridViewKontrolu : Form
    {
        public DataGridViewKontrolu()
        {
            InitializeComponent();
            //GridDoldurKategori_List_Ile();
            GridDoldurKategori_DataAdapterDataTableDataSet_Ile();
        }
        public void GridDoldurKategori_List_Ile()
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
        public void GridDoldurKategori_DataAdapterDataTableDataSet_Ile()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            SqlDataAdapter da_kategori = new SqlDataAdapter("SELECT * FROM Categories", baglanti);
            SqlDataAdapter da_urunler = new SqlDataAdapter("SELECT * FROM Products", baglanti);
            SqlDataAdapter da_urunler1 = new SqlDataAdapter("SELECT P.ProductID, P.ProductName, C.CategoryName FROM Products AS P JOIN Categories AS C ON P.CategoryID = C.CategoryID", baglanti);

            DataTable dt_kategori = new DataTable("Kategoriler");
            DataTable dt_urun = new DataTable("Urunler");

            da_kategori.Fill(dt_kategori);
            //da_urunler.Fill(dt_urun);
            da_urunler1.Fill(dt_urun);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt_kategori);
            ds.Tables.Add(dt_urun);
            //DataRelation dr_urunToKategori = new DataRelation("UrunToKategori", dt_kategori.Columns["CategoryID"], dt_urun.Columns["CategoryID"]);
            //ds.Relations.Add(dr_urunToKategori);

            dataGridView1.DataSource = ds.Tables["Urunler"];
        }
    }
}
