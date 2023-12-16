using Hamburgerci.Enumlar;
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
    public partial class MenuEklemeFormu : Form
    {
        public MenuEklemeFormu()
        {
        }

        public MenuEklemeFormu(AnaForm anaForm)
        {
            InitializeComponent();
        }
        
        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            SiparisFormu.Menuler.Add(new Menu { MenuAdi = txtMenuAd.Text, MenuFiyati = nudMenuFiyat.Value });

            MessageBox.Show("Menü eklendi.");
        }
    }
}
