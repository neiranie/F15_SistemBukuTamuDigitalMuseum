using System;
using System.Windows.Forms;

namespace UCP1
{
    public partial class Form3 : Form  
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnPengunjung_Click(object sender, EventArgs e)
        {
            Form2 formPengunjung = new Form2();
            formPengunjung.Show();
            this.Hide();
        }

        private void btnPetugas_Click(object sender, EventArgs e)
        {
            Form4 formLogin = new Form4();
            formLogin.Show();
            this.Hide();
        }
    }
}