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

namespace Hotel_Management.Admin_Control
{
    public partial class UserControlAdminClient : UserControl
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseClient\ClientData.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public UserControlAdminClient()
        {
            InitializeComponent();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            string textToSearch = textBoxAdminClientPhone.Text.ToString();

            adpt = new SqlDataAdapter("SELECT * FROM Client_table WHERE Client_phone = '" + textToSearch + "'", conn);
            dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewAdminSearch.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No records found for the provided phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewAdminSearch.DataSource = null;
            }
            textBoxAdminClientPhone.Text = "";
        }

        private void buttonAdminDelete_Click(object sender, EventArgs e)
        {
                conn.ConnectionString = CONNECTION_STRING;
                string textToSearch = textBoxAdminClient_Phone.Text.Trim();
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM client_table WHERE Client_phone = @phoneNumber", conn);
                    cmd.Parameters.AddWithValue("@phoneNumber", textToSearch);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM client_table", conn);
                        DataTable dt = new DataTable();
                        adpt.Fill(dt);
                        dataGridViewAdminAllClient.DataSource = dt;
                        MessageBox.Show($"{rowsAffected}deleted successfully.");
                        textBoxAdminClient_Phone.Text = "";
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

        private void tabPage3_Click(object sender, EventArgs e)
        {
            ShowClientData();
        }
        private void ShowClientData()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELEct * FROM Client_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAdminAllClient.DataSource = dt;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            ShowAllClientData();
        }

        private void ShowAllClientData()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELEct * FROM Client_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllClient.DataSource = dt;
        }
    }
}
