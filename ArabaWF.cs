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
    public partial class ArabaWF : Form
    {
        public ArabaWF()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        private void btn_a_ekle_Click(object sender, EventArgs e)
        {
            Arabalar araba = new Arabalar();
            araba.Plaka = txt_a_plaka.Text;
            araba.Marka = txt_a_marka.Text;
            araba.Model = txt_a_model.Text;
            araba.AracTipi = cmb_a_aractipi.SelectedItem.ToString();
            araba.Vites = cmb_a_vitestipi.SelectedItem.ToString();
            araba.YakitTipi = cmb_a_yakıttipi.SelectedItem.ToString();
            araba.Fiyat = Convert.ToDecimal(txt_a_fiyat.Text);
            araba.AddDate = DateTime.Now;
            araba.AktifMi = true;
            db.Cars.Add(araba);
            db.SaveChanges();
            MessageBox.Show("Araç kayıt eklendi");
           
            txt_aaktifmi.Text = string.Empty;
            cmb_a_aractipi.SelectedIndex = -1;
            cmb_a_vitestipi.SelectedIndex = -1;
            cmb_a_yakıttipi.SelectedIndex = -1;
            txt_a_plaka.Text = string.Empty;
            txt_a_marka.Text = default(string);
            txt_a_model.Text = string.Empty;
            txt_a_fiyat.Text = string.Empty;
            CarList();
        }
        public void CarList()
        {
            lstvw_a_bilgi.Items.Clear();
            foreach (Arabalar item in db.Cars.ToList())
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.Plaka);
                lvi.SubItems.Add(item.Marka);
                lvi.SubItems.Add(item.Model);
                lvi.SubItems.Add(item.AracTipi);
                lvi.SubItems.Add(item.Vites);
                lvi.SubItems.Add(item.YakitTipi);
                lvi.SubItems.Add(item.Fiyat.ToString());
                lvi.SubItems.Add(item.AddDate.ToString());
                lvi.SubItems.Add(item.UpdateDate.ToString());
                lvi.SubItems.Add(item.DeleteDate.ToString());
                lvi.SubItems.Add(item.AktifMi.ToString());
                lvi.Tag = item.ID; //etiket
                lstvw_a_bilgi.Items.Add(lvi);
            }
        }

        private void ArabaWF_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            CarList();
        }

        Arabalar updated;
        private void btn_a_duzenle_Click(object sender, EventArgs e)
        {
            if (lstvw_a_bilgi.SelectedItems.Count <= 0 && updated == null)
                return;
            updated.Plaka = txt_a_plaka.Text;
            updated.Marka = txt_a_marka.Text;
            updated.Model = txt_a_model.Text;
            updated.AracTipi = cmb_a_aractipi.SelectedItem.ToString();
            updated.Vites = cmb_a_vitestipi.SelectedItem.ToString();
            updated.YakitTipi = cmb_a_yakıttipi.SelectedItem.ToString();
            updated.Fiyat = Convert.ToDecimal(txt_a_fiyat.Text);
            updated.UpdateDate = DateTime.Now;
            updated.AktifMi = Convert.ToBoolean(txt_aaktifmi.Text);

            db.Entry(db.Cars.Find(updated.ID)).CurrentValues.SetValues(updated);
            db.SaveChanges();

            txt_aaktifmi.Text = string.Empty; 
            cmb_a_aractipi.SelectedIndex = -1;
            cmb_a_vitestipi.SelectedIndex = -1;
            cmb_a_yakıttipi.SelectedIndex = -1;
            txt_a_plaka.Text = string.Empty;
            txt_a_marka.Text = default(string);
            txt_a_model.Text = string.Empty;
            txt_a_fiyat.Text = string.Empty;

            CarList();
        }

        private void lstvw_a_bilgi_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lstvw_a_bilgi.SelectedItems[0].Tag);
            updated = db.Cars.Find(id);
            txt_a_plaka.Text = updated.Plaka;
            txt_a_marka.Text = updated.Marka;
            txt_a_model.Text = updated.Model;
            cmb_a_aractipi.Text = updated.AracTipi;
            cmb_a_vitestipi.Text = updated.Vites;
            cmb_a_yakıttipi.Text = updated.YakitTipi;
            txt_a_fiyat.Text = updated.Fiyat.ToString();
            txt_aaktifmi.Text = updated.AktifMi.ToString();
        }

        private void Btn_a_sil_Click(object sender, EventArgs e)
        {
            if (lstvw_a_bilgi.SelectedItems.Count <= 0 && updated == null)
                return;
            int id = Convert.ToInt32(lstvw_a_bilgi.SelectedItems[0].Tag);
            Arabalar deleted = db.Cars.Find(id);

            SilinenArabalar saraba = new SilinenArabalar();
            saraba.Plaka = txt_a_plaka.Text;
            saraba.Marka = txt_a_marka.Text;
            saraba.Model = txt_a_model.Text;
            saraba.AracTipi = cmb_a_aractipi.SelectedItem.ToString();
            saraba.Vites = cmb_a_vitestipi.SelectedItem.ToString();
            saraba.YakitTipi = cmb_a_yakıttipi.SelectedItem.ToString();
            saraba.Fiyat = Convert.ToDecimal(txt_a_fiyat.Text);
            saraba.AktifMi = Convert.ToBoolean(txt_aaktifmi.Text);
            saraba.DeleteDate = DateTime.Now;
            saraba.AddDate = updated.AddDate;
            saraba.UpdateDate = updated.UpdateDate;
            db.SilinenArabalars.Add(saraba);
            db.Cars.Remove(deleted);

            db.SaveChanges();

            txt_aaktifmi.Text = string.Empty;
            cmb_a_aractipi.SelectedIndex = -1;
            cmb_a_vitestipi.SelectedIndex = -1;
            cmb_a_yakıttipi.SelectedIndex = -1;
            txt_a_plaka.Text = string.Empty;
            txt_a_marka.Text = default(string);
            txt_a_model.Text = string.Empty;
            txt_a_fiyat.Text = string.Empty;


            CarList();
        }
    }
    }

