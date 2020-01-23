namespace Bati1
{
    partial class FrmBiletIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiletIslemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TxtBiletID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtErkekID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtKadinId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MskGidisSaat = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbFirma = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.BtnOnayla = new System.Windows.Forms.Button();
            this.MskDonusSaat = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MskDonus = new System.Windows.Forms.MaskedTextBox();
            this.MskGidis = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNry = new System.Windows.Forms.TextBox();
            this.TxtNrdn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnOdeme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Miriam Libre", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(868, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilet İşlemleri Formuna Hoşgeldiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1189, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.TxtBiletID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtErkekID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtKadinId);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.MskGidisSaat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CmbFirma);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BtnTemizle);
            this.groupBox1.Controls.Add(this.BtnOnayla);
            this.groupBox1.Controls.Add(this.MskDonusSaat);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MskDonus);
            this.groupBox1.Controls.Add(this.MskGidis);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNry);
            this.groupBox1.Controls.Add(this.TxtNrdn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 530);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yolcu İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Location = new System.Drawing.Point(145, 479);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(134, 38);
            this.BtnSil.TabIndex = 23;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtBiletID
            // 
            this.TxtBiletID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtBiletID.Location = new System.Drawing.Point(175, 53);
            this.TxtBiletID.Name = "TxtBiletID";
            this.TxtBiletID.Size = new System.Drawing.Size(176, 35);
            this.TxtBiletID.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(40, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "Bilet ID:";
            // 
            // TxtErkekID
            // 
            this.TxtErkekID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtErkekID.Location = new System.Drawing.Point(176, 135);
            this.TxtErkekID.Name = "TxtErkekID";
            this.TxtErkekID.Size = new System.Drawing.Size(176, 35);
            this.TxtErkekID.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(26, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 29);
            this.label11.TabIndex = 20;
            this.label11.Text = "Erkek ID:";
            // 
            // TxtKadinId
            // 
            this.TxtKadinId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKadinId.Location = new System.Drawing.Point(176, 94);
            this.TxtKadinId.Name = "TxtKadinId";
            this.TxtKadinId.Size = new System.Drawing.Size(176, 35);
            this.TxtKadinId.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(26, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "Kadın ID:";
            // 
            // MskGidisSaat
            // 
            this.MskGidisSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskGidisSaat.Location = new System.Drawing.Point(223, 355);
            this.MskGidisSaat.Mask = "00:00";
            this.MskGidisSaat.Name = "MskGidisSaat";
            this.MskGidisSaat.Size = new System.Drawing.Size(87, 26);
            this.MskGidisSaat.TabIndex = 8;
            this.MskGidisSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(113, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gidiş Saat:";
            // 
            // CmbFirma
            // 
            this.CmbFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbFirma.FormattingEnabled = true;
            this.CmbFirma.Items.AddRange(new object[] {
            "Kamil Koç",
            "Metro",
            "Ulusoy",
            "Güney Akdeniz",
            "Kontur"});
            this.CmbFirma.Location = new System.Drawing.Point(223, 429);
            this.CmbFirma.Name = "CmbFirma";
            this.CmbFirma.Size = new System.Drawing.Size(142, 37);
            this.CmbFirma.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(97, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Firma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(363, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(357, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 31);
            this.button2.TabIndex = 12;
            this.button2.Text = "<>";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTemizle.Location = new System.Drawing.Point(7, 479);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(134, 38);
            this.BtnTemizle.TabIndex = 12;
            this.BtnTemizle.Text = "TEMİZLE";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // BtnOnayla
            // 
            this.BtnOnayla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOnayla.Location = new System.Drawing.Point(282, 479);
            this.BtnOnayla.Name = "BtnOnayla";
            this.BtnOnayla.Size = new System.Drawing.Size(134, 38);
            this.BtnOnayla.TabIndex = 11;
            this.BtnOnayla.Text = "ONAYLA";
            this.BtnOnayla.UseVisualStyleBackColor = false;
            this.BtnOnayla.Click += new System.EventHandler(this.BtnOnayla_Click);
            // 
            // MskDonusSaat
            // 
            this.MskDonusSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDonusSaat.Location = new System.Drawing.Point(223, 387);
            this.MskDonusSaat.Mask = "00:00";
            this.MskDonusSaat.Name = "MskDonusSaat";
            this.MskDonusSaat.Size = new System.Drawing.Size(87, 26);
            this.MskDonusSaat.TabIndex = 9;
            this.MskDonusSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(101, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Dönüş Saat:";
            // 
            // MskDonus
            // 
            this.MskDonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskDonus.Location = new System.Drawing.Point(223, 315);
            this.MskDonus.Mask = "00/00/0000";
            this.MskDonus.Name = "MskDonus";
            this.MskDonus.Size = new System.Drawing.Size(176, 35);
            this.MskDonus.TabIndex = 7;
            this.MskDonus.ValidatingType = typeof(System.DateTime);
            // 
            // MskGidis
            // 
            this.MskGidis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskGidis.Location = new System.Drawing.Point(223, 269);
            this.MskGidis.Mask = "00/00/0000";
            this.MskGidis.Name = "MskGidis";
            this.MskGidis.Size = new System.Drawing.Size(176, 35);
            this.MskGidis.TabIndex = 6;
            this.MskGidis.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dönüş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gidiş Tarihi";
            // 
            // TxtNry
            // 
            this.TxtNry.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNry.Location = new System.Drawing.Point(175, 222);
            this.TxtNry.Name = "TxtNry";
            this.TxtNry.Size = new System.Drawing.Size(176, 35);
            this.TxtNry.TabIndex = 5;
            // 
            // TxtNrdn
            // 
            this.TxtNrdn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtNrdn.Location = new System.Drawing.Point(175, 180);
            this.TxtNrdn.Name = "TxtNrdn";
            this.TxtNrdn.Size = new System.Drawing.Size(176, 35);
            this.TxtNrdn.TabIndex = 4;
            this.TxtNrdn.TextChanged += new System.EventHandler(this.TxtNrdn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nereye:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nereden:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.BtnOdeme);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(476, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 530);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seyahat Özeti";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // BtnOdeme
            // 
            this.BtnOdeme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnOdeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOdeme.Location = new System.Drawing.Point(393, 479);
            this.BtnOdeme.Name = "BtnOdeme";
            this.BtnOdeme.Size = new System.Drawing.Size(184, 38);
            this.BtnOdeme.TabIndex = 14;
            this.BtnOdeme.Text = "ÖDEME";
            this.BtnOdeme.UseVisualStyleBackColor = false;
            this.BtnOdeme.Click += new System.EventHandler(this.Btniptal_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(168, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 38);
            this.button1.TabIndex = 13;
            this.button1.Text = "KABUL ET";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 412);
            this.dataGridView1.TabIndex = 15;
            // 
            // FrmBiletIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1218, 652);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmBiletIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmBiletIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox MskDonusSaat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MskDonus;
        private System.Windows.Forms.MaskedTextBox MskGidis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNry;
        private System.Windows.Forms.TextBox TxtNrdn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button BtnOnayla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnOdeme;
        private System.Windows.Forms.ComboBox CmbFirma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MskGidisSaat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtKadinId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtErkekID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtBiletID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}