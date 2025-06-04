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

namespace Платформа_для_обмена_учебными_материалами.admin.role
{
    public partial class admin_role_edit: Form
    {
        private int id;
        private admin_role admin;
        public admin_role_edit(int id, admin_role admin)
        {
            this.id = id;
            this.admin = admin;
            InitializeComponent();
        }

        private void admin_role_edit_Load(object sender, EventArgs e)
        {
            auth.con.Open();
            SqlCommand DataCommand = new SqlCommand("SELECT * FROM Role WHERE id = @id", auth.con);
            DataCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader Reader = DataCommand.ExecuteReader();

            Reader.Read();
            txtId.Text = Reader[0].ToString();
            txtRole.Text = Reader[1].ToString();

            auth.con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите изменить эту запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                auth.con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Role SET name = @name WHERE id = @Id", auth.con);

                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtRole.Text);

                cmd.ExecuteNonQuery();
                auth.con.Close();
                this.Close();
                admin.DgvMain_Update();
            }
        }
    }
}
