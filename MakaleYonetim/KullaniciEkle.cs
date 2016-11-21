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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            msk_tel.Mask = "(999) 000 00 00"; //format
            txt_Sifre.PasswordChar = '*'; //sansür
            txt_SifreTkr.PasswordChar = '*';
            txt_Kadi.MaxLength = 50; //en fazla girilebilecek uzunluk
            txt_Sifre.MaxLength = 50;
            txt_SifreTkr.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        { //Ekle butonu
            tblKullanici.Validasyonlar(this);
          
            #region hatalar
            string hatamsg = "";

            if (txt_Sifre.Text != txt_SifreTkr.Text)
                hatamsg += "Şifreler eşleşmiyor";

            if (!txt_email.Text.Contains("@"))
                hatamsg += " \nEmail geçerli değil";

            Data d = new Data();
            d.komut.CommandText = "SELECT * FROM tblKullanici WHERE Kadi=@pkadi";
            d.komut.Parameters.AddWithValue("pkadi",txt_Kadi.Text);
            if (d.TabloGetir().Rows.Count > 0)
                hatamsg += " \nKullanıcı adı daha önce alınmış";

            if(hatamsg!="")
            MessageBox.Show(hatamsg);

            #endregion

            if (string.IsNullOrEmpty(hatamsg)) {
                //hata yokmuş, ekleyelim
                Data de = new Data();
                de.komut.CommandText = @"INSERT INTO tblKullanici
                (AdSoyad,Kadi,Sifre,Telefon,Eposta,YetkiGrup) 
                VALUES (@pad, @pkadi, @psifre, @ptel, @pemail, @pyetki)";

                de.komut.Parameters.AddWithValue("pad",txt_AdSoyad.Text);
                de.komut.Parameters.AddWithValue("pkadi", txt_Kadi.Text);
                de.komut.Parameters.AddWithValue("psifre", txt_Sifre.Text);
                de.komut.Parameters.AddWithValue("ptel", msk_tel.Text);
                de.komut.Parameters.AddWithValue("pemail", txt_email.Text);
                de.komut.Parameters.AddWithValue("pyetki", checkBox1.Checked ? 1 : 2);
                de.KomutCalistir();
                MessageBox.Show("Eklendi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//göster gizle butonu
            if (txt_Sifre.PasswordChar == '*')
            {
                txt_Sifre.PasswordChar = '\0'; //null char değeri
                txt_SifreTkr.PasswordChar = '\0'; //(yok)
            }
            else {
                txt_Sifre.PasswordChar = '*';
                txt_SifreTkr.PasswordChar = '*';
            }

        }

        private void button2_Click(object sender, EventArgs e)
        { //şifre üret butonu
            string a = tblKullanici.SifreUret();
            txt_Sifre.Text = a;
            txt_SifreTkr.Text = a;
        }
    }
}
