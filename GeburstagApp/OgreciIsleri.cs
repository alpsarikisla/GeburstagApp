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
        int ogrenciid;
        public OgreciIsleri()
        {
            InitializeComponent();
            GridDoldur();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
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
                MessageBox.Show("Öğrenci Ekleme Başarılı", "Başarılı");
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
            dgv_Ogrenciler.Rows.Clear();
            dgv_Ogrenciler.ColumnCount = 4;
            dgv_Ogrenciler.Columns[0].Name = "Okul No";
            dgv_Ogrenciler.Columns[0].Width = 150;
            dgv_Ogrenciler.Columns[1].Name = "Öğrenci İsim";
            dgv_Ogrenciler.Columns[1].Width = 150;
            dgv_Ogrenciler.Columns[2].Name = "Öğrenci Soyisim";
            dgv_Ogrenciler.Columns[2].Width = 150;
            dgv_Ogrenciler.Columns[3].Name = "Öğrenci Doğum Tarihi";
            dgv_Ogrenciler.Columns[3].Width = 150;

            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
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

        private void TSMI_Guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandText = "SELECT OkulNo, Isim, Soyisim, DogumTarihi FROM Ogrenciler WHERE OkulNo=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", ogrenciid);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string okulno = reader.GetString(0);
                    string isim = reader.GetString(1);
                    string soyisim = reader.GetString(2);
                    DateTime dogumtarihi = reader.GetDateTime(3);
                    tb_isim.Text = isim;
                    tb_soyisim.Text = soyisim;
                    tb_okulNo.Text = okulno;
                    dtp_dogumTarihi.Value = dogumtarihi;
                }
                btn_Ekle.Visible = false;
                btn_guncelle.Visible = true;
                btn_iptal.Visible = true;
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

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT COUNT(*) FROM Veliler WHERE Ogrenci_ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", ogrenciid);
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    if (MessageBox.Show($"öğrenci ve kayıtlı {count} veli bilgisi silinecek. Onaylıyor musunuz?", "Onay Gerekiyor", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        cmd.CommandText = "DELETE FROM Veliler WHERE Ogrenci_ID=@id";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", ogrenciid);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "DELETE FROM Ogrenciler WHERE OkulNo=@id";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", ogrenciid);
                        cmd.ExecuteNonQuery();
                        GridDoldur();
                        MessageBox.Show("Öğrenci silme işlemi başarılı", "Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemini iptal edildi", "Bilgi");
                    }
                }
                else
                {
                    if (MessageBox.Show("öğrenci bilgisi silinecek. Onaylıyor musunuz?", "Onay Gerekiyor", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        cmd.CommandText = "DELETE FROM Ogrenciler WHERE OkulNo=@id";
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@id", ogrenciid);
                        cmd.ExecuteNonQuery();
                        GridDoldur();
                        MessageBox.Show("Öğrenci silme işlemi başarılı", "Başarılı");
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemini iptal edildi", "Bilgi");
                    }
                }
              
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Oluştu", "Başarısız");
            }
            finally
            {
                con.Close();
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
                ogrenciid = Convert.ToInt32(dgv_Ogrenciler.Rows[currentMouseOverRow].Cells[0].Value);
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();

            string isim = tb_isim.Text;
            string soyisim = tb_soyisim.Text;
            string okulno = tb_okulNo.Text;
            DateTime DogumTarihi = dtp_dogumTarihi.Value;

            try
            {
                cmd.CommandText = "UPDATE Ogrenciler SET Isim=@isim, soyisim=@soyisim, DogumTarihi=@dogumtarihi  WHERE OkulNo=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", ogrenciid);
                cmd.Parameters.AddWithValue("@isim", isim);
                cmd.Parameters.AddWithValue("@soyisim", soyisim);
                cmd.Parameters.AddWithValue("@dogumtarihi", DogumTarihi);
                con.Open();
                cmd.ExecuteNonQuery();
                GridDoldur();
                tb_isim.Text = tb_okulNo.Text = tb_soyisim.Text = "";
                dtp_dogumTarihi.Value = DateTime.Now;
                btn_Ekle.Visible = true;
                btn_guncelle.Visible = false;
                btn_iptal.Visible = false;
                MessageBox.Show("Öğrenci Güncelleme Başarılı", "Başarılı");
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
            btn_Ekle.Visible = true;
            btn_guncelle.Visible = false;
            btn_iptal.Visible = false;
        }
    }
}
