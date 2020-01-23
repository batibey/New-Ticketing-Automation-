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
    public partial class FrmBiletIslemleri : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();

        Frmman fr = new Frmman();
        Frmwoman frw = new Frmwoman();

        
        public FrmBiletIslemleri()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            
            
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtBiletID.Clear();
            TxtErkekID.Clear();
            TxtKadinId.Clear();
            TxtNrdn.Clear();
            TxtNry.Clear();
            MskDonus.Clear();
            MskGidis.Clear();
            MskGidisSaat.Clear();
            MskDonusSaat.Clear();
            CmbFirma.Text = "";
            //listBox1.Items.Clear();
        }

        private void BtnOnayla_Click(object sender, EventArgs e)
        {

            
            /*listBox1.Items.Add("Bilet ID: " + TxtBiletID.Text);
            listBox1.Items.Add("Kadın ID: " + TxtKadinId.Text);
            listBox1.Items.Add("Erkek ID: " + TxtErkekID.Text);
            listBox1.Items.Add("Nereden: " + TxtNrdn.Text);
            listBox1.Items.Add("Nereye: " + TxtNry.Text);
            listBox1.Items.Add("Gidiş: " + MskGidis.Text);
            listBox1.Items.Add("Dönüş: " + MskDonus.Text);
            listBox1.Items.Add("Gidiş Saat: " + MskDonusSaat.Text);
            listBox1.Items.Add("Dönüş Saat: " + MskGidisSaat.Text);
            listBox1.Items.Add("Firma Adı: " + CmbFirma.Text);*/

            SqlCommand komut = new SqlCommand("insert into Biletleme (BiletID,kID,eID,Nereden,Nereye,GidisT,DonusT,GidisSaat,DonusSaat,Firma) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBiletID.Text);
            komut.Parameters.AddWithValue("@p2", TxtKadinId.Text);
            komut.Parameters.AddWithValue("@p3", TxtErkekID.Text);
            komut.Parameters.AddWithValue("@p4", TxtNrdn.Text);
            komut.Parameters.AddWithValue("@p5", TxtNry.Text);
            komut.Parameters.AddWithValue("@p6", MskGidis.Text);
            komut.Parameters.AddWithValue("@p7", MskDonus.Text);
            komut.Parameters.AddWithValue("@p8", MskGidisSaat.Text);
            komut.Parameters.AddWithValue("@p9", MskDonusSaat.Text);
            komut.Parameters.AddWithValue("@p10", CmbFirma.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgiler Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bilet Alma İşleminiz Tamamlandı ÖDEME Adımını Geçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = TxtNry.Text;
            TxtNry.Text = TxtNrdn.Text;
            TxtNrdn.Text = label7.Text;
        }

        private void Btniptal_Click(object sender, EventArgs e)
        {
            FrmOdeme fr = new FrmOdeme();
            this.Hide();
            fr.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmBiletIslemleri_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Biletleme", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TxtNrdn_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Biletleme where BiletID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBiletID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
