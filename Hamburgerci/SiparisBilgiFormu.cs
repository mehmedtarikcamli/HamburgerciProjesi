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
    public partial class SiparisBilgiFormu : Form
    {
        public SiparisBilgiFormu()
        {
            InitializeComponent();
        }

        decimal toplam1 = 0;
        decimal toplam2 = 0;

        private void SiparisBilgiFormu_Load(object sender, EventArgs e)
        {
            if (SiparisFormu.TumSiparisler.Count > 0)
            {
                foreach (var item in SiparisFormu.TumSiparisler)
                {
                    lstTumSiparisler.Items.Add(item);
                }
            }

            foreach (var item in SiparisFormu.TumSiparisler)
            {
                toplam1 += item.Hesapla();
            }

            lblCiro.Text = toplam1.ToString();

            lblToplamSiparis.Text = SiparisFormu.TumSiparisler.Count.ToString();


            foreach (var item in SiparisFormu.TumSiparisler)
            {
                foreach (var ekstra in item.EkstraMalzeme)
                {
                    toplam2 += ekstra.Fiyati;
                }
            }

            lblEkstraMalzemeGeliri.Text = Top.ToString();
        }
    }
}
