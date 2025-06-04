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
using Платформа_для_обмена_учебными_материалами.admin.users;
using static Платформа_для_обмена_учебными_материалами.admin.users.admin_users;

namespace Платформа_для_обмена_учебными_материалами.admin.role
{
    public partial class admin_role: Form
    {
        private admin admin;
        public admin_role(admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void admin_role_Load(object sender, EventArgs e)
        {
            // ПОИСК
            cbColumns.DisplayMember = "Text";
            cbColumns.ValueMember = "Tag";
            cbColumns.Items.Add(new users.admin_users.ComboBoxItem { Text = "ID", Tag = "id" });
            cbColumns.Items.Add(new users.admin_users.ComboBoxItem { Text = "Название", Tag = "name" });
            cbColumns.SelectedIndex = 0;
            // ПОИСК

            dgvMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            dgvMain.Columns.Add("id", "ID");
            dgvMain.Columns.Add("name", "Название");
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            DgvMain_Update();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            admin_role_edit admin_Role_Edit = new admin_role_edit(Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString()), this);
            admin_Role_Edit.Show();
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0) { return; }
            txtSelectedRecord.Text = dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            admin_role_edit admin_Role_Edit = new admin_role_edit(Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString()), this);
            admin_Role_Edit.Show();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            admin_role_add admin_Role_Add = new admin_role_add(this);
            admin_Role_Add.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DgvMain_Update();
        }
        public void DgvMain_Update()
        {
            dgvMain.Rows.Clear();
            auth.con.Open();

            SqlCommand DataCommand = new SqlCommand("SELECT * FROM Role", auth.con);
            SqlDataReader Reader = DataCommand.ExecuteReader();
            while (Reader.Read())
                dgvMain.Rows.Add(Reader[0], Reader[1]);
            auth.con.Close();
        }

        private void admin_role_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") { return; }

            auth.con.Open();
            SqlCommand cmd = new SqlCommand($@"SELECT * FROM Role WHERE Role.{((ComboBoxItem)cbColumns.SelectedItem).Tag.ToString()} = @SearchText", auth.con);
            cmd.Parameters.AddWithValue("@SearchText", txtSearch.Text);
            SqlDataReader Reader = cmd.ExecuteReader();
            dgvMain.Rows.Clear();

            while (Reader.Read())
                dgvMain.Rows.Add(Reader[0], Reader[1]);
            auth.con.Close();
        }
    }
}
