using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Change0 : Form
    {
        private MySqlConnection connection;
        private string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";
        private string kullaniciAdi;

        public Change0(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
            connection = new MySqlConnection(connectionString);
        }

        private void btnCnfm_Click(object sender, EventArgs e)
        {
            string currentPassword = txtOldPass.Text;
            string newPassword = txtNPass.Text;
            string newPassword1 = txtNPass1.Text;

            if (newPassword != newPassword1)
            {
                MessageBox.Show("Yeni şifreler uyuşmuyor. Lütfen doğru şifreleri girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();
                string updateQuery = "UPDATE users SET kullaniciPass = @newPassword WHERE kullanici = @kullaniciAdi AND kullaniciPass = @currentPassword";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                updateCmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                updateCmd.Parameters.AddWithValue("@currentPassword", currentPassword);

                int rowsAffected = updateCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Şifre başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Şifre güncellenemedi. Mevcut şifre yanlış olabilir veya kullanıcı adı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Panel0 pnl0 = new Panel0(kullaniciAdi);
            pnl0.Show();
        }
    }
}
