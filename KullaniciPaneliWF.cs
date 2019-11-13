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
    public partial class KullaniciPaneliWF : Form
    {
        public KullaniciPaneliWF()
        {
            InitializeComponent();
        }

        private void Btn_admnmusteri_Click(object sender, EventArgs e)
        {
            Form1 admm = new Form1();
            admm.Show();
        }

        private void Btn_admnaraba_Click(object sender, EventArgs e)
        {
            ArabaWF admna = new ArabaWF();
            admna.Show();
        }

        private void Btn_admnszlesm_Click(object sender, EventArgs e)
        {
            SözlesmeWF admns = new SözlesmeWF();
            admns.Show();
        }

        private void KullaniciPaneliWF_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
