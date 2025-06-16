namespace Платформа_для_обмена_учебными_материалами.client
{
    partial class user_material_add
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
            this.linklblFile = new System.Windows.Forms.LinkLabel();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linklblFile
            // 
            this.linklblFile.AutoSize = true;
            this.linklblFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.linklblFile.Location = new System.Drawing.Point(324, 56);
            this.linklblFile.Name = "linklblFile";
            this.linklblFile.Size = new System.Drawing.Size(52, 21);
            this.linklblFile.TabIndex = 124;
            this.linklblFile.TabStop = true;
            this.linklblFile.Text = "Пусто";
            this.linklblFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblFile_LinkClicked);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnSelectFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSelectFile.ForeColor = System.Drawing.Color.Black;
            this.btnSelectFile.Location = new System.Drawing.Point(597, 39);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(127, 38);
            this.btnSelectFile.TabIndex = 123;
            this.btnSelectFile.Text = "Выбрать файл";
            this.btnSelectFile.UseVisualStyleBackColor = false;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtDesc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtxtDesc.Location = new System.Drawing.Point(12, 134);
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(292, 121);
            this.rtxtDesc.TabIndex = 122;
            this.rtxtDesc.Text = "";
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(344, 235);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(157, 29);
            this.date.TabIndex = 121;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDate.Location = new System.Drawing.Point(340, 211);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(114, 21);
            this.lblDate.TabIndex = 120;
            this.lblDate.Text = "Дата создания";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDesc.Location = new System.Drawing.Point(8, 110);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(81, 21);
            this.lblDesc.TabIndex = 119;
            this.lblDesc.Text = "Описание";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblName.Location = new System.Drawing.Point(8, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 21);
            this.lblName.TabIndex = 118;
            this.lblName.Text = "Название";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtName.Location = new System.Drawing.Point(12, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(282, 29);
            this.txtName.TabIndex = 117;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmail.Location = new System.Drawing.Point(321, 27);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(104, 21);
            this.lblEmail.TabIndex = 116;
            this.lblEmail.Text = "Путь к файлу";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(560, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 32);
            this.btnAdd.TabIndex = 115;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(563, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(28, 35);
            this.btnCancel.TabIndex = 125;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // user_material_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 278);
            this.Controls.Add(this.linklblFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.date);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "user_material_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить материал";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnCancel;
    }
}