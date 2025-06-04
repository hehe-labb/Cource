using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Платформа_для_обмена_учебными_материалами.admin.users.admin_users_edit;

namespace Платформа_для_обмена_учебными_материалами.admin.users
{
    public partial class admin_users_add: Form
    {
        private admin_users admin;
        public admin_users_add(admin_users admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtFIO.Text == "" || txtLogin.Text == "" || txtPassword.Text == "") { return; }
            if (MessageBox.Show("Вы хотите добавить запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                auth.con.Open();
                SqlCommand DataCommand = new SqlCommand("INSERT INTO Users (fio, mail, id_role, login, password, date_reg) VALUES (@fio, @mail, @role, @login, @password, @date)", auth.con);
                DataCommand.Parameters.AddWithValue("@fio", txtFIO.Text);
                DataCommand.Parameters.AddWithValue("@mail", txtEmail.Text);
                DataCommand.Parameters.AddWithValue("@role", ((ComboBoxItem1)cbRole.SelectedItem).Tag.ToString());
                DataCommand.Parameters.AddWithValue("@login", auth.md5(txtLogin.Text));
                DataCommand.Parameters.AddWithValue("@password", auth.md5(txtPassword.Text));
                DataCommand.Parameters.AddWithValue("@date", date.Value);

                DataCommand.ExecuteNonQuery();
                auth.con.Close();
                admin.DgvMain_Update();
            }
        }

        private void admin_users_add_Load(object sender, EventArgs e)
        {
            auth.con.Open();
            SqlCommand DataCommand = new SqlCommand("SELECT * FROM Role", auth.con);
            SqlDataReader Reader = DataCommand.ExecuteReader();

            while (Reader.Read())
            {
                cbRole.Items.Add(new ComboBoxItem1 { Text = Reader[1].ToString(), Tag = Convert.ToInt32(Reader[0]) });
            }
            cbRole.DisplayMember = "Text";      // что отображать (название роли)
            cbRole.ValueMember = "Tag";         // что использовать как значение (ID)
            cbRole.SelectedIndex = 0;
            Reader.Close();
            auth.con.Close();
        }
    }
}
