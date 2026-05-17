namespace UCP1
{
    partial class Form2
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
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblAsalDaerah = new System.Windows.Forms.Label();
            this.lblTujuan = new System.Windows.Forms.Label();
            this.btnKirim = new System.Windows.Forms.Button();
            this.textBoxAsalDaerah = new System.Windows.Forms.TextBox();
            this.textBoxTujuan = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(729, 155);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(320, 60);
            this.textBoxNama.TabIndex = 0;
            this.textBoxNama.TextChanged += new System.EventHandler(this.textBoxNama_TextChanged);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(557, 155);
            this.lblNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // lblAsalDaerah
            // 
            this.lblAsalDaerah.AutoSize = true;
            this.lblAsalDaerah.Location = new System.Drawing.Point(557, 260);
            this.lblAsalDaerah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsalDaerah.Name = "lblAsalDaerah";
            this.lblAsalDaerah.Size = new System.Drawing.Size(97, 20);
            this.lblAsalDaerah.TabIndex = 2;
            this.lblAsalDaerah.Text = "Asal Daerah";
            // 
            // lblTujuan
            // 
            this.lblTujuan.AutoSize = true;
            this.lblTujuan.Location = new System.Drawing.Point(557, 355);
            this.lblTujuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTujuan.Name = "lblTujuan";
            this.lblTujuan.Size = new System.Drawing.Size(57, 20);
            this.lblTujuan.TabIndex = 3;
            this.lblTujuan.Text = "Tujuan";
            // 
            // btnKirim
            // 
            this.btnKirim.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnKirim.Location = new System.Drawing.Point(670, 532);
            this.btnKirim.Margin = new System.Windows.Forms.Padding(2);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(141, 41);
            this.btnKirim.TabIndex = 4;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = false;
            this.btnKirim.Click += new System.EventHandler(this.Kirim_Click);
            // 
            // textBoxAsalDaerah
            // 
            this.textBoxAsalDaerah.Location = new System.Drawing.Point(729, 260);
            this.textBoxAsalDaerah.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAsalDaerah.Multiline = true;
            this.textBoxAsalDaerah.Name = "textBoxAsalDaerah";
            this.textBoxAsalDaerah.Size = new System.Drawing.Size(320, 60);
            this.textBoxAsalDaerah.TabIndex = 5;
            // 
            // textBoxTujuan
            // 
            this.textBoxTujuan.Location = new System.Drawing.Point(729, 355);
            this.textBoxTujuan.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTujuan.Multiline = true;
            this.textBoxTujuan.Name = "textBoxTujuan";
            this.textBoxTujuan.Size = new System.Drawing.Size(320, 60);
            this.textBoxTujuan.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(729, 462);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(320, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(557, 462);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(66, 20);
            this.lblTanggal.TabIndex = 8;
            this.lblTanggal.Text = "Tanggal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(631, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data Pengunjung";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.Location = new System.Drawing.Point(840, 532);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 41);
            this.btnLogout.TabIndex = 15;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 844);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxTujuan);
            this.Controls.Add(this.textBoxAsalDaerah);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.lblTujuan);
            this.Controls.Add(this.lblAsalDaerah);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.textBoxNama);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblAsalDaerah;
        private System.Windows.Forms.Label lblTujuan;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.TextBox textBoxAsalDaerah;
        private System.Windows.Forms.TextBox textBoxTujuan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLogout;
    }
}