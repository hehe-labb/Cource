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

namespace Платформа_для_обмена_учебными_материалами.admin.users
{
    public partial class admin_users: Form
    {
        private admin admin;
        public admin_users(admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Tag { get; set; }

            public override string ToString()
            {
                return Text; // Это будет отображаться в ComboBox
            }
        }
        private void admin_users_Load(object sender, EventArgs e)
        {
            // ПОИСК
            cbColumns.DisplayMember = "Text";
            cbColumns.ValueMember = "Tag";
            cbColumns.Items.Add(new ComboBoxItem { Text = "ID", Tag = "id" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "ФИО", Tag = "fio" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Почта", Tag = "mail" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Роль", Tag = "role" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Дата регистрации", Tag = "date_reg" });
            cbColumns.SelectedIndex = 0;
            // ПОИСК

            dgvMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            dgvMain.Columns.Add("id", "ID");
            dgvMain.Columns.Add("fio", "ФИО");
            dgvMain.Columns.Add("mail", "Почта");
            dgvMain.Columns.Add("role", "Роль");
            dgvMain.Columns.Add("date_reg", "Дата регистрации");
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            DgvMain_Update();
        }

        public void DgvMain_Update()
        {
            dgvMain.Rows.Clear();
            auth.con.Open();

            SqlCommand DataCommand = new SqlCommand("SELECT Users.id, Users.fio, Users.mail, Role.name, Users.date_reg, Users.id_role FROM Users INNER JOIN Role ON Users.id_role = Role.id", auth.con);
            SqlDataReader Reader = DataCommand.ExecuteReader();
            while (Reader.Read())
                dgvMain.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString());
            auth.con.Close();
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0) { return; }
            txtSelectedRecord.Text = dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            admin_users_edit admin_Users_Edit = new admin_users_edit(Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString()), this);
            admin_Users_Edit.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DgvMain_Update();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            admin_users_edit admin_Users_Edit = new admin_users_edit(Convert.ToInt32(txtSelectedRecord.Text), this);
            admin_Users_Edit.Show();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            admin_users_add admin_Users_Add = new admin_users_add(this);
            admin_Users_Add.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") { return; }

            auth.con.Open();
            string table = "";
            string column = "";
            if ((((ComboBoxItem)cbColumns.SelectedItem).Tag.ToString() == "role"))
            {
                table = "Role";
                column = "name";
            }
            else
            {
                table = "Users";
                column = ((ComboBoxItem)cbColumns.SelectedItem).Tag.ToString();
            }

            SqlCommand cmd = new SqlCommand($@"SELECT Users.id, Users.fio, Users.mail, Role.name, Users.id_role, Users.date_reg 
                                                FROM Users 
                                                INNER JOIN Role ON Users.id_role = Role.id 
                                                WHERE {table}.{column} = @SearchText", auth.con);
            cmd.Parameters.AddWithValue("@SearchText", txtSearch.Text);
            SqlDataReader Reader = cmd.ExecuteReader();
            dgvMain.Rows.Clear();

            while (Reader.Read())
                dgvMain.Rows.Add(Reader[0], Reader[1], Reader[2], Reader[3], Reader[5]);
            auth.con.Close();
        }

        private void admin_users_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Focus();
        }

        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0) { return; }
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Вы хотите удалить эту запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    auth.con.Open();
                    SqlCommand DataCommand = new SqlCommand("DELETE Users WHERE id = @id", auth.con);
                    DataCommand.Parameters.AddWithValue("@id", Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    DataCommand.ExecuteNonQuery();
                    auth.con.Close();
                    DgvMain_Update();
                }
            }
        }
    }
}
