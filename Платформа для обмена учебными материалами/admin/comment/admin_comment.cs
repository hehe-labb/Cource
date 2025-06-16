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
using Платформа_для_обмена_учебными_материалами.admin.materials;
using static Платформа_для_обмена_учебными_материалами.admin.users.admin_users;

namespace Платформа_для_обмена_учебными_материалами.admin.comment
{
    public partial class admin_comment : Form
    {
        private admin admin;
        public admin_comment(admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void admin_comment_Load(object sender, EventArgs e)
        {
            // ПОИСК
            cbColumns.DisplayMember = "Text";
            cbColumns.ValueMember = "Tag";
            cbColumns.Items.Add(new ComboBoxItem { Text = "ID", Tag = "id" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "ID материала", Tag = "id_material" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Комментатор", Tag = "fio" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Текст", Tag = "text" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Оценка", Tag = "score" });
            cbColumns.Items.Add(new ComboBoxItem { Text = "Дата создания", Tag = "date_create" });
            cbColumns.SelectedIndex = 0;
            // ПОИСК

            dgvMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            dgvMain.Columns.Add("id", "ID");
            dgvMain.Columns.Add("id_material", "ID материала");
            dgvMain.Columns.Add("fio", "Комментатор");
            dgvMain.Columns.Add("text", "Текст");
            dgvMain.Columns.Add("score", "Оценка");
            dgvMain.Columns.Add("Дата создания", "date_create");
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            DgvMain_Update();
        }
        public void DgvMain_Update()
        {
            dgvMain.Rows.Clear();
            auth.con.Open();

            SqlCommand DataCommand = new SqlCommand("SELECT Comment.id, Comment.id_material, Users.fio, Comment.text, Comment.score, Comment.date_create FROM Comment INNER JOIN Users ON Comment.id_users = Users.id", auth.con);
            SqlDataReader Reader = DataCommand.ExecuteReader();
            while (Reader.Read())
                dgvMain.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString());

            auth.con.Close();
        }

        private void admin_comment_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Focus();
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0) { return; }
            txtSelectedRecord.Text = dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DgvMain_Update();
        }

        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 0) { return; }
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Вы хотите удалить эту запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    auth.con.Open();
                    SqlCommand DataCommand = new SqlCommand("DELETE Comment WHERE id = @id", auth.con);
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
                table = "Comment";
                column = ((ComboBoxItem)cbColumns.SelectedItem).Tag.ToString();
            }

            SqlCommand cmd = new SqlCommand($@"SELECT Comment.id, Comment.id_material, Users.fio, Comment.text, Comment.score, Comment.date_create
                                                FROM Comment 
                                                INNER JOIN Users ON Comment.id_users = Users.id 
                                                WHERE {table}.{column} = @SearchText", auth.con);
            cmd.Parameters.AddWithValue("@SearchText", txtSearch.Text);
            SqlDataReader Reader = cmd.ExecuteReader();
            dgvMain.Rows.Clear();

            while (Reader.Read())
                dgvMain.Rows.Add(Reader[0].ToString(), Reader[1].ToString(), Reader[2].ToString(), Reader[3].ToString(), Reader[4].ToString(), Reader[5].ToString());
            auth.con.Close();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            admin_comment_add admin_comment_add = new admin_comment_add(this);
            admin_comment_add.Show();
        }

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            admin_comment_edit admin_comment_edit = new admin_comment_edit(Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString()), this);
            admin_comment_edit.Show();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            admin_comment_edit admin_comment_edit = new admin_comment_edit(Convert.ToInt32(dgvMain.Rows[dgvMain.SelectedRows[0].Index].Cells[0].Value.ToString()), this);
            admin_comment_edit.Show();
        }
    }
}
