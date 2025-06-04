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
    public partial class admin_role_add: Form
    {
        private admin_role admin;
        public admin_role_add(admin_role admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void admin_role_add_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRole.Text == "") { return; }
            if (MessageBox.Show("Вы хотите добавить запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                auth.con.Open();
                SqlCommand DataCommand = new SqlCommand("INSERT INTO Role (name) VALUES (@name)", auth.con);
                DataCommand.Parameters.AddWithValue("@name", txtRole.Text);

                DataCommand.ExecuteNonQuery();
                auth.con.Close();
                admin.DgvMain_Update();
            }
        }
    }
}
