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
    public partial class Yonetim : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Yonetim()
        {
            InitializeComponent();
        }
        private Sql sql = new Sql();

        void YoneticiBilgiGetir()
        {
            baglanti = new SqlConnection(@"Data Source=DESKTOP-GE4SKD8\SQLEXPRESS;Initial Catalog=Bilgiler;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select* from Tbl_Yonetici", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo); //datatable nesnesini çekilen veri tablosuyla doldur.
            dataGridYonetici.DataSource = tablo;
            baglanti.Close();
        }

        private void Yonetim_Load(object sender, EventArgs e)
        {
            YoneticiBilgiGetir();
            KullaniciBilgiGetir();
            BilgilerGetir();
        }

        private void dataGridYonetici_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtAd.Text = dataGridYonetici.CurrentRow.Cells[1].Value.ToString();
            txtEposta.Text = dataGridYonetici.CurrentRow.Cells[2].Value.ToString();
            txtSifre.Text = dataGridYonetici.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtAraYonetici_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter ara = new SqlDataAdapter("select * from Tbl_Yonetici where AdSoyad like '%" + txtAraYonetici.Text + "%'", baglanti);
            DataTable tbl = new DataTable();
            ara.Fill(tbl);
            dataGridYonetici.DataSource = tbl;
            baglanti.Close();

        }

        private void btnEkleYonetici_Click(object sender, EventArgs e)
        {
            string sorgu = $"INSERT INTO Tbl_Yonetici(AdSoyad,Eposta,Sifre) VALUES (@adsoyad,@eposta,@sifre)";
            komut = new SqlCommand(sorgu, sql.baglantiSagla());
            komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            komut.Parameters.AddWithValue("@eposta", txtEposta.Text);
            komut.Parameters.AddWithValue("@sifre", Sifreleme.hashPassword(txtSifre.Text));
            komut.ExecuteNonQuery();
            sql.baglantiSagla().Close();
            YoneticiBilgiGetir();
        }

        private void btnSilYonetici_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Tbl_Yonetici WHERE AdSoyad=@adsoyad";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            YoneticiBilgiGetir();
        }

        private void btnGuncelleYonetici_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Tbl_Yonetici SET AdSoyad=@adsoyad,Eposta=@eposta,Sifre=@sifre WHERE Id=@bilgiid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@bilgiid", dataGridYonetici.SelectedCells[0].Value);
            komut.Parameters.AddWithValue("@adsoyad", txtAd.Text);
            komut.Parameters.AddWithValue("@eposta", txtEposta.Text);
            komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            YoneticiBilgiGetir();
        }

        void KullaniciBilgiGetir()
        {
            baglanti = new SqlConnection(@"Data Source=DESKTOP-GE4SKD8\SQLEXPRESS;Initial Catalog=Bilgiler;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select* from Tbl_Kullanici", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo); //datatable nesnesini çekilen veri tablosuyla doldur.
            dataGridKullanici.DataSource = tablo;
            baglanti.Close();
        }


        private void txtAraKullanıcı_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter ara = new SqlDataAdapter("select * from Tbl_Kullanici where KullaniciAdi like '%" + txtAraKullanıcı.Text + "%' OR Eposta like '%" + txtAraKullanıcı.Text + "%' OR Ad like '%" + txtAraKullanıcı.Text + "%' OR Soyad like '%" + txtAraKullanıcı.Text + "%'", baglanti); //
            DataTable tbl = new DataTable();
            ara.Fill(tbl);
            dataGridKullanici.DataSource = tbl;
            baglanti.Close();
        }


        private void btnSilKullanici_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Tbl_Kullanici WHERE KullaniciAdi=@kullaniciadi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kullaniciadi", dataGridKullanici.SelectedCells[3].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KullaniciBilgiGetir();

        }

        void BilgilerGetir()
        {
            baglanti = new SqlConnection(@"Data Source=DESKTOP-GE4SKD8\SQLEXPRESS;Initial Catalog=Bilgiler;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select* from Tbl_Bilgiler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo); //datatable nesnesini çekilen veri tablosuyla doldur.
            dataGridBilgi.DataSource = tablo;
            baglanti.Close();
        }

        private void txtAraBilgi_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter ara = new SqlDataAdapter("select * from Tbl_Bilgiler where BilgiAd like '%" + txtAraBilgi.Text + "%' OR Bilgi like '%" + txtAraBilgi.Text + "%' OR Kullaniciid like '%" + txtAraBilgi.Text + "%'", baglanti); 
            DataTable tbl = new DataTable();
            ara.Fill(tbl);
            dataGridBilgi.DataSource = tbl;
            baglanti.Close();
        }

        private void btnSilBilgi_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Tbl_Bilgiler WHERE Bilgi=@bilgi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@bilgi", dataGridBilgi.SelectedCells[2].Value);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            BilgilerGetir();
        }
    }
}
