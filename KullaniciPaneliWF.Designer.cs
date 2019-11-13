namespace RentACarOtomasyonu
{
    partial class KullaniciPaneliWF
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
            this.btn_admnmusteri = new System.Windows.Forms.Button();
            this.btn_admnaraba = new System.Windows.Forms.Button();
            this.btn_admnszlesm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_admnmusteri
            // 
            this.btn_admnmusteri.Location = new System.Drawing.Point(121, 54);
            this.btn_admnmusteri.Name = "btn_admnmusteri";
            this.btn_admnmusteri.Size = new System.Drawing.Size(192, 79);
            this.btn_admnmusteri.TabIndex = 0;
            this.btn_admnmusteri.Text = "MUSTERI KAYITLARI";
            this.btn_admnmusteri.UseVisualStyleBackColor = true;
            this.btn_admnmusteri.Click += new System.EventHandler(this.Btn_admnmusteri_Click);
            // 
            // btn_admnaraba
            // 
            this.btn_admnaraba.Location = new System.Drawing.Point(121, 159);
            this.btn_admnaraba.Name = "btn_admnaraba";
            this.btn_admnaraba.Size = new System.Drawing.Size(192, 79);
            this.btn_admnaraba.TabIndex = 1;
            this.btn_admnaraba.Text = "ARABA KAYITLARI";
            this.btn_admnaraba.UseVisualStyleBackColor = true;
            this.btn_admnaraba.Click += new System.EventHandler(this.Btn_admnaraba_Click);
            // 
            // btn_admnszlesm
            // 
            this.btn_admnszlesm.Location = new System.Drawing.Point(121, 279);
            this.btn_admnszlesm.Name = "btn_admnszlesm";
            this.btn_admnszlesm.Size = new System.Drawing.Size(192, 79);
            this.btn_admnszlesm.TabIndex = 2;
            this.btn_admnszlesm.Text = "SOZLESME  ALANI";
            this.btn_admnszlesm.UseVisualStyleBackColor = true;
            this.btn_admnszlesm.Click += new System.EventHandler(this.Btn_admnszlesm_Click);
            // 
            // KullaniciPaneliWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btn_admnszlesm);
            this.Controls.Add(this.btn_admnaraba);
            this.Controls.Add(this.btn_admnmusteri);
            this.Name = "KullaniciPaneliWF";
            this.Text = "KullaniciPaneliWF";
            this.Load += new System.EventHandler(this.KullaniciPaneliWF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_admnmusteri;
        private System.Windows.Forms.Button btn_admnaraba;
        private System.Windows.Forms.Button btn_admnszlesm;
    }
}