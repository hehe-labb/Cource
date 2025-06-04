using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Платформа_для_обмена_учебными_материалами.admin.materials
{
    public partial class admin_materials_edit : Form
    {
        private admin_materials admin;
        private int id;
        private string ext;
        public admin_materials_edit(int id, admin_materials admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.id = id;
        }

        private void admin_materials_edit_Load(object sender, EventArgs e)
        {
            linklblFile.Text = null;
            auth.con.Open();
            SqlCommand DataCommand = new SqlCommand("SELECT * FROM Materials WHERE id = @id", auth.con);
            DataCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader Reader = DataCommand.ExecuteReader();

            Reader.Read();
            txtID.Text = Reader[0].ToString();
            txtName.Text = Reader[1].ToString();
            rtxtDesc.Text = Reader[2].ToString();
            date.Text = Reader[6].ToString();
            ext = Reader[4].ToString();
            auth.con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы хотите изменить эту запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                auth.con.Open();
                SqlCommand cmd = new SqlCommand($@"UPDATE Materials SET name = @name, description = @desc,{(linklblFile.Text != "" ? "path_to_file = @path, extension = @ext," : "")}  date_create = @date WHERE id = @Id", auth.con);

                cmd.Parameters.AddWithValue("@Id", txtID.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@desc", rtxtDesc.Text);
                if (linklblFile.Text != "")
                {
                    FileInfo fileInfo = new FileInfo(linklblFile.Text);
                    cmd.Parameters.AddWithValue("@path", $@"E:\курсач\Платформа для обмена учебными материалами\Платформа для обмена учебными материалами\bin\Debug\server\{id}{fileInfo.Extension}");
                    cmd.Parameters.AddWithValue("@ext", fileInfo.Extension);
                    File.Delete($@"E:\курсач\Платформа для обмена учебными материалами\Платформа для обмена учебными материалами\bin\Debug\server\{id}{ext}");
                    File.Copy(fileInfo.FullName, $@"E:\курсач\Платформа для обмена учебными материалами\Платформа для обмена учебными материалами\bin\Debug\server\{id}{fileInfo.Extension}");
                }
                cmd.Parameters.AddWithValue("@date", date.Value);

                cmd.ExecuteNonQuery();
                auth.con.Close();
                
                this.Close();
                admin.DgvMain_Update();
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "docx";
            openFileDialog.Filter = "docx files (*.docx)|*.docx|pptx files (*.pptx)|*.pptx|pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                linklblFile.Text = openFileDialog.FileName;
            }
        }
    }
}
