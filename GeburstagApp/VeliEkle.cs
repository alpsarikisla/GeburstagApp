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
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Geburstag_DB;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();

            string VeliAdi = tb_isim.Text;
            string VeliSoyadi = tb_soyisim.Text;
            string VeliYakinlik = tb_yakinlik.Text;
            DateTime DogumTarihi = dtp_dogumTarihi.Value;

            try
            {
                cmd.CommandText = "INSERT INTO Veliler(YakinlikDerecesi, Isim, Soyisim, DogumTarihi, Ogrenci_ID) VALUES(@yakinlik, @isim, @soyisim, @dogumtarih, @ogrenciid)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@yakinlik", VeliYakinlik);
                cmd.Parameters.AddWithValue("@isim", VeliAdi);
                cmd.Parameters.AddWithValue("@soyisim", VeliSoyadi);
                cmd.Parameters.AddWithValue("@dogumtarih", DogumTarihi);
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
