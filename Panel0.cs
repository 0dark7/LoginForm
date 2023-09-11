using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{

    public partial class Panel0 : Form
    {
        private string kullaniciAdi;
        private string gercekAd;

        public Panel0(string username)
        {
            InitializeComponent();
            kullaniciAdi = username;
        }

        private void Panel0_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel0_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lgn = new Login();
            lgn.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hesabınızı silmek istediğinizden emin misiniz?", "Hesap Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM users WHERE kullanici = @kullaniciAdi";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Hesabınız başarıyla silindi. Oturumunuz kapatılacak.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                            Login lgn = new Login();
                            lgn.Show();
                        }
                        else
                        {
                            MessageBox.Show("Hesabınızı silme başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Change0 chgn = new Change0(kullaniciAdi);
            chgn.Show();
        }
    }
}
