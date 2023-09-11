using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    public partial class Panel1 : Form
    {
        private string kullaniciAdi;
        private string gercekAd;
        public Panel1(string username)
        {
            InitializeComponent();
            kullaniciAdi = username;

        }
        private void Panel1_Load(object sender, EventArgs e)
        {
            string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ad, soyad FROM users WHERE kullanici = @kullaniciAdi";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            gercekAd = $"{reader["ad"]} {reader["soyad"]}";
                        }
                    }
                }

                label10.Text = $"Hoş geldiniz, {gercekAd}";

                query = "SELECT ad, soyad, role FROM users";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBox1.Items.Clear();

                        while (reader.Read())
                        {
                            string ad = reader["ad"].ToString();
                            string soyad = reader["soyad"].ToString();
                            int role = Convert.ToInt32(reader["role"]);

                            string satir = $"{ad} {soyad}";
                            if (role == 1)
                            {
                                satir += " 🔑";
                            }

                            listBox1.Items.Add(satir);
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminicon_Click(object sender, EventArgs e)
        {

            string kullaniciAdi = adminicon.Tag.ToString();

            string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"UPDATE users SET role = 1 WHERE kullanici = '{kullaniciAdi}'";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show($"Kullanıcı {kullaniciAdi} artık bir admindir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Kullanıcı {kullaniciAdi} admin yapma başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lgn = new Login();
            lgn.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string selectedUser = listBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUser))
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] userParts = selectedUser.Split(' ');
            if (userParts.Length != 2)
            {
                MessageBox.Show("Geçersiz kullanıcı adı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ad = userParts[0];
            string soyad = userParts[1];

            string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM users WHERE ad = @ad AND soyad = @soyad";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show($"{ad} {soyad} kullanıcısı başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Panel1_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show($"{ad} {soyad} kullanıcısını silme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string selectedUser = listBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUser))
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] userParts = selectedUser.Split(' ');
            if (userParts.Length != 2)
            {
                MessageBox.Show("Geçersiz kullanıcı adı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ad = userParts[0];
            string soyad = userParts[1];

            string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE users SET role = 1 WHERE ad = @ad AND soyad = @soyad";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show($"{ad} {soyad} artık bir admindir.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Panel1_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show($"{ad} {soyad} kullanıcısını admin yapma başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedUser = listBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUser))
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] userParts = selectedUser.Split(' ');
            if (userParts.Length != 2)
            {
                MessageBox.Show("Geçersiz kullanıcı adı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ad = userParts[0];
            string soyad = userParts[1];

            Edit edt = new Edit(ad, soyad);
            edt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Change1 chgn = new Change1(kullaniciAdi);
            chgn.Show();
        }
    }
}
