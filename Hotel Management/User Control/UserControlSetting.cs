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
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseUser\UserDatabase.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public UserControlSetting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text.ToString();
            string userpassword = textBoxUserPassword.Text.ToString();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userpassword))
            {
                MessageBox.Show("No empty fields allowed.");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO user_table (username, userpassword) VALUES('" + username + "','" + userpassword + "')";
                cmd.Connection = conn;
                int check = cmd.ExecuteNonQuery();
                conn.Close();
                if (check > 0)
                {
                    MessageBox.Show("User added successfully.");
                    textBoxUserName.Text = "";
                    textBoxUserPassword.Text = "";
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

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM user_table WHERE username = @user", conn);
                cmd.Parameters.AddWithValue("@user", textToSearch);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM user_table", conn);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewAllUserdata.DataSource = dt;
                    MessageBox.Show($"{rowsAffected}deleted successfully.");
                    textBoxDeleteUser.Text = "";
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
