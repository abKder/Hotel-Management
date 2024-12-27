namespace Hotel_Management.Admin_Control
{
    partial class UserControlAdminReservation
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewAdminAllReservationData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewSearchReservationData = new System.Windows.Forms.DataGridView();
            this.buttonSearchReservation = new System.Windows.Forms.Button();
            this.textBoxReservationPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewShowReservationDataafterDelete = new System.Windows.Forms.DataGridView();
            this.buttonDeleteReservationFormAdmin = new System.Windows.Forms.Button();
            this.textBoxReservationphoneNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAllReservationData)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchReservationData)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowReservationDataafterDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 465);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewAdminAllReservationData);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(969, 430);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "All Reservation";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dataGridViewAdminAllReservationData
            // 
            this.dataGridViewAdminAllReservationData.AllowUserToAddRows = false;
            this.dataGridViewAdminAllReservationData.AllowUserToDeleteRows = false;
            this.dataGridViewAdminAllReservationData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAdminAllReservationData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdminAllReservationData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminAllReservationData.Location = new System.Drawing.Point(6, 58);
            this.dataGridViewAdminAllReservationData.Name = "dataGridViewAdminAllReservationData";
            this.dataGridViewAdminAllReservationData.ReadOnly = true;
            this.dataGridViewAdminAllReservationData.Size = new System.Drawing.Size(957, 363);
            this.dataGridViewAdminAllReservationData.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "All Reservation:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewSearchReservationData);
            this.tabPage5.Controls.Add(this.buttonSearchReservation);
            this.tabPage5.Controls.Add(this.textBoxReservationPhone);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(969, 430);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Reservation Details";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearchReservationData
            // 
            this.dataGridViewSearchReservationData.AllowUserToAddRows = false;
            this.dataGridViewSearchReservationData.AllowUserToDeleteRows = false;
            this.dataGridViewSearchReservationData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSearchReservationData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchReservationData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchReservationData.Location = new System.Drawing.Point(5, 188);
            this.dataGridViewSearchReservationData.Name = "dataGridViewSearchReservationData";
            this.dataGridViewSearchReservationData.ReadOnly = true;
            this.dataGridViewSearchReservationData.Size = new System.Drawing.Size(957, 233);
            this.dataGridViewSearchReservationData.TabIndex = 24;
            // 
            // buttonSearchReservation
            // 
            this.buttonSearchReservation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearchReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchReservation.Location = new System.Drawing.Point(152, 105);
            this.buttonSearchReservation.Name = "buttonSearchReservation";
            this.buttonSearchReservation.Size = new System.Drawing.Size(102, 39);
            this.buttonSearchReservation.TabIndex = 23;
            this.buttonSearchReservation.Text = "Search";
            this.buttonSearchReservation.UseVisualStyleBackColor = true;
            this.buttonSearchReservation.Click += new System.EventHandler(this.buttonSearchReservation_Click);
            // 
            // textBoxReservationPhone
            // 
            this.textBoxReservationPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxReservationPhone.Location = new System.Drawing.Point(152, 70);
            this.textBoxReservationPhone.Name = "textBoxReservationPhone";
            this.textBoxReservationPhone.Size = new System.Drawing.Size(280, 29);
            this.textBoxReservationPhone.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Phone No:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Client Details:";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridViewShowReservationDataafterDelete);
            this.tabPage6.Controls.Add(this.buttonDeleteReservationFormAdmin);
            this.tabPage6.Controls.Add(this.textBoxReservationphoneNo);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(969, 430);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Delete Reservation";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // dataGridViewShowReservationDataafterDelete
            // 
            this.dataGridViewShowReservationDataafterDelete.AllowUserToAddRows = false;
            this.dataGridViewShowReservationDataafterDelete.AllowUserToDeleteRows = false;
            this.dataGridViewShowReservationDataafterDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewShowReservationDataafterDelete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowReservationDataafterDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowReservationDataafterDelete.Location = new System.Drawing.Point(5, 194);
            this.dataGridViewShowReservationDataafterDelete.Name = "dataGridViewShowReservationDataafterDelete";
            this.dataGridViewShowReservationDataafterDelete.ReadOnly = true;
            this.dataGridViewShowReservationDataafterDelete.Size = new System.Drawing.Size(957, 227);
            this.dataGridViewShowReservationDataafterDelete.TabIndex = 22;
            // 
            // buttonDeleteReservationFormAdmin
            // 
            this.buttonDeleteReservationFormAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteReservationFormAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteReservationFormAdmin.Location = new System.Drawing.Point(179, 128);
            this.buttonDeleteReservationFormAdmin.Name = "buttonDeleteReservationFormAdmin";
            this.buttonDeleteReservationFormAdmin.Size = new System.Drawing.Size(92, 34);
            this.buttonDeleteReservationFormAdmin.TabIndex = 21;
            this.buttonDeleteReservationFormAdmin.Text = "Delete";
            this.buttonDeleteReservationFormAdmin.UseVisualStyleBackColor = true;
            this.buttonDeleteReservationFormAdmin.Click += new System.EventHandler(this.buttonDeleteReservationFormAdmin_Click);
            // 
            // textBoxReservationphoneNo
            // 
            this.textBoxReservationphoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxReservationphoneNo.Location = new System.Drawing.Point(179, 82);
            this.textBoxReservationphoneNo.Name = "textBoxReservationphoneNo";
            this.textBoxReservationphoneNo.Size = new System.Drawing.Size(280, 29);
            this.textBoxReservationphoneNo.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "Phone No:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 22);
            this.label10.TabIndex = 18;
            this.label10.Text = "Delete Client:";
            // 
            // UserControlAdminReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlAdminReservation";
            this.Size = new System.Drawing.Size(977, 468);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminAllReservationData)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchReservationData)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowReservationDataafterDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewAdminAllReservationData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridViewSearchReservationData;
        private System.Windows.Forms.Button buttonSearchReservation;
        private System.Windows.Forms.TextBox textBoxReservationPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dataGridViewShowReservationDataafterDelete;
        private System.Windows.Forms.Button buttonDeleteReservationFormAdmin;
        private System.Windows.Forms.TextBox textBoxReservationphoneNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
