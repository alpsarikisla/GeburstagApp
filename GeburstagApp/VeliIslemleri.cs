using System;
using System.Collections;
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
    public partial class VeliIslemleri : Form
    {
        int veliid;
        public VeliIslemleri()
        {
            InitializeComponent();
            GridDoldur();
            groupBox1.Enabled = false;
        }
        private void GridDoldur()
        {
            dgv_Ogrenciler.Rows.Clear();
            dgv_Ogrenciler.ColumnCount = 7;
            dgv_Ogrenciler.Columns[0].Name = "ID";
            dgv_Ogrenciler.Columns[1].Name = "İsim";
            dgv_Ogrenciler.Columns[2].Name = "Soyisim";
            dgv_Ogrenciler.Columns[3].Name = "Doğum Tarihi";
            dgv_Ogrenciler.Columns[4].Name = "Yakınlık Derecesi";
            dgv_Ogrenciler.Columns[5].Name = "Öğrenci İsim Soyisim";
            dgv_Ogrenciler.Columns[6].Name = "Cep Telefonu";


            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT V.ID,V.Isim, V.Soyisim, V.DogumTarihi, V.YakinlikDerecesi, O.Isim +' '+ O.Soyisim, V.GSM FROM Veliler AS V JOIN Ogrenciler AS O ON V.Ogrenci_ID = O.OkulNo";
            cmd.Parameters.Clear();
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ArrayList row = new ArrayList();
                row.Add(reader.GetInt32(0));

                row.Add(reader.GetString(1));
                dgv_Ogrenciler.Columns[1].Width = 150;

                row.Add(reader.GetString(2));
                dgv_Ogrenciler.Columns[2].Width = 150;

                row.Add(reader.GetDateTime(3).ToShortDateString());
                dgv_Ogrenciler.Columns[3].Width = 150;

                row.Add(reader.GetString(4));
                dgv_Ogrenciler.Columns[4].Width = 150;

                row.Add(reader.GetString(5));
                dgv_Ogrenciler.Columns[5].Width = 150;

                row.Add(reader.GetString(6));
                dgv_Ogrenciler.Columns[6].Width = 150;

                dgv_Ogrenciler.Rows.Add(row.ToArray());
            }
        }

        private void dgv_Ogrenciler_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgv_Ogrenciler.HitTest(e.X, e.Y).RowIndex;
                contextMenuStrip1.Show(dgv_Ogrenciler, new Point(e.X, e.Y));
                dgv_Ogrenciler.ClearSelection();
                dgv_Ogrenciler.Rows[currentMouseOverRow].Selected = true;
                veliid = Convert.ToInt32(dgv_Ogrenciler.Rows[currentMouseOverRow].Cells[0].Value);
            }
        }

        private void Duzenle_TSMI_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT ID, Isim, Soyisim, YakinlikDerecesi, DogumTarihi,GSM FROM Veliler WHERE ID=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", veliid);
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string isim = reader.GetString(1);
                string soyisim = reader.GetString(2);
                string yakinlik = reader.GetString(3);
                DateTime dogumtarihi = reader.GetDateTime(4);
                string GSM = reader.GetString(5);
                tb_isim.Text = isim;
                tb_soyisim.Text = soyisim;
                tb_okulNo.Text = yakinlik;
                dtp_dogumTarihi.Value = dogumtarihi;
                mtb_GSM.Text = GSM;
            }
            groupBox1.Enabled = true;
        }

        private void Sil_TSMI_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Veliler WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", veliid);
                con.Open();
                cmd.ExecuteNonQuery();
                GridDoldur();
                MessageBox.Show("Veli silme işlemi başarılı", "Başarılı");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu", "Başarısız");
            }
            finally
            {
                con.Close();
            }
        }
        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();

            string VeliAdi = tb_isim.Text;
            string VeliSoyadi = tb_soyisim.Text;
            string VeliYakinlik = tb_okulNo.Text;
            DateTime DogumTarihi = dtp_dogumTarihi.Value;
            string Gsm = mtb_GSM.Text;
            try
            {
                cmd.CommandText = "UPDATE Veliler SET YakinlikDerecesi =@yakinlik, Isim=@isim, Soyisim=@soyisim, DogumTarihi=@dogumtarih, GSM=@gsm WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", veliid);
                cmd.Parameters.AddWithValue("@yakinlik", VeliYakinlik);
                cmd.Parameters.AddWithValue("@isim", VeliAdi);
                cmd.Parameters.AddWithValue("@soyisim", VeliSoyadi);
                cmd.Parameters.AddWithValue("@dogumtarih", DogumTarihi);
                cmd.Parameters.AddWithValue("@gsm", Gsm);
                con.Open();
                cmd.ExecuteNonQuery();
                GridDoldur();
                tb_isim.Text = tb_okulNo.Text = tb_soyisim.Text = "";
                dtp_dogumTarihi.Value = DateTime.Now;
                groupBox1.Enabled = false;
                MessageBox.Show("Veli Güncelleme Başarılı", "Başarılı");
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

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            tb_isim.Text = tb_okulNo.Text = tb_soyisim.Text = "";
            dtp_dogumTarihi.Value = DateTime.Now;
            groupBox1.Enabled = false;
        }
    }
}
