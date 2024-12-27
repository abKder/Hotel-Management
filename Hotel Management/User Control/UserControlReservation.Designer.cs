namespace Hotel_Management.User_Control
{
    partial class UserControlReservation
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
            this.textBoxR_roomtype = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxR_phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxR_out = new System.Windows.Forms.TextBox();
            this.textBoxR_in = new System.Windows.Forms.TextBox();
            this.textBoxR_nid = new System.Windows.Forms.TextBox();
            this.textBoxR_roomno = new System.Windows.Forms.TextBox();
            this.textBoxR_name = new System.Windows.Forms.TextBox();
            this.buttonReservation_Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Search = new System.Windows.Forms.Button();
            this.dataGridViewSearchReservation = new System.Windows.Forms.DataGridView();
            this.textBoxRe_Phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewAll_Reservation = new System.Windows.Forms.DataGridView();
            this.textBoxRe_phoneNo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchReservation)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll_Reservation)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(912, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxR_roomtype);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBoxR_phone);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBoxR_out);
            this.tabPage1.Controls.Add(this.textBoxR_in);
            this.tabPage1.Controls.Add(this.textBoxR_nid);
            this.tabPage1.Controls.Add(this.textBoxR_roomno);
            this.tabPage1.Controls.Add(this.textBoxR_name);
            this.tabPage1.Controls.Add(this.buttonReservation_Add);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Reservation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxR_roomtype
            // 
            this.textBoxR_roomtype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR_roomtype.Location = new System.Drawing.Point(155, 247);
            this.textBoxR_roomtype.Name = "textBoxR_roomtype";
            this.textBoxR_roomtype.Size = new System.Drawing.Size(265, 29);
            this.textBoxR_roomtype.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(151, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "Room Type:";
            // 
            // textBoxR_phone
            // 
            this.textBoxR_phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR_phone.Location = new System.Drawing.Point(489, 108);
            this.textBoxR_phone.Name = "textBoxR_phone";
            this.textBoxR_phone.Size = new System.Drawing.Size(265, 29);
            this.textBoxR_phone.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(485, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Phone No:";
            // 
            // textBoxR_out
            // 
            this.textBoxR_out.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR_out.Location = new System.Drawing.Point(489, 247);
            this.textBoxR_out.Name = "textBoxR_out";
            this.textBoxR_out.Size = new System.Drawing.Size(265, 29);
            this.textBoxR_out.TabIndex = 11;
            // 
            // textBoxR_in
            // 
            this.textBoxR_in.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR_in.Location = new System.Drawing.Point(489, 178);
            this.textBoxR_in.Name = "textBoxR_in";
            this.textBoxR_in.Size = new System.Drawing.Size(265, 29);
            this.textBoxR_in.TabIndex = 10;
            // 
            // textBoxR_nid
            // 
            this.textBoxR_nid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR_nid.Location = new System.Drawing.Point(155, 178);
            this.textBoxR_nid.Name = "textBoxR_nid";
            this.textBoxR_nid.Size = new System.Drawing.Size(265, 29);
            this.textBoxR_nid.TabIndex = 9;
            // 
            // textBoxR_roomno
            // 
            this.textBoxR_roomno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR_roomno.Location = new System.Drawing.Point(155, 314);
            this.textBoxR_roomno.Name = "textBoxR_roomno";
            this.textBoxR_roomno.Size = new System.Drawing.Size(265, 29);
            this.textBoxR_roomno.TabIndex = 8;
            // 
            // textBoxR_name
            // 
            this.textBoxR_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxR_name.Location = new System.Drawing.Point(155, 108);
            this.textBoxR_name.Name = "textBoxR_name";
            this.textBoxR_name.Size = new System.Drawing.Size(265, 29);
            this.textBoxR_name.TabIndex = 7;
            // 
            // buttonReservation_Add
            // 
            this.buttonReservation_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReservation_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReservation_Add.Location = new System.Drawing.Point(801, 320);
            this.buttonReservation_Add.Name = "buttonReservation_Add";
            this.buttonReservation_Add.Size = new System.Drawing.Size(97, 33);
            this.buttonReservation_Add.TabIndex = 6;
            this.buttonReservation_Add.Text = "Add";
            this.buttonReservation_Add.UseVisualStyleBackColor = true;
            this.buttonReservation_Add.Click += new System.EventHandler(this.buttonReservation_Add_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Out:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "In:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(151, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(151, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Room No:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "NID:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Reservation:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Search);
            this.tabPage2.Controls.Add(this.dataGridViewSearchReservation);
            this.tabPage2.Controls.Add(this.textBoxRe_Phone);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservation Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.Location = new System.Drawing.Point(185, 116);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(102, 39);
            this.Search.TabIndex = 13;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // dataGridViewSearchReservation
            // 
            this.dataGridViewSearchReservation.AllowUserToAddRows = false;
            this.dataGridViewSearchReservation.AllowUserToDeleteRows = false;
            this.dataGridViewSearchReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchReservation.Location = new System.Drawing.Point(19, 181);
            this.dataGridViewSearchReservation.Name = "dataGridViewSearchReservation";
            this.dataGridViewSearchReservation.ReadOnly = true;
            this.dataGridViewSearchReservation.Size = new System.Drawing.Size(867, 169);
            this.dataGridViewSearchReservation.TabIndex = 4;
            // 
            // textBoxRe_Phone
            // 
            this.textBoxRe_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRe_Phone.Location = new System.Drawing.Point(185, 81);
            this.textBoxRe_Phone.Name = "textBoxRe_Phone";
            this.textBoxRe_Phone.Size = new System.Drawing.Size(269, 29);
            this.textBoxRe_Phone.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phone No:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservation Details:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewAll_Reservation);
            this.tabPage3.Controls.Add(this.textBoxRe_phoneNo);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(904, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Reservation";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridViewAll_Reservation
            // 
            this.dataGridViewAll_Reservation.AllowUserToAddRows = false;
            this.dataGridViewAll_Reservation.AllowUserToDeleteRows = false;
            this.dataGridViewAll_Reservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAll_Reservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAll_Reservation.Location = new System.Drawing.Point(10, 182);
            this.dataGridViewAll_Reservation.Name = "dataGridViewAll_Reservation";
            this.dataGridViewAll_Reservation.ReadOnly = true;
            this.dataGridViewAll_Reservation.Size = new System.Drawing.Size(881, 169);
            this.dataGridViewAll_Reservation.TabIndex = 14;
            // 
            // textBoxRe_phoneNo
            // 
            this.textBoxRe_phoneNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRe_phoneNo.Location = new System.Drawing.Point(177, 94);
            this.textBoxRe_phoneNo.Name = "textBoxRe_phoneNo";
            this.textBoxRe_phoneNo.Size = new System.Drawing.Size(303, 29);
            this.textBoxRe_phoneNo.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(177, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(173, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "Phone No:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Delete Reservation:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // UserControlReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlReservation";
            this.Size = new System.Drawing.Size(915, 412);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchReservation)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAll_Reservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReservation_Add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewSearchReservation;
        private System.Windows.Forms.TextBox textBoxRe_Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxRe_phoneNo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridViewAll_Reservation;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBoxR_out;
        private System.Windows.Forms.TextBox textBoxR_in;
        private System.Windows.Forms.TextBox textBoxR_nid;
        private System.Windows.Forms.TextBox textBoxR_roomno;
        private System.Windows.Forms.TextBox textBoxR_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxR_phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxR_roomtype;
        private System.Windows.Forms.Label label11;
    }
}
