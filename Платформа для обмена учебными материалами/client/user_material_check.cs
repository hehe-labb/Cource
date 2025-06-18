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

namespace Платформа_для_обмена_учебными_материалами.client
{
    public partial class user_material_check : Form
    {
        private int id;
        public user_material_check(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void user_material_check_Load(object sender, EventArgs e)
        {
            auth.con.Open();
            SqlCommand command = new SqlCommand("SELECT Materials.name, Materials.description, Materials.extension, Materials.date_create, Users.fio FROM Materials INNER JOIN Users ON Materials.id_users = Users.id WHERE Materials.id = @id", auth.con);
            command.Parameters.AddWithValue("id", id);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                this.Text = reader[0].ToString();
            }
            auth.con.Close();
        }
    }
}
