using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeburstagApp
{
    public partial class VeliEkle : Form
    {
        private string ogrenciID;
        public VeliEkle(string id)
        {
            ogrenciID = id;
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();

            string VeliAdi = tb_isim.Text;
            string VeliSoyadi = tb_soyisim.Text;
            string VeliYakinlik = tb_yakinlik.Text;
            string GSM = mtb_GSM.Text;
            DateTime DogumTarihi = dtp_dogumTarihi.Value;

            try
            {
                cmd.CommandText = "INSERT INTO Veliler(YakinlikDerecesi, Isim, Soyisim, DogumTarihi, Ogrenci_ID, GSM) VALUES(@yakinlik, @isim, @soyisim, @dogumtarih, @ogrenciid, @gsm)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@yakinlik", VeliYakinlik);
                cmd.Parameters.AddWithValue("@isim", VeliAdi);
                cmd.Parameters.AddWithValue("@soyisim", VeliSoyadi);
                cmd.Parameters.AddWithValue("@dogumtarih", DogumTarihi);
                cmd.Parameters.AddWithValue("@gsm", GSM);
                cmd.Parameters.AddWithValue("@ogrenciid", ogrenciID);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Veli Ekleme Başarılı", "Başarılı");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu", "Başarısız");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
