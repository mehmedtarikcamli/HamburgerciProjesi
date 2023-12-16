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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        public void FormGoster(Form acilacakForm)
        {
            acilacakForm.StartPosition = 0;
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == acilacakForm.Text)
                {
                    durum = true;
                    form.Show();
                }
                else
                    form.Close();
            }
            if (!durum)
            {
                acilacakForm.MdiParent = this;
                acilacakForm.Show();
            }
        }

        private void siparisOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisFormu());
        }

        private void siparisBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new SiparisBilgiFormu());
        }

        private void menuEkleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormGoster(new MenuEklemeFormu(this));
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGoster(new EkstraEklemeFormu(this));
        }
    }
}
