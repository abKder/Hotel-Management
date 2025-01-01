using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Hotel_Management.AdminHomePage;
using Hotel_Management.User_Control;
using Hotel_Management.Forgot_Password;

namespace Hotel_Management
{
    public partial class FormAdminLogin : Form
    {
        private string CNNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Md.Abdul Kader\OneDrive\Documents\DatabaseAdmin.mdf"";Integrated Security=True;Connect Timeout=30";
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFrontPage formFrontPage = new FormFrontPage();
            formFrontPage.Show();
        }

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            string AdminUsername = textBoxAdminName.Text.ToString();
            string AdminPassword = textBoxAdminPassword.Text.ToString();
            if (string.IsNullOrEmpty(AdminUsername) || string.IsNullOrEmpty(AdminPassword))
            {
                DialogResult dialogResult = MessageBox.Show("No empty fields allowed.", "You cannot continue.", MessageBoxButtons.OK);

            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CNNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM Adminuser_table WHERE Admin_Username = '" + AdminUsername + "' AND Admin_Userpassword = '" + AdminPassword + "' ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    this.Hide();
                    FormAdminHomePage formAdminHomePage = new FormAdminHomePage();
                    textBoxAdminName.Clear();
                    textBoxAdminPassword.Clear();
                    formAdminHomePage.Show();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect");
                }
                conn.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormForgotPasswordAdmin formForgotPasswordAdmin = new FormForgotPasswordAdmin();
            formForgotPasswordAdmin.Show();
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
