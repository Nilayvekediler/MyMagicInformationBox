using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
namespace CSharpSonProjem
{
    public partial class SifreYenileme : Form
    {
        private String guvenlikkod;
        public SifreYenileme()
        {
            InitializeComponent();
        }

        private String guvenlikKodUret()
        {
            Random rastgele = new Random();
            int sayi1, sayi2, sayi3;
            int harfdegeri1, harfdegeri2, harfdegeri3;
            sayi1 = rastgele.Next(0, 100);
            sayi2 = rastgele.Next(0, 100);
            sayi3 = rastgele.Next(0, 100);
            harfdegeri1 = rastgele.Next(65, 91);
            harfdegeri2 = rastgele.Next(65, 91);
            harfdegeri3 = rastgele.Next(65, 91);
            char karakter1, karakter2, karakter3;
            karakter1 = Convert.ToChar(harfdegeri1);
            karakter2 = Convert.ToChar(harfdegeri2);
            karakter3 = Convert.ToChar(harfdegeri3);
            String kod;
            kod = sayi1.ToString() + karakter1 + sayi2.ToString() + karakter2 + sayi3.ToString() + karakter3;
            return kod;
        }
        private void btnGönder_Click(object sender, EventArgs e)
        {
            Sql sql = new Sql();
            SqlCommand komut = new SqlCommand("Select * from Tbl_Kullanici where KullaniciAdi=@ad and Eposta=@eposta",sql.baglantiSagla());
            komut.Parameters.AddWithValue("@ad", txtKullaniciAd1.Text);
            komut.Parameters.AddWithValue("@eposta", txteposta1.Text);

            SqlDataReader reader = komut.ExecuteReader();

           
                if(reader.Read())
                {
                    try
                    {
                        if (sql.baglantiSagla().State == ConnectionState.Closed)//Eğer bağlantı kapalıysa bağlantıyı aç.
                        {
                            sql.baglantiSagla().Open();
                        }

                        guvenlikkod = guvenlikKodUret();

                        SmtpClient smtpserver = new SmtpClient();
                        MailMessage mail = new MailMessage();
                        String tarih = DateTime.Now.ToLongDateString();
                        String mailadresim = ("SihirliBilgiKutum@gmail.com");
                        String sifre = ("OgrenmeSayim3125");
                        String smptsrvr = "smtp.gmail.com";
                        String kime = (reader["Eposta"].ToString());
                        String konu = ("Sihirli Bilgi Kutum Şifremi Unuttum Mail'i");
                        String yaz = ("Sayın, " + reader["Ad"].ToString() + " " + reader["Soyad"].ToString() + "\n" +
                                      "Bizden " + tarih + " tarihinde şifre yenileme talebinde bulundunuz.\n" +
                                      "Kodunuz : " + guvenlikkod + "\nİyi günler");
                        smtpserver.Credentials = new NetworkCredential(mailadresim, sifre);
                        smtpserver.Port = 587; //Gmail için böyle int. de yazıyor.
                        smtpserver.Host = smptsrvr;
                        smtpserver.EnableSsl = true;
                        mail.From = new MailAddress(mailadresim);
                        mail.To.Add(kime);
                        mail.Subject = konu;
                        mail.Body = yaz;
                        smtpserver.Send(mail);
                        DialogResult bilgiYazisi = new DialogResult();
                        bilgiYazisi =
                            MessageBox.Show(
                                "Girmiş olduğunuz bilgiler uyuşuyor. Şifrenizi yenilemek için Mail adresinize kod gönderilmiştir!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mail'iniz gönderilmemiştir hata:", ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz bilgiler yanlış ya da birbiriyle uyuşmuyor. Mail gönderilemedi!");
                }
            }

        private void btnSifreYenile_Click(object sender, EventArgs e)
        {
            if (txtGuvenlikKodu.Text==guvenlikkod)
            {
                Sql sql = new Sql();
                string sorgu = "UPDATE Tbl_Kullanici SET Sifre=@yenisifre WHERE KullaniciAdi=@nick AND Eposta=@eposta ";
                SqlCommand komut = new SqlCommand();
                komut = new SqlCommand(sorgu, sql.baglantiSagla());
                komut.Parameters.AddWithValue("@yenisifre", Sifreleme.hashPassword(txtYeniSifre.Text));
                komut.Parameters.AddWithValue("@nick", txtKullaniciAd1.Text);
                komut.Parameters.AddWithValue("@eposta", txteposta1.Text);
                komut.ExecuteNonQuery();
                sql.baglantiSagla().Close();
                MessageBox.Show("Şifreniz başarıyla güncellendi!");
                Giriş giriş = new Giriş();
                giriş.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Yanlış güvenlik kodu!");
            }
        }

        private void GiriseDon_Click(object sender, EventArgs e)
        {
            Giriş giriş = new Giriş();
            giriş.Show();
            this.Hide();
        }
    }
}
