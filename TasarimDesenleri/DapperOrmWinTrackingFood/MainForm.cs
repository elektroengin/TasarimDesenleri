using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DapperOrmWinTrackingFood
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Connection : Veritabanındaki veriler ile çalışabilmek için ilk adım ve Connection paramtreleri ile bağlanıyoruz
        //Database name veya Datasource -> Bağlantının kurulması için gerekli olan parametre
        //Credentials - SQL Kimlik bilgileri gerekiyor username/password bilgisi
        //CRUD işlemleri : Create,Read,Update ve Delete işlemleri
        //Veritabanından verileri çekme, Veritabanına kayıt ekleme, Veritabanında kaydı güncelleme ve veritabanında kaydı silme
        //SqlCommand komutu: kullanıcının veritabanı sorgulamasına ve komutları veritabanına gönderilmesine izin verir.
        //Sorgucu sonuçları için: ExecuteReader yönetimi ve insert,update ve delete için ExecuteNonQuery iki yöntem kullanıyoruz.

        private void btnConn_Click(object sender, EventArgs e)
        {
            //Değişkenleri tanımladık
            string connectionString = string.Empty;
            SqlConnection conn;

            try
            {
                //Bağlantıyı set ettik
                connectionString = "Data Source = DEVOPS\\DEVOPS; Initial Catalog = FoodTracking; Integrated Security = True";
                //Connection Assign yaptık
                conn = new SqlConnection(connectionString);
                //Connection Open
                conn.Open();
                MessageBox.Show("Bağlantı Kuruldu");

                //Connection Close
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Empty;
            SqlConnection conn;
            SqlCommand command;
            SqlDataReader dataReader;
            string sql, output = string.Empty;
            lKullanici.Items.Clear();

            try
            {
                connectionString = "Data Source = DEVOPS\\DEVOPS; Initial Catalog = FoodTracking; Integrated Security = True";
                conn = new SqlConnection(connectionString);
                conn.Open();

                sql = "select id,adi,soyadi from dbo.kullanici";
                command = new SqlCommand(sql, conn); //C# içerisinde tanımlanmış bir sınıftır. veritabanına okuma yazma sileme güncelleme için kullanılır.
                dataReader = command.ExecuteReader(); //Sql sorgusu tarafından belirtilen tüm verileri çekmek için kullanılır.

                while (dataReader.Read())
                {
                    lKullanici.Items.Add(dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "-" + dataReader.GetValue(2));
                    //output = output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "\n";
                }

                //MessageBox.Show(output);

                //Tüm objeleri kapadım
                dataReader.Close();
                command.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            string connectionString = string.Empty;
            SqlConnection conn;
            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string sql, output = string.Empty;
            lKullanici.Items.Clear();

            try
            {
                connectionString = "Data Source = DEVOPS\\DEVOPS; Initial Catalog = FoodTracking; Integrated Security = True";
                conn = new SqlConnection(connectionString);
                conn.Open();

                sql = "INSERT INTO dbo.kullanici (adi, soyadi) values ('" + tAd.Text + "', '" + tSoyad.Text + "');";
                command = new SqlCommand(sql, conn); //C# içerisinde tanımlanmış bir sınıftır. veritabanına okuma yazma sileme güncelleme için kullanılır.

                dataAdapter.InsertCommand = new SqlCommand(sql, conn);
                dataAdapter.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Kullanıcı Kaydedildi.");

                //Tüm objeleri kapadım                
                command.Dispose();
                conn.Close();

                tAd.Clear();
                tSoyad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = string.Empty;
            SqlConnection conn;
            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string sql, output = string.Empty;
            lKullanici.Items.Clear();

            try
            {
                connectionString = "Data Source = DEVOPS\\DEVOPS; Initial Catalog = FoodTracking; Integrated Security = True";
                conn = new SqlConnection(connectionString);
                conn.Open();

                sql = "update dbo.kullanici set adi = '" + tUAdi.Text + "', soyadi = '" + tUSoyad.Text + "' where Id = '" + TId.Text + "'";
                command = new SqlCommand(sql, conn); //C# içerisinde tanımlanmış bir sınıftır. veritabanına okuma yazma sileme güncelleme için kullanılır.

                dataAdapter.UpdateCommand = new SqlCommand(sql, conn);
                dataAdapter.UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Kullanıcı Güncellendi.");

                //Tüm objeleri kapadım                
                command.Dispose();
                conn.Close();

                tUAdi.Clear();
                tUSoyad.Clear();
                TId.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = string.Empty;
            SqlConnection conn;
            SqlCommand command;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string sql, output = string.Empty;
            lKullanici.Items.Clear();

            try
            {
                connectionString = "Data Source = DEVOPS\\DEVOPS; Initial Catalog = FoodTracking; Integrated Security = True";
                conn = new SqlConnection(connectionString);
                conn.Open();

                sql = "delete from dbo.kullanici  where Id = '" + tDId.Text + "'";
                command = new SqlCommand(sql, conn); //C# içerisinde tanımlanmış bir sınıftır. veritabanına okuma yazma sileme güncelleme için kullanılır.

                dataAdapter.DeleteCommand = new SqlCommand(sql, conn);
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                MessageBox.Show("Kullanıcı Silindi.");

                //Tüm objeleri kapadım                
                command.Dispose();
                conn.Close();

                tDId.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
