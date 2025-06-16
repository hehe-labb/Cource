using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Платформа_для_обмена_учебными_материалами.admin.role;
using Платформа_для_обмена_учебными_материалами.admin.users;
using Платформа_для_обмена_учебными_материалами.admin.materials;
using Платформа_для_обмена_учебными_материалами.admin.download;
using Платформа_для_обмена_учебными_материалами.admin.comment;
//using Платформа_для_обмена_учебными_материалами.admin.download;
//using Платформа_для_обмена_учебными_материалами.admin.comment;

namespace Платформа_для_обмена_учебными_материалами.admin
{
    public partial class admin: Form
    {
        private auth auth;
        public static int id;
        public admin(auth auth, int id1)
        {
            id = id1;
            this.auth = auth;
            InitializeComponent();
        }

        private void admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            admin_materials admin_Materials = new admin_materials(this);
            admin_Materials.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            admin_users admin_Users = new admin_users(this);
            admin_Users.Show();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            admin_role admin_Role = new admin_role(this);
            admin_Role.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            auth.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_download admin_Download = new admin_download(this);
            admin_Download.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin_comment admin_Comment = new admin_comment(this);
            admin_Comment.Show();
        }
    }
}
