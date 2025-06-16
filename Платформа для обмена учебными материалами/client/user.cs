using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Платформа_для_обмена_учебными_материалами.Properties;

namespace Платформа_для_обмена_учебными_материалами.client
{
    public partial class user : Form
    {
        public int id;
        public user(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void user_Load(object sender, EventArgs e)
        {
            if (File.Exists($@"{Application.StartupPath}\server\logo\{id}.jpg"))
                ava.Image = Image.FromFile($@"{Application.StartupPath}\server\logo\{id}.jpg");
            else
                ava.Image = Image.FromFile($@"{Application.StartupPath}\server\logo\noavatar.png");

            
            Main_Update();
        }

        public void Main_Update()
        {
            auth.con.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Materials", auth.con);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            materials.Text = $"Всего {reader[0].ToString()} материал";

            reader.Close();
            command.Dispose();
            pnlMain.Controls.Clear();
            command = new SqlCommand("SELECT Materials.name, Materials.extension, Materials.id_users, Users.fio, Materials.date_create, (SELECT COUNT(*) FROM Comment WHERE Comment.id_material = Materials.id) AS comment_count, (SELECT COUNT(*) FROM Download WHERE Download.id_material = Materials.id) AS download_count FROM Materials INNER JOIN Users ON Materials.id_users = Users.id", auth.con);
            reader = command.ExecuteReader();
            int y1 = -185;
            int y2 = 185;

            while (reader.Read())
            {
                y1 += y2;
                Panel panel = new Panel()
                {
                    Location = new System.Drawing.Point(162, y1),
                    Size = new System.Drawing.Size(508, 179),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Label name = new Label()
                {
                    AutoEllipsis = true,
                    AutoSize = true,
                    Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Location = new System.Drawing.Point(48, 8),
                    Size = new System.Drawing.Size(66, 30),
                    TabIndex = 0,
                    Text = reader[0].ToString()
                };
                PictureBox icon1 = new PictureBox()
                {
                    Image = Image.FromFile($@"{Application.StartupPath}\server\icon\{reader[1].ToString().Replace(".", string.Empty)}.png"),
                    Location = new System.Drawing.Point(12, 8),
                    Size = new System.Drawing.Size(29, 30),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                };

                Label user = new Label()
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(40, 62),
                    Size = new System.Drawing.Size(52, 21),
                    Text = reader[3].ToString()
                };
                PictureBox icon2 = new PictureBox()
                {
                    Location = new System.Drawing.Point(14, 62),
                    Size = new System.Drawing.Size(20, 21),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                };
                if (File.Exists($@"{Application.StartupPath}\server\logo\{reader[2].ToString()}.jpg"))
                    icon2.Image = Image.FromFile($@"{Application.StartupPath}\server\logo\{reader[2].ToString()}.jpg");
                else
                    icon2.Image = Image.FromFile($@"{Application.StartupPath}\server\logo\noavatar.png");

                Button button = new Button()
                {
                    BackColor = System.Drawing.Color.LightSteelBlue,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                    Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold),
                    ForeColor = System.Drawing.Color.RoyalBlue,
                    Location = new System.Drawing.Point(12, 125),
                    Size = new System.Drawing.Size(182, 42),
                    Text = "Подробнее",
                    UseVisualStyleBackColor = false
                };
                button.FlatAppearance.BorderSize = 0;
                button.Click += Button_Click;

                Label date = new Label()
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(304, 62),
                    Size = new System.Drawing.Size(88, 21),
                    Text = reader[4].ToString().Split(' ')[0]
                };
                PictureBox icon3 = new PictureBox()
                {
                    Image = Image.FromFile($@"{Application.StartupPath}\server\icon\date.png"),
                    Location = new System.Drawing.Point(284, 62),
                    Size = new System.Drawing.Size(20, 21),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                };

                Label download = new Label()
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(417, 62),
                    Size = new System.Drawing.Size(28, 21),
                    Text = reader[6].ToString()
                };
                PictureBox icon4 = new PictureBox()
                {
                    Image = Image.FromFile($@"{Application.StartupPath}\server\icon\download.png"),
                    Location = new System.Drawing.Point(397, 62),
                    Size = new System.Drawing.Size(20, 21),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                };
                Label comment = new Label()
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(467, 62),
                    Size = new System.Drawing.Size(28, 21),
                    Text = reader[5].ToString()
                };
                PictureBox icon5 = new PictureBox()
                {
                    Image = Image.FromFile($@"{Application.StartupPath}\server\icon\comment.png"),
                    Location = new System.Drawing.Point(447, 62),
                    Size = new System.Drawing.Size(20, 21),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
                };

                panel.Controls.Add(name);
                panel.Controls.Add(icon1);
                panel.Controls.Add(user);
                panel.Controls.Add(icon2);
                panel.Controls.Add(button);
                panel.Controls.Add(date);
                panel.Controls.Add(icon3);
                panel.Controls.Add(download);
                panel.Controls.Add(icon4);
                panel.Controls.Add(comment);
                panel.Controls.Add(icon5);
                pnlMain.Controls.Add(panel);
            }
            auth.con.Close();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            
        }

        private void user_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ava_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            user_material_add user = new user_material_add(id, this);
            user.Show();
        }
    }
}
