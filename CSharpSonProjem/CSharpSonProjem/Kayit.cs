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
using System.Security.Cryptography;

namespace CSharpSonProjem
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private Sql sql = new Sql();

        private bool ayniKullaniciAdindanVarMi(string kullaniciadi) //Aynı kullanıcı adı önceden alınmışsa T alınmamışsa F döner
        {
            string sorgu1 = $"select KullaniciAdi from Tbl_Kullanici where KullaniciAdi='{kullaniciadi}'";
            SqlCommand komut1 = new SqlCommand(sorgu1, sql.baglantiSagla()); 
            SqlDataReader reader = komut1.ExecuteReader();
            if (reader.Read())
            {
                return true;//önceden alınmış bu nick
            }
            else
            {
                return false;
            }
        }
        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (ayniKullaniciAdindanVarMi(txtNick.Text))
            {
                MessageBox.Show(
                    "Almak istediğiniz kullanıcı adı maalesef daha önce alınmış, lütfen başka bir kullanıcı adı deneyiniz!");
            }
            else
            {
                string sorgu = "INSERT INTO Tbl_Kullanici(Ad,Soyad,KullaniciAdi,Eposta,Sifre) VALUES (@ad,@soyad,@nick,@eposta,@sifre)";
                SqlCommand komut = new SqlCommand(sorgu, sql.baglantiSagla());
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@nick", txtNick.Text);
                komut.Parameters.AddWithValue("@eposta", txtEposta.Text);
                komut.Parameters.AddWithValue("@sifre", Sifreleme.hashPassword(txtSifre.Text));
                komut.ExecuteNonQuery();
                sql.baglantiSagla().Close();
                MessageBox.Show("Kayıt işleminiz başarıyla tamamlandı!");
                Giriş giriş = new Giriş();
                giriş.Show();
                this.Hide();
            }
            
        }

    }
}
