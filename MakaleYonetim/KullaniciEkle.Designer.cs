namespace MakaleYonetim
{
    partial class KullaniciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_AdSoyad = new System.Windows.Forms.TextBox();
            this.txt_Kadi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_SifreTkr = new System.Windows.Forms.TextBox();
            this.msk_tel = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre (tekrar):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // txt_AdSoyad
            // 
            this.txt_AdSoyad.Location = new System.Drawing.Point(230, 20);
            this.txt_AdSoyad.Name = "txt_AdSoyad";
            this.txt_AdSoyad.Size = new System.Drawing.Size(388, 40);
            this.txt_AdSoyad.TabIndex = 6;
            // 
            // txt_Kadi
            // 
            this.txt_Kadi.Location = new System.Drawing.Point(230, 81);
            this.txt_Kadi.Name = "txt_Kadi";
            this.txt_Kadi.Size = new System.Drawing.Size(388, 40);
            this.txt_Kadi.TabIndex = 7;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(230, 139);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(175, 40);
            this.txt_Sifre.TabIndex = 8;
            // 
            // txt_SifreTkr
            // 
            this.txt_SifreTkr.Location = new System.Drawing.Point(230, 192);
            this.txt_SifreTkr.Name = "txt_SifreTkr";
            this.txt_SifreTkr.Size = new System.Drawing.Size(175, 40);
            this.txt_SifreTkr.TabIndex = 9;
            // 
            // msk_tel
            // 
            this.msk_tel.Location = new System.Drawing.Point(230, 250);
            this.msk_tel.Name = "msk_tel";
            this.msk_tel.Size = new System.Drawing.Size(388, 40);
            this.msk_tel.TabIndex = 10;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(230, 305);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(388, 40);
            this.txt_email.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 63);
            this.button1.TabIndex = 12;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(411, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 93);
            this.button2.TabIndex = 13;
            this.button2.Text = "Şifre Üret";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(500, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 93);
            this.button3.TabIndex = 14;
            this.button3.Text = "Göster / Gizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Yönetici:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(230, 361);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 37);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Evet";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 490);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.msk_tel);
            this.Controls.Add(this.txt_SifreTkr);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Kadi);
            this.Controls.Add(this.txt_AdSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "KullaniciEkle";
            this.Text = "Yazar Ekle";
            this.Load += new System.EventHandler(this.KullaniciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_AdSoyad;
        private System.Windows.Forms.TextBox txt_Kadi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_SifreTkr;
        private System.Windows.Forms.MaskedTextBox msk_tel;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}