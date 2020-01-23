namespace Bati1
{
    partial class FrmOdemeDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeDuzenleme));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSil = new System.Windows.Forms.Button();
            this.TxtOdemeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.MskSKT = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.MskKartNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtCVC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(618, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödeme Düzenleme ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(694, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.TxtOdemeID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(31, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Silme İşlemleri";
            // 
            // BtnSil
            // 
            this.BtnSil.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSil.Location = new System.Drawing.Point(60, 87);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(106, 33);
            this.BtnSil.TabIndex = 2;
            this.BtnSil.Text = "SİL";
            this.BtnSil.UseVisualStyleBackColor = false;
            this.BtnSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtOdemeID
            // 
            this.TxtOdemeID.Location = new System.Drawing.Point(116, 38);
            this.TxtOdemeID.Name = "TxtOdemeID";
            this.TxtOdemeID.Size = new System.Drawing.Size(100, 29);
            this.TxtOdemeID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Odeme ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BtnGuncelle);
            this.groupBox2.Controls.Add(this.MskSKT);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtAdSoyad);
            this.groupBox2.Controls.Add(this.MskKartNo);
            this.groupBox2.Controls.Add(this.TxtCVC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(365, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 336);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Güncelleme İşlemleri";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuncelle.Location = new System.Drawing.Point(94, 291);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(171, 33);
            this.BtnGuncelle.TabIndex = 14;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.UseVisualStyleBackColor = false;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // MskSKT
            // 
            this.MskSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskSKT.Location = new System.Drawing.Point(125, 183);
            this.MskSKT.Mask = "00.00";
            this.MskSKT.Name = "MskSKT";
            this.MskSKT.Size = new System.Drawing.Size(100, 35);
            this.MskSKT.TabIndex = 10;
            this.MskSKT.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ad Soyad";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(125, 86);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(181, 29);
            this.TxtAdSoyad.TabIndex = 6;
            // 
            // MskKartNo
            // 
            this.MskKartNo.Location = new System.Drawing.Point(125, 135);
            this.MskKartNo.Mask = "0000.0000.0000.0000";
            this.MskKartNo.Name = "MskKartNo";
            this.MskKartNo.Size = new System.Drawing.Size(181, 29);
            this.MskKartNo.TabIndex = 8;
            // 
            // TxtCVC
            // 
            this.TxtCVC.Location = new System.Drawing.Point(125, 240);
            this.TxtCVC.Name = "TxtCVC";
            this.TxtCVC.Size = new System.Drawing.Size(100, 29);
            this.TxtCVC.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(28, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kart No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(49, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "S.K.T";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(60, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "CVC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(83, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 17;
            // 
            // FrmOdemeDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(723, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOdemeDuzenleme";
            this.Text = "FrmOdemeDuzenleme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.TextBox TxtOdemeID;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.MaskedTextBox MskSKT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.MaskedTextBox MskKartNo;
        private System.Windows.Forms.TextBox TxtCVC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}