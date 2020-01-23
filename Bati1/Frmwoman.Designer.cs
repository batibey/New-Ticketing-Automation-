namespace Bati1
{
    partial class Frmwoman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmwoman));
            this.MskTel = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtSehir = new System.Windows.Forms.TextBox();
            this.TxtYas = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.Btnileri = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MskTel
            // 
            this.MskTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTel.Location = new System.Drawing.Point(121, 276);
            this.MskTel.Mask = "(999) 000-0000";
            this.MskTel.Name = "MskTel";
            this.MskTel.Size = new System.Drawing.Size(111, 21);
            this.MskTel.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1049, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(430, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 44);
            this.label6.TabIndex = 26;
            this.label6.Text = "KADIN KAYIT";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEkle.Location = new System.Drawing.Point(2, 306);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(106, 31);
            this.BtnEkle.TabIndex = 7;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtSehir
            // 
            this.TxtSehir.Location = new System.Drawing.Point(121, 230);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(100, 29);
            this.TxtSehir.TabIndex = 5;
            // 
            // TxtYas
            // 
            this.TxtYas.Location = new System.Drawing.Point(121, 189);
            this.TxtYas.Name = "TxtYas";
            this.TxtYas.Size = new System.Drawing.Size(100, 29);
            this.TxtYas.TabIndex = 4;
            this.TxtYas.TextChanged += new System.EventHandler(this.TxtYas_TextChanged);
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(121, 145);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 29);
            this.TxtSoyad.TabIndex = 3;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(121, 103);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 29);
            this.TxtAd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "TELEFON:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "ŞEHİR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "YAŞ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "AD:";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTemizle.Location = new System.Drawing.Point(111, 306);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(106, 31);
            this.BtnTemizle.TabIndex = 8;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // Btnileri
            // 
            this.Btnileri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnileri.Location = new System.Drawing.Point(220, 306);
            this.Btnileri.Name = "Btnileri";
            this.Btnileri.Size = new System.Drawing.Size(74, 31);
            this.Btnileri.TabIndex = 9;
            this.Btnileri.Text = "İleri";
            this.Btnileri.UseVisualStyleBackColor = true;
            this.Btnileri.Click += new System.EventHandler(this.Btnileri_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.Location = new System.Drawing.Point(111, 343);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(183, 31);
            this.BtnGuncelle.TabIndex = 11;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Location = new System.Drawing.Point(2, 343);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(106, 31);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(121, 60);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 29);
            this.TxtId.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 281);
            this.dataGridView1.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(312, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 309);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kadın Kayıt";
            // 
            // Frmwoman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(1079, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.Btnileri);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.MskTel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtSehir);
            this.Controls.Add(this.TxtYas);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frmwoman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frmwoman";
            this.Load += new System.EventHandler(this.Frmwoman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MskTel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtSehir;
        private System.Windows.Forms.TextBox TxtYas;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.Button Btnileri;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}