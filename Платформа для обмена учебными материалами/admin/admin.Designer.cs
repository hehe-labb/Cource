namespace Платформа_для_обмена_учебными_материалами.admin
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMaterials = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.lblAuth = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaterials
            // 
            this.btnMaterials.Location = new System.Drawing.Point(26, 117);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(184, 42);
            this.btnMaterials.TabIndex = 0;
            this.btnMaterials.Text = "Материалы";
            this.btnMaterials.UseVisualStyleBackColor = true;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(26, 187);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(184, 42);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Комментарии";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRole
            // 
            this.btnRole.Location = new System.Drawing.Point(232, 187);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(184, 42);
            this.btnRole.TabIndex = 4;
            this.btnRole.Text = "Роли";
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuth.Location = new System.Drawing.Point(21, 29);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(229, 25);
            this.lblAuth.TabIndex = 5;
            this.lblAuth.Text = "Панель администратора";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(585, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 302);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAuth);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMaterials);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Button btnExit;
    }
}