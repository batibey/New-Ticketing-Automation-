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

namespace Bati1
{
    public partial class Frmwoman : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public Frmwoman()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*listBox1.Items.Add("ID: " + TxtId.Text);
            listBox1.Items.Add("İsim: " + TxtAd.Text);
            listBox1.Items.Add("Soyisim: " + TxtSoyad.Text);
            listBox1.Items.Add("Yaş: " + TxtYas.Text);
            listBox1.Items.Add("Şehir: " + TxtSehir.Text);
            listBox1.Items.Add("Telefon: " + MskTel.Text);*/

            SqlCommand komut = new SqlCommand("insert into TblKadinKayit (kID,Ad,Soyad,Yas,Sehir,Tel) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", TxtYas.Text);
            komut.Parameters.AddWithValue("@p5", TxtSehir.Text);
            komut.Parameters.AddWithValue("@p6", MskTel.Text);
            MessageBox.Show("Kayıt Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            TxtId.Text = "";
            TxtAd.Text = "";
            TxtSehir.Text = "";
            TxtSoyad.Text = "";
            TxtYas.Text = "";
            MskTel.Text = "";
        }

        private void Btnileri_Click(object sender, EventArgs e)
        {
            FrmBiletIslemleri fr = new FrmBiletIslemleri();
            fr.Show();
        }

        private void TxtYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TblKadinKayit where kID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TblKadinKayit set Ad=@p2, Soyad=@p3, Yas=@p4, Sehir=@p5, Tel=@p6 where kID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtId.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", TxtYas.Text);
            komut.Parameters.AddWithValue("@p5", TxtSehir.Text);
            komut.Parameters.AddWithValue("@p6", MskTel.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }

        private void Frmwoman_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblKadinKayit", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
