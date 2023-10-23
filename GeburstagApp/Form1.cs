using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeburstagApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmi_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmi_Ogrenciisleri_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikmi = false;

            for (int i = 0; i < acikFormlar.Length; i++)
            {
                if (acikFormlar[i].GetType() == typeof(OgreciIsleri))
                {
                    acikmi = true;
                    acikFormlar[i].Activate();
                }
            }
            if (acikmi == false)
            {
                OgreciIsleri oi = new OgreciIsleri();
                oi.MdiParent = this;
                oi.WindowState = FormWindowState.Maximized;
                oi.Show();
            }
        }

        private void veliislemleri_TSMI_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikmi = false;

            for (int i = 0; i < acikFormlar.Length; i++)
            {
                if (acikFormlar[i].GetType() == typeof(VeliIslemleri))
                {
                    acikmi = true;
                    acikFormlar[i].Activate();
                }
            }
            if (acikmi == false)
            {
                VeliIslemleri vi = new VeliIslemleri();
                vi.MdiParent = this;
                vi.WindowState = FormWindowState.Maximized;
                vi.Show();
            }
        }
    }
}
