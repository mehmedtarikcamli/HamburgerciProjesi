using Hamburgerci.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci
{
    public partial class EkstraEklemeFormu : Form
    {
        public EkstraEklemeFormu()
        {
        }

        public EkstraEklemeFormu(AnaForm anaForm)
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeKaydet_Click(object sender, EventArgs e)
        {
            SiparisFormu.Ekstralar.Add(new Ekstra { Adi = txtEkstraMalzemeAd.Text, Fiyati = nudEkstraMalzemeFiyat.Value });
            MessageBox.Show("Ekstra malzeme eklendi.");
        }
    }
}
