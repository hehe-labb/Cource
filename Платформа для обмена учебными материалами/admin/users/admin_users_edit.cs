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
using static Платформа_для_обмена_учебными_материалами.admin.users.admin_users;

namespace Платформа_для_обмена_учебными_материалами.admin.users
{
    public partial class admin_users_edit: Form
    {
        private int id;
        private admin_users admin;
        public admin_users_edit(int id, admin_users admin_Users)
        {
            this.admin = admin_Users;
            this.id = id;
            InitializeComponent();
        }
        public class ComboBoxItem1
        {
            public string Text { get; set; }
            public int Tag { get; set; }

            public override string ToString()
            {
                return Text; // Отображаемый текст в ComboBox
            }
        }
        private void admin_users_edit_Load(object sender, EventArgs e)
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
            Reader.Close();

            SqlCommand DataCommand1 = new SqlCommand("SELECT * FROM Users WHERE id = @id", auth.con);
            DataCommand1.Parameters.AddWithValue("@id", id);
            SqlDataReader Reader1 = DataCommand1.ExecuteReader();

            Reader1.Read();
            foreach (ComboBoxItem1 item in cbRole.Items)
            {
                if (item.Tag == Convert.ToInt32(Reader1[5]))
                {
                    cbRole.SelectedItem = item;
                    break;
                }
            }
            txtId.Text = Reader1[0].ToString();
            txtFIO.Text = Reader1[3].ToString();
            txtEmail.Text = Reader1[4].ToString();
            date.Text = Reader1[6].ToString();
            auth.con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите изменить эту запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                auth.con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET fio = @fio, mail = @mail, id_role = @role, date_reg = @date WHERE id = @Id", auth.con);

                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@fio", txtFIO.Text);
                cmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                cmd.Parameters.AddWithValue("@role", ((ComboBoxItem1)cbRole.SelectedItem).Tag.ToString());
                cmd.Parameters.AddWithValue("@date", date.Value);

                cmd.ExecuteNonQuery();
                auth.con.Close();
                this.Close();
                admin.DgvMain_Update();
            }
        }
    }
}
