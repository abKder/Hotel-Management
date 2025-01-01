using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management.Forgot_Password
{
    public partial class FormForgotPasswordAdmin : Form
    {
       // private System.Windows.Forms.ToolTip toolTip1;
        private string CNNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Md.Abdul Kader\OneDrive\Documents\DatabaseAdmin.mdf"";Integrated Security=True;Connect Timeout=30";
        public FormForgotPasswordAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            string Adminname = textBoxAdminName.Text.Trim();
            string newPassword = textBoxAdminPassword.Text.Trim();

            if (string.IsNullOrEmpty(Adminname) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(CNNECTION_STRING))
                {
                    conn.Open();
                    string queryCheck = "SELECT COUNT(*) FROM Adminuser_table WHERE Admin_Username = @Adminname";
                    using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@Adminname", Adminname);
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("Admin username does not exist.");
                            return;
                        }
                    }
                    string queryUpdate = "UPDATE Adminuser_table SET Admin_Userpassword = @newPassword WHERE Admin_Username = @Adminname";
                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@Adminname", Adminname);
                        cmdUpdate.Parameters.AddWithValue("@newPassword", newPassword);
                        int rowsAffected = cmdUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                            textBoxAdminName.Text = "";
                            textBoxAdminPassword.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        Label tooltipLabel = new Label();
        private void Form1_Load(object sender, EventArgs e)
        {
            tooltipLabel.Text = "Hide Password";
            tooltipLabel.Visible = false;
            tooltipLabel.BackColor = Color.LightYellow; 
            tooltipLabel.AutoSize = true;
            tooltipLabel.BorderStyle = BorderStyle.FixedSingle;
            this.Controls.Add(tooltipLabel);
        }
        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            tooltipLabel.Location = new Point(pictureBoxHide.Right, pictureBoxHide.Top); 
            tooltipLabel.Visible = true;
        }

        private void pictureBoxHide_MouseLeave(object sender, EventArgs e)
        {
            tooltipLabel.Visible = false;
        }
       
        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            tooltipLabel.Location = new Point(pictureBoxShow.Right, pictureBoxShow.Top); 
            tooltipLabel.Visible = true;
        }

        private void pictureBoxShow_MouseHover_1(object sender, EventArgs e)
        {
            tooltipLabel.Visible = false;
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxAdminPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxAdminPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

       
    }
}
