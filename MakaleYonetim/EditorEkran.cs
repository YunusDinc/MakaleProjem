using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakaleYonetim
{
    public partial class EditorEkran : Form
    {
        public EditorEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//makale ekle
            MakaleEkle m = new MakaleEkle();
            m.Show();
        }
        string gridSorgu = "";
        
        public void EditorEkran_Load(object sender, EventArgs e)
        {
            gridSorgu= @"SELECT MakaleID, Baslik, k.KategoriAdi, KarakterSayisi AS Karakter, Tarih FROM tblMakale m
                INNER JOIN tblKategori k ON m.KategoriID=k.KategoriID";

            Data d = new Data();
            d.komut.CommandText = gridSorgu;
            dataGridView1.DataSource = d.TabloGetir();

            d.komut.CommandText = "SELECT * FROM tblKategori";
            DataTable dt = d.TabloGetir();
            DataRow satir = dt.NewRow();
            satir["KategoriID"] = 0;
            satir["KategoriAdi"] = "Tüm kategoriler";
            dt.Rows.Add(satir);

           
            comboBox1.DisplayMember = "KategoriAdi";
            comboBox1.ValueMember = "KategoriID";
            comboBox1.SelectedValue = 0;
            comboBox1.DataSource = dt;
            comboBox1.SelectedValue = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {//Sil butonu
            object makaleid = dataGridView1.SelectedRows[0].Cells["MakaleID"].Value;

            Data d = new Data();
            d.komut.CommandText = "DELETE FROM tblMakale WHERE MakaleID=@mid";
            d.komut.Parameters.AddWithValue("mid",makaleid);
            d.KomutCalistir();
            EditorEkran_Load(sender,e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { //bir kategori adı seçildiğinde
            Data d = new Data();
            if ((int)comboBox1.SelectedValue == 0)
            {
        
                //Tüm kategoriler
                d.komut.CommandText = gridSorgu;
            }
            else
            { //Gerçek kategori seçilmiş
                d.komut.CommandText = gridSorgu + " WHERE m.KategoriID=@kid";

                d.komut.Parameters.AddWithValue("kid", comboBox1.SelectedValue);
            }

            dataGridView1.DataSource = d.TabloGetir();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object makaleid = dataGridView1.SelectedRows[0].Cells["MakaleID"].Value;

            MakaleDuzenle m = new MakaleDuzenle();
            m.MakaleID = Convert.ToInt32(makaleid);
            m.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu = gridSorgu;
            if (comboBox2.SelectedItem == "Eskiden Yeniye")
                sorgu += " ORDER BY Tarih ASC";
            else
                sorgu += " ORDER BY Tarih DESC";

            Data d = new Data();
            d.komut.CommandText = sorgu;
            dataGridView1.DataSource = d.TabloGetir();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = (Form1)Application.OpenForms["Form1"];
            f.Show();
        }
    }
}
