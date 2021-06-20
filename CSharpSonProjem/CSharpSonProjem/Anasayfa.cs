using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices; //gerekli kütüphanemizi ekledik.

namespace CSharpSonProjem
{

    public partial class Anasayfa : Form
    {

        static int kayitSayisi1, kayitSayisi2; //kaç satır bilgi olduğunu tutacak int değişkenin tanımlanması.
        int tutucu1, tutucu2; //Ekranda o sırada yazan bilginin kaçid li bilgi olduğunu tutacaktır.
        int[] idTutucu1, idTutucu2;

        List<int> ogrenilenSayilar1 = new List<int>(); //int veri tipini tutan ogrenilenSayilar Liste yapısının oluşturulması.
        List<int> ogrenilenSayilar2 = new List<int>();

        public Anasayfa()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            BilgiKutum.Visible = false;
            Ögrendim.Visible = false;

        }

        private Sql sql = new Sql();
        private int rastgeleSayiUret1() //genel bilgilerden rastgele bilgiid seçip döndürem metot.
        {
            SqlConnection baglan1 = new SqlConnection(@"Data Source=DESKTOP-GE4SKD8\SQLEXPRESS;Initial Catalog=Bilgiler;Integrated Security=True");

            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Bilgiler", baglan1); //Veritabanında kaç satır bilgi olduğunu bulan Sql komutu
            SqlCommand komut3 = new SqlCommand("select Bilgiid from Tbl_Bilgiler", baglan1);

            baglan1.Open();
            kayitSayisi1 = Convert.ToInt32(komut1.ExecuteScalar()); //Kayıt sayısının int kayitSayisi değişkenine atanması.
            idTutucu1 = new int[kayitSayisi1];

            SqlDataReader reader = komut3.ExecuteReader();
            int j = 0;
            while (reader.Read())
            {
                idTutucu1[j] = reader.GetInt32(0);
                j++;
            }
            baglan1.Close();

            Random random = new Random(); //Random sınıfından nesne oluşturulması.
            int randomNumber = random.Next(0, kayitSayisi1); //1 ile son satır sayısı dahil olmak üzere bu sayılar arasından rastgele sayı üretme. 5 satır yani 5 bilgi varsa 1,2,3,4,5 arasında değerler üreteblir.

            int dondurulecekRandomNumber = idTutucu1[randomNumber];

            //Aşağıdaki if else yapısı öğrendim butonuna tıklanılan yani öğrenilen bir bilginin o oturum boyunca kullanıcının tekrar karşısına gelmemesini sağlar.
            if (!(ogrenilenSayilar1.Contains(dondurulecekRandomNumber))) //rastgele üretilen sayı eğer öğrenilen sayıların(öğrenilen satırdaki bilgi) içinde değilse bu random sayıyı döndür.
            {
                tutucu1 = dondurulecekRandomNumber; //üretilen rastgele sayıyı tutar.
                return dondurulecekRandomNumber;
            }
            else //rastgele üretilen sayı zaten daha önce öğrenilenlerin içindeyse bunu geri döndürme tekrar recursive olarak bu metoda dön yeni sayı üret kontrol et ve onu döndür.
            {
                return rastgeleSayiUret1();
            }

        }

