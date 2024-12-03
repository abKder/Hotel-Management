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
                   // formAdminHomePage.Admin_Username = textBoxAdminName.Text;
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
    }
}
