using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Edit : Form
    {
        private string ad;
        private string soyad;

        public Edit(string ad, string soyad)
        {
            InitializeComponent();
            this.ad = ad;
            this.soyad = soyad;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            txtNFname.Text = ad;
            txtNLname.Text = soyad;
        }

        private void btnCnfm_Click(object sender, EventArgs e)
        {
            string newAd = txtNFname.Text;
            string newSoyad = txtNLname.Text;
            string newPassword = txtNPass.Text;
            string newPassword1 = txtNPass1.Text;

            if (newPassword != newPassword1)
            {
                MessageBox.Show("Şifre ve şifre onayı uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE users SET ad = @newAd, soyad = @newSoyad, kullaniciPass = @newPassword WHERE ad = @ad AND soyad = @soyad";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@newAd", newAd);
                    cmd.Parameters.AddWithValue("@newSoyad", newSoyad);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show($"{ad} {soyad} kullanıcısı başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{ad} {soyad} kullanıcısını güncelleme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.Close();
            Panel1 pnl1 = new Panel1(ad);
            pnl1.Show();
        }

    }
}
