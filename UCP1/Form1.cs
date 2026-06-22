using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UCP1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=MIFTAHULJANNAH\\MIFTAHJW;Initial Catalog=DBBukuTamuMuseum;Integrated Security=True";

        private int selectedId = 0;
        private DataTable dataTable = new DataTable();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);

            btnMenampilkanData.Enabled = false;
            btnMenambahkanData.Enabled = false;
            btnMengubahData.Enabled = false;
            btnMenghapusData.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            bindingNavigator1.BindingSource = bindingSource;
        }

        private bool IsValidText(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;
            if (text.Trim().Length < 2) return false;
            return Regex.IsMatch(text.Trim(), @"^[a-zA-Z\s]+$");
        }

        private bool IsValidTanggal(DateTime tanggal, out string pesanError)
        {
            DateTime hariIni = DateTime.Today;

            if (tanggal.Date != hariIni)
            {
                pesanError = "Tanggal kunjungan hanya bisa diisi dengan tanggal hari ini.";
                return false;
            }

            pesanError = string.Empty;
            return true;
        }

        private bool ValidasiTeksForm()
        {
            if (!IsValidText(textBoxNama.Text))
            {
                MessageBox.Show(
                    "Nama belum diisi dengan benar.\n\nMohon isi minimal 2 huruf, tanpa angka atau simbol (contoh: Budi Santoso).",
                    "Periksa Kembali Nama", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNama.Focus();
                return false;
            }
            if (!IsValidText(textBoxAsalDaerah.Text))
            {
                MessageBox.Show(
                    "Asal Daerah belum diisi dengan benar.\n\nMohon isi minimal 2 huruf, tanpa angka atau simbol (contoh: Bandung).",
                    "Periksa Kembali Asal Daerah", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAsalDaerah.Focus();
                return false;
            }
            if (!IsValidText(textBoxTujuan.Text))
            {
                MessageBox.Show(
                    "Tujuan kunjungan belum diisi dengan benar.\n\nMohon isi minimal 2 huruf, tanpa angka atau simbol (contoh: Penelitian).",
                    "Periksa Kembali Tujuan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxTujuan.Focus();
                return false;
            }
            return true;
        }

        private bool ValidasiFormTambah()
        {
            if (!ValidasiTeksForm()) return false;

            if (!IsValidTanggal(dateTimePicker.Value, out string pesanTanggal))
            {
                MessageBox.Show(pesanTanggal, "Periksa Kembali Tanggal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker.Focus();
                return false;
            }
            return true;
        }

        private bool ValidasiFormUbah()
        {
            return ValidasiTeksForm();
        }

        private void MembukaKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MessageBox.Show("Berhasil tersambung ke database museum.", "Koneksi Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnMenampilkanData.Enabled = true;
                btnMenambahkanData.Enabled = true;
                btnMengubahData.Enabled = true;
                btnMenghapusData.Enabled = true;
                btnMembukaKoneksi.Enabled = false;
                btnSearch.Enabled = true;

                HitungTotalTamu();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Tidak bisa tersambung ke database.\n\nMohon periksa apakah SQL Server sudah menyala dan koneksi jaringan Anda normal.",
                    "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Terjadi gangguan saat mencoba tersambung ke database. Mohon coba lagi beberapa saat.",
                    "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenampilkanData_Click(object sender, EventArgs e)
        {
            TampilkanSemuaData();
        }

        private void TampilkanSemuaData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("sp_GetAllBukuTamu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;

                if (dataGridView1.Columns["idTamu"] != null)
                    dataGridView1.Columns["idTamu"].Visible = false;

                HitungTotalTamu();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Data tidak dapat ditampilkan saat ini. Mohon pastikan koneksi database masih aktif.",
                    "Gagal Menampilkan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HitungTotalTamu()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("sp_CountBukuTamu", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                object hasil = cmd.ExecuteScalar();
                lblTotal.Text = "Total: " + Convert.ToInt32(hasil).ToString();
            }
            catch (SqlException)
            {
                lblTotal.Text = "Total: -";
            }
        }

        private void MenambahkanData_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (!ValidasiFormTambah()) return;

                SqlCommand cmd = new SqlCommand("sp_InsertBukuTamu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text.Trim());
                cmd.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text.Trim());
                cmd.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text.Trim());
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker.Value.Date);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data tamu berhasil ditambahkan. Terima kasih!", "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                TampilkanSemuaData();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("duplikasi") || ex.Message.Contains("sudah ada"))
                {
                    MessageBox.Show(
                        "Sepertinya data ini sudah pernah dicatat sebelumnya (nama, asal, tujuan, dan tanggal yang sama).",
                        "Data Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Data gagal disimpan karena ada gangguan pada database. Mohon coba lagi.",
                        "Gagal Menambahkan Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MengubahData_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (selectedId == 0)
                {
                    MessageBox.Show(
                        "Silakan pilih salah satu baris data di tabel terlebih dahulu sebelum mengubah.",
                        "Belum Ada Data Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidasiFormUbah()) return;

                SqlCommand cmd = new SqlCommand("sp_UpdateBukuTamu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTamu", selectedId);
                cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text.Trim());
                cmd.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text.Trim());
                cmd.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text.Trim());
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker.Value.Date);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil diperbarui.", "Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                TampilkanSemuaData();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Tidak ada perubahan"))
                {
                    MessageBox.Show(
                        "Tidak ada perubahan yang terdeteksi pada data ini.",
                        "Tidak Ada Perubahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("sama sudah ada"))
                {
                    MessageBox.Show(
                        "Data dengan nama, asal, tujuan, dan tanggal yang sama sudah ada pada catatan lain.",
                        "Data Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Perubahan gagal disimpan karena ada gangguan pada database. Mohon coba lagi.",
                        "Gagal Mengubah Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MenghapusData_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (selectedId == 0)
                {
                    MessageBox.Show(
                        "Silakan pilih salah satu baris data di tabel terlebih dahulu sebelum menghapus.",
                        "Belum Ada Data Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultConfirm = MessageBox.Show(
                    "Data yang dihapus tidak dapat dikembalikan. Yakin ingin menghapus data ini?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("sp_DeleteBukuTamu", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdTamu", selectedId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus.", "Berhasil",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    TampilkanSemuaData();
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("tidak ditemukan"))
                {
                    MessageBox.Show(
                        "Data yang ingin dihapus tidak ditemukan. Mungkin sudah dihapus sebelumnya.",
                        "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(
                        "Data gagal dihapus karena ada gangguan pada database. Mohon coba lagi.",
                        "Gagal Menghapus Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CariData();
        }

        private void CariData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string keyword = textBoxSearch.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    TampilkanSemuaData();
                    return;
                }

                SqlCommand cmd = new SqlCommand("sp_SearchBukuTamu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", keyword);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;

                if (dataGridView1.Columns["idTamu"] != null)
                    dataGridView1.Columns["idTamu"].Visible = false;

                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show(
                        $"Tidak ada data yang cocok dengan pencarian \"{keyword}\".",
                        "Data Tidak Ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                textBoxSearch.Clear();
                textBoxSearch.Focus();
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Pencarian gagal dilakukan karena ada gangguan pada database. Mohon coba lagi.",
                    "Gagal Mencari Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["idTamu"].Value);
                textBoxNama.Text = row.Cells["namaLengkap"].Value.ToString();
                textBoxAsalDaerah.Text = row.Cells["asalDaerah"].Value.ToString();
                textBoxTujuan.Text = row.Cells["keperluan"].Value.ToString();

                // dateTimePicker diisi tanggal ASLI dari data yang dipilih
                // (bukan tanggal hari ini), supaya saat tombol "Ubah" ditekan,
                // tanggal kunjungan yang lama tetap tersimpan apa adanya
                // kecuali memang sengaja diganti oleh pengguna.
                dateTimePicker.Value = Convert.ToDateTime(row.Cells["tanggal"].Value);
            }
        }

        private void ClearForm()
        {
            selectedId = 0;
            textBoxNama.Clear();
            textBoxAsalDaerah.Clear();
            textBoxTujuan.Clear();
            dateTimePicker.Value = DateTime.Now;
            textBoxNama.Focus();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "Yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                Form3 formWelcome = new Form3();
                formWelcome.Show();
                this.Close();
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.ShowDialog();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            FormReport laporan = new FormReport();
            laporan.ShowDialog();
        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx;*.xls";
            ofd.Title = "Pilih File Excel";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    OfficeOpenXml.ExcelPackage.License.SetNonCommercialPersonal("UCP1");

                    using (var package = new OfficeOpenXml.ExcelPackage(new System.IO.FileInfo(ofd.FileName)))
                    {
                        var sheet = package.Workbook.Worksheets[0];
                        int rowCount = sheet.Dimension.Rows;
                        int berhasil = 0;
                        int gagal = 0;

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            for (int row = 2; row <= rowCount; row++) // baris 1 = header
                            {
                                try
                                {
                                    string nama = sheet.Cells[row, 1].Text;
                                    string asal = sheet.Cells[row, 2].Text;
                                    string keperluan = sheet.Cells[row, 3].Text;
                                    string tanggal = sheet.Cells[row, 4].Text;

                                    if (string.IsNullOrEmpty(nama)) continue;

                                    SqlCommand cmd = new SqlCommand("sp_InsertBukuTamu", conn);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@Nama", nama);
                                    cmd.Parameters.AddWithValue("@AsalDaerah", asal);
                                    cmd.Parameters.AddWithValue("@Tujuan", keperluan);
                                    cmd.Parameters.AddWithValue("@Tanggal", Convert.ToDateTime(tanggal));
                                    cmd.ExecuteNonQuery();
                                    berhasil++;
                                }
                                catch
                                {
                                    gagal++;
                                }
                            }
                        }

                        MessageBox.Show($"Import selesai!\nBerhasil: {berhasil} data\nGagal/Skip: {gagal} data",
                            "Import Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh data di tabel
                        TampilkanSemuaData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Gagal Import",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblNama_Click(object sender, EventArgs e) { }

        private void lblTotal_Click(object sender, EventArgs e) { }

        private void textBoxSearch_TextChanged(object sender, EventArgs e) { }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CariData();
                e.Handled = true;
            }
        }
    }
}