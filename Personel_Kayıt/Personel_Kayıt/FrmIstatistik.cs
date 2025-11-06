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

namespace Personel_Kayıt
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        private SqlConnection baglanti = new SqlConnection("Data Source=Barbaros;Initial Catalog=PersonelVeriTabani;Integrated Security=True;TrustServerCertificate=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            // Toplam Personel Sayısını burada bulduk
            baglanti.Open();
            SqlCommand cmd1 = new SqlCommand("select count(*) from Tbl_Personel", baglanti);
            SqlDataReader dr1 = cmd1.ExecuteReader(); // Execute reader ise select için sorguyu çalıştırır.
            while(dr1.Read())
            {
                LblToplamPersonel.Text = dr1[0].ToString();
            }
            baglanti.Close();

            // Evli Personel sayısı
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum=1", baglanti);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while(dr2.Read())
            {
                LblEvliPersonel.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // Bekar Personel Sayısı
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum=0", baglanti);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            while(dr3.Read())
            {
                LblBekarPersonel.Text = dr3[0].ToString();
            }
            baglanti.Close();

            // Şehir Sayısı
            baglanti.Open();
            SqlCommand cmd4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_Personel", baglanti);
            SqlDataReader dr4 = cmd4.ExecuteReader();
            while(dr4.Read())
            {
                LblSehirSayisi.Text = dr4[0].ToString();
            }
            baglanti.Close();

            // Toplam Maaş
            baglanti.Open();
            SqlCommand cmd5 = new SqlCommand("select sum(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dr5 = cmd5.ExecuteReader();
            while(dr5.Read())
            {
                LblToplamMaas.Text = dr5[0].ToString();
            }
            baglanti.Close();

            // Ortalama Maaş
            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("select avg(PerMaas) from Tbl_Personel", baglanti);
            SqlDataReader dr6 = cmd6.ExecuteReader();
            while(dr6.Read())
            {
                LblOrtalamaMaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
