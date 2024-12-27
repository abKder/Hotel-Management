namespace Hotel_Management.Admin_Control
{
    partial class UserControlAdminClient
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
            this.dataGridViewAllClient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewAdminSearch = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.textBoxAdminClientPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewAdminAllClient = new System.Windows.Forms.DataGridView();
            this.buttonAdminDelete = new System.Windows.Forms.Button();
            this.textBoxAdminClient_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllClient)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminSearch)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAllClient)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewAllClient);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "All Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridViewAllClient
            // 
            this.dataGridViewAllClient.AllowUserToAddRows = false;
            this.dataGridViewAllClient.AllowUserToDeleteRows = false;
            this.dataGridViewAllClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAllClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllClient.Location = new System.Drawing.Point(6, 64);
            this.dataGridViewAllClient.Name = "dataGridViewAllClient";
            this.dataGridViewAllClient.ReadOnly = true;
            this.dataGridViewAllClient.Size = new System.Drawing.Size(957, 363);
            this.dataGridViewAllClient.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Client:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewAdminSearch);
            this.tabPage2.Controls.Add(this.Search);
            this.tabPage2.Controls.Add(this.textBoxAdminClientPhone);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAdminSearch
            // 
            this.dataGridViewAdminSearch.AllowUserToAddRows = false;
            this.dataGridViewAdminSearch.AllowUserToDeleteRows = false;
            this.dataGridViewAdminSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAdminSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdminSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminSearch.Location = new System.Drawing.Point(6, 194);
            this.dataGridViewAdminSearch.Name = "dataGridViewAdminSearch";
            this.dataGridViewAdminSearch.ReadOnly = true;
            this.dataGridViewAdminSearch.Size = new System.Drawing.Size(957, 233);
            this.dataGridViewAdminSearch.TabIndex = 19;
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Location = new System.Drawing.Point(153, 111);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(102, 39);
            this.Search.TabIndex = 18;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBoxAdminClientPhone
            // 
            this.textBoxAdminClientPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdminClientPhone.Location = new System.Drawing.Point(153, 76);
            this.textBoxAdminClientPhone.Name = "textBoxAdminClientPhone";
            this.textBoxAdminClientPhone.Size = new System.Drawing.Size(280, 29);
            this.textBoxAdminClientPhone.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone No:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Client Details:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewAdminAllClient);
            this.tabPage3.Controls.Add(this.buttonAdminDelete);
            this.tabPage3.Controls.Add(this.textBoxAdminClient_Phone);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(969, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Client";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridViewAdminAllClient
            // 
            this.dataGridViewAdminAllClient.AllowUserToAddRows = false;
            this.dataGridViewAdminAllClient.AllowUserToDeleteRows = false;
            this.dataGridViewAdminAllClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAdminAllClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdminAllClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminAllClient.Location = new System.Drawing.Point(6, 200);
            this.dataGridViewAdminAllClient.Name = "dataGridViewAdminAllClient";
            this.dataGridViewAdminAllClient.ReadOnly = true;
            this.dataGridViewAdminAllClient.Size = new System.Drawing.Size(957, 227);
            this.dataGridViewAdminAllClient.TabIndex = 17;
            // 
            // buttonAdminDelete
            // 
            this.buttonAdminDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdminDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdminDelete.Location = new System.Drawing.Point(180, 134);
            this.buttonAdminDelete.Name = "buttonAdminDelete";
            this.buttonAdminDelete.Size = new System.Drawing.Size(92, 34);
            this.buttonAdminDelete.TabIndex = 16;
            this.buttonAdminDelete.Text = "Delete";
            this.buttonAdminDelete.UseVisualStyleBackColor = true;
            this.buttonAdminDelete.Click += new System.EventHandler(this.buttonAdminDelete_Click);
            // 
            // textBoxAdminClient_Phone
            // 
            this.textBoxAdminClient_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAdminClient_Phone.Location = new System.Drawing.Point(180, 81);
            this.textBoxAdminClient_Phone.Name = "textBoxAdminClient_Phone";
            this.textBoxAdminClient_Phone.Size = new System.Drawing.Size(280, 29);
            this.textBoxAdminClient_Phone.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phone No:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Delete Client:";
            // 
            // UserControlAdminClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlAdminClient";
            this.Size = new System.Drawing.Size(983, 474);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllClient)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminSearch)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAllClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxAdminClientPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdminDelete;
        private System.Windows.Forms.TextBox textBoxAdminClient_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.DataGridView dataGridViewAdminSearch;
        private System.Windows.Forms.DataGridView dataGridViewAdminAllClient;
        private System.Windows.Forms.DataGridView dataGridViewAllClient;
    }
}
