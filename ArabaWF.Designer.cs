﻿namespace RentACarOtomasyonu
{
    partial class ArabaWF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_a_yakıttipi = new System.Windows.Forms.ComboBox();
            this.cmb_a_vitestipi = new System.Windows.Forms.ComboBox();
            this.cmb_a_aractipi = new System.Windows.Forms.ComboBox();
            this.txt_a_fiyat = new System.Windows.Forms.TextBox();
            this.lstvw_a_bilgi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label9 = new System.Windows.Forms.Label();
            this.btn_a_sil = new System.Windows.Forms.Button();
            this.btn_a_duzenle = new System.Windows.Forms.Button();
            this.btn_a_ekle = new System.Windows.Forms.Button();
            this.txt_a_model = new System.Windows.Forms.TextBox();
            this.txt_a_marka = new System.Windows.Forms.TextBox();
            this.txt_a_plaka = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_aaktifmi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_aaktifmi);
            this.groupBox1.Controls.Add(this.cmb_a_yakıttipi);
            this.groupBox1.Controls.Add(this.cmb_a_vitestipi);
            this.groupBox1.Controls.Add(this.cmb_a_aractipi);
            this.groupBox1.Controls.Add(this.txt_a_fiyat);
            this.groupBox1.Controls.Add(this.lstvw_a_bilgi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_a_sil);
            this.groupBox1.Controls.Add(this.btn_a_duzenle);
            this.groupBox1.Controls.Add(this.btn_a_ekle);
            this.groupBox1.Controls.Add(this.txt_a_model);
            this.groupBox1.Controls.Add(this.txt_a_marka);
            this.groupBox1.Controls.Add(this.txt_a_plaka);
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
            this.groupBox1.Size = new System.Drawing.Size(1037, 524);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // cmb_a_yakıttipi
            // 
            this.cmb_a_yakıttipi.FormattingEnabled = true;
            this.cmb_a_yakıttipi.Items.AddRange(new object[] {
            "Dizel",
            "Benzin",
            "Hibrit"});
            this.cmb_a_yakıttipi.Location = new System.Drawing.Point(172, 192);
            this.cmb_a_yakıttipi.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_a_yakıttipi.Name = "cmb_a_yakıttipi";
            this.cmb_a_yakıttipi.Size = new System.Drawing.Size(167, 24);
            this.cmb_a_yakıttipi.TabIndex = 28;
            // 
            // cmb_a_vitestipi
            // 
            this.cmb_a_vitestipi.FormattingEnabled = true;
            this.cmb_a_vitestipi.Items.AddRange(new object[] {
            "Otomatik",
            "Yarı Otomatik",
            "Manuel"});
            this.cmb_a_vitestipi.Location = new System.Drawing.Point(172, 160);
            this.cmb_a_vitestipi.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_a_vitestipi.Name = "cmb_a_vitestipi";
            this.cmb_a_vitestipi.Size = new System.Drawing.Size(167, 24);
            this.cmb_a_vitestipi.TabIndex = 27;
            // 
            // cmb_a_aractipi
            // 
            this.cmb_a_aractipi.FormattingEnabled = true;
            this.cmb_a_aractipi.Items.AddRange(new object[] {
            "Sedan",
            "HatchBack",
            "Suv"});
            this.cmb_a_aractipi.Location = new System.Drawing.Point(172, 128);
            this.cmb_a_aractipi.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_a_aractipi.Name = "cmb_a_aractipi";
            this.cmb_a_aractipi.Size = new System.Drawing.Size(167, 24);
            this.cmb_a_aractipi.TabIndex = 26;
            // 
            // txt_a_fiyat
            // 
            this.txt_a_fiyat.Location = new System.Drawing.Point(172, 224);
            this.txt_a_fiyat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a_fiyat.Name = "txt_a_fiyat";
            this.txt_a_fiyat.Size = new System.Drawing.Size(167, 22);
            this.txt_a_fiyat.TabIndex = 24;
            // 
            // lstvw_a_bilgi
            // 
            this.lstvw_a_bilgi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lstvw_a_bilgi.HideSelection = false;
            this.lstvw_a_bilgi.Location = new System.Drawing.Point(8, 362);
            this.lstvw_a_bilgi.Margin = new System.Windows.Forms.Padding(4);
            this.lstvw_a_bilgi.Name = "lstvw_a_bilgi";
            this.lstvw_a_bilgi.Size = new System.Drawing.Size(985, 154);
            this.lstvw_a_bilgi.TabIndex = 22;
            this.lstvw_a_bilgi.UseCompatibleStateImageBehavior = false;
            this.lstvw_a_bilgi.View = System.Windows.Forms.View.Details;
            this.lstvw_a_bilgi.DoubleClick += new System.EventHandler(this.lstvw_a_bilgi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Plaka";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Marka";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Model";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Araç Tipi";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vites Tipi";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Yakıt Tipi";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fiyat";
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
            this.label9.Location = new System.Drawing.Point(64, 261);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "AktifMi";
            // 
            // btn_a_sil
            // 
            this.btn_a_sil.Location = new System.Drawing.Point(380, 233);
            this.btn_a_sil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_a_sil.Name = "btn_a_sil";
            this.btn_a_sil.Size = new System.Drawing.Size(188, 80);
            this.btn_a_sil.TabIndex = 19;
            this.btn_a_sil.Text = "ARABA KAYIT SİL";
            this.btn_a_sil.UseVisualStyleBackColor = true;
            this.btn_a_sil.Click += new System.EventHandler(this.Btn_a_sil_Click);
            // 
            // btn_a_duzenle
            // 
            this.btn_a_duzenle.Location = new System.Drawing.Point(380, 132);
            this.btn_a_duzenle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_a_duzenle.Name = "btn_a_duzenle";
            this.btn_a_duzenle.Size = new System.Drawing.Size(188, 80);
            this.btn_a_duzenle.TabIndex = 18;
            this.btn_a_duzenle.Text = "GÜNCELLE";
            this.btn_a_duzenle.UseVisualStyleBackColor = true;
            this.btn_a_duzenle.Click += new System.EventHandler(this.btn_a_duzenle_Click);
            // 
            // btn_a_ekle
            // 
            this.btn_a_ekle.Location = new System.Drawing.Point(380, 32);
            this.btn_a_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_a_ekle.Name = "btn_a_ekle";
            this.btn_a_ekle.Size = new System.Drawing.Size(188, 80);
            this.btn_a_ekle.TabIndex = 17;
            this.btn_a_ekle.Text = "ARABA KAYIT EKLE";
            this.btn_a_ekle.UseVisualStyleBackColor = true;
            this.btn_a_ekle.Click += new System.EventHandler(this.btn_a_ekle_Click);
            // 
            // txt_a_model
            // 
            this.txt_a_model.Location = new System.Drawing.Point(172, 96);
            this.txt_a_model.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a_model.Name = "txt_a_model";
            this.txt_a_model.Size = new System.Drawing.Size(167, 22);
            this.txt_a_model.TabIndex = 10;
            // 
            // txt_a_marka
            // 
            this.txt_a_marka.Location = new System.Drawing.Point(172, 64);
            this.txt_a_marka.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a_marka.Name = "txt_a_marka";
            this.txt_a_marka.Size = new System.Drawing.Size(167, 22);
            this.txt_a_marka.TabIndex = 9;
            // 
            // txt_a_plaka
            // 
            this.txt_a_plaka.Location = new System.Drawing.Point(172, 32);
            this.txt_a_plaka.Margin = new System.Windows.Forms.Padding(4);
            this.txt_a_plaka.Name = "txt_a_plaka";
            this.txt_a_plaka.Size = new System.Drawing.Size(167, 22);
            this.txt_a_plaka.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yakıt Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vites Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Araç Tipi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // txt_aaktifmi
            // 
            this.txt_aaktifmi.Location = new System.Drawing.Point(172, 261);
            this.txt_aaktifmi.Name = "txt_aaktifmi";
            this.txt_aaktifmi.Size = new System.Drawing.Size(167, 22);
            this.txt_aaktifmi.TabIndex = 29;
            // 
            // ArabaWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ArabaWF";
            this.Text = "Araba Paneli";
            this.Load += new System.EventHandler(this.ArabaWF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstvw_a_bilgi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_a_sil;
        private System.Windows.Forms.Button btn_a_duzenle;
        private System.Windows.Forms.Button btn_a_ekle;
        private System.Windows.Forms.TextBox txt_a_model;
        private System.Windows.Forms.TextBox txt_a_marka;
        private System.Windows.Forms.TextBox txt_a_plaka;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a_fiyat;
        private System.Windows.Forms.ComboBox cmb_a_yakıttipi;
        private System.Windows.Forms.ComboBox cmb_a_vitestipi;
        private System.Windows.Forms.ComboBox cmb_a_aractipi;
        private System.Windows.Forms.TextBox txt_aaktifmi;
    }
}