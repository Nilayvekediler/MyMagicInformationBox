using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //gerekli kütüphanemizi ekledik.

namespace CSharpSonProjem
{
    public partial class SihirliKutuyuYonetme : Form 
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public SihirliKutuyuYonetme()
        {
            InitializeComponent();
        }

        private Sql sql = new Sql();
        void BilgiGetir()
        {
            baglanti = new SqlConnection(@"Data Source=DESKTOP-GE4SKD8\SQLEXPRESS;Initial Catalog=Bilgiler;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter($"select* from Tbl_Bilgiler where Kullaniciid = {kullaniciIdDondur(lblKullaniciAdi.Text)}",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo); //veri kaynağında olanlarla eşleşecek şekilde ekler veya yeniler 
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void Yonetme_Load(object sender, EventArgs e)
        {
            BilgiGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBilgiAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtBilgi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Anasayfa yeni = new Anasayfa();
            anasayfayaKullaniciAdiGonder(yeni);
            yeni.Show();
            this.Hide();
        }

        private int kullaniciIdDondur(String kullaniciadi)
        {
            string sorgu = $"select Id from Tbl_Kullanici where KullaniciAdi = '{kullaniciadi}'";
            komut = new SqlCommand(sorgu, sql.baglantiSagla());
            SqlDataReader reader = komut.ExecuteReader();
            int id=0;
            while (reader.Read())
            {
                id= reader.GetInt32(0);
            }

            sql.baglantiSagla().Close();
            return id;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = $"INSERT INTO Tbl_Bilgiler(BilgiAd,Bilgi,Kullaniciid) VALUES (@bilgiAd,@bilgi,{kullaniciIdDondur(lblKullaniciAdi.Text)})"; 
            komut = new SqlCommand(sorgu, sql.baglantiSagla());
            komut.Parameters.AddWithValue("@bilgiAd", txtBilgiAd.Text);
            komut.Parameters.AddWithValue("@bilgi", txtBilgi.Text);
            komut.ExecuteNonQuery();
            sql.baglantiSagla().Close();
            BilgiGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Tbl_Bilgiler WHERE BilgiAd=@bilgiad";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@bilgiad", txtBilgiAd.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            BilgiGetir();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Tbl_Bilgiler SET BilgiAd=@bilgiad,Bilgi=@bilgi WHERE Bilgiid=@bilgiid";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@bilgiid", dataGridView1.SelectedCells[0].Value);
            komut.Parameters.AddWithValue("@bilgiad", txtBilgiAd.Text);
            komut.Parameters.AddWithValue("@bilgi", txtBilgi.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            BilgiGetir();

        }

        public void anasayfayaKullaniciAdiGonder(Anasayfa anasayfa) 
        {
            anasayfa.lblKullanici.Text = lblKullaniciAdi.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter ara = new SqlDataAdapter($"select * from Tbl_Bilgiler where Kullaniciid = {kullaniciIdDondur(lblKullaniciAdi.Text)} AND (BilgiAd like '%" + txtAraBilgi.Text + "%' OR Bilgi like '%" + txtAraBilgi.Text + "%' OR Kullaniciid like '%" + txtAraBilgi.Text + "%')", baglanti);
            DataTable tbl = new DataTable();
            ara.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
        }

    }
}
