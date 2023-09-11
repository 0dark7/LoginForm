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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtUser.Text;
            string ad = txtFname.Text;
            string soyad = txtLname.Text;
            string sifre = txtPass.Text;
            string sifreOnay = txtPass1.Text;

            if (sifre != sifreOnay)
            {
                MessageBox.Show("Şifre ve şifre onayı uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string connectionString = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO users (kullanici, kullaniciPass, ad, soyad) VALUES (@kullaniciAdi, @sifre, @ad, @soyad)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);

                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Kullanıcı başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı kaydetme başarısız oldu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Panel1 pnl1 = new Panel1(Text);
            pnl1.Show();
        }
    }
}
