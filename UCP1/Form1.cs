using System;
using System.Data;
using System.Data.SqlClient;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private bool IsValidText(string text)
        {
            if (text.Trim().Length < 2) return false;
            bool adaHuruf = false;
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    adaHuruf = true;
                    break;
                }
            }
            return adaHuruf;
        }

        private void MembukaKoneksi_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                MessageBox.Show("Koneksi berhasil", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnMenampilkanData.Enabled = true;
                btnMenambahkanData.Enabled = true;
                btnMengubahData.Enabled = true;
                btnMenghapusData.Enabled = true;
                btnMembukaKoneksi.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenampilkanData_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "SELECT idTamu, namaLengkap, asalDaerah, keperluan, tanggal FROM BukuTamu";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                dataTable = new DataTable();
                adapter.Fill(dataTable);

                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;

                dataGridView1.Columns["idTamu"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenambahkanData_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (!IsValidText(textBoxNama.Text))
                {
                    MessageBox.Show("Nama tidak valid! Minimal 2 karakter dan harus mengandung huruf.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNama.Focus();
                    return;
                }
                if (!IsValidText(textBoxAsalDaerah.Text))
                {
                    MessageBox.Show("Asal Daerah tidak valid! Minimal 2 karakter dan harus mengandung huruf.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxAsalDaerah.Focus();
                    return;
                }
                if (!IsValidText(textBoxTujuan.Text))
                {
                    MessageBox.Show("Tujuan tidak valid! Minimal 2 karakter dan harus mengandung huruf.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxTujuan.Focus();
                    return;
                }

                string queryCheck = @"SELECT COUNT(*) FROM BukuTamu 
                                      WHERE namaLengkap = @Nama 
                                      AND asalDaerah = @AsalDaerah 
                                      AND keperluan = @Tujuan 
                                      AND CAST(tanggal AS DATE) = CAST(@Tanggal AS DATE)";

                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmdCheck.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text);
                cmdCheck.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text);
                cmdCheck.Parameters.AddWithValue("@Tanggal", dateTimePicker.Value.Date);

                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Data sudah ada, tidak boleh duplikasi!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO BukuTamu
                                    (namaLengkap, asalDaerah, keperluan, tanggal)
                                 VALUES
                                    (@Nama, @AsalDaerah, @Tujuan, @Tanggal)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmd.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text);
                cmd.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text);
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker.Value.Date);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    MenampilkanData_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Pilih data dari tabel terlebih dahulu", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidText(textBoxNama.Text))
                {
                    MessageBox.Show("Nama tidak valid! Minimal 2 karakter dan harus mengandung huruf.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxNama.Focus();
                    return;
                }
                if (!IsValidText(textBoxAsalDaerah.Text))
                {
                    MessageBox.Show("Asal Daerah tidak valid! Minimal 2 karakter dan harus mengandung huruf.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxAsalDaerah.Focus();
                    return;
                }
                if (!IsValidText(textBoxTujuan.Text))
                {
                    MessageBox.Show("Tujuan tidak valid! Minimal 2 karakter dan harus mengandung huruf.",
                        "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxTujuan.Focus();
                    return;
                }

                string querySama = @"SELECT COUNT(*) FROM BukuTamu 
                                     WHERE idTamu = @IdTamu
                                     AND namaLengkap = @Nama 
                                     AND asalDaerah = @AsalDaerah 
                                     AND keperluan = @Tujuan 
                                     AND CAST(tanggal AS DATE) = CAST(@Tanggal AS DATE)";

                SqlCommand cmdSama = new SqlCommand(querySama, conn);
                cmdSama.Parameters.AddWithValue("@IdTamu", selectedId);
                cmdSama.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmdSama.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text);
                cmdSama.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text);
                cmdSama.Parameters.AddWithValue("@Tanggal", dateTimePicker.Value.Date);

                int countSama = (int)cmdSama.ExecuteScalar();
                if (countSama > 0)
                {
                    MessageBox.Show("Tidak ada perubahan data!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string queryCheck = @"SELECT COUNT(*) FROM BukuTamu 
                                      WHERE namaLengkap = @Nama 
                                      AND asalDaerah = @AsalDaerah 
                                      AND keperluan = @Tujuan 
                                      AND CAST(tanggal AS DATE) = CAST(@Tanggal AS DATE)
                                      AND idTamu != @IdTamu";

                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmdCheck.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text);
                cmdCheck.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text);
                cmdCheck.Parameters.AddWithValue("@Tanggal", dateTimePicker.Value.Date);
                cmdCheck.Parameters.AddWithValue("@IdTamu", selectedId);

                int count = (int)cmdCheck.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Data sama sudah ada, perubahan harus berbeda!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"UPDATE BukuTamu
                                 SET namaLengkap = @Nama,
                                     asalDaerah  = @AsalDaerah,
                                     keperluan   = @Tujuan,
                                     tanggal     = @Tanggal
                                 WHERE idTamu = @IdTamu";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdTamu", selectedId);
                cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmd.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text);
                cmd.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text);
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker.Value.Date);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil diubah", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    MenampilkanData_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Pilih data dari tabel terlebih dahulu", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultConfirm = MessageBox.Show(
                    "Yakin ingin menghapus data?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultConfirm == DialogResult.Yes)
                {
                    string query = "DELETE FROM BukuTamu WHERE idTamu = @IdTamu";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdTamu", selectedId);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        MenampilkanData_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                Form3 formWelcome = new Form3();
                formWelcome.Show();
                this.Close();
            }
        }

        private void lblNama_Click(object sender, EventArgs e)
        {
        }
    }
}