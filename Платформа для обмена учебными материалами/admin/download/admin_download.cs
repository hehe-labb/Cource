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
using static Платформа_для_обмена_учебными_материалами.admin.users.admin_users;

namespace Платформа_для_обмена_учебными_материалами.admin.download
{
    public partial class admin_download : Form
    {
        private admin admin;
        public admin_download(admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void admin_download_Load(object sender, EventArgs e)
        {
            // ПОИСК
            cbColumns.DisplayMember = "Text";
            cbColumns.ValueMember = "Tag";
            cbColumns.Items.Add(new ComboBoxItem { Text = "ID", Tag = "id" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Название", Tag = "name" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Путь к файлу", Tag = "path_to_file" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Расширение", Tag = "extension" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Загрузчик", Tag = "fio" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Дата загрузки", Tag = "date_create" });
            cbColumns.SelectedIndex = 0;
            // ПОИСК

            dgvMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            dgvMain.Columns.Add("id", "ID");
            dgvMain.Columns.Add("name", "Название");
            dgvMain.Columns.Add("path_to_file", "Путь к файлу");
            dgvMain.Columns.Add("extension", "Расширение");
            dgvMain.Columns.Add("id_users", "Загрузчик");
            dgvMain.Columns.Add("date_create", "Дата загрузки");
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            auth.con.Open();

            SqlCommand DataCommand = new SqlCommand("SELECT Download.id, Materials.name, Materials.path_to_file, Materials.extension, Users.fio, Download.date_download, Download.id_material, Download.id_users FROM Download INNER JOIN Users ON Download.id_users = Users.id INNER JOIN Materials ON Download.id_material = Materials.id", auth.con);
            SqlDataReader Reader = DataCommand.ExecuteReader();
            while (Reader.Read())
                dgvMain.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString());
            auth.con.Close();
        }

        private void admin_download_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "") { return; }

            auth.con.Open();
            string table = "";
            string column = "";

            switch ((((ComboBoxItem)cbColumns.SelectedItem).Tag.ToString())) {
                case "fio":
                    table = "Users";
                    column = "fio";
                    break;
                case "name":
                    table = "Materials";
                    column = "name";
                    break;
                case "path_to_file":
                    table = "Materials";
                    column = "path_to_file";
                    break;
                case "extension":
                    table = "Materials";
                    column = "extension";
                    break;
                default:
                    table = "Download";
                    column = ((ComboBoxItem)cbColumns.SelectedItem).Tag.ToString();
                    break;
            }

            SqlCommand cmd = new SqlCommand($@"SELECT Download.id, Materials.name, Materials.path_to_file, Materials.extension, Users.fio, Download.date_download, Download.id_material, Download.id_users
                                                FROM Download 
                                                INNER JOIN Users ON Download.id_users = Users.id 
                                                INNER JOIN Materials ON Download.id_material = Materials.id 
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
