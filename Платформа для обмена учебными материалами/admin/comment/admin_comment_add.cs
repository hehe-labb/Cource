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

namespace Платформа_для_обмена_учебными_материалами.admin.comment
{
    public partial class admin_comment_add : Form
    {
        private admin_comment admin;
        public admin_comment_add(admin_comment admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void admin_comment_add_Load(object sender, EventArgs e)
        {
            auth.con.Open();
            SqlCommand command = new SqlCommand("SELECT id FROM Materials", auth.con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbColumns.Items.Add(reader[0].ToString());
            }
            cbColumns.SelectedIndex = 0;
            auth.con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rtxtDesc.Text != string.Empty)
            {
                if (MessageBox.Show("Вы хотите добавить запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    auth.con.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Comment (id_material, id_users, text, score, date_create) VALUES (@id_m, @id_u, @txt, @score, @date)", auth.con);
                    command.Parameters.AddWithValue("@id_m", Convert.ToInt32(cbColumns.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@id_u", Платформа_для_обмена_учебными_материалами.admin.admin.id);
                    command.Parameters.AddWithValue("@txt", rtxtDesc.Text);
                    command.Parameters.AddWithValue("@score", numericUpDown1.Value);
                    command.Parameters.AddWithValue("@date", date.Value);
                    command.ExecuteNonQuery();
                    auth.con.Close();

                    admin.DgvMain_Update();
                }
            }
        }
    }
}
