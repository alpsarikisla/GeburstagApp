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
        public VeliIslemleri()
        {
            InitializeComponent();
            GridDoldur();
        }
        private void GridDoldur()
        {
            dgv_Ogrenciler.ColumnCount = 8;
            dgv_Ogrenciler.Columns[0].Name = "Okul No";
            dgv_Ogrenciler.Columns[1].Name = "Öğrenci İsim";
            dgv_Ogrenciler.Columns[2].Name = "Öğrenci Soyisim";
            dgv_Ogrenciler.Columns[3].Name = "Öğrenci Doğum Tarihi";
            dgv_Ogrenciler.Columns[4].Name = "Veli İsim";
            dgv_Ogrenciler.Columns[5].Name = "Veli Soyisim";
            dgv_Ogrenciler.Columns[6].Name = "Yakınlık Derecesi";
            dgv_Ogrenciler.Columns[7].Name = "Doğum Tarihi";

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=Geburstag_DB;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT O.*, V.Isim, V.Soyisim,V.YakinlikDerecesi, V.DogumTarihi FROM Veliler AS V JOIN Ogrenciler AS O ON V.Ogrenci_ID = O.OkulNo";
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
                row.Add(reader.GetString(4));
                row.Add(reader.GetString(5));
                row.Add(reader.GetString(6));
                row.Add(reader.GetDateTime(7).ToShortDateString());
                dgv_Ogrenciler.Rows.Add(row.ToArray());
            }
         
         

        }
    }
}
