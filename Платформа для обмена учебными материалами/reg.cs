using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Платформа_для_обмена_учебными_материалами
{
    public partial class reg: Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length != 0 || txtPassword.Text.Length != 0 || txtConfirmPassword.Text.Length != 0 || txtMail.Text.Length != 0 || txtName.Text.Length != 0 || txtSurname.Text.Length != 0 || txtSecName.Text.Length != 0)
            {
                if (txtConfirmPassword.Text == txtPassword.Text)
                {

                    auth.con.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Users (login, password, fio, mail, id_role, date_reg) VALUES (@login, @password, @fio, @mail, 2, @date)", auth.con);
                    sqlCommand.Parameters.AddWithValue("@login", auth.md5(txtLogin.Text));
                    sqlCommand.Parameters.AddWithValue("@password", auth.md5(txtPassword.Text));
                    sqlCommand.Parameters.AddWithValue("@fio", $"{txtSurname.Text} {txtName.Text} {txtSecName.Text}");
                    sqlCommand.Parameters.AddWithValue("@mail", txtMail.Text);
                    sqlCommand.Parameters.AddWithValue("@date", date.Value);
                    sqlCommand.ExecuteNonQuery();
                    auth.con.Close();
                    MessageBox.Show("Успешая регистрация");
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                    txtConfirmPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Одно или несколько полей пустые!");
            }
        }

        private void linkLblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            auth auth = new auth();
            auth.Show();
        }
    }
}
