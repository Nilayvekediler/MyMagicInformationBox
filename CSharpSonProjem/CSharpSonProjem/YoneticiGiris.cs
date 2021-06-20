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
    public partial class YoneticiGiris : Form
    {
        public YoneticiGiris()
        {
            InitializeComponent();
        }

        private Sql sql = new Sql();

        private void btnGirişYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Yonetici where AdSoyad=@isim AND Sifre=@sifre", sql.baglantiSagla());
            komut.Parameters.AddWithValue("@isim", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@sifre", Sifreleme.hashPassword(txtSifre.Text));
            
            SqlDataReader reader = komut.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
                Yonetim yeni = new Yonetim();
                yeni.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }

            sql.baglantiSagla().Close();
        }
    }
}
