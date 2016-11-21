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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                textBox1.BackColor = Color.Red;
            else
                textBox1.BackColor = Color.White;


            if (string.IsNullOrEmpty(textBox2.Text))
                textBox2.BackColor = Color.Red;
            else
                textBox2.BackColor = Color.White;

            Data d = new Data();

            #region SQLInjection
            //d.komut.CommandText = "SELECT * FROM tblKullanici WHERE Kadi='" + textBox1.Text + "' AND Sifre='" + textBox2.Text + "'";

            /*
             * "SELECT * FROM tblKullanici WHERE Kadi='"+textBox1.Text+"' AND Sifre='"+textBox2.Text+"'";


            textBox1.Text= ' OR 'a'='a

            textBox2.Text= ' OR 'a'='a

            SQL Injection

            SELECT * FROM tblKullanici WHERE Kadi='' OR 'a'='a' 
            AND Sifre='' OR 'a'='a'

            abc.com/Haber/SonHaber?id=15
            SELECT * FROM tblHaber WHERE ID="+textbox1.Text+"
            */
            #endregion
            d.komut.CommandText = "SELECT * FROM tblKullanici WHERE Kadi=@k AND Sifre=@s";
            d.komut.Parameters.AddWithValue("k", textBox1.Text);
            d.komut.Parameters.AddWithValue("s", textBox2.Text);

            DataTable dt = d.TabloGetir();
            if (dt.Rows.Count == 0)
                MessageBox.Show("Hatalı giriş");
            else
            {
                DataRow dr = dt.Rows[0];
                tblKullanici.GirisYapan = new tblKullanici();
                tblKullanici.GirisYapan.KullaniciID = (int)dr["KullaniciID"];
                tblKullanici.GirisYapan.AdSoyad = dr["AdSoyad"].ToString();

                string yetki =dr["YetkiGrup"].ToString();
                if (yetki == "1") new AdminEkran().Show();
                else new EditorEkran().Show();
                this.Hide();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnteraBasincaButonaTikla(object sender, KeyEventArgs e) {
            if (e.KeyValue == 13) { //entera basınca
                button1.PerformClick(); //butona tıkla
            }
        }
    }
}
