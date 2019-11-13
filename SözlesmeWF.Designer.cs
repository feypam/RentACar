namespace RentACarOtomasyonu
{
    partial class SözlesmeWF
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
            this.dtp_alimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_s_araba = new System.Windows.Forms.ComboBox();
            this.btn_s_olustur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvw_s_aracbilgi = new System.Windows.Forms.DataGridView();
            this.lbl_sure = new System.Windows.Forms.Label();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_teslimtarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_s_aktifmi = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_scikis = new System.Windows.Forms.Button();
            this.datagvw_sozlesmeblg = new System.Windows.Forms.DataGridView();
            this.btn_sgstr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_s_aracbilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvw_sozlesmeblg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Seçiniz";
            // 
            // dtp_alimtarihi
            // 
            this.dtp_alimtarihi.CustomFormat = "";
            this.dtp_alimtarihi.Location = new System.Drawing.Point(64, 246);
            this.dtp_alimtarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_alimtarihi.MinDate = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.dtp_alimtarihi.Name = "dtp_alimtarihi";
            this.dtp_alimtarihi.Size = new System.Drawing.Size(265, 22);
            this.dtp_alimtarihi.TabIndex = 2;
            this.dtp_alimtarihi.Value = new System.DateTime(2019, 11, 13, 0, 0, 0, 0);
            this.dtp_alimtarihi.ValueChanged += new System.EventHandler(this.Dtp_alimtarihi_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kiralanan Süre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Toplam Fatura Tutari";
            // 
            // cmb_s_araba
            // 
            this.cmb_s_araba.FormattingEnabled = true;
            this.cmb_s_araba.Location = new System.Drawing.Point(429, 63);
            this.cmb_s_araba.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_s_araba.Name = "cmb_s_araba";
            this.cmb_s_araba.Size = new System.Drawing.Size(160, 24);
            this.cmb_s_araba.TabIndex = 5;
            this.cmb_s_araba.SelectedIndexChanged += new System.EventHandler(this.cmb_s_araba_SelectedIndexChanged);
            // 
            // btn_s_olustur
            // 
            this.btn_s_olustur.Location = new System.Drawing.Point(727, 262);
            this.btn_s_olustur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_s_olustur.Name = "btn_s_olustur";
            this.btn_s_olustur.Size = new System.Drawing.Size(161, 54);
            this.btn_s_olustur.TabIndex = 7;
            this.btn_s_olustur.Text = "Sözleşme Oluştur";
            this.btn_s_olustur.UseVisualStyleBackColor = true;
            this.btn_s_olustur.Click += new System.EventHandler(this.btn_s_tamamla_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seçilen Araç Özellikleri";
            // 
            // dgvw_s_aracbilgi
            // 
            this.dgvw_s_aracbilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvw_s_aracbilgi.Location = new System.Drawing.Point(621, 63);
            this.dgvw_s_aracbilgi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvw_s_aracbilgi.Name = "dgvw_s_aracbilgi";
            this.dgvw_s_aracbilgi.RowHeadersWidth = 51;
            this.dgvw_s_aracbilgi.Size = new System.Drawing.Size(571, 180);
            this.dgvw_s_aracbilgi.TabIndex = 10;
            // 
            // lbl_sure
            // 
            this.lbl_sure.AutoSize = true;
            this.lbl_sure.Location = new System.Drawing.Point(425, 362);
            this.lbl_sure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sure.Name = "lbl_sure";
            this.lbl_sure.Size = new System.Drawing.Size(0, 17);
            this.lbl_sure.TabIndex = 13;
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Location = new System.Drawing.Point(425, 401);
            this.lbl_tutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(0, 17);
            this.lbl_tutar.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Alım Tarihi Seçiniz";
            // 
            // dtp_teslimtarihi
            // 
            this.dtp_teslimtarihi.CustomFormat = "";
            this.dtp_teslimtarihi.Location = new System.Drawing.Point(64, 322);
            this.dtp_teslimtarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_teslimtarihi.MinDate = new System.DateTime(2019, 11, 2, 0, 0, 0, 0);
            this.dtp_teslimtarihi.Name = "dtp_teslimtarihi";
            this.dtp_teslimtarihi.Size = new System.Drawing.Size(265, 22);
            this.dtp_teslimtarihi.TabIndex = 16;
            this.dtp_teslimtarihi.Value = new System.DateTime(2019, 11, 13, 0, 0, 0, 0);
            this.dtp_teslimtarihi.ValueChanged += new System.EventHandler(this.Dtp_teslimtarihi_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Teslim Tarihi Seçiniz";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 362);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gün";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 401);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "TL";
            // 
            // cmb_s_aktifmi
            // 
            this.cmb_s_aktifmi.FormattingEnabled = true;
            this.cmb_s_aktifmi.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cmb_s_aktifmi.Location = new System.Drawing.Point(405, 466);
            this.cmb_s_aktifmi.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_s_aktifmi.Name = "cmb_s_aktifmi";
            this.cmb_s_aktifmi.Size = new System.Drawing.Size(167, 24);
            this.cmb_s_aktifmi.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(280, 469);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "AktifMi";
            // 
            // btn_scikis
            // 
            this.btn_scikis.Location = new System.Drawing.Point(951, 262);
            this.btn_scikis.Name = "btn_scikis";
            this.btn_scikis.Size = new System.Drawing.Size(156, 54);
            this.btn_scikis.TabIndex = 28;
            this.btn_scikis.Text = "Cikis";
            this.btn_scikis.UseVisualStyleBackColor = true;
            this.btn_scikis.Click += new System.EventHandler(this.Btn_scikis_Click);
            // 
            // datagvw_sozlesmeblg
            // 
            this.datagvw_sozlesmeblg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagvw_sozlesmeblg.Location = new System.Drawing.Point(579, 345);
            this.datagvw_sozlesmeblg.Name = "datagvw_sozlesmeblg";
            this.datagvw_sozlesmeblg.RowHeadersWidth = 51;
            this.datagvw_sozlesmeblg.RowTemplate.Height = 24;
            this.datagvw_sozlesmeblg.Size = new System.Drawing.Size(613, 150);
            this.datagvw_sozlesmeblg.TabIndex = 29;
            // 
            // btn_sgstr
            // 
            this.btn_sgstr.Location = new System.Drawing.Point(633, 501);
            this.btn_sgstr.Name = "btn_sgstr";
            this.btn_sgstr.Size = new System.Drawing.Size(175, 65);
            this.btn_sgstr.TabIndex = 30;
            this.btn_sgstr.Text = "Sozlesme Bilgisi Goster";
            this.btn_sgstr.UseVisualStyleBackColor = true;
            this.btn_sgstr.Click += new System.EventHandler(this.Btn_sgstr_Click);
            // 
            // SözlesmeWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 578);
            this.Controls.Add(this.btn_sgstr);
            this.Controls.Add(this.datagvw_sozlesmeblg);
            this.Controls.Add(this.btn_scikis);
            this.Controls.Add(this.cmb_s_aktifmi);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_teslimtarihi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.lbl_sure);
            this.Controls.Add(this.dgvw_s_aracbilgi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_s_olustur);
            this.Controls.Add(this.cmb_s_araba);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_alimtarihi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SözlesmeWF";
            this.Text = "Araç Kiralama Paneli";
            this.Load += new System.EventHandler(this.SözlesmeWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvw_s_aracbilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagvw_sozlesmeblg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_alimtarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_s_araba;
        private System.Windows.Forms.Button btn_s_olustur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvw_s_aracbilgi;
        private System.Windows.Forms.Label lbl_sure;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_teslimtarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_s_aktifmi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_scikis;
        public System.Windows.Forms.DataGridView datagvw_sozlesmeblg;
        public System.Windows.Forms.Button btn_sgstr;
    }
}