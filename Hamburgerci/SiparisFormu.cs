using Hamburgerci.Enumlar;
using Hamburgerci.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Hamburgerci
{
    public partial class SiparisFormu : Form
    {
        public SiparisFormu()
        {
            InitializeComponent();
            if (cboMenuSec.SelectedIndex == -1)
            { cboMenuSec.Text = "BİR MENÜ SEÇİNİZ."; }
            lstMevcutSiparisler.Items.AddRange(MevcutSiparisler.ToArray());
        }

        decimal toplam = 0;

        public static List<Siparis> TumSiparisler = new List<Siparis>();
        public static List<Siparis> MevcutSiparisler = new List<Siparis>();

        public static List<Menu> Menuler = new List<Menu>()
        {
            new Menu{MenuAdi = "Big King", MenuFiyati = 60.00M},
            new Menu{MenuAdi = "Double King Chicken",MenuFiyati = 45.50M},
            new Menu{MenuAdi = "Chicken Royal", MenuFiyati = 30.50M},
            new Menu{MenuAdi = "Steakhouse",MenuFiyati = 60.75M},
            new Menu{MenuAdi = "Whooper",MenuFiyati = 45.00M},
            new Menu{MenuAdi = "Whooper Jr.",MenuFiyati = 50.00M}
        };

        public static List<Ekstra> Ekstralar = new List<Ekstra>()
        {
            new Ekstra{Adi = "Ketçap",Fiyati = 2.00M },
            new Ekstra{Adi ="Mayonez",Fiyati = 2.00M},
            new Ekstra{Adi ="Hardal",Fiyati = 2.50M},
            new Ekstra{Adi ="BBQ", Fiyati = 2.50M},
            new Ekstra{Adi ="Ranch",Fiyati = 2.50M},
            new Ekstra{Adi ="Buffalo",Fiyati = 2.50M}
        };

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.SecilenMenu = (Menu)cboMenuSec.SelectedItem;

            string secilenMenu = cboMenuSec.SelectedItem.ToString();

            if (siparis.SecilenMenu == null)
            {
                MessageBox.Show("Lütfen bir menü seçiniz.");
                return;
            }
            if (rdbKucuk.Checked)
            {
                siparis.Boyut = Boyut.Kucuk;
            }
            else if (rdbOrta.Checked)
            {
                siparis.Boyut = Boyut.Kucuk;
            }
            else if (rdbBuyuk.Checked)
            {
                siparis.Boyut = Boyut.Orta;
            }

            if (!(rdbKucuk.Checked || rdbOrta.Checked || rdbBuyuk.Checked))
            {
                MessageBox.Show("Lütfen bir boyut seçiniz.");
                return;
            }

            siparis.Adet = (int)nudAdet.Value;

            if (siparis.Adet == 0)
            {
                MessageBox.Show("Lütfen adet seçiniz.");
                return;
            }

            siparis.EkstraMalzeme = new List<Ekstra>();

            foreach (CheckBox item in flpEkstraMalzemeler.Controls)
            {
               if(item.Checked)
                {
                    siparis.EkstraMalzeme.Add((Ekstra)item.Tag);
                }
            }

            if ((rdbKucuk.Checked || rdbOrta.Checked || rdbBuyuk.Checked) && cboMenuSec.SelectedIndex != -1 && siparis.Adet > 0)
            {
                MevcutSiparisler.Add(siparis);
                TumSiparisler.Add(siparis);
                SiparisleriListele();

                siparis.ToplamTutar = siparis.Hesapla();
                toplam += siparis.Hesapla();
                lblToplam.Text = "₺" + toplam.ToString();
            }
        }

        private void SiparisleriListele()
        {
            lstMevcutSiparisler.Items.Clear();
            foreach (var item in MevcutSiparisler)
            {
                lstMevcutSiparisler.Items.Add(item);
            }
        }

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            lstMevcutSiparisler.Items.Clear();
            MevcutSiparisler.Clear();
            lblToplam.Text = "₺ 0.00";
            toplam = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstMevcutSiparisler.SelectedItem != null)
            {
                Siparis silinecekOlanSiparis = (Siparis)lstMevcutSiparisler.SelectedItem;
                MevcutSiparisler.Remove(silinecekOlanSiparis);
                SiparisleriListele();
                toplam = toplam - silinecekOlanSiparis.Hesapla();
                lblToplam.Text = "₺" + toplam.ToString();
                TumSiparisler.Remove(silinecekOlanSiparis);
            }
        }

        private void SiparisFormu_Load(object sender, EventArgs e)
        {
            foreach (var item in Menuler)
            {
                cboMenuSec.Items.Add(item);
            }
            foreach (Sınıflar.Ekstra ekstra in Ekstralar)
            {
                int sayac = 0;
                int x = 42;
                flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = ekstra.Adi, Tag = ekstra, Location = new Point(x, 421) });
                x += 114;
                sayac++;
                if (sayac > 3)
                {
                    flpEkstraMalzemeler.Controls.Add(new CheckBox() { Text = ekstra.Adi, Tag = ekstra, Location = new Point(x, 440) });
                    x += 114;
                }

            }
            foreach (var item in MevcutSiparisler)
            {
                toplam += item.Hesapla();
            }

            lblToplam.Text = "₺" + toplam.ToString();
        }
    }
}
