namespace RentACarOtomasyonu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstvw_m_bilgi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.btn_m_sil = new System.Windows.Forms.Button();
            this.btn_m_duzenle = new System.Windows.Forms.Button();
            this.txt_m_adres = new System.Windows.Forms.TextBox();
            this.txt_m_sifre = new System.Windows.Forms.TextBox();
            this.txt_m_email = new System.Windows.Forms.TextBox();
            this.txt_m_telefon = new System.Windows.Forms.TextBox();
            this.txt_m_ehliyet = new System.Windows.Forms.TextBox();
            this.txt_m_soyisim = new System.Windows.Forms.TextBox();
            this.txt_m_isim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maktifmi = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txt_m_tc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_maktifmi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lstvw_m_bilgi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_m_sil);
            this.groupBox1.Controls.Add(this.btn_m_duzenle);
            this.groupBox1.Controls.Add(this.txt_m_adres);
            this.groupBox1.Controls.Add(this.txt_m_sifre);
            this.groupBox1.Controls.Add(this.txt_m_email);
            this.groupBox1.Controls.Add(this.txt_m_telefon);
            this.groupBox1.Controls.Add(this.txt_m_ehliyet);
            this.groupBox1.Controls.Add(this.txt_m_tc);
            this.groupBox1.Controls.Add(this.txt_m_soyisim);
            this.groupBox1.Controls.Add(this.txt_m_isim);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(779, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 77);
            this.button1.TabIndex = 24;
            this.button1.Text = "MUSTERI KAYIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // lstvw_m_bilgi
            // 
            this.lstvw_m_bilgi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lstvw_m_bilgi.HideSelection = false;
            this.lstvw_m_bilgi.Location = new System.Drawing.Point(8, 362);
            this.lstvw_m_bilgi.Margin = new System.Windows.Forms.Padding(4);
            this.lstvw_m_bilgi.Name = "lstvw_m_bilgi";
            this.lstvw_m_bilgi.Size = new System.Drawing.Size(763, 154);
            this.lstvw_m_bilgi.TabIndex = 22;
            this.lstvw_m_bilgi.UseCompatibleStateImageBehavior = false;
            this.lstvw_m_bilgi.View = System.Windows.Forms.View.Details;
            this.lstvw_m_bilgi.DoubleClick += new System.EventHandler(this.lstvw_m_bilgi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İsim";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyisim";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TC";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ehliyet No";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Telefon No";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Adres";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Şifre";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "EklenmeTarihi";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "GüncellenmeTarihi";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Silinme Tarihi";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "AktifMi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "AktifMi";
            // 
            // btn_m_sil
            // 
            this.btn_m_sil.Location = new System.Drawing.Point(380, 242);
            this.btn_m_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_m_sil.Name = "btn_m_sil";
            this.btn_m_sil.Size = new System.Drawing.Size(188, 80);
            this.btn_m_sil.TabIndex = 19;
            this.btn_m_sil.Text = "KAYIT SİL";
            this.btn_m_sil.UseVisualStyleBackColor = true;
            this.btn_m_sil.Click += new System.EventHandler(this.Btn_m_sil_Click);
            // 
            // btn_m_duzenle
            // 
            this.btn_m_duzenle.Location = new System.Drawing.Point(380, 131);
            this.btn_m_duzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_m_duzenle.Name = "btn_m_duzenle";
            this.btn_m_duzenle.Size = new System.Drawing.Size(188, 80);
            this.btn_m_duzenle.TabIndex = 18;
            this.btn_m_duzenle.Text = "GÜNCELLE";
            this.btn_m_duzenle.UseVisualStyleBackColor = true;
            this.btn_m_duzenle.Click += new System.EventHandler(this.btn_m_duzenle_Click);
            // 
            // txt_m_adres
            // 
            this.txt_m_adres.Location = new System.Drawing.Point(172, 224);
            this.txt_m_adres.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m_adres.Name = "txt_m_adres";
            this.txt_m_adres.Size = new System.Drawing.Size(132, 22);
            this.txt_m_adres.TabIndex = 16;
            // 
            // txt_m_sifre
            // 
            this.txt_m_sifre.Location = new System.Drawing.Point(172, 256);
            this.txt_m_sifre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m_sifre.Name = "txt_m_sifre";
            this.txt_m_sifre.Size = new System.Drawing.Size(132, 22);
            this.txt_m_sifre.TabIndex = 15;
            this.txt_m_sifre.WordWrap = false;
            // 
            // txt_m_email
            // 
            this.txt_m_email.Location = new System.Drawing.Point(172, 192);
            this.txt_m_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m_email.Name = "txt_m_email";
            this.txt_m_email.Size = new System.Drawing.Size(132, 22);
            this.txt_m_email.TabIndex = 13;
            // 
            // txt_m_telefon
            // 
            this.txt_m_telefon.Location = new System.Drawing.Point(172, 160);
            this.txt_m_telefon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m_telefon.Name = "txt_m_telefon";
            this.txt_m_telefon.Size = new System.Drawing.Size(132, 22);
            this.txt_m_telefon.TabIndex = 12;
            // 
            // txt_m_ehliyet
            // 
            this.txt_m_ehliyet.Location = new System.Drawing.Point(172, 128);
            this.txt_m_ehliyet.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m_ehliyet.Name = "txt_m_ehliyet";
            this.txt_m_ehliyet.Size = new System.Drawing.Size(132, 22);
            this.txt_m_ehliyet.TabIndex = 11;
            // 
            // txt_m_soyisim
            // 
            this.txt_m_soyisim.Location = new System.Drawing.Point(172, 64);
            this.txt_m_soyisim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m_soyisim.Name = "txt_m_soyisim";
            this.txt_m_soyisim.Size = new System.Drawing.Size(132, 22);
            this.txt_m_soyisim.TabIndex = 9;
            // 
            // txt_m_isim
            // 
            this.txt_m_isim.Location = new System.Drawing.Point(172, 32);
            this.txt_m_isim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m_isim.Name = "txt_m_isim";
            this.txt_m_isim.Size = new System.Drawing.Size(132, 22);
            this.txt_m_isim.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Şifre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ehliyet No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // txt_maktifmi
            // 
            this.txt_maktifmi.Location = new System.Drawing.Point(172, 288);
            this.txt_maktifmi.Name = "txt_maktifmi";
            this.txt_maktifmi.Size = new System.Drawing.Size(132, 22);
            this.txt_maktifmi.TabIndex = 25;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // txt_m_tc
            // 
            this.txt_m_tc.Location = new System.Drawing.Point(172, 96);
            this.txt_m_tc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_m_tc.MaxLength = 11;
            this.txt_m_tc.Name = "txt_m_tc";
            this.txt_m_tc.Size = new System.Drawing.Size(132, 22);
            this.txt_m_tc.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "GIRIS PANELİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_m_adres;
        private System.Windows.Forms.TextBox txt_m_sifre;
        private System.Windows.Forms.TextBox txt_m_email;
        private System.Windows.Forms.TextBox txt_m_telefon;
        private System.Windows.Forms.TextBox txt_m_ehliyet;
        private System.Windows.Forms.TextBox txt_m_soyisim;
        private System.Windows.Forms.TextBox txt_m_isim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstvw_m_bilgi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btn_m_sil;
        public System.Windows.Forms.Button btn_m_duzenle;
        private System.Windows.Forms.TextBox txt_maktifmi;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox txt_m_tc;
    }
}

