using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelSqls
{
    class Personel
    {
        int PersonelID;
        string PersonelAdi;
        string PersonelSoyadi;
        DateTime PersonelIBT = DateTime.Now;
        bool AktifCalisan;

        public void PersonelEkle()
        {
            Console.Write("Personel Adı Giriniz:");
            PersonelAdi = Console.ReadLine();
            Console.Write("Personel Soyadı Giriniz:");
            PersonelSoyadi = Console.ReadLine();
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = "Server=localhost; Database=PersonelSql; user=sa; Password=1234";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = $"INSERT INTO PersonelTable VALUES('{PersonelAdi}', '{PersonelSoyadi}', getdate(), 1)";
            komut.Connection = Baglanti;
            Baglanti.Open();
            komut.ExecuteNonQuery();
            Baglanti.Close();
        }
        public void PersonelDuzenle(int id)
        {
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = "Server=localhost; Database=PersonelSql; user=sa; Password=1234";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = $"SELECT * FROM PersonelTable where PersonelID={id}";
            komut.Connection = Baglanti;
            Baglanti.Open();
            SqlDataReader table = komut.ExecuteReader();
            while (table.Read())
            {
                Console.WriteLine($"Güncellenecek kişi verileri: {table[1]} {table[2]} doğru mu? E/H");

            }
            komut.ExecuteNonQuery();
            Baglanti.Close();
            Console.Write("Personel Adı Giriniz:");
            PersonelAdi = Console.ReadLine();
            Console.Write("Personel Soyadı Giriniz:");
            PersonelSoyadi = Console.ReadLine();
        }

        public void PersonelSil()
        {

        }

        public void PersonelListele()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.PersonelDuzenle(1);
            Console.ReadKey();

        }
    }
}
