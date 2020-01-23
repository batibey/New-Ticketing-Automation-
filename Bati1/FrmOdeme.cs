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
    public partial class FrmOdeme : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        public FrmOdeme()
        {
            InitializeComponent();
        }

        private void FrmOdeme_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Odemeler(AdSoyad,KartNo,SKT,CVC,OnayKod) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", MskKartNo.Text);
            komut.Parameters.AddWithValue("@p3", MskSKT.Text);
            komut.Parameters.AddWithValue("@p4", TxtCVC.Text);
            komut.Parameters.AddWithValue("@p5", TxtOnayKod.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Onaylandı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.baglanti().Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOdemeDuzenleme fr = new FrmOdemeDuzenleme();
            fr.Show();
        }
    }
}
