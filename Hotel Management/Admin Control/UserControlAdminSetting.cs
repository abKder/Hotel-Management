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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management.Admin_Control
{
    public partial class UserControlAdminSetting : UserControl
    {
        public string _Adminusername;

        private string CONNECTION_STRING1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseUser\UserDatabase.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt1;
        DataTable dt1;
        SqlConnection conn1 = new SqlConnection();

        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Md.Abdul Kader\OneDrive\Documents\DatabaseAdmin.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public UserControlAdminSetting(string adminusername)
        {
            InitializeComponent();
            _Adminusername = adminusername;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            ShowAdminData();
        }

        private void ShowAdminData()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM Adminuser_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAfterdelete.DataSource = dt;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            string textToSearch = textBoxAdmin_name.Text.ToString();

            adpt = new SqlDataAdapter("SELECT * FROM Adminuser_table WHERE Admin_Username = '" + textToSearch + "'", conn);
            dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewSearchAdmin.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No records found for the provided Username.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewSearchAdmin.DataSource = null;
            }
                textBoxAdmin_name.Text = "";
        }

        private void buttonDeleteAdmin_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            string textToSearch = textBoxAdmin_name_delete.Text.Trim();
            string currentAdminname = _Adminusername;

            if (string.IsNullOrEmpty(textToSearch))
            {
                MessageBox.Show("Please enter a username to delete.");
                return;
            }

            if (textToSearch.Equals(currentAdminname, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("You cannot delete your own account.");
                textBoxAdmin_name_delete.Text = "";
                return;
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Adminuser_table WHERE Admin_Username = @user AND Admin_Username != @currentAdmin", conn);
                cmd.Parameters.AddWithValue("@user", textToSearch);
                cmd.Parameters.AddWithValue("@currentAdmin", currentAdminname);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Admin_Username", conn);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewAfterdelete.DataSource = dt;
                    MessageBox.Show($"{rowsAffected} Supper Admin(s) deleted successfully.");
                    textBoxAdmin_name_delete.Text = "";
                }
                else
                {
                    MessageBox.Show("No matching Supper Admin found, or you cannot delete this user.");
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
        //Admin Site
        private void buttonAddAdmin_Click(object sender, EventArgs e)
        {

            string username = textBoxUserName.Text.Trim();
            string userpassword = textBoxUserPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userpassword))
            {
                MessageBox.Show("No empty fields allowed.");
                return;
            }

            using (SqlConnection conn1 = new SqlConnection(CONNECTION_STRING1))
            {
                conn1.Open();
                string checkQuery = "SELECT COUNT(1) FROM user_table WHERE username = @Username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn1))
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
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn1))
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

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING1;
            string textToSearch = textBoxDeleteUser.Text.Trim();
            if (string.IsNullOrEmpty(textToSearch))
            {
                MessageBox.Show("Please enter a Admin name to delete.");
                return;
            }

            try
            {
                conn1.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM user_table WHERE username = @user", conn1);
                cmd.Parameters.AddWithValue("@user", textToSearch);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    SqlDataAdapter adpt1 = new SqlDataAdapter("SELECT * FROM user_table", conn1);
                    DataTable dt1 = new DataTable();
                    adpt1.Fill(dt1);
                    dataGridViewAllUserdata.DataSource = dt1;
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
                conn1.Close();
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            ShowUserData();
        }

        private void ShowUserData()
        {
            conn1.ConnectionString = CONNECTION_STRING1;
            adpt1 = new SqlDataAdapter("SELECT * FROM user_table", conn1);
            dt1 = new DataTable();
            adpt1.Fill(dt1);
            dataGridViewAllUserdata.DataSource = dt1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING1;
            SqlCommand cmd = new SqlCommand();
            string textToSearch = textBoxUserSearch.Text.ToString();

            adpt1 = new SqlDataAdapter("SELECT * FROM user_table WHERE username = '" + textToSearch + "'", conn1);
            dt1 = new DataTable();
            adpt1.Fill(dt1);

            if (dt1.Rows.Count > 0)
            {
                dataGridViewUserSearchData.DataSource = dt1;
            }
            else
            {
                MessageBox.Show("No records found for the provided Username.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewUserSearchData.DataSource = null;
            }
            textBoxUserSearch.Text = "";
        }
    }
}

