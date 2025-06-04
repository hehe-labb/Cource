namespace Платформа_для_обмена_учебными_материалами.admin.role
{
    partial class admin_role_add
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(243, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 32);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Добавить роль";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRole.Location = new System.Drawing.Point(3, 29);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(117, 21);
            this.lblRole.TabIndex = 23;
            this.lblRole.Text = "Название роли";
            // 
            // txtRole
            // 
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRole.Location = new System.Drawing.Point(7, 53);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(170, 29);
            this.txtRole.TabIndex = 22;
            // 
            // admin_role_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 111);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtRole);
            this.Name = "admin_role_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление роли";
            this.Load += new System.EventHandler(this.admin_role_add_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtRole;
    }
}