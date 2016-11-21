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
    public partial class KullaniciDuzenle : Form
    {
        public int gelenid { get; set; }
        public KullaniciDuzenle()
        {
            InitializeComponent();
        }

        private void KullaniciDuzenle_Load(object sender, EventArgs e)
        {
            Data d = new Data();
            d.komut.CommandText = "SELECT * FROM tblKullanici WHERE KullaniciID="+gelenid;
            DataRow dr = d.SatirGetir();

            txt_AdSoyad.Text = dr["Adsoyad"].ToString();
            txt_email.Text = dr["Eposta"].ToString();
            //checkBox1.Checked = true;
            checkBox1.Checked = (int)dr["YetkiGrup"] == 1;
            txt_Kadi.Text = dr["Kadi"].ToString();
            txt_Sifre.Text = dr["Sifre"].ToString();
            txt_SifreTkr.Text = txt_Sifre.Text;
            msk_tel.Text = dr["Telefon"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //formda boş yerler varsa kırmızı yapsın
            tblKullanici.Validasyonlar(this);

            #region hatalar
            string hatamsg = "";

            if (txt_Sifre.Text != txt_SifreTkr.Text)
                hatamsg += "Şifreler eşleşmiyor";

            if (!txt_email.Text.Contains("@"))
                hatamsg += " \nEmail geçerli değil";

            #endregion

            if (hatamsg != "")
                MessageBox.Show(hatamsg);
            else
            {
                #region Kayit
                //gelen formu kaydedelim
                Data d = new Data();
                d.komut.CommandText = @"UPDATE [dbo].[tblKullanici]
   SET [AdSoyad] = @pad
      ,[Kadi] = @pkadi
      ,[Sifre] = @psifre
      ,[Telefon] = @ptel
      ,[EPosta] = @pemail
      ,[YetkiGrup] = @pyetki
 WHERE KullaniciID=" + gelenid;
                d.komut.Parameters.AddWithValue("pad", txt_AdSoyad.Text);
                d.komut.Parameters.AddWithValue("pkadi", txt_Kadi.Text);
                d.komut.Parameters.AddWithValue("psifre", txt_Sifre.Text);
                d.komut.Parameters.AddWithValue("ptel", msk_tel.Text);
                d.komut.Parameters.AddWithValue("pemail", txt_email.Text);
                d.komut.Parameters.AddWithValue("pyetki", checkBox1.Checked ? 1 : 2);
                d.KomutCalistir();
                MessageBox.Show("Güncellendi");
                #endregion
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {//şifre üret butonu
            string a = tblKullanici.SifreUret();
            txt_Sifre.Text = a;
            txt_SifreTkr.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //göster gizle butonu
            if (txt_Sifre.PasswordChar == '*')
            {
                txt_Sifre.PasswordChar = '\0'; //null char değeri
                txt_SifreTkr.PasswordChar = '\0'; //(yok)
            }
            else
            {
                txt_Sifre.PasswordChar = '*';
                txt_SifreTkr.PasswordChar = '*';
            }

        }
    }
}
