using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Платформа_для_обмена_учебными_материалами.client
{
    public partial class user_material_add : Form
    {
        private int id;
        private user user;
        public user_material_add(int id, user user)
        {
            InitializeComponent();
            linklblFile.Text = null;
            this.id = id;
            this.user = user;
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
                Process.Start(new ProcessStartInfo(linklblFile.Text) { UseShellExecute = true });
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
                    DataCommand.Parameters.AddWithValue("@id_users", id);
                    DataCommand.Parameters.AddWithValue("@date", date.Value);

                    DataCommand.ExecuteNonQuery();
                    auth.con.Close();
                    user.Main_Update();
                }
            }
        }
    }
}
