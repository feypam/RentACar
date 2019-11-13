namespace RentACarOtomasyonu
{
    partial class KullaniciGirisiWF
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
            this.btn_admin = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ksifre = new System.Windows.Forms.TextBox();
            this.txt_kadi = new System.Windows.Forms.TextBox();
            this.btn_mgiris = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_msifre = new System.Windows.Forms.TextBox();
            this.txt_mtc = new System.Windows.Forms.TextBox();
            this.btn_yenikayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(173, 160);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(100, 45);
            this.btn_admin.TabIndex = 13;
            this.btn_admin.Text = "Admin Giris";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.Btn_admin_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Sifre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Kullanici Adi";
            // 
            // txt_ksifre
            // 
            this.txt_ksifre.Location = new System.Drawing.Point(252, 111);
            this.txt_ksifre.Name = "txt_ksifre";
            this.txt_ksifre.PasswordChar = '*';
            this.txt_ksifre.Size = new System.Drawing.Size(100, 22);
            this.txt_ksifre.TabIndex = 10;
            // 
            // txt_kadi
            // 
            this.txt_kadi.Location = new System.Drawing.Point(252, 57);
            this.txt_kadi.Name = "txt_kadi";
            this.txt_kadi.Size = new System.Drawing.Size(100, 22);
            this.txt_kadi.TabIndex = 9;
            // 
            // btn_mgiris
            // 
            this.btn_mgiris.Location = new System.Drawing.Point(252, 343);
            this.btn_mgiris.Name = "btn_mgiris";
            this.btn_mgiris.Size = new System.Drawing.Size(100, 50);
            this.btn_mgiris.TabIndex = 18;
            this.btn_mgiris.Text = "Musteri Giris";
            this.btn_mgiris.UseVisualStyleBackColor = true;
            this.btn_mgiris.Click += new System.EventHandler(this.Btn_mgiris_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 285);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Sifre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Musteri TC";
            // 
            // txt_msifre
            // 
            this.txt_msifre.Location = new System.Drawing.Point(252, 280);
            this.txt_msifre.Name = "txt_msifre";
            this.txt_msifre.PasswordChar = '*';
            this.txt_msifre.Size = new System.Drawing.Size(100, 22);
            this.txt_msifre.TabIndex = 15;
            // 
            // txt_mtc
            // 
            this.txt_mtc.Location = new System.Drawing.Point(252, 226);
            this.txt_mtc.MaxLength = 11;
            this.txt_mtc.Name = "txt_mtc";
            this.txt_mtc.Size = new System.Drawing.Size(100, 22);
            this.txt_mtc.TabIndex = 14;
            this.txt_mtc.WordWrap = false;
            // 
            // btn_yenikayit
            // 
            this.btn_yenikayit.Location = new System.Drawing.Point(108, 343);
            this.btn_yenikayit.Name = "btn_yenikayit";
            this.btn_yenikayit.Size = new System.Drawing.Size(101, 50);
            this.btn_yenikayit.TabIndex = 19;
            this.btn_yenikayit.Text = "Yeni Kayit";
            this.btn_yenikayit.UseVisualStyleBackColor = true;
            this.btn_yenikayit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // KullaniciGirisiWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.btn_yenikayit);
            this.Controls.Add(this.btn_mgiris);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_msifre);
            this.Controls.Add(this.txt_mtc);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_ksifre);
            this.Controls.Add(this.txt_kadi);
            this.Name = "KullaniciGirisiWF";
            this.Text = "KullaniciGirisiWF";
            this.Load += new System.EventHandler(this.KullaniciGirisiWF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_ksifre;
        private System.Windows.Forms.TextBox txt_kadi;
        private System.Windows.Forms.Button btn_mgiris;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_msifre;
        private System.Windows.Forms.TextBox txt_mtc;
        private System.Windows.Forms.Button btn_yenikayit;
    }
}