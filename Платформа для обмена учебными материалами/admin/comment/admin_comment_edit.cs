using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Платформа_для_обмена_учебными_материалами.admin.comment
{
    public partial class admin_comment_edit : Form
    {
        private int id;
        private admin_comment admin;
        public admin_comment_edit(int id, admin_comment admin)
        {
            InitializeComponent();
            this.id = id;
            this.admin = admin;
        }

        private void admin_comment_edit_Load(object sender, EventArgs e)
        {
            txtID.Text = id.ToString();
            auth.con.Open();

            SqlCommand command = new SqlCommand("SELECT id FROM Materials", auth.con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                cbColumns.Items.Add(reader[0].ToString());
            reader.Close();

            SqlCommand DataCommand = new SqlCommand("SELECT * FROM Comment WHERE id = @id", auth.con);
            DataCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader Reader = DataCommand.ExecuteReader();

            Reader.Read();
            txtID.Text = Reader[0].ToString();
            cbColumns.SelectedItem = Reader[1].ToString();
            rtxtDesc.Text = Reader[3].ToString();
            numericUpDown1.Value = Convert.ToInt32(Reader[4].ToString());
            date.Text = Reader[5].ToString();
            auth.con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите изменить эту запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                auth.con.Open();
                SqlCommand cmd = new SqlCommand($@"UPDATE Comment SET id_material = @material, text = @txt, score = @score, date_create = @date WHERE id = @id", auth.con);

                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@material", Convert.ToInt32(cbColumns.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@txt", rtxtDesc.Text);
                cmd.Parameters.AddWithValue("@score", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@date", date.Value);

                cmd.ExecuteNonQuery();
                auth.con.Close();

                this.Close();
                admin.DgvMain_Update();
            }
        }
    }
}
