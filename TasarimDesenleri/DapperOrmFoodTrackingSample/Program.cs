using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;//Çok kullanılır

namespace DapperOrmFoodTrackingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRUD işlemler (Create,Read,Update,Delete) Select,Insert,Update ve Delete işlemleri
            //Veritabanı (ORM bağlantısı) Dapper ve Microsoft Sql Client ile yapacağız
            //Thirtparty bileşenleri Nuget Paketinden yükleyebiliriz. 

            //dbo.Kullanici tablosundan verileri çekecez.

            #region Dapper Select

            IDbConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = DEVOPS\\DEVOPS; Initial Catalog = FoodTracking; Integrated Security = True";
            connection.Open();


            var sql = "select * from dbo.kullanici";

            var kullaniciListesi = connection.Query<Kullanici>(sql).ToList();
            var kullaniciId = connection.Query<Kullanici>(sql).Where(x => x.id == 2).FirstOrDefault();

            foreach (var item in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adi Soyadi: {0} {1}", item.adi, ' ' + item.soyadi);
            }

            Console.WriteLine("Kullanıcı Count: {0}", kullaniciListesi.Count());
            Console.WriteLine("Kullanıcı Any: {0}", kullaniciListesi.Any());
            Console.WriteLine("Kullanıcı Adi Soyadi: {0} {1}", kullaniciListesi.First().adi, ' ' + kullaniciListesi.First().soyadi);

            #endregion

            #region Dapper Insert

            /*
            var kullanici = new Kullanici { adi = "Yigit2", soyadi = "Eyi2" };

            string insertKullanici = "INSERT INTO dbo.kullanici (adi, soyadi) values (@adi, @soyadi); Select CAST(SCOPE_IDENTITY() as int)";

            int kullaniciid = connection.Query<int>(insertKullanici, kullanici).Single();

            string insertKullanici2 = "INSERT INTO dbo.kullanici (adi, soyadi) values (@adi, @soyadi);";

            var kullaniciid2 = connection.Query(insertKullanici2, kullanici).Single();


            Console.WriteLine("Kullanıcı Insert: {0}", kullaniciid);
            */
            #endregion

            #region Dapper Update



            #endregion

        }
    }
}
