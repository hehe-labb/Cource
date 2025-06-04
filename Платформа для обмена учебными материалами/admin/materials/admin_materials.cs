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
using Платформа_для_обмена_учебными_материалами.admin.users;
using static Платформа_для_обмена_учебными_материалами.admin.users.admin_users;

namespace Платформа_для_обмена_учебными_материалами.admin.materials
{
    public partial class admin_materials : Form
    {
        private admin admin;
        public admin_materials(admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void admin_materials_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Focus();
        }
        public void DgvMain_Update()
        {
            dgvMain.Rows.Clear();
            auth.con.Open();

            SqlCommand DataCommand = new SqlCommand("SELECT Materials.id, Materials.name, Materials.description, Materials.path_to_file, Materials.extension, Users.fio, Materials.date_create FROM Materials INNER JOIN Users ON Materials.id_users = Users.id", auth.con);
            SqlDataReader Reader = DataCommand.ExecuteReader();
            while (Reader.Read())
                dgvMain.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), Reader[6].ToString());
            auth.con.Close();
        }

        private void admin_materials_Load(object sender, EventArgs e)
        {
            // ПОИСК
            cbColumns.DisplayMember = "Text";
            cbColumns.ValueMember = "Tag";
            cbColumns.Items.Add(new ComboBoxItem { Text = "ID", Tag = "id" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Название", Tag = "name" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Описание", Tag = "description" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Путь к файлу", Tag = "path_to_file" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Расширение", Tag = "extension" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Создатель", Tag = "fio" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Дата создания", Tag = "date_create" });
            cbColumns.SelectedIndex = 0;
            // ПОИСК

            dgvMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            dgvMain.Columns.Add("id", "ID");
            dgvMain.Columns.Add("name", "Название");
            dgvMain.Columns.Add("description", "Описание");
            dgvMain.Columns.Add("path_to_file", "Путь к файлу");
            dgvMain.Columns.Add("extension", "Расширение");
            dgvMain.Columns.Add("id_users", "Создатель");
            dgvMain.Columns.Add("date_create", "Дата создания");
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            DgvMain_Update();
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0) { return; }
            txtSelectedRecord.Text = dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            admin_materials_edit admin_Materials_Edit = new admin_materials_edit(Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString()), this);
            admin_Materials_Edit.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DgvMain_Update();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            admin_materials_edit admin_Materials_Edit = new admin_materials_edit(Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString()), this);
            admin_Materials_Edit.Show();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            admin_materials_add admin_Materials_Add = new admin_materials_add(this);
            admin_Materials_Add.Show();
        }

        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0) { return; }
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Вы хотите удалить эту запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    auth.con.Open();
                    SqlCommand DataCommand = new SqlCommand("DELETE Materials WHERE id = @id", auth.con);
                    DataCommand.Parameters.AddWithValue("@id", Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString()));
                    DataCommand.ExecuteNonQuery();
                    auth.con.Close();
                    DgvMain_Update();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") { return; }

            auth.con.Open();
            string table = "";
            string column = "";
            if ((((ComboBoxItem)cbColumns.SelectedItem).Tag.ToString() == "fio"))
            {
                table = "Users";
                column = "fio";
            }
            else
            {
                table = "Materials";
                column = ((ComboBoxItem)cbColumns.SelectedItem).Tag.ToString();
            }

            SqlCommand cmd = new SqlCommand($@"SELECT Materials.id, Materials.name, Materials.description, Materials.path_to_file, Materials.extension, Users.fio, Materials.date_create
                                                FROM Materials 
                                                INNER JOIN Users ON Materials.id_users = Users.id 
                                                WHERE {table}.{column} = @SearchText", auth.con);
            cmd.Parameters.AddWithValue("@SearchText", txtSearch.Text);
            SqlDataReader Reader = cmd.ExecuteReader();
            dgvMain.Rows.Clear();

            while (Reader.Read())
                dgvMain.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString(), Reader[6].ToString());
            auth.con.Close();
        }
    }
}
