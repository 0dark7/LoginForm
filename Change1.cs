using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Change1 : Form
    {
        private MySqlConnection connection;
        private string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";
        private string kullaniciAdi;

        public Change1(string kullaniciAdi)
        {
            InitializeComponent();
            this.kullaniciAdi = kullaniciAdi;
            connection = new MySqlConnection(connectionString);
        }

        private void btnCnfm_Click(object sender, EventArgs e)
        {
            string newUsername = txtNUser.Text;
            string newFname = txtNFname.Text;
            string newLname = txtNLname.Text;
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

                string updateQuery = "UPDATE users SET kullanici = @newUsername, ad = @newFname, soyad = @newLname, kullaniciPass = @newPassword WHERE kullanici = @kullaniciAdi";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@newUsername", newUsername);
                updateCmd.Parameters.AddWithValue("@newFname", newFname);
                updateCmd.Parameters.AddWithValue("@newLname", newLname);
                updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                updateCmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                int rowsAffected = updateCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Bilgiler başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bilgiler güncellenemedi. Mevcut şifre yanlış olabilir veya kullanıcı adı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Panel1 pnl1 = new Panel1(kullaniciAdi);
            pnl1.Show();
        }
    }
}
