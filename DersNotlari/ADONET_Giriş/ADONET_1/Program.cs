using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection baglanti_Okul_VT = new SqlConnection();//nesne tanımladık
            baglanti_Okul_VT.ConnectionString= @"Server=localhost; Database=Okul_VT; User=sa; Password=1234";
            //SqlCommand komut1 = new SqlCommand(); 
            //komut1.CommandText = "SELECT* FROM Ogretmenler";
            //komut1.Connection = baglanti_Okul_VT;
            //baglanti_Okul_VT.Open();//bağlantıyı gerçekleştiren komut
            //SqlDataReader dataReaderOgretmenler = komut1.ExecuteReader();//komut1 in çıktısını datareader in nesnesine atadık.
            //while (dataReaderOgretmenler.Read())
            //{
            //    string OgretmenID = dataReaderOgretmenler[0].ToString();
            //    //string OgretmenAdi = dataReaderOgretmenler[1].ToString();//alt satı ile aynı işlemi yapar
            //    string OgretmenAdi = dataReaderOgretmenler["OgretmenAdi"].ToString();
            //    Console.WriteLine($"Öğretmen ID'si: {OgretmenID}\n Öğretmen Adı: {OgretmenAdi}");
            //}
            //baglanti_Okul_VT.Close();

            {
                string OgretmenAdi2 = "Hasan Koyuncu";
                SqlCommand KomutInsert = new SqlCommand();
                KomutInsert.CommandText = $"INSERT INTO Ogretmenler VALUES('{OgretmenAdi2}',0)";
                KomutInsert.Connection = baglanti_Okul_VT;
                baglanti_Okul_VT.Open();
                KomutInsert.ExecuteNonQuery();
                baglanti_Okul_VT.Close();
            }
            
            Console.ReadKey();
        }
    }
}
