using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakaleYonetim
{
    class tblKullanici //tblKullanici (model)
    {
        #region Model
        public static tblKullanici GirisYapan { get; set; }
        public int KullaniciID { get; set; }
        public string Kadi { get; set; }
        public string Sifre { get; set; }
        public string AdSoyad { get; set; }
        public int YetkiGrup { get; set; }
        public string Telefon { get; set; }
        public string Eposta { get; set; }
        #endregion

        #region Business
        //6 haneli bir şifre üreten metodu yazın
        public static string SifreUret() {
            string s = Guid.NewGuid().ToString().Substring(0, 6);
            return s;
        }

        public static void Validasyonlar(Form gelenform) {
            #region Validasyonlar
            foreach (var item in gelenform.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    if (string.IsNullOrEmpty(t.Text))
                        t.BackColor = Color.Pink;
                    else
                        t.BackColor = Color.White;
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox m = (MaskedTextBox)item;
                    if (string.IsNullOrEmpty(m.Text.Replace(" ", "").Replace("(", "").Replace(")", "")))
                        m.BackColor = Color.Pink;
                    else
                        m.BackColor = Color.White;
                }
            }
            #endregion

        }

        #endregion
    }
}
