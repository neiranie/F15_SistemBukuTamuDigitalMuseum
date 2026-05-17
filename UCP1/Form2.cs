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

                string queryCheck = @"SELECT COUNT(*) FROM BukuTamu 
                                      WHERE namaLengkap = @Nama 
                                      AND asalDaerah = @AsalDaerah 
                                      AND keperluan = @Tujuan 
                                      AND CAST(tanggal AS DATE) = CAST(@Tanggal AS DATE)";

                SqlCommand cmdCheck = new SqlCommand(queryCheck, conn);
                cmdCheck.Parameters.AddWithValue("@Nama", textBoxNama.Text);
                cmdCheck.Parameters.AddWithValue("@AsalDaerah", textBoxAsalDaerah.Text);
                cmdCheck.Parameters.AddWithValue("@Tujuan", textBoxTujuan.Text);
                cmdCheck.Parameters.AddWithValue("@Tanggal", dateTimePicker1.Value.Date);

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
                cmd.Parameters.AddWithValue("@Tanggal", dateTimePicker1.Value.Date);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil dikirim", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Data gagal dikirim", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
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