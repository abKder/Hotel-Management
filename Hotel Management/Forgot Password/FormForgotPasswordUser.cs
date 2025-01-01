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

namespace Hotel_Management.Forgot_Password
{
    public partial class FormForgotPasswordUser : Form
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseUser\UserDatabase.mdf"";Integrated Security=True;Connect Timeout=30";
        public FormForgotPasswordUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Username = textBoxUsername.Text.Trim();
            string newPassword = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    string queryCheck = "SELECT COUNT(*) FROM user_table WHERE username = @Username";
                    using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@Username", Username);
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count == 0)
                        {
                            MessageBox.Show("User does not exist.");
                            return;
                        }
                    }
                    string queryUpdate = "UPDATE user_table SET userpassword = @newPassword WHERE username = @Username";
                    using (SqlCommand cmdUpdate = new SqlCommand(queryUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@Username", Username);
                        cmdUpdate.Parameters.AddWithValue("@newPassword", newPassword);
                        int rowsAffected = cmdUpdate.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                            textBoxUsername.Text = "";
                            textBoxPassword.Text = "";
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
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

       
    }
}
