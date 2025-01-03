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

namespace Hotel_Management.Create_admin_account
{
    public partial class FormCreateAdminAccount : Form
    {
        private string CNNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Md.Abdul Kader\OneDrive\Documents\DatabaseAdmin.mdf"";Integrated Security=True;Connect Timeout=30";
        public FormCreateAdminAccount()
        {
            InitializeComponent();
        }

        private void buttonSuperadmincreateclose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {

            string adminName = textBoxAdminName.Text.Trim();
            string adminPassword = textBoxAdminPassword.Text.Trim();

            if (string.IsNullOrEmpty(adminName) || string.IsNullOrEmpty(adminPassword))
            {
                MessageBox.Show("No empty fields allowed.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(CNNECTION_STRING))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(1) FROM Adminuser_table WHERE Admin_Username = @AdminName";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@AdminName", adminName);
                    int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userExists > 0)
                    {
                        MessageBox.Show("Supper Admin already exists. Please choose a different Supper Admin Name.");
                        textBoxAdminName.Text = "";
                        textBoxAdminPassword.Text = "";
                        return;
                    }
                }
                string insertQuery = "INSERT INTO Adminuser_table (Admin_Username, Admin_Userpassword) VALUES (@AdminName, @AdminPassword)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@AdminName", adminName);
                    insertCmd.Parameters.AddWithValue("@AdminPassword", adminPassword);

                    int check = insertCmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        MessageBox.Show("Create account successfully.");
                        textBoxAdminName.Text = "";
                        textBoxAdminPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Supper Admin. Please try again.");
                    }
                }
            }
        }

        private void pictureBoxShow_Click_1(object sender, EventArgs e)
        {
            pictureBoxShow.Hide();
            textBoxAdminPassword.UseSystemPasswordChar = false;
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click_1(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            textBoxAdminPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }
    }
}
