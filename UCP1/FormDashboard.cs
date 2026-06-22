using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UCP1
{
    public partial class FormDashboard : Form
    {
        private readonly string connectionString =
            "Data Source=MIFTAHULJANNAH\\MIFTAHJW;Initial Catalog=DBBukuTamuMuseum;Integrated Security=True";

        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            SetupChart();
            MuatDashboard();
        }

        private void SetupChart()
        {
            chartKunjungan.ChartAreas.Clear();
            chartKunjungan.Series.Clear();
            chartKunjungan.Legends.Clear();

            ChartArea area = new ChartArea("MainArea");
            area.AxisX.Title = "Bulan";
            area.AxisY.Title = "Jumlah Tamu";
            area.AxisY.Interval = 1;
            area.BackColor = Color.WhiteSmoke;
            area.AxisX.LabelStyle.Angle = -30;
            chartKunjungan.ChartAreas.Add(area);

            Series series = new Series("Kunjungan");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.SteelBlue;
            series.IsValueShownAsLabel = true;
            series.Font = new Font("Arial", 9, FontStyle.Bold);
            chartKunjungan.Series.Add(series);

            chartKunjungan.Titles.Clear();
            chartKunjungan.Titles.Add(new Title(
                "Grafik Kunjungan Tamu per Bulan — Tahun " + DateTime.Now.Year,
                Docking.Top,
                new Font("Arial", 11, FontStyle.Bold),
                Color.DarkSlateGray));

            chartKunjungan.BackColor = Color.White;
        }

        private void MuatDashboard()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_GetDashboardData", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);

                    // Total semua
                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        lblTotalSemua.Text = ds.Tables[0].Rows[0]["TotalSemua"].ToString();

                    // Hari ini
                    if (ds.Tables.Count > 1 && ds.Tables[1].Rows.Count > 0)
                        lblHariIni.Text = ds.Tables[1].Rows[0]["TotalHariIni"].ToString();

                    // Bulan ini
                    if (ds.Tables.Count > 2 && ds.Tables[2].Rows.Count > 0)
                        lblBulanIni.Text = ds.Tables[2].Rows[0]["TotalBulanIni"].ToString();

                    // Grafik per bulan
                    chartKunjungan.Series["Kunjungan"].Points.Clear();
                    if (ds.Tables.Count > 3)
                    {
                        foreach (DataRow row in ds.Tables[3].Rows)
                        {
                            chartKunjungan.Series["Kunjungan"].Points.AddXY(
                                row["NamaBulan"].ToString(),
                                Convert.ToInt32(row["JumlahTamu"]));
                        }
                    }

                    lblUpdateTerakhir.Text = "Update: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            catch (SqlException)
            {
                lblTotalSemua.Text = "-";
                lblHariIni.Text = "-";
                lblBulanIni.Text = "-";
                lblUpdateTerakhir.Text = "⚠ Gagal memuat data. Pastikan database aktif.";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            MuatDashboard();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}