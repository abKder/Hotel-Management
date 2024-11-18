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

namespace Hotel_Management
{
    public partial class LoginForm : Form
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseUser\UserDatabase.mdf"";Integrated Security=True;Connect Timeout=30";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.ToString();
            string userpassword = textBoxPassword.Text.ToString();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userpassword))
            {
                DialogResult dialogResult = MessageBox.Show("Please fill up the form ", "You cannot continue", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
               conn.ConnectionString = CONNECTION_STRING;
               conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM user_table WHERE username = '" + username + "' AND userpassword = '" + userpassword + "' ";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    this.Hide();
                    HomeForm homeForm = new HomeForm();
                    homeForm.username = textBoxUsername.Text;
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();
                    homeForm.Show();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect");
                }
                conn.Close();
            }
        }

       
    }
}
