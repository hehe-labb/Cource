namespace Платформа_для_обмена_учебными_материалами.client
{
    partial class user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            this.pnlHat = new System.Windows.Forms.Panel();
            this.pbMaterials = new System.Windows.Forms.PictureBox();
            this.materials = new System.Windows.Forms.Label();
            this.ava = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlFind = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ava)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHat
            // 
            this.pnlHat.BackColor = System.Drawing.Color.White;
            this.pnlHat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHat.Controls.Add(this.pbMaterials);
            this.pnlHat.Controls.Add(this.materials);
            this.pnlHat.Controls.Add(this.ava);
            this.pnlHat.Controls.Add(this.btnAdd);
            this.pnlHat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHat.Location = new System.Drawing.Point(0, 0);
            this.pnlHat.Name = "pnlHat";
            this.pnlHat.Size = new System.Drawing.Size(992, 89);
            this.pnlHat.TabIndex = 0;
            // 
            // pbMaterials
            // 
            this.pbMaterials.Image = ((System.Drawing.Image)(resources.GetObject("pbMaterials.Image")));
            this.pbMaterials.Location = new System.Drawing.Point(12, 27);
            this.pbMaterials.Name = "pbMaterials";
            this.pbMaterials.Size = new System.Drawing.Size(34, 32);
            this.pbMaterials.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaterials.TabIndex = 3;
            this.pbMaterials.TabStop = false;
            // 
            // materials
            // 
            this.materials.AutoSize = true;
            this.materials.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materials.Location = new System.Drawing.Point(52, 27);
            this.materials.Name = "materials";
            this.materials.Size = new System.Drawing.Size(76, 32);
            this.materials.TabIndex = 2;
            this.materials.Text = "label1";
            // 
            // ava
            // 
            this.ava.Location = new System.Drawing.Point(910, 25);
            this.ava.Name = "ava";
            this.ava.Size = new System.Drawing.Size(48, 42);
            this.ava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ava.TabIndex = 1;
            this.ava.TabStop = false;
            this.ava.Click += new System.EventHandler(this.ava_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAdd.FlatAppearance.BorderSize = 2;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(663, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(207, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить материал";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlFind
            // 
            this.pnlFind.BackColor = System.Drawing.Color.White;
            this.pnlFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFind.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlFind.Location = new System.Drawing.Point(816, 89);
            this.pnlFind.Name = "pnlFind";
            this.pnlFind.Size = new System.Drawing.Size(176, 585);
            this.pnlFind.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 89);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(816, 585);
            this.pnlMain.TabIndex = 3;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(992, 674);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlFind);
            this.Controls.Add(this.pnlHat);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.user_FormClosing);
            this.Load += new System.EventHandler(this.user_Load);
            this.pnlHat.ResumeLayout(false);
            this.pnlHat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ava)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox ava;
        private System.Windows.Forms.Label materials;
        private System.Windows.Forms.PictureBox pbMaterials;
        private System.Windows.Forms.Panel pnlFind;
        private System.Windows.Forms.Panel pnlMain;
    }
}