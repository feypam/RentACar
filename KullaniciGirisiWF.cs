using RentACarOtomasyonu.ORM.Context;
using RentACarOtomasyonu.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RentACarOtomasyonu
{
    public partial class KullaniciGirisiWF : Form
    {
        public KullaniciGirisiWF()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        public static string gonderilecekveri;
        
        private void Btn_admin_Click(object sender, EventArgs e)
        {
            gonderilecekveri = txt_kadi.Text;
            string ad = "";
            string sifre = "";


            List<Kullanicilar> f = new List<Kullanicilar>();
            f = db.Kullanicilars.Where(x => x.KullaniciAdi == txt_kadi.Text).ToList();
            foreach (Kullanicilar item in f)
            {
                ad = item.KullaniciAdi.ToString();
                sifre = item.Sifre.ToString();

            }

            if (string.IsNullOrEmpty(txt_kadi.Text) || string.IsNullOrEmpty(txt_ksifre.Text))
            {
                MessageBox.Show("Alanlari Bos Gecemezsiniz!");
            }
            else
            {
                if (ad==(txt_kadi.Text))
                {
                    if (sifre == txt_ksifre.Text)

                    {
                        KullaniciPaneliWF kk = new KullaniciPaneliWF();
                        kk.Show();
                    }
                    else
                    {
                        MessageBox.Show("Sifre Yanlis ");
                    }

                }
                else
                {
                    MessageBox.Show("Kullanici yok");
                }
            }
          
        }

        private void Btn_mgiris_Click(object sender, EventArgs e)
        {   

            string tc = "";
            string sifre = "";
            

            List<Musteriler> m = new List<Musteriler>();
            m = db.Customers.Where(x => x.TC == txt_mtc.Text).ToList();
            foreach (Musteriler item in m)
            {
                tc = item.TC;
                sifre = item.Sifre.ToString();

            }

            if (string.IsNullOrEmpty(txt_mtc.Text) || string.IsNullOrEmpty(txt_mtc.Text))
            {
                MessageBox.Show("Musteri alanlari bos gecilemez");
            }
            else
            {
                if ( tc == txt_mtc.Text)
                {
                    if(sifre == txt_msifre.Text )
                    {
                        SözlesmeWF ms = new SözlesmeWF();
                        ms.Show();
                        ms.btn_sgstr.Hide();
                        ms.datagvw_sozlesmeblg.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sifre yanlis");
                    }
                }
                else
                {
                    MessageBox.Show("Musteri Yok");
                }
               
            }
            
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 myk = new Form1();
            myk.Show();
            myk.btn_m_sil.Hide();
            myk.btn_m_duzenle.Hide();
            
        }

        private void KullaniciGirisiWF_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}