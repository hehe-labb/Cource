using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using static Платформа_для_обмена_учебными_материалами.admin.users.admin_users_edit;
using System.Data.SqlClient;

namespace Платформа_для_обмена_учебными_материалами.admin.materials
{
    public partial class admin_materials_add : Form
    {
        private admin_materials admin;
        public admin_materials_add(admin_materials admin)
        {
            this.admin = admin;
            InitializeComponent();
            linklblFile.Text = null;
        }

        private void admin_materials_add_Load(object sender, EventArgs e)
        {

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

        private void linklblFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linklblFile.Text != null) 
                Process.Start(new ProcessStartInfo(linklblFile.Text) { UseShellExecute = true});
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            linklblFile.Text = null;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty || rtxtDesc.Text != string.Empty || linklblFile.Text != string.Empty)
            {
                if (MessageBox.Show("Вы хотите добавить запись?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var Random = new Random();
                    int ranint = Random.Next(1000000, 9999999);
                    FileInfo fileInfo = new FileInfo(linklblFile.Text);
                    string newpath = $@"\server\{ranint}{fileInfo.Extension}";
                    File.Copy(fileInfo.FullName, Application.StartupPath + newpath);
                    auth.con.Open();
                    SqlCommand DataCommand = new SqlCommand("INSERT INTO Materials (id, name, description, path_to_file, extension, id_users, date_create) VALUES (@id, @name, @desc, @path, @ext, @id_users, @date)", auth.con);
                    DataCommand.Parameters.AddWithValue("@id", ranint);
                    DataCommand.Parameters.AddWithValue("@name", txtName.Text);
                    DataCommand.Parameters.AddWithValue("@desc", rtxtDesc.Text);
                    DataCommand.Parameters.AddWithValue("@path", newpath);
                    DataCommand.Parameters.AddWithValue("@ext", fileInfo.Extension);
                    DataCommand.Parameters.AddWithValue("@id_users", Платформа_для_обмена_учебными_материалами.admin.admin.id);
                    DataCommand.Parameters.AddWithValue("@date", date.Value);

                    DataCommand.ExecuteNonQuery();
                    auth.con.Close();
                    admin.DgvMain_Update();
                }
            }
        }
    }
}
