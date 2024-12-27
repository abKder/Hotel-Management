using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management.User_Control
{
    public partial class UserControlClient1 : UserControl
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseClient\ClientData.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter  adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public UserControlClient1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Client_name = textBoxClientName.Text.ToString();
            string Client_email = textBoxClientEmail.Text.ToString();
            string Client_nid = textBoxClientNID.Text.ToString();
            string Client_phone = textBoxClientPhone.Text.ToString();
            string Client_roomType = textBoxClientRoomType.Text.ToString();
            string Client_roomNo = textBoxClientRoomNo.Text.ToString();
            string Client_in = textBoxClientIn.Text.ToString();
            string Client_out = textBoxClientOut.Text.ToString();
            if (String.IsNullOrEmpty(Client_name) || String.IsNullOrEmpty(Client_email) || String.IsNullOrEmpty(Client_nid) || String.IsNullOrEmpty(Client_phone) || String.IsNullOrEmpty(Client_roomType) || String.IsNullOrEmpty(Client_roomNo) || String.IsNullOrEmpty(Client_in) || String.IsNullOrEmpty(Client_out) || String.IsNullOrEmpty(Client_in))
            {
                MessageBox.Show("No empty fields allowed.");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Client_table (Client_name, Client_email, Client_nid, Client_phone, Client_roomType, Client_roomNo, Client_in, Client_out) VALUES('"+Client_name+"','"+Client_email+"','"+Client_nid+"','"+Client_phone+ "','"+Client_roomType+ "','"+Client_roomNo+ "','"+Client_in+ "','"+Client_out+"')";
                cmd.Connection = conn;
               int check = cmd.ExecuteNonQuery();
                conn.Close();
                if (check > 0)
                {
                    MessageBox.Show("Client added successfully.");
                    textBoxClientName.Text = "";
                    textBoxClientEmail.Text = "";
                    textBoxClientNID.Text = "";
                    textBoxClientPhone.Text = "";
                    textBoxClientRoomType.Text = "";
                    textBoxClientRoomNo.Text = "";
                    textBoxClientIn.Text = "";
                    textBoxClientOut.Text = "";
                }
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            ShowClientData();
        }

        private void ShowClientData()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM Client_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllClient.DataSource = dt;

        }

        private void Search_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            string textToSearch = textBoxClient_Phone.Text.ToString();

            adpt = new SqlDataAdapter("SELECT * FROM Client_table WHERE Client_phone = '" + textToSearch + "'", conn);
            dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewSearchValue.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No records found for the provided phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewSearchValue.DataSource = null; 
            }
            textBoxClient_Phone.Text = "";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            string textToSearch = textBoxClient_phoneNo.Text.Trim();

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
                    dataGridViewAllClient.DataSource = dt;
                    MessageBox.Show($"{rowsAffected}deleted successfully.");
                    textBoxClient_phoneNo.Text = "";
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
