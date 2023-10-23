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
    public partial class OgreciIsleri : Form
    {
        public OgreciIsleri()
        {
            InitializeComponent();
            GridDoldur();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Geburstag_DB;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();

            string ogrenciAdi = tb_isim.Text;
            string ogrenciSoyadi = tb_soyisim.Text;
            string okulNo = tb_okulNo.Text;
            DateTime DogumTarihi = dtp_dogumTarihi.Value;

           try
            {
                cmd.CommandText = "INSERT INTO Ogrenciler(OkulNo, Isim, Soyisim, DogumTarihi) VALUES(@okulno,@isim,@soyisim,@dogumtarih)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@okulno", okulNo);
                cmd.Parameters.AddWithValue("@isim", ogrenciAdi);
                cmd.Parameters.AddWithValue("@soyisim", ogrenciSoyadi);
                cmd.Parameters.AddWithValue("@dogumtarih", DogumTarihi);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Ekleme Başarılı","Başarılı");
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu", "Başarısız");
            }
            finally
            {
                con.Close();
            }
            GridDoldur();
        }
        private void GridDoldur()
        {
            dgv_Ogrenciler.ColumnCount = 4;
            dgv_Ogrenciler.Columns[0].Name = "Okul No";
            dgv_Ogrenciler.Columns[0].Width = 150;
            dgv_Ogrenciler.Columns[1].Name = "Öğrenci İsim";
            dgv_Ogrenciler.Columns[1].Width = 150;
            dgv_Ogrenciler.Columns[2].Name = "Öğrenci Soyisim";
            dgv_Ogrenciler.Columns[2].Width = 150;
            dgv_Ogrenciler.Columns[3].Name = "Öğrenci Doğum Tarihi";
            dgv_Ogrenciler.Columns[3].Width = 150;

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Geburstag_DB;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT * FROM Ogrenciler";
            cmd.Parameters.Clear();
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ArrayList row = new ArrayList();
                row.Add(reader.GetString(0));
                row.Add(reader.GetString(1));
                row.Add(reader.GetString(2));
                row.Add(reader.GetDateTime(3).ToShortDateString());
                dgv_Ogrenciler.Rows.Add(row.ToArray());
            }
            DataGridViewButtonColumn dgvbc = new DataGridViewButtonColumn();
            dgvbc.HeaderText = "Veli Ekle";
            dgvbc.Text = "Veli Ekle";
            dgvbc.UseColumnTextForButtonValue = true;
            dgv_Ogrenciler.Columns.Add(dgvbc);
        }
        private void dgv_Ogrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                VeliEkle frm = new VeliEkle(dgv_Ogrenciler.Rows[e.RowIndex].Cells[0].Value.ToString());
                frm.ShowDialog();
            }
        }
    }
}
