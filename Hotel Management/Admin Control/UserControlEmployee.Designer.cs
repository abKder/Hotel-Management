namespace Hotel_Management.Admin_Control
{
    partial class UserControlEmployee
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxEmployeGender = new System.Windows.Forms.TextBox();
            this.buttonEmployeeAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmployeeEmailID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEmployeePhoneNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmployeeNIDNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridViewEmployeeSearch = new System.Windows.Forms.DataGridView();
            this.textBoxEmployeePhnoneNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewAllEmployee = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.textBoxEmployeePhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeSearch)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmployee)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 474);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxEmployeGender);
            this.tabPage1.Controls.Add(this.buttonEmployeeAdd);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxEmployeeEmailID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxEmployeePhoneNo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxEmployeeNIDNo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxEmployeeName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxEmployeGender
            // 
            this.textBoxEmployeGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmployeGender.Location = new System.Drawing.Point(180, 280);
            this.textBoxEmployeGender.Name = "textBoxEmployeGender";
            this.textBoxEmployeGender.Size = new System.Drawing.Size(330, 32);
            this.textBoxEmployeGender.TabIndex = 12;
            // 
            // buttonEmployeeAdd
            // 
            this.buttonEmployeeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployeeAdd.Location = new System.Drawing.Point(870, 378);
            this.buttonEmployeeAdd.Name = "buttonEmployeeAdd";
            this.buttonEmployeeAdd.Size = new System.Drawing.Size(81, 38);
            this.buttonEmployeeAdd.TabIndex = 11;
            this.buttonEmployeeAdd.Text = "Add";
            this.buttonEmployeeAdd.UseVisualStyleBackColor = true;
            this.buttonEmployeeAdd.Click += new System.EventHandler(this.buttonEmployeeAdd_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Gender:";
            // 
            // textBoxEmployeeEmailID
            // 
            this.textBoxEmployeeEmailID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmployeeEmailID.Location = new System.Drawing.Point(529, 203);
            this.textBoxEmployeeEmailID.Name = "textBoxEmployeeEmailID";
            this.textBoxEmployeeEmailID.Size = new System.Drawing.Size(294, 32);
            this.textBoxEmployeeEmailID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email ID:";
            // 
            // textBoxEmployeePhoneNo
            // 
            this.textBoxEmployeePhoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmployeePhoneNo.Location = new System.Drawing.Point(529, 121);
            this.textBoxEmployeePhoneNo.Name = "textBoxEmployeePhoneNo";
            this.textBoxEmployeePhoneNo.Size = new System.Drawing.Size(294, 32);
            this.textBoxEmployeePhoneNo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Phone No:";
            // 
            // textBoxEmployeeNIDNo
            // 
            this.textBoxEmployeeNIDNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmployeeNIDNo.Location = new System.Drawing.Point(180, 203);
            this.textBoxEmployeeNIDNo.Name = "textBoxEmployeeNIDNo";
            this.textBoxEmployeeNIDNo.Size = new System.Drawing.Size(330, 32);
            this.textBoxEmployeeNIDNo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "NID No:";
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmployeeName.Location = new System.Drawing.Point(180, 121);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(330, 32);
            this.textBoxEmployeeName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dataGridViewEmployeeSearch);
            this.tabPage2.Controls.Add(this.textBoxEmployeePhnoneNo);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employee Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(191, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridViewEmployeeSearch
            // 
            this.dataGridViewEmployeeSearch.AllowUserToAddRows = false;
            this.dataGridViewEmployeeSearch.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeeSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewEmployeeSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployeeSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeSearch.Location = new System.Drawing.Point(10, 185);
            this.dataGridViewEmployeeSearch.Name = "dataGridViewEmployeeSearch";
            this.dataGridViewEmployeeSearch.ReadOnly = true;
            this.dataGridViewEmployeeSearch.Size = new System.Drawing.Size(959, 233);
            this.dataGridViewEmployeeSearch.TabIndex = 3;
            // 
            // textBoxEmployeePhnoneNo
            // 
            this.textBoxEmployeePhnoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmployeePhnoneNo.Location = new System.Drawing.Point(191, 84);
            this.textBoxEmployeePhnoneNo.Name = "textBoxEmployeePhnoneNo";
            this.textBoxEmployeePhnoneNo.Size = new System.Drawing.Size(258, 32);
            this.textBoxEmployeePhnoneNo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Phone No:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employee Details:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewAllEmployee);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.buttonDeleteEmployee);
            this.tabPage3.Controls.Add(this.textBoxEmployeePhone);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(975, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Employee Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridViewAllEmployee
            // 
            this.dataGridViewAllEmployee.AllowUserToAddRows = false;
            this.dataGridViewAllEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewAllEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAllEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllEmployee.Location = new System.Drawing.Point(10, 191);
            this.dataGridViewAllEmployee.Name = "dataGridViewAllEmployee";
            this.dataGridViewAllEmployee.ReadOnly = true;
            this.dataGridViewAllEmployee.Size = new System.Drawing.Size(959, 233);
            this.dataGridViewAllEmployee.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(216, 131);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(93, 39);
            this.buttonDeleteEmployee.TabIndex = 3;
            this.buttonDeleteEmployee.Text = "Delete";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // textBoxEmployeePhone
            // 
            this.textBoxEmployeePhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmployeePhone.Location = new System.Drawing.Point(216, 84);
            this.textBoxEmployeePhone.Name = "textBoxEmployeePhone";
            this.textBoxEmployeePhone.Size = new System.Drawing.Size(222, 32);
            this.textBoxEmployeePhone.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "Phone No:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Employee Delete:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControlEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlEmployee";
            this.Size = new System.Drawing.Size(986, 480);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeSearch)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmployeeEmailID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEmployeePhoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmployeeNIDNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEmployeeAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeSearch;
        private System.Windows.Forms.TextBox textBoxEmployeePhnoneNo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewAllEmployee;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.TextBox textBoxEmployeePhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEmployeGender;
        private System.Windows.Forms.Button button3;
    }
}
