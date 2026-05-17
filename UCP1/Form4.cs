using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace UCP1
{
    public partial class Form4 : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString =
            "Data Source=MIFTAHULJANNAH\\MIFTAHJW;Initial Catalog=DBBukuTamuMuseum;Integrated Security=True";

        public Form4()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (textBoxUsername.Text == "")
                {
                    MessageBox.Show("Username harus diisi", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxUsername.Focus();
                    return;
                }
                if (textBoxPassword.Text == "")
                {
                    MessageBox.Show("Password harus diisi", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPassword.Focus();
                    return;
                }

            }
            string queryInjection = "SELECT * FROM Petugas WHERE username = '"
                    + textBoxUsername.Text + "' AND password = '"
                    + textBoxPassword.Text + "'";

            SqlCommand cmdInjection = new SqlCommand(queryInjection, conn);
            SqlDataReader reader = cmdInjection.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Login berhasil! Selamat datang, " + reader["nama"].ToString(),
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                reader.Close();


