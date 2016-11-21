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
    public partial class MakaleEkle : Form
    {
        public MakaleEkle()
        {
            InitializeComponent();
        }

        private void MakaleEkle_Load(object sender, EventArgs e){
            Data d = new Data();
            d.komut.CommandText = "SELECT * FROM tblKategori ORDER BY KategoriAdi";
            comboBox1.DataSource = d.TabloGetir();
            comboBox1.DisplayMember = "KategoriAdi";
            comboBox1.ValueMember = "KategoriID";
            lbl_Yazar.Text = tblKullanici.GirisYapan.AdSoyad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data d = new Data();
            d.komut.CommandText = "INSERT INTO tblMakale (KategoriID, KullaniciID, Baslik, Icerik, KarakterSayisi, Tarih) VALUES (@katid, @kid, @pbaslik, @picerik, LEN(@picerik), GETDATE())";
            d.komut.Parameters.AddWithValue("katid",comboBox1.SelectedValue);
            d.komut.Parameters.AddWithValue("kid",tblKullanici.GirisYapan.KullaniciID);
            d.komut.Parameters.AddWithValue("pbaslik",textBox1.Text);
            d.komut.Parameters.AddWithValue("picerik",richTextBox1.Text);
            d.KomutCalistir();
            MessageBox.Show("Eklendi");

            //açık olan EditorEkran formuna ulaşıp
            //load event ini çağıralım.
            EditorEkran eform = (EditorEkran)Application.OpenForms["EditorEkran"];
            eform.EditorEkran_Load(sender, e);
        }
    }
}
