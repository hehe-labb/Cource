namespace Платформа_для_обмена_учебными_материалами
{
    partial class reg
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
            this.btnReg = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.txtSecName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.linkLblRegistration = new System.Windows.Forms.LinkLabel();
            this.lblAuth = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(61, 607);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(175, 35);
            this.btnReg.TabIndex = 10;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(28, 156);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 21);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 180);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(246, 29);
            this.txtPassword.TabIndex = 8;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(28, 81);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(54, 21);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(28, 105);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(246, 29);
            this.txtLogin.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(28, 232);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(159, 21);
            this.lblConfirmPassword.TabIndex = 12;
            this.lblConfirmPassword.Text = "Подтвердите пароль";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(28, 256);
            this.txtConfirmPassword.MaxLength = 20;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(246, 29);
            this.txtConfirmPassword.TabIndex = 11;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(28, 312);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(54, 21);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "Почта";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(28, 336);
            this.txtMail.MaxLength = 20;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(246, 29);
            this.txtMail.TabIndex = 13;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lbl);
            this.pnlMain.Controls.Add(this.txtSecName);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.lblSurname);
            this.pnlMain.Controls.Add(this.txtSurname);
            this.pnlMain.Controls.Add(this.linkLblRegistration);
            this.pnlMain.Controls.Add(this.lblMail);
            this.pnlMain.Controls.Add(this.lblAuth);
            this.pnlMain.Controls.Add(this.txtMail);
            this.pnlMain.Controls.Add(this.btnReg);
            this.pnlMain.Controls.Add(this.lblConfirmPassword);
            this.pnlMain.Controls.Add(this.txtLogin);
            this.pnlMain.Controls.Add(this.txtConfirmPassword);
            this.pnlMain.Controls.Add(this.lblLogin);
            this.pnlMain.Controls.Add(this.lblPassword);
            this.pnlMain.Controls.Add(this.txtPassword);
            this.pnlMain.Location = new System.Drawing.Point(33, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(309, 682);
            this.pnlMain.TabIndex = 15;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(28, 530);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(77, 21);
            this.lbl.TabIndex = 20;
            this.lbl.Text = "Отчество";
            // 
            // txtSecName
            // 
            this.txtSecName.Location = new System.Drawing.Point(28, 554);
            this.txtSecName.MaxLength = 20;
            this.txtSecName.Name = "txtSecName";
            this.txtSecName.Size = new System.Drawing.Size(246, 29);
            this.txtSecName.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 455);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 21);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Имя";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(28, 479);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 29);
            this.txtName.TabIndex = 17;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(28, 384);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(75, 21);
            this.lblSurname.TabIndex = 16;
            this.lblSurname.Text = "Фамилия";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(28, 408);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(246, 29);
            this.txtSurname.TabIndex = 15;
            // 
            // linkLblRegistration
            // 
            this.linkLblRegistration.AutoSize = true;
            this.linkLblRegistration.Location = new System.Drawing.Point(57, 645);
            this.linkLblRegistration.Name = "linkLblRegistration";
            this.linkLblRegistration.Size = new System.Drawing.Size(187, 21);
            this.linkLblRegistration.TabIndex = 6;
            this.linkLblRegistration.TabStop = true;
            this.linkLblRegistration.Text = "Уже есть аккаунт? Войти\r\n";
            this.linkLblRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegistration_LinkClicked);
            // 
            // lblAuth
            // 
            this.lblAuth.AutoSize = true;
            this.lblAuth.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuth.Location = new System.Drawing.Point(91, 28);
            this.lblAuth.Name = "lblAuth";
            this.lblAuth.Size = new System.Drawing.Size(122, 25);
            this.lblAuth.TabIndex = 0;
            this.lblAuth.Text = "Регистрация";
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.date.Location = new System.Drawing.Point(126, 338);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(183, 29);
            this.date.TabIndex = 122;
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 737);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.date);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.LinkLabel linkLblRegistration;
        private System.Windows.Forms.Label lblAuth;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtSecName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.DateTimePicker date;
    }
}