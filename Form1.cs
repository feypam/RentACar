﻿using RentACarOtomasyonu.ORM.Context;
using RentACarOtomasyonu.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        ProjectContext db = new ProjectContext();
        
        


        private void Form1_Load(object sender, EventArgs e)
        {
            CustomerList();
            CenterToScreen();
            

           

        }

        Musteriler updated;
        private void btn_m_duzenle_Click(object sender, EventArgs e)
        {
           
                
            if (lstvw_m_bilgi.SelectedItems.Count <= 0 && updated == null)
                return;
            updated.Ad = txt_m_isim.Text;
            updated.Soyad = txt_m_soyisim.Text;
            updated.TC = txt_m_tc.Text;
            updated.EhliyetNo = txt_m_ehliyet.Text;
            updated.Telefon = txt_m_telefon.Text;
            updated.Email = txt_m_email.Text;
            updated.Adres = txt_m_adres.Text;
            updated.Sifre = txt_m_sifre.Text;
            updated.UpdateDate = DateTime.Now;
            updated.AktifMi = Convert.ToBoolean(txt_maktifmi.Text);

            db.Entry(db.Customers.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();

            txt_maktifmi.Text = string.Empty;
            txt_m_isim.Text = string.Empty;
            txt_m_soyisim.Text = default(string);
            txt_m_tc.Text = default(string);
            txt_m_ehliyet.Text = string.Empty;
            txt_m_telefon.Text = string.Empty;
            txt_m_email.Text = string.Empty;
            txt_m_adres.Text = string.Empty;
            txt_m_sifre.Text = string.Empty;

            CustomerList();
        }

        private void lstvw_m_bilgi_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lstvw_m_bilgi.SelectedItems[0].Tag);
            updated = db.Customers.Find(id);
            txt_m_isim.Text = updated.Ad;
            txt_m_soyisim.Text = updated.Soyad;
            txt_m_tc.Text=updated.TC;
            txt_m_ehliyet.Text = updated.EhliyetNo;
            txt_m_telefon.Text = updated.Telefon;
            txt_m_email.Text = updated.Email;
            txt_m_adres.Text = updated.Adres;
            txt_m_sifre.Text = updated.Sifre;
            txt_maktifmi.Text=Convert.ToString( updated.AktifMi);
        }

        
        public void CustomerList()
        {
            lstvw_m_bilgi.Items.Clear();
            foreach (Musteriler item in db.Customers.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Ad);
                lvi.SubItems.Add(item.Soyad);
                lvi.SubItems.Add(item.TC);
                lvi.SubItems.Add(item.EhliyetNo);
                lvi.SubItems.Add(item.Telefon);
                lvi.SubItems.Add(item.Email);
                lvi.SubItems.Add(item.Adres);
                lvi.SubItems.Add(item.Sifre);
                lvi.SubItems.Add(item.AddDate.ToString());
                lvi.SubItems.Add(item.UpdateDate.ToString());
                lvi.SubItems.Add(item.DeleteDate.ToString());
                lvi.SubItems.Add(item.AktifMi.ToString());
                lvi.Tag = item.ID;
                lstvw_m_bilgi.Items.Add(lvi);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            
            Musteriler musteri = new Musteriler();
            musteri.Ad = txt_m_isim.Text;
            musteri.Soyad = txt_m_soyisim.Text;
            musteri.TC = txt_m_tc.Text;
            musteri.EhliyetNo = txt_m_ehliyet.Text;
            musteri.Telefon = txt_m_telefon.Text;
            musteri.Email = txt_m_email.Text;
            musteri.Adres = txt_m_adres.Text;
            musteri.Sifre = txt_m_sifre.Text;

            musteri.AddDate = DateTime.Now;
            musteri.AktifMi =true;

            db.Customers.Add(musteri);
            db.SaveChanges();

            txt_maktifmi.Text = string.Empty;
            txt_m_isim.Text = string.Empty;
            txt_m_soyisim.Text = default(string);
            txt_m_tc.Text = default(string);
            txt_m_ehliyet.Text = string.Empty;
            txt_m_telefon.Text = string.Empty;
            txt_m_email.Text = string.Empty;
            txt_m_adres.Text = string.Empty;
            txt_m_sifre.Text = string.Empty;
            CustomerList();
        }
        
        private void Btn_m_sil_Click(object sender, EventArgs e)
        {
            if (lstvw_m_bilgi.SelectedItems.Count <= 0 && updated == null)
                return;
            int id = Convert.ToInt32(lstvw_m_bilgi.SelectedItems[0].Tag);
            Musteriler deleted = db.Customers.Find(id);
          
            SilinenMusteriler smusteri = new SilinenMusteriler();
            smusteri.MusteriID = updated.ID;
            smusteri.Ad = txt_m_isim.Text;
            smusteri.Soyad = txt_m_soyisim.Text;
            smusteri.TC = txt_m_tc.Text;
            smusteri.EhliyetNo = txt_m_ehliyet.Text;
            smusteri.Telefon = txt_m_telefon.Text;
            smusteri.Email = txt_m_email.Text;
            smusteri.Adres = txt_m_adres.Text;
            smusteri.Sifre = txt_m_sifre.Text;
            smusteri.AktifMi = Convert.ToBoolean(txt_maktifmi.Text);
            smusteri.DeleteDate= DateTime.Now;
            smusteri.AddDate = updated.AddDate;
            smusteri.UpdateDate = updated.UpdateDate;
            db.SilinenMusterilers.Add(smusteri);
            db.Customers.Remove(deleted);
           
            db.SaveChanges();

            txt_maktifmi.Text = string.Empty;
            txt_m_isim.Text = string.Empty;
            txt_m_soyisim.Text = default(string);
            txt_m_tc.Text = default(string);
            txt_m_ehliyet.Text = string.Empty;
            txt_m_telefon.Text = string.Empty;
            txt_m_email.Text = string.Empty;
            txt_m_adres.Text = string.Empty;
            txt_m_sifre.Text = string.Empty;

            CustomerList();
        }
    }


}
    

