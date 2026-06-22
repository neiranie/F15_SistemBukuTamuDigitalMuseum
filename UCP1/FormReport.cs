using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace UCP1
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(Application.StartupPath + "\\LaporanKunjungan.rpt");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}