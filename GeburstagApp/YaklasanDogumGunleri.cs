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
    public partial class YaklasanDogumGunleri : Form
    {
        public YaklasanDogumGunleri()
        {
            InitializeComponent();
        }

        private void YaklasanDogumGunleri_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToShortDateString();
            GridDoldur();
        }
        private void GridDoldur()
        {
            dgv_yaklasanDogumGunleri.Rows.Clear();
            dgv_yaklasanDogumGunleri.ColumnCount = 6;
            dgv_yaklasanDogumGunleri.Columns[0].Name = "ID";
            dgv_yaklasanDogumGunleri.Columns[1].Name = "İsim";
            dgv_yaklasanDogumGunleri.Columns[2].Name = "Soyisim";
            dgv_yaklasanDogumGunleri.Columns[3].Name = "Doğum Tarihi";
            dgv_yaklasanDogumGunleri.Columns[4].Name = "Yakınlık Derecesi";
            dgv_yaklasanDogumGunleri.Columns[5].Name = "Öğrenci İsim Soyisim";


            SqlConnection con = new SqlConnection(@"Data Source=mssql01.trwww.com;Initial Catalog=veksisbu_GeburstagDB;Persist Security Info=True;User ID=gebAdmn;Password=?Nc)4i5n??*");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "DECLARE @InNextDays INT; SET @InNextDays = 3; SELECT  V.ID,V.Isim, V.Soyisim, V.DogumTarihi, V.YakinlikDerecesi, O.Isim +' '+ O.Soyisim FROM Veliler AS V JOIN Ogrenciler AS O ON V.Ogrenci_ID = O.OkulNo WHERE DATEADD( Year, DATEPART( Year, GETDATE()) - DATEPART( Year, V.DogumTarihi), V.DogumTarihi) BETWEEN CONVERT( DATE, GETDATE()) AND CONVERT( DATE, GETDATE() + @InNextDays);";
            cmd.Parameters.Clear();
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ArrayList row = new ArrayList();
                row.Add(reader.GetInt32(0));

                row.Add(reader.GetString(1));
                dgv_yaklasanDogumGunleri.Columns[1].Width = 150;

                row.Add(reader.GetString(2));
                dgv_yaklasanDogumGunleri.Columns[2].Width = 150;

                row.Add(reader.GetDateTime(3).ToShortDateString());
                dgv_yaklasanDogumGunleri.Columns[3].Width = 150;

                row.Add(reader.GetString(4));
                dgv_yaklasanDogumGunleri.Columns[4].Width = 150;

                row.Add(reader.GetString(5));
                dgv_yaklasanDogumGunleri.Columns[5].Width = 150;

                dgv_yaklasanDogumGunleri.Rows.Add(row.ToArray());
            }
        }
    }
}
