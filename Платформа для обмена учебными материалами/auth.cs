using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Платформа_для_обмена_учебными_материалами
{
    public partial class auth : Form
    {
        public static string ConnectString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db.mdf;Integrated Security=True";
        public static SqlConnection con;
        public auth()
        {
            InitializeComponent();
            con = new SqlConnection(ConnectString);
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT id, login, password, id_role FROM Users WHERE login = @login AND password = @password", con);
            sqlCommand.Parameters.AddWithValue("@login", md5(txtLogin.Text));
            sqlCommand.Parameters.AddWithValue("@password", md5(txtPassword.Text));
            SqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                switch(reader[3].ToString())
                {
                    case "1":       // ADMIN
                        this.Hide();
                        admin.admin admin = new admin.admin(this, Convert.ToInt32(reader[0].ToString()));
                        admin.Show();
                        break;
                    case "2":       // USER
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
            con.Close();
        }
        public static string md5(string input)
        {
            return BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(input))).Replace("-", "");
        }

        private void linkLblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg reg = new reg();
            reg.Show();
        }

        private void auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
