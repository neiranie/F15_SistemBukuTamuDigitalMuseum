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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 502);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 304);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(78, 170);
            this.lblNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(51, 20);
            this.lblNama.TabIndex = 8;
            this.lblNama.Text = "Nama";
            this.lblNama.Click += new System.EventHandler(this.lblNama_Click);
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(217, 170);
            this.textBoxNama.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNama.Multiline = true;
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(320, 60);
            this.textBoxNama.TabIndex = 9;
            // 
            // lblAsalDaerah
            // 
            this.lblAsalDaerah.AutoSize = true;
            this.lblAsalDaerah.Location = new System.Drawing.Point(78, 256);
            this.lblAsalDaerah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsalDaerah.Name = "lblAsalDaerah";
            this.lblAsalDaerah.Size = new System.Drawing.Size(97, 20);
            this.lblAsalDaerah.TabIndex = 10;
            this.lblAsalDaerah.Text = "Asal Daerah";
            // 
            // textBoxAsalDaerah
            // 
            this.textBoxAsalDaerah.Location = new System.Drawing.Point(217, 254);
            this.textBoxAsalDaerah.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAsalDaerah.Multiline = true;
            this.textBoxAsalDaerah.Name = "textBoxAsalDaerah";
            this.textBoxAsalDaerah.Size = new System.Drawing.Size(320, 60);
            this.textBoxAsalDaerah.TabIndex = 11;
            // 
            // lblTujuan
            // 
            this.lblTujuan.AutoSize = true;
            this.lblTujuan.Location = new System.Drawing.Point(78, 339);
            this.lblTujuan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTujuan.Name = "lblTujuan";
            this.lblTujuan.Size = new System.Drawing.Size(57, 20);
            this.lblTujuan.TabIndex = 12;
            this.lblTujuan.Text = "Tujuan";
            // 
            // textBoxTujuan
            // 
            this.textBoxTujuan.Location = new System.Drawing.Point(217, 339);
            this.textBoxTujuan.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTujuan.Multiline = true;
            this.textBoxTujuan.Name = "textBoxTujuan";
            this.textBoxTujuan.Size = new System.Drawing.Size(320, 60);
            this.textBoxTujuan.TabIndex = 13;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(78, 434);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(66, 20);
            this.lblTanggal.TabIndex = 14;
            this.lblTanggal.Text = "Tanggal";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(217, 430);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(320, 26);
            this.dateTimePicker.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 38);
            this.label7.TabIndex = 16;
            this.label7.Text = "Petugas";
            // 
            // btnMenampilkanData
            // 
            this.btnMenampilkanData.Location = new System.Drawing.Point(611, 231);
            this.btnMenampilkanData.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenampilkanData.Name = "btnMenampilkanData";
            this.btnMenampilkanData.Size = new System.Drawing.Size(318, 45);
            this.btnMenampilkanData.TabIndex = 20;
            this.btnMenampilkanData.Text = "Menampilkan Data";
            this.btnMenampilkanData.UseVisualStyleBackColor = true;
            this.btnMenampilkanData.Click += new System.EventHandler(this.MenampilkanData_Click);
            // 
            // btnMenambahkanData
            // 
            this.btnMenambahkanData.Location = new System.Drawing.Point(611, 292);
            this.btnMenambahkanData.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenambahkanData.Name = "btnMenambahkanData";
            this.btnMenambahkanData.Size = new System.Drawing.Size(318, 44);
            this.btnMenambahkanData.TabIndex = 21;
            this.btnMenambahkanData.Text = "Menambahkan Data";
            this.btnMenambahkanData.UseVisualStyleBackColor = true;
            this.btnMenambahkanData.Click += new System.EventHandler(this.MenambahkanData_Click);
            // 
            // btnMengubahData
            // 
            this.btnMengubahData.Location = new System.Drawing.Point(611, 352);
            this.btnMengubahData.Margin = new System.Windows.Forms.Padding(2);
            this.btnMengubahData.Name = "btnMengubahData";
            this.btnMengubahData.Size = new System.Drawing.Size(318, 44);
            this.btnMengubahData.TabIndex = 22;
            this.btnMengubahData.Text = "Mengubah Data";
            this.btnMengubahData.UseVisualStyleBackColor = true;
            this.btnMengubahData.Click += new System.EventHandler(this.MengubahData_Click);
            // 
            // btnMenghapusData
            // 
            this.btnMenghapusData.Location = new System.Drawing.Point(611, 410);
            this.btnMenghapusData.Margin = new System.Windows.Forms.Padding(2);
            this.btnMenghapusData.Name = "btnMenghapusData";
            this.btnMenghapusData.Size = new System.Drawing.Size(318, 44);
            this.btnMenghapusData.TabIndex = 23;
            this.btnMenghapusData.Text = "Menghapus Data";
            this.btnMenghapusData.UseVisualStyleBackColor = true;
            this.btnMenghapusData.Click += new System.EventHandler(this.MenghapusData_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Salmon;
            this.btnLogout.Location = new System.Drawing.Point(960, 170);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(318, 44);
            this.btnLogout.TabIndex = 24;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnMembukaKoneksi
            // 
            this.btnMembukaKoneksi.Location = new System.Drawing.Point(611, 170);
            this.btnMembukaKoneksi.Margin = new System.Windows.Forms.Padding(2);
            this.btnMembukaKoneksi.Name = "btnMembukaKoneksi";
            this.btnMembukaKoneksi.Size = new System.Drawing.Size(318, 45);
            this.btnMembukaKoneksi.TabIndex = 25;
            this.btnMembukaKoneksi.Text = "Membuka Koneksi";
            this.btnMembukaKoneksi.UseVisualStyleBackColor = true;
            this.btnMembukaKoneksi.Click += new System.EventHandler(this.MembukaKoneksi_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1443, 33);
            this.bindingNavigator1.TabIndex = 26;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 844);
            this.Controls.Add(this.bindingNavigator1);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
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
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}