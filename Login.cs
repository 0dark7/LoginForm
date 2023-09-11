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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string ConStr = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";
            using (var baglan = new MySqlConnection(ConStr))
            {
                using (var komut = new MySqlCommand("SELECT kullanici FROM users ORDER BY kullanici ASC", baglan))
                {
                    try
                    {
                        komut.Connection.Open();
                        MySqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            comboUser.Items.Add(dr["kullanici"].ToString());
                        }
                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show(hata.Message);
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = comboUser.Text;
            string sifre = txtPass.Text;

            Metod metod = new Metod();
            int rol = metod.KullaniciRolunuGetir(kullaniciAdi, sifre);

            if (rol == 0)
            {
                Panel0 panel0Form = new Panel0(kullaniciAdi);
                this.Hide();
                panel0Form.Show();
            }
            else if (rol == 1)
            {
                Panel1 panel1Form = new Panel1(kullaniciAdi);
                this.Hide();
                panel1Form.Show();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot frgt = new Forgot();
            this.Hide();
            frgt.Show();
        }
    }
}
