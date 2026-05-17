namespace UCP1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblNama = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.lblAsalDaerah = new System.Windows.Forms.Label();
            this.textBoxAsalDaerah = new System.Windows.Forms.TextBox();
            this.lblTujuan = new System.Windows.Forms.Label();
            this.textBoxTujuan = new System.Windows.Forms.TextBox();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMenampilkanData = new System.Windows.Forms.Button();
            this.btnMenambahkanData = new System.Windows.Forms.Button();
            this.btnMengubahData = new System.Windows.Forms.Button();
            this.btnMenghapusData = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMembukaKoneksi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 402);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1064, 243);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(69, 136);
            this.lblNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(44, 16);
            this.lblNama.TabIndex = 8;
            this.lblNama.Text = "Nama";
            this.lblNama.Click += new System.EventHandler(this.lblNama_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(193, 136);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(285, 49);
            this.textBoxNama.TabIndex = 9;
            // 
            // lblAsalDaerah
            // 
            this.lblAsalDaerah.AutoSize = true;
            this.lblAsalDaerah.Location = new System.Drawing.Point(69, 205);
            this.lblAsalDaerah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsalDaerah.Name = "lblAsalDaerah";
            this.lblAsalDaerah.Size = new System.Drawing.Size(82, 16);
            this.lblAsalDaerah.TabIndex = 10;
            this.lblAsalDaerah.Text = "Asal Daerah";
            // 
            // textBoxAsalDaerah
            // 
            this.textBoxAsalDaerah.Location = new System.Drawing.Point(193, 203);
            this.textBoxAsalDaerah.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAsalDaerah.Multiline = true;
            this.textBoxAsalDaerah.Name = "textBoxAsalDaerah";
            this.textBoxAsalDaerah.Size = new System.Drawing.Size(285, 49);
            this.textBoxAsalDaerah.TabIndex = 11;
            // 
            // lblTujuan
            // 
            this.lblTujuan.AutoSize = true;
            this.lblTujuan.Location = new System.Drawing.Point(69, 271);
            this.lblTujuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTujuan.Name = "lblTujuan";
            this.lblTujuan.Size = new System.Drawing.Size(48, 16);
            this.lblTujuan.TabIndex = 12;
            this.lblTujuan.Text = "Tujuan";
            // 
            // textBoxTujuan
            // 
            this.textBoxTujuan.Location = new System.Drawing.Point(193, 271);
            this.textBoxTujuan.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTujuan.Multiline = true;
            this.textBoxTujuan.Name = "textBoxTujuan";
            this.textBoxTujuan.Size = new System.Drawing.Size(285, 49);
            this.textBoxTujuan.TabIndex = 13;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(69, 347);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(58, 16);
            this.lblTanggal.TabIndex = 14;
            this.lblTanggal.Text = "Tanggal";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(193, 344);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(285, 22);
            this.dateTimePicker.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "Petugas";
            // 
            // btnMenampilkanData
            // 
            this.btnMenampilkanData.Location = new System.Drawing.Point(543, 185);
            this.btnMenampilkanData.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenampilkanData.Name = "btnMenampilkanData";
            this.btnMenampilkanData.Size = new System.Drawing.Size(283, 36);
            this.btnMenampilkanData.TabIndex = 20;
            this.btnMenampilkanData.Text = "Menampilkan Data";
            this.btnMenampilkanData.UseVisualStyleBackColor = true;
            this.btnMenampilkanData.Click += new System.EventHandler(this.MenampilkanData_Click);
            // 
            // btnMenambahkanData
            // 
            this.btnMenambahkanData.Location = new System.Drawing.Point(543, 234);
            this.btnMenambahkanData.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenambahkanData.Name = "btnMenambahkanData";
            this.btnMenambahkanData.Size = new System.Drawing.Size(283, 35);
            this.btnMenambahkanData.TabIndex = 21;
            this.btnMenambahkanData.Text = "Menambahkan Data";
            this.btnMenambahkanData.UseVisualStyleBackColor = true;
            this.btnMenambahkanData.Click += new System.EventHandler(this.MenambahkanData_Click);
            // 
            // btnMengubahData
            // 
            this.btnMengubahData.Location = new System.Drawing.Point(543, 282);
            this.btnMengubahData.Margin = new System.Windows.Forms.Padding(2);
            this.btnMengubahData.Name = "btnMengubahData";
            this.btnMengubahData.Size = new System.Drawing.Size(283, 35);
            this.btnMengubahData.TabIndex = 22;
            this.btnMengubahData.Text = "Mengubah Data";
            this.btnMengubahData.UseVisualStyleBackColor = true;
            this.btnMengubahData.Click += new System.EventHandler(this.MengubahData_Click);
            // 
            // btnMenghapusData
            // 
            this.btnMenghapusData.Location = new System.Drawing.Point(543, 328);
            this.btnMenghapusData.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenghapusData.Name = "btnMenghapusData";
            this.btnMenghapusData.Size = new System.Drawing.Size(283, 35);
            this.btnMenghapusData.TabIndex = 23;
            this.btnMenghapusData.Text = "Menghapus Data";
            this.btnMenghapusData.UseVisualStyleBackColor = true;
            this.btnMenghapusData.Click += new System.EventHandler(this.MenghapusData_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.Location = new System.Drawing.Point(853, 136);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(283, 35);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnMembukaKoneksi
            // 
            this.btnMembukaKoneksi.Location = new System.Drawing.Point(543, 136);
            this.btnMembukaKoneksi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMembukaKoneksi.Name = "btnMembukaKoneksi";
            this.btnMembukaKoneksi.Size = new System.Drawing.Size(283, 36);
            this.btnMembukaKoneksi.TabIndex = 25;
            this.btnMembukaKoneksi.Text = "Membuka Koneksi";
            this.btnMembukaKoneksi.UseVisualStyleBackColor = true;
            this.btnMembukaKoneksi.Click += new System.EventHandler(this.MembukaKoneksi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.btnMembukaKoneksi);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMenghapusData);
            this.Controls.Add(this.btnMengubahData);
            this.Controls.Add(this.btnMenambahkanData);
            this.Controls.Add(this.btnMenampilkanData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.textBoxTujuan);
            this.Controls.Add(this.lblTujuan);
            this.Controls.Add(this.textBoxAsalDaerah);
            this.Controls.Add(this.lblAsalDaerah);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Label lblAsalDaerah;
        private System.Windows.Forms.TextBox textBoxAsalDaerah;
        private System.Windows.Forms.Label lblTujuan;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMenampilkanData;
        private System.Windows.Forms.Button btnMenambahkanData;
        private System.Windows.Forms.Button btnMengubahData;
        private System.Windows.Forms.Button btnMenghapusData;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMembukaKoneksi;
        private System.Windows.Forms.TextBox textBoxTujuan;
    }
}