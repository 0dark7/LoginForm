using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Forgot : Form
    {
        public Forgot()
        {
            InitializeComponent();
        }

        private void txtRecname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRecLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            string ad = txtRecname.Text;
            string soyad = txtRecLname.Text;

            string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT kullaniciPass FROM users WHERE ad = @ad AND soyad = @soyad";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string kullaniciSifre = result.ToString();

                        MessageBox.Show($"Şifreniz: {kullaniciSifre}", "Şifre Hatırlatma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı veya bilgiler hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lgn = new Login();
            lgn.Show();
        }
    }
}
