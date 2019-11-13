using RentACarOtomasyonu.ORM.Context;
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
    public partial class SözlesmeWF : Form
    {
        public SözlesmeWF()
        {
            InitializeComponent();
        }
        List<DateTime> list = new List<DateTime>();
        ProjectContext db = new ProjectContext();
        public void KontrolEt()
        {
            List<Kiralama> krl = new List<Kiralama>();
            krl = db.Kiralamas.Where(x => x.AktifMi == true).ToList();

            foreach (Kiralama item in krl)
            {
                DateTime start = new DateTime();
                start = item.AlisTarihi;
                DateTime end = new DateTime();
                end = item.TeslimTarihi;

                var dates = new List<DateTime>();
                for (var dt = start; dt <= end; dt = dt.AddDays(1))
                {
                    dates.Add(dt);

                    list.Add(dt);
                }
            }
        }

        List<DateTime> secilentariharaligi = new List<DateTime>();
        public bool GonderilenKontrol(DateTime AlisTarihi, DateTime TeslimTarihi)
        {

            DateTime start = new DateTime();
            start = AlisTarihi;
            DateTime end = new DateTime();
            end = TeslimTarihi;

            var dates = new List<DateTime>();
            for (var dt = start; dt <= end; dt = dt.AddDays(1))
            {
                dates.Add(dt);

                secilentariharaligi.Add(dt);
            }


            for (int i = 0; i < dates.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (dates[i].ToString() == list[j].ToString())
                    {
                        return false;
                    }
                }
            }

            return true;

        }

        private void btn_s_tamamla_Click(object sender, EventArgs e)
        {

            TimeSpan a = dtp_teslimtarihi.Value - dtp_alimtarihi.Value;
            int saraba;
            saraba = Convert.ToInt32(cmb_s_araba.SelectedValue);


            int b = Convert.ToInt32(a.Days);
            int c = Convert.ToInt32(db.Cars.Where(x => x.ID == saraba).Sum(x => x.Fiyat));
            Kiralama kiralama = new Kiralama();
            kiralama.ArabaID = saraba;

            //kiralama.AlisTarihi = Convert.ToDateTime(dtp_alimtarihi.Value.Date);
            //kiralama.TeslimTarihi = Convert.ToDateTime(dtp_teslimtarihi.Value.Date);
            if (db.Cars.Where(x => x.ID == saraba).ToList() != null)
            {


                List<Kiralama> krl = db.Kiralamas.Where(x => x.AlisTarihi == dtp_alimtarihi.Value.Date && x.TeslimTarihi == dtp_teslimtarihi.Value.Date && x.ArabaID == saraba).ToList();

                if (krl.Count<=0)
                {
                    kiralama.AlisTarihi = Convert.ToDateTime(dtp_alimtarihi.Value.Date);
                    kiralama.TeslimTarihi = Convert.ToDateTime(dtp_teslimtarihi.Value.Date);

                    kiralama.KiralanmaSuresi = Convert.ToInt32(a.Days.ToString());
                    kiralama.FaturaTutari = Convert.ToDecimal((b * c).ToString());
                    kiralama.AddDate = DateTime.Now;
                    kiralama.AktifMi = Convert.ToBoolean(cmb_s_aktifmi.SelectedIndex);
                    db.Kiralamas.Add(kiralama);
                    db.SaveChanges();
                    MessageBox.Show("Sözleşme oluşturuldu");
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz Tarihte Daha önceden Kiralanma yapılmıştır");
                }
            }


            


            cmb_s_aktifmi.SelectedIndex = -1;
            cmb_s_araba.SelectedIndex = -1;

            dtp_alimtarihi.Text = string.Empty;
            dtp_teslimtarihi.Text = string.Empty;
            lbl_sure.Text = string.Empty;
            lbl_tutar.Text = string.Empty;
            SozlesmeList();

        }


        public void SozlesmeList()
        {

            foreach (Kiralama item in db.Kiralamas.ToList())
            {

                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ID.ToString();
                lvi.SubItems.Add(item.ArabaID.ToString());
                lvi.SubItems.Add(item.MusteriID.ToString());
                lvi.SubItems.Add(item.AlisTarihi.ToString());
                lvi.SubItems.Add(item.TeslimTarihi.ToString());
                lvi.SubItems.Add(item.KiralanmaSuresi.ToString());
                lvi.SubItems.Add(item.FaturaTutari.ToString());
                lvi.SubItems.Add(item.AddDate.ToString());
                lvi.SubItems.Add(item.UpdateDate.ToString());
                lvi.SubItems.Add(item.DeleteDate.ToString());
                lvi.SubItems.Add(item.AktifMi.ToString());

                lvi.Tag = item.ID;

            }
        }

        private void SözlesmeWF_Load(object sender, EventArgs e)
        {
            CarList();
            KontrolEt();
            SozlesmeList();
            CenterToScreen();
        }
        public void CarList()
        {
            cmb_s_araba.DisplayMember = "Marka";
            cmb_s_araba.ValueMember = "ID";
            cmb_s_araba.DataSource = db.Cars.Where(x => x.AktifMi == true).ToList();
            cmb_s_araba.SelectedIndex = -1;
        }

        private void cmb_s_araba_SelectedIndexChanged(object sender, EventArgs e)
        {

            int saraba;
            saraba = Convert.ToInt32(cmb_s_araba.SelectedValue);
            dgvw_s_aracbilgi.DataSource = db.Cars.Where(x => x.ID == saraba).ToList();


        }



        private void Dtp_alimtarihi_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslimtarihi.Enabled = true;


        }

        private void Dtp_teslimtarihi_ValueChanged(object sender, EventArgs e)
        {
            int saraba;
            saraba = Convert.ToInt32(cmb_s_araba.SelectedValue);



            TimeSpan a = dtp_teslimtarihi.Value - dtp_alimtarihi.Value;
            lbl_sure.Text = a.Days.ToString();
            int b = Convert.ToInt32(a.Days);

            double arabafiyat = 0;
            List<Arabalar> c = new List<Arabalar>();
            c = db.Cars.Where(x => x.ID == saraba).ToList();

            foreach (Arabalar item in c)
            {
                arabafiyat = Convert.ToDouble(item.Fiyat);
            }
            if (dtp_teslimtarihi.Value < dtp_alimtarihi.Value)
            {
                MessageBox.Show("Teslim Tarihi Alis Tarihinden once olamaz!");
            }
            else
            {
                double hesapla = Convert.ToDouble(lbl_sure.Text) * arabafiyat;
                lbl_tutar.Text = hesapla.ToString();
            }
        }

        private void Btn_scikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_sgstr_Click(object sender, EventArgs e)
        {
            datagvw_sozlesmeblg.DataSource = db.Kiralamas.Where(x => x.AktifMi == true).ToList();
            SozlesmeList();

        }
    }


}


