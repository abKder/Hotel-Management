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
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Md.Abdul Kader\OneDrive\Documents\DatabaseAdmin.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public UserControlAdminSetting()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string adminName = textBoxAdminname.Text.ToString();
            string adminpassword = textBoxAdminpassword.Text.ToString();
            if (string.IsNullOrEmpty(adminName) || string.IsNullOrEmpty(adminpassword))
            {
                MessageBox.Show("No empty fields allowed.");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Adminuser_table (Admin_Username, Admin_Userpassword) VALUES('" + adminName + "','" + adminpassword + "')";
                cmd.Connection = conn;
                int check = cmd.ExecuteNonQuery();
                conn.Close();
                if (check > 0)
                {
                    MessageBox.Show("User added successfully.");
                    textBoxAdminname.Text = "";
                    textBoxAdminpassword.Text = "";
                }
            }
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

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Adminuser_table WHERE Admin_Username = @user", conn);
                cmd.Parameters.AddWithValue("@user", textToSearch);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Adminuser_table", conn);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewAfterdelete.DataSource = dt;
                    MessageBox.Show($"{rowsAffected}deleted successfully.");
                    textBoxAdmin_name_delete.Text = "";
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
