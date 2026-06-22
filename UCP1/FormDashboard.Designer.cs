namespace UCP1
{
    partial class FormDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lblJudulSemua = new System.Windows.Forms.Label();
            this.lblJudulHariIni = new System.Windows.Forms.Label();
            this.lblJudulBulanIni = new System.Windows.Forms.Label();
            this.lblTotalSemua = new System.Windows.Forms.Label();
            this.lblHariIni = new System.Windows.Forms.Label();
            this.lblBulanIni = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.chartKunjungan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblUpdateTerakhir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartKunjungan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD MUSEUM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJudulSemua
            // 
            this.lblJudulSemua.AutoSize = true;
            this.lblJudulSemua.Location = new System.Drawing.Point(76, 114);
            this.lblJudulSemua.Name = "lblJudulSemua";
            this.lblJudulSemua.Size = new System.Drawing.Size(143, 20);
            this.lblJudulSemua.TabIndex = 1;
            this.lblJudulSemua.Text = "Total Semua Tamu";
            // 
            // lblJudulHariIni
            // 
            this.lblJudulHariIni.AutoSize = true;
            this.lblJudulHariIni.Location = new System.Drawing.Point(427, 114);
            this.lblJudulHariIni.Name = "lblJudulHariIni";
            this.lblJudulHariIni.Size = new System.Drawing.Size(103, 20);
            this.lblJudulHariIni.TabIndex = 2;
            this.lblJudulHariIni.Text = "Tamu Hari Ini";
            // 
            // lblJudulBulanIni
            // 
            this.lblJudulBulanIni.AutoSize = true;
            this.lblJudulBulanIni.Location = new System.Drawing.Point(766, 114);
            this.lblJudulBulanIni.Name = "lblJudulBulanIni";
            this.lblJudulBulanIni.Size = new System.Drawing.Size(115, 20);
            this.lblJudulBulanIni.TabIndex = 3;
            this.lblJudulBulanIni.Text = "Tamu Bulan Ini";
            // 
            // lblTotalSemua
            // 
            this.lblTotalSemua.AutoSize = true;
            this.lblTotalSemua.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSemua.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotalSemua.Location = new System.Drawing.Point(114, 134);
            this.lblTotalSemua.Name = "lblTotalSemua";
            this.lblTotalSemua.Size = new System.Drawing.Size(59, 64);
            this.lblTotalSemua.TabIndex = 4;
            this.lblTotalSemua.Text = "0";
            // 
            // lblHariIni
            // 
            this.lblHariIni.AutoSize = true;
            this.lblHariIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHariIni.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHariIni.Location = new System.Drawing.Point(449, 134);
            this.lblHariIni.Name = "lblHariIni";
            this.lblHariIni.Size = new System.Drawing.Size(59, 64);
            this.lblHariIni.TabIndex = 5;
            this.lblHariIni.Text = "0";
            // 
            // lblBulanIni
            // 
            this.lblBulanIni.AutoSize = true;
            this.lblBulanIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBulanIni.ForeColor = System.Drawing.Color.Tomato;
            this.lblBulanIni.Location = new System.Drawing.Point(799, 134);
            this.lblBulanIni.Name = "lblBulanIni";
            this.lblBulanIni.Size = new System.Drawing.Size(59, 64);
            this.lblBulanIni.TabIndex = 6;
            this.lblBulanIni.Text = "0";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(735, 580);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(123, 46);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.BackColor = System.Drawing.Color.Gray;
            this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKembali.ForeColor = System.Drawing.Color.White;
            this.btnKembali.Location = new System.Drawing.Point(601, 580);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(123, 46);
            this.btnKembali.TabIndex = 8;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // chartKunjungan
            // 
            chartArea2.Name = "ChartArea1";
            this.chartKunjungan.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartKunjungan.Legends.Add(legend2);
            this.chartKunjungan.Location = new System.Drawing.Point(172, 213);
            this.chartKunjungan.Name = "chartKunjungan";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartKunjungan.Series.Add(series2);
            this.chartKunjungan.Size = new System.Drawing.Size(686, 349);
            this.chartKunjungan.TabIndex = 9;
            this.chartKunjungan.Text = "chart1";
            // 
            // lblUpdateTerakhir
            // 
            this.lblUpdateTerakhir.AutoSize = true;
            this.lblUpdateTerakhir.Location = new System.Drawing.Point(76, 580);
            this.lblUpdateTerakhir.Name = "lblUpdateTerakhir";
            this.lblUpdateTerakhir.Size = new System.Drawing.Size(115, 20);
            this.lblUpdateTerakhir.TabIndex = 10;
            this.lblUpdateTerakhir.Text = "Memuat data...";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1443, 960);
            this.Controls.Add(this.lblUpdateTerakhir);
            this.Controls.Add(this.chartKunjungan);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblBulanIni);
            this.Controls.Add(this.lblHariIni);
            this.Controls.Add(this.lblTotalSemua);
            this.Controls.Add(this.lblJudulBulanIni);
            this.Controls.Add(this.lblJudulHariIni);
            this.Controls.Add(this.lblJudulSemua);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardMuseum";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartKunjungan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblJudulSemua;
        private System.Windows.Forms.Label lblJudulHariIni;
        private System.Windows.Forms.Label lblJudulBulanIni;
        private System.Windows.Forms.Label lblTotalSemua;
        private System.Windows.Forms.Label lblHariIni;
        private System.Windows.Forms.Label lblBulanIni;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKunjungan;
        private System.Windows.Forms.Label lblUpdateTerakhir;
    }
}