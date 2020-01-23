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
    public partial class FrmOdemeDuzenleme : Form
    {

        sqlbaglantisi bgl = new sqlbaglantisi();
        public FrmOdemeDuzenleme()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM Odemeler WHERE OdemeID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtOdemeID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ödeme Kaydı Silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  Odemeler set AdSoyad=@p2,KartNo=@p3,SKT=@p4,CVC=@p5 where OdemeID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskKartNo.Text);
            komut.Parameters.AddWithValue("@p4", MskSKT.Text);
            komut.Parameters.AddWithValue("@p5", TxtCVC.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ödeme Kaydınız Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }
    }
}
