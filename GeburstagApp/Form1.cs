using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
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
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {

                }
            }
            catch
            {
                MessageBox.Show("İnternet Bağlantınızı Kontrol Ediniz", "İnternet Bağlantısı yok");
                this.Close();
            }
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
                    acikFormlar[i].Close();
                    VeliIslemleri vi = new VeliIslemleri();
                    vi.MdiParent = this;
                    vi.WindowState = FormWindowState.Maximized;
                    vi.Show();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();

            //cmd.CommandText = "DECLARE @InNextDays INT; SET @InNextDays = 3; SELECT  V.ID,V.Isim, V.Soyisim, V.DogumTarihi, V.YakinlikDerecesi, O.Isim +' '+ O.Soyisim FROM Veliler AS V JOIN Ogrenciler AS O ON V.Ogrenci_ID = O.OkulNo WHERE DATEADD( Year, DATEPART( Year, GETDATE()) - DATEPART( Year, V.DogumTarihi), V.DogumTarihi) BETWEEN CONVERT( DATE, GETDATE()) AND CONVERT( DATE, GETDATE() + @InNextDays);";
            cmd.CommandText = "DECLARE @InNextDays INT; SET @InNextDays = 3; SELECT COUNT(*) FROM Veliler AS V JOIN Ogrenciler AS O ON V.Ogrenci_ID = O.OkulNo WHERE DATEADD( Year, DATEPART( Year, GETDATE()) - DATEPART( Year, V.DogumTarihi), V.DogumTarihi) BETWEEN CONVERT( DATE, GETDATE()) AND CONVERT( DATE, GETDATE() + @InNextDays);";
            cmd.Parameters.Clear();
            con.Open();
            int sayi = Convert.ToInt32(cmd.ExecuteScalar());
            toolStripStatusLabel1.Text = "Doğum günü yaklaşan veli sayısı = " + sayi;
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikmi = false;

            for (int i = 0; i < acikFormlar.Length; i++)
            {
                if (acikFormlar[i].GetType() == typeof(Hakkimizda))
                {
                    acikmi = true;
                    acikFormlar[i].Activate();
                }
            }
            if (acikmi == false)
            {
                Hakkimizda oi = new Hakkimizda();
                oi.MdiParent = this;
                oi.WindowState = FormWindowState.Maximized;
                oi.Show();
            }
        }

        private void Takip_TSMI_Click(object sender, EventArgs e)
        {
            Form[] acikFormlar = this.MdiChildren;
            bool acikmi = false;

            for (int i = 0; i < acikFormlar.Length; i++)
            {
                if (acikFormlar[i].GetType() == typeof(YaklasanDogumGunleri))
                {
                    acikmi = true;
                    acikFormlar[i].Activate();
                }
            }
            if (acikmi == false)
            {
                YaklasanDogumGunleri oi = new YaklasanDogumGunleri();
                oi.MdiParent = this;
                oi.WindowState = FormWindowState.Maximized;
                oi.Show();
            }
        }
    }
}
