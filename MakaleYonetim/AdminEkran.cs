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
    public partial class AdminEkran : Form
    {
        public AdminEkran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullaniciEkle k = new KullaniciEkle();
            k.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {//yazardüzenle butonu
            if (listBox1.SelectedIndex < 1)
                MessageBox.Show("Bir yazar seçiniz");
            else
            {
                object secilenid = listBox1.SelectedValue;

                KullaniciDuzenle k = new KullaniciDuzenle();
                k.gelenid = Convert.ToInt32(secilenid);
                k.Show();
            }
        }

        private void AdminEkran_Load(object sender, EventArgs e)
        {
            Data d = new Data();
            d.komut.CommandText = "SELECT Adsoyad,KullaniciID FROM tblKullanici WHERE SilindiMi=0";
            DataTable dt = new DataTable();
            dt.Columns.Add("AdSoyad");
            dt.Columns.Add("KullaniciID");
            DataRow dr = dt.NewRow();
            dr["AdSoyad"] = "Tüm yazarlar";
            dr["KullaniciID"] = 0;
            dt.Rows.Add(dr);
            
            DataTable dbdengelen = d.TabloGetir();
            foreach (DataRow item in dbdengelen.Rows)
                dt.ImportRow(item);

          
            //  listBox1.DataSource = d.TabloGetir();

            listBox1.DisplayMember = "Adsoyad"; //görünen kısım
            listBox1.ValueMember = "KullaniciID"; //seçilen şeylerin id si
  listBox1.DataSource = dt;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = listBox1.SelectedValue.ToString();
            string sorgu = "SELECT MakaleID,Baslik,Tarih FROM tblMakale";
            if (id != "0")
                sorgu += "         WHERE KullaniciID="+id;

            sorgu += "     ORDER BY Tarih DESC";
            Data d = new Data();
            d.komut.CommandText = sorgu;
            dataGridView1.DataSource = d.TabloGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {  //Sil butonu
            if (listBox1.SelectedIndex < 1)
                MessageBox.Show("Bir yazar seçiniz");
            else {
               DialogResult dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(dr == DialogResult.Yes)
                { //Kullanıcı gerçekten silmek istiyor
                    string id = listBox1.SelectedValue.ToString();
                    Data d = new Data();
                    d.komut.CommandText="UPDATE tblKullanici SET Silindimi=1 WHERE KullaniciID="+id;
                    d.KomutCalistir();
                    MessageBox.Show("silindi");
                    AdminEkran_Load(sender,e);
                }

            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            object id = dataGridView1.SelectedRows[0].Cells[0].Value;
            MessageBox.Show(id.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Istatistik i = new Istatistik();
            i.Show();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = (Form1)Application.OpenForms["Form1"];
            f.Show();
        }
    }
}
