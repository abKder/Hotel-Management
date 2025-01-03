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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonAddAdmin = new System.Windows.Forms.Button();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewUserSearchData = new System.Windows.Forms.DataGridView();
            this.textBoxUserSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewAllUserdata = new System.Windows.Forms.DataGridView();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.textBoxDeleteUser = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchAdmin)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfterdelete)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSearchData)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUserdata)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 465);
            this.tabControl1.TabIndex = 0;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonAddAdmin);
            this.tabPage4.Controls.Add(this.textBoxUserPassword);
            this.tabPage4.Controls.Add(this.textBoxUserName);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(949, 430);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add Admin";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonAddAdmin
            // 
            this.buttonAddAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddAdmin.Location = new System.Drawing.Point(153, 209);
            this.buttonAddAdmin.Name = "buttonAddAdmin";
            this.buttonAddAdmin.Size = new System.Drawing.Size(85, 36);
            this.buttonAddAdmin.TabIndex = 11;
            this.buttonAddAdmin.Text = "Add";
            this.buttonAddAdmin.UseVisualStyleBackColor = true;
            this.buttonAddAdmin.Click += new System.EventHandler(this.buttonAddAdmin_Click);
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserPassword.Location = new System.Drawing.Point(435, 151);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.Size = new System.Drawing.Size(263, 29);
            this.textBoxUserPassword.TabIndex = 10;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserName.Location = new System.Drawing.Point(153, 151);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(263, 29);
            this.textBoxUserName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Admin Name:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 24);
            this.label10.TabIndex = 6;
            this.label10.Text = "Add Admin:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.dataGridViewUserSearchData);
            this.tabPage5.Controls.Add(this.textBoxUserSearch);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(949, 430);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Admin Details";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(188, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 39);
            this.button3.TabIndex = 18;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewUserSearchData
            // 
            this.dataGridViewUserSearchData.AllowUserToAddRows = false;
            this.dataGridViewUserSearchData.AllowUserToDeleteRows = false;
            this.dataGridViewUserSearchData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUserSearchData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserSearchData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserSearchData.Location = new System.Drawing.Point(6, 252);
            this.dataGridViewUserSearchData.Name = "dataGridViewUserSearchData";
            this.dataGridViewUserSearchData.ReadOnly = true;
            this.dataGridViewUserSearchData.Size = new System.Drawing.Size(937, 172);
            this.dataGridViewUserSearchData.TabIndex = 17;
            // 
            // textBoxUserSearch
            // 
            this.textBoxUserSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserSearch.Location = new System.Drawing.Point(188, 132);
            this.textBoxUserSearch.Name = "textBoxUserSearch";
            this.textBoxUserSearch.Size = new System.Drawing.Size(288, 29);
            this.textBoxUserSearch.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(184, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 22);
            this.label11.TabIndex = 15;
            this.label11.Text = "Admin Name:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 24);
            this.label12.TabIndex = 14;
            this.label12.Text = "Admin Details:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridViewAllUserdata);
            this.tabPage6.Controls.Add(this.buttonDeleteUser);
            this.tabPage6.Controls.Add(this.textBoxDeleteUser);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.label14);
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(949, 430);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Delete Admin";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // dataGridViewAllUserdata
            // 
            this.dataGridViewAllUserdata.AllowUserToAddRows = false;
            this.dataGridViewAllUserdata.AllowUserToDeleteRows = false;
            this.dataGridViewAllUserdata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAllUserdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllUserdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllUserdata.Location = new System.Drawing.Point(6, 231);
            this.dataGridViewAllUserdata.Name = "dataGridViewAllUserdata";
            this.dataGridViewAllUserdata.ReadOnly = true;
            this.dataGridViewAllUserdata.Size = new System.Drawing.Size(937, 193);
            this.dataGridViewAllUserdata.TabIndex = 12;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteUser.Location = new System.Drawing.Point(186, 156);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(110, 41);
            this.buttonDeleteUser.TabIndex = 11;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // textBoxDeleteUser
            // 
            this.textBoxDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDeleteUser.Location = new System.Drawing.Point(186, 112);
            this.textBoxDeleteUser.Name = "textBoxDeleteUser";
            this.textBoxDeleteUser.Size = new System.Drawing.Size(304, 29);
            this.textBoxDeleteUser.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 22);
            this.label13.TabIndex = 9;
            this.label13.Text = "Admin Name:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 22);
            this.label14.TabIndex = 8;
            this.label14.Text = "Delete Admin:";
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchAdmin)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAfterdelete)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserSearchData)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUserdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonAddAdmin;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewUserSearchData;
        private System.Windows.Forms.TextBox textBoxUserSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridViewAllUserdata;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.TextBox textBoxDeleteUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}
