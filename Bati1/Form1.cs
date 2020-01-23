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
    

    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frmman fr = new Frmman();
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frmwoman fr = new Frmwoman();
            fr.Show();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
