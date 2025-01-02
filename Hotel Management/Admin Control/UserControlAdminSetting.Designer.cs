namespace Hotel_Management.Admin_Control
{
    partial class UserControlAdminSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAdminpassword = new System.Windows.Forms.TextBox();
            this.textBoxAdminname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridViewSearchAdmin = new System.Windows.Forms.DataGridView();
            this.textBoxAdmin_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewAfterdelete = new System.Windows.Forms.DataGridView();
            this.buttonDeleteAdmin = new System.Windows.Forms.Button();
            this.textBoxAdmin_name_delete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchAdmin)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfterdelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBoxAdminpassword);
            this.tabPage1.Controls.Add(this.textBoxAdminname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Supper Admin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(188, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAdminpassword
            // 
            this.textBoxAdminpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdminpassword.Location = new System.Drawing.Point(470, 182);
            this.textBoxAdminpassword.Name = "textBoxAdminpassword";
            this.textBoxAdminpassword.Size = new System.Drawing.Size(263, 32);
            this.textBoxAdminpassword.TabIndex = 10;
            // 
            // textBoxAdminname
            // 
            this.textBoxAdminname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdminname.Location = new System.Drawing.Point(188, 182);
            this.textBoxAdminname.Name = "textBoxAdminname";
            this.textBoxAdminname.Size = new System.Drawing.Size(263, 32);
            this.textBoxAdminname.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Supper Admin Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Supper Admin:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Search);
            this.tabPage2.Controls.Add(this.dataGridViewSearchAdmin);
            this.tabPage2.Controls.Add(this.textBoxAdmin_name);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Supper Admin Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Location = new System.Drawing.Point(180, 143);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(102, 39);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridViewSearchAdmin
            // 
            this.dataGridViewSearchAdmin.AllowUserToAddRows = false;
            this.dataGridViewSearchAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewSearchAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSearchAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchAdmin.Location = new System.Drawing.Point(19, 210);
            this.dataGridViewSearchAdmin.Name = "dataGridViewSearchAdmin";
            this.dataGridViewSearchAdmin.ReadOnly = true;
            this.dataGridViewSearchAdmin.Size = new System.Drawing.Size(924, 199);
            this.dataGridViewSearchAdmin.TabIndex = 7;
            // 
            // textBoxAdmin_name
            // 
            this.textBoxAdmin_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdmin_name.Location = new System.Drawing.Point(180, 95);
            this.textBoxAdmin_name.Name = "textBoxAdmin_name";
            this.textBoxAdmin_name.Size = new System.Drawing.Size(288, 29);
            this.textBoxAdmin_name.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Supper Admin Name:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Supper Admin Details:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewAfterdelete);
            this.tabPage3.Controls.Add(this.buttonDeleteAdmin);
            this.tabPage3.Controls.Add(this.textBoxAdmin_name_delete);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(949, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Supper Admin";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridViewAfterdelete
            // 
            this.dataGridViewAfterdelete.AllowUserToAddRows = false;
            this.dataGridViewAfterdelete.AllowUserToDeleteRows = false;
            this.dataGridViewAfterdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAfterdelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAfterdelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAfterdelete.Location = new System.Drawing.Point(13, 205);
            this.dataGridViewAfterdelete.Name = "dataGridViewAfterdelete";
            this.dataGridViewAfterdelete.ReadOnly = true;
            this.dataGridViewAfterdelete.Size = new System.Drawing.Size(924, 219);
            this.dataGridViewAfterdelete.TabIndex = 12;
            // 
            // buttonDeleteAdmin
            // 
            this.buttonDeleteAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteAdmin.Location = new System.Drawing.Point(144, 133);
            this.buttonDeleteAdmin.Name = "buttonDeleteAdmin";
            this.buttonDeleteAdmin.Size = new System.Drawing.Size(85, 36);
            this.buttonDeleteAdmin.TabIndex = 11;
            this.buttonDeleteAdmin.Text = "Delete";
            this.buttonDeleteAdmin.UseVisualStyleBackColor = true;
            this.buttonDeleteAdmin.Click += new System.EventHandler(this.buttonDeleteAdmin_Click);
            // 
            // textBoxAdmin_name_delete
            // 
            this.textBoxAdmin_name_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdmin_name_delete.Location = new System.Drawing.Point(144, 98);
            this.textBoxAdmin_name_delete.Name = "textBoxAdmin_name_delete";
            this.textBoxAdmin_name_delete.Size = new System.Drawing.Size(263, 29);
            this.textBoxAdmin_name_delete.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Supper Admin Name:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Delete Supper Admin:";
            // 
            // UserControlAdminSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlAdminSetting";
            this.Size = new System.Drawing.Size(977, 468);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchAdmin)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfterdelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxAdminpassword;
        private System.Windows.Forms.TextBox textBoxAdminname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteAdmin;
        private System.Windows.Forms.TextBox textBoxAdmin_name_delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewSearchAdmin;
        private System.Windows.Forms.TextBox textBoxAdmin_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridViewAfterdelete;
    }
}