        private void bilgiyiGetir1() //veritabanındaki genel bilgiyi çeker.
        {

            SqlCommand komut2 = new SqlCommand($"SELECT * FROM Tbl_Bilgiler WHERE Bilgiid = {rastgeleSayiUret1()}", sql.baglantiSagla()); //veritabanındaki bilgiyi çekmeye yarayan sql komutu.
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BilgiKutum.Text = oku2["Bilgi"].ToString();
                label1.Text = oku2["BilgiAd"].ToString();
                label3.Text = oku2["BilgiEklemeTarih"].ToString();
            }
            sql.baglantiSagla().Close();
        }





        private int kullaniciIdDondur(String kullaniciadi)
        {
            SqlConnection baglan2 = new SqlConnection(@"Data Source=DESKTOP-GE4SKD8\SQLEXPRESS;Initial Catalog=Bilgiler;Integrated Security=True");
            string sorgu = $"select Id from Tbl_Kullanici where KullaniciAdi = '{kullaniciadi}'";
            baglan2.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglan2);
            SqlDataReader reader = komut.ExecuteReader();
            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            baglan2.Close();
            return id;
        }
        private int rastgeleSayiUret2() //sadece kendi bilgilerimizden rastgele bilgiid seçip döndürem metot.
        {


            SqlCommand komut1 = new SqlCommand($"select count(*) from Tbl_Bilgiler where Kullaniciid ={kullaniciIdDondur(lblKullanici.Text)}", sql.baglantiSagla()); //Veritabanında kaç satır bilgi olduğunu bulan Sql komutu
            SqlCommand komut3 = new SqlCommand($"select Bilgiid from Tbl_Bilgiler where Kullaniciid ={kullaniciIdDondur(lblKullanici.Text)}", sql.baglantiSagla());

            kayitSayisi2 = Convert.ToInt32(komut1.ExecuteScalar()); //Kayıt sayısının int kayitSayisi değişkenine atanması.
            idTutucu2 = new int[kayitSayisi2];

            SqlDataReader reader = komut3.ExecuteReader();
            int j = 0;
            while (reader.Read())
            {
                idTutucu2[j] = reader.GetInt32(0);
                j++;
            }
            sql.baglantiSagla().Close();

            Random random = new Random(); //Random sınıfından nesne oluşturulması.
            int randomNumber = random.Next(0, kayitSayisi2); //1 ile son satır sayısı dahil olmak üzere bu sayılar arasından rastgele sayı üretme. 5 satır yani 5 bilgi varsa 1,2,3,4,5 arasında değerler üreteblir.

            int dondurulecekRandomNumber = idTutucu2[randomNumber];

            //Aşağıdaki if else yapısı öğrendim butonuna tıklanılan yani öğrenilen bir bilginin o oturum boyunca kullanıcının tekrar karşısına gelmemesini sağlar.
            if (!(ogrenilenSayilar2.Contains(dondurulecekRandomNumber))) //rastgele üretilen sayı eğer öğrenilen sayıların(öğrenilen satırdaki bilgi) içinde değilse bu random sayıyı döndür.
            {
                tutucu2 = dondurulecekRandomNumber; //üretilen rastgele sayıyı tutar.
                return dondurulecekRandomNumber;
            }
            else //rastgele üretilen sayı zaten daha önce öğrenilenlerin içindeyse bunu geri döndürme tekrar recursive olarak bu metoda dön yeni sayı üret kontrol et ve onu döndür.
            {
                return rastgeleSayiUret2();
            }


        }

        private void kisininbilgiyiGetir2() //veritabanındaki bilgiyi çeker.
        {

            SqlCommand komut2 = new SqlCommand($"SELECT * FROM Tbl_Bilgiler WHERE Bilgiid = {rastgeleSayiUret2()} AND Kullaniciid = {kullaniciIdDondur(lblKullanici.Text)}", sql.baglantiSagla()); //veritabanındaki bilgiyi çekmeye yarayan sql komutu.
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                BilgiKutum.Text = oku2["Bilgi"].ToString();
                label1.Text = oku2["BilgiAd"].ToString();
                label3.Text = oku2["BilgiEklemeTarih"].ToString();
            }
            sql.baglantiSagla().Close();
        }

        private bool kisininBilgisiVarMi()//Eğer kişi bir bilgi eklediyse true eklemediyse false döndürür.
        {
            SqlCommand komut2 = new SqlCommand($"SELECT * FROM Tbl_Bilgiler WHERE Kullaniciid = {kullaniciIdDondur(lblKullanici.Text)}", sql.baglantiSagla()); //veritabanındaki bilgiyi çekmeye yarayan sql komutu.
            SqlDataReader oku2 = komut2.ExecuteReader();

            if (oku2.Read())
            {
                if (oku2["Bilgi"].ToString() == null && oku2["BilgiAd"].ToString() == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            sql.baglantiSagla().Close();
        }


        private void btnAbrakadabra_Click_1(object sender, EventArgs e) //adındakiabrakadabra butonuna tıklandığında bilgi getir metodu çağrılır.
        {

            if (checkBox1.Checked == false)
            {

                if (kisininBilgisiVarMi() == false)
                {
                    MessageBox.Show(
                        "Henüz bir bilgi eklemeden sihirli kutudan bilgi istiyorsunuz. Bilgiyi görüntülemek için Kutuyu Düzenle kısmından kendiniz bilgi ekleyebilir ya da Genel bilgileri göster seçeneği ile farklı kullanıcıların eklediği bilgileri görüntüleyebilirsiniz!");
                }
                else
                {
                    pictureBox1.Visible = true;
                    BilgiKutum.Visible = true;
                    Ögrendim.Visible = true;
                    lblTarih.Text = "Eklenme Tarihi";
                    kisininbilgiyiGetir2();
                }
            }
            else
            {
                pictureBox1.Visible = true;
                BilgiKutum.Visible = true;
                Ögrendim.Visible = true;
                lblTarih.Text = "Eklenme Tarihi";
                bilgiyiGetir1();
            }
        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            Giriş giriş = new Giriş();
            giriş.Show();
            this.Close();
        }


        private void Ögrendim_Click(object sender, EventArgs e) //öğrendim butonuna 
        {
            if (checkBox1.Checked == false)
            {
                ogrenilenSayilar2.Add(tutucu2);
            }
            else
            {
                ogrenilenSayilar1.Add(tutucu1);
            }

        }



        public void yonetmeyeKullaniciAdiGonder(SihirliKutuyuYonetme yonetme)
        {
            yonetme.lblKullaniciAdi.Text = lblKullanici.Text;
        }

        private void btnKutuyuDuzenle_Click(object sender, EventArgs e)
        {
            SihirliKutuyuYonetme yeni = new SihirliKutuyuYonetme();
            yonetmeyeKullaniciAdiGonder(yeni);
            yeni.Show();
            this.Hide();
        }


    }

}
