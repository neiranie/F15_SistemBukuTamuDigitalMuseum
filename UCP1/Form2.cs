using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UCP1
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=MIFTAHULJANNAH\\MIFTAHJW;Initial Catalog=DBBukuTamuMuseum;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
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

        private void Kirim_Click(object sender, EventArgs e)
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

                if (!IsValidTanggal(dateTimePicker1.Value, out string pesanTanggal))
                {
                    MessageBox.Show(pesanTanggal, "Periksa Kembali Tanggal",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dateTimePicker1.Focus();
                    return;
                }

                SqlCommand cmd = new SqlCommand("sp_InsertBukuTamu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nama", textBoxNama.Text.Trim());
                cmd.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text.Trim());
                cmd.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text.Trim());
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker1.Value.Date);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil dikirim", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("duplikasi") || ex.Message.Contains("sudah ada"))
                {
                    MessageBox.Show("Data sudah ada, tidak boleh duplikasi!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(
                        "Data gagal dikirim karena ada gangguan pada database. Mohon coba lagi.",
                        "Gagal Mengirim Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            textBoxNama.Clear();
            textBoxAsalDaerah.Clear();
            textBoxTujuan.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBoxNama.Focus();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult konfirmasi = MessageBox.Show(
                "Apakah kamu yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (konfirmasi == DialogResult.Yes)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();

                Form3 form3 = new Form3();
                form3.Show();
                this.Close();
            }
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {
        }
    }
}