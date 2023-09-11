using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3
{
    internal class Metod
    {
        #region kullanici kontrol
        string ConStr = "SERVER=localhost;DATABASE=testdb;UID=root;PWD=0000";
        public int KullaniciKontrol(string kTip, string kPass, int rol)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(ConStr))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT kullanici, kullaniciPass, role  FROM users WHERE kullanici='{kTip}' AND kullaniciPass='{kPass}'";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        using (var dtr = cmd.ExecuteReader())
                        {
                            if (dtr.Read())
                            {
                                string d_k = dtr["kullanici"].ToString();
                                string d_p = dtr["kullaniciPass"].ToString();
                                if (d_k == kTip && d_p == kPass)
                                {
                                    sonuc = 1;
                                }
                                else
                                {
                                    sonuc = 0;
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    sonuc = 0;
                }
            }
            return sonuc;
        }
        #endregion
        public int KullaniciRolunuGetir(string kTip, string kPass)
        {
            int rol = -1;
            using (var con = new MySqlConnection(ConStr))
            {
                try
                {
                    con.Open();
                    string query = $"SELECT role FROM users WHERE kullanici='{kTip}' AND kullaniciPass='{kPass}'";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            rol = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception)
                {
                    rol = -1;
                }
            }
            return rol;
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
