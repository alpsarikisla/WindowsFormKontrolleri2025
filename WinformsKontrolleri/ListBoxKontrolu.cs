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
    public partial class ListBoxKontrolu : Form
    {
        public ListBoxKontrolu()
        {
            InitializeComponent();
            listBox1.Items.Add("Eleman 3");
            listBox1.Items.Add("Eleman 4");
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                listBox1.Items.Add(tb_isim.Text);
            }
            else
            {
                MessageBox.Show("Textbox Boş Bırakılmamalıdır");
            }
        }

        private void btn_seç_Click(object sender, EventArgs e)
        {
            //if(listBox1.SelectedItem != null)
            //{
            //    lb_secilen.Text = listBox1.SelectedItem.ToString();
            //}
            if(listBox1.SelectedItems.Count != 0)
            {
                string secilenler = "";
                foreach (var item in listBox1.SelectedItems)
                {
                    secilenler += item.ToString() + ", ";
                }
                lb_secilen.Text = secilenler;
            }
        }
    }
}
