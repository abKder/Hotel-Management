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

namespace Hotel_Management.User_Control
{
    public partial class UserControlSetting : UserControl
    {
        public string _username;
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseUser\UserDatabase.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();

        public UserControlSetting(string usernam)
        {
            InitializeComponent();
            _username = usernam;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.Trim();
            string userpassword = textBoxUserPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userpassword))
            {
                MessageBox.Show("No empty fields allowed.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(1) FROM user_table WHERE username = @Username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userExists > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        textBoxUserName.Text = "";
                        textBoxUserPassword.Text = "";
                        return;
                    }
                }
                string insertQuery = "INSERT INTO user_table (username, userpassword) VALUES (@Username, @UserPassword)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@UserPassword", userpassword);

                    int check = insertCmd.ExecuteNonQuery();
                    if (check > 0)
                    {
                        MessageBox.Show("User added successfully.");
                        textBoxUserName.Text = "";
                        textBoxUserPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user. Please try again.");
                    }
                }
            }
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {
            ShowUserData();
        }

        private void ShowUserData()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM user_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllUserdata.DataSource = dt;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            string textToSearch = textBoxUserSearch.Text.ToString();

            adpt = new SqlDataAdapter("SELECT * FROM user_table WHERE username = '" + textToSearch + "'", conn);
            dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewUserSearchData.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No records found for the provided Username.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewUserSearchData.DataSource = null;
            }
            textBoxUserSearch.Text = "";
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            string textToSearch = textBoxDeleteUser.Text.Trim();
            string currentUsername = _username;

            if (string.IsNullOrEmpty(textToSearch))
            {
                MessageBox.Show("Please enter a username to delete.");
                return;
            }

            if (textToSearch.Equals(currentUsername, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot delete your own account.");
                textBoxDeleteUser.Text = "";
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM user_table WHERE username = @user AND username != @currentUser", conn);
                cmd.Parameters.AddWithValue("@user", textToSearch);
                cmd.Parameters.AddWithValue("@currentUser", currentUsername);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM user_table", conn);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewAllUserdata.DataSource = dt;
                    MessageBox.Show($"{rowsAffected} user(s) deleted successfully.");
                    textBoxDeleteUser.Text = "";
                }
                else
                {
                    MessageBox.Show("No matching user found, or you cannot delete this user.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

       
    }
}
