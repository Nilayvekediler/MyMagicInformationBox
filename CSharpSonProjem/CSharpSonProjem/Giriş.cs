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

namespace CSharpSonProjem
{
    public partial class Giriş : Form
    {

        public Giriş()
        {
            InitializeComponent();
        }

        private Sql sql = new Sql();

        private void btnGirişYap_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from Tbl_Kullanici where KullaniciAdi=@ad AND Sifre=@sifre", sql.baglantiSagla());
            komut.Parameters.AddWithValue("@ad", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@sifre", Sifreleme.hashPassword(txtSifre.Text));

            SqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
                Anasayfa yeni = new Anasayfa();
                anasayfayaKullaniciAdiGonder(yeni);

                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }

            sql.baglantiSagla().Close();

        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifreYenileme sy = new SifreYenileme();
            sy.Show();
            this.Hide();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            Kayit kayit = new Kayit();
            kayit.Show();
            this.Hide();
        }

        public void anasayfayaKullaniciAdiGonder(Anasayfa anasayfa)
        {
            anasayfa.lblKullanici.Text = txtKullaniciAd.Text;
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            YoneticiGiris yg = new YoneticiGiris();
            yg.Show();
            this.Hide();
        }

    }

}
