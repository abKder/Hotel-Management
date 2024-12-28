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
            string clientName = textBoxClientName.Text.Trim();
            string clientEmail = textBoxClientEmail.Text.Trim();
            string clientNid = textBoxClientNID.Text.Trim();
            string clientPhone = textBoxClientPhone.Text.Trim();
            string clientRoomType = textBoxClientRoomType.Text.Trim();
            string clientRoomNo = textBoxClientRoomNo.Text.Trim();
            string clientIn = textBoxClientIn.Text.Trim();
            string clientOut = textBoxClientOut.Text.Trim();

            if (string.IsNullOrEmpty(clientName) || string.IsNullOrEmpty(clientEmail) || string.IsNullOrEmpty(clientNid) || string.IsNullOrEmpty(clientPhone) || string.IsNullOrEmpty(clientRoomType) || string.IsNullOrEmpty(clientRoomNo) || string.IsNullOrEmpty(clientIn) || string.IsNullOrEmpty(clientOut))
            {
                MessageBox.Show("No empty fields allowed.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();
                string checkQuery = @"
            SELECT COUNT(1)
            FROM Client_table
            WHERE Client_roomNo = @RoomNo
              AND (Client_in <= @OutDate AND Client_out >= @InDate)";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@RoomNo", clientRoomNo);
                    checkCmd.Parameters.AddWithValue("@InDate", clientIn);
                    checkCmd.Parameters.AddWithValue("@OutDate", clientOut);

                    int roomExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (roomExists > 0)
                    {
                        MessageBox.Show("The room is already reserved for the selected dates. Please choose a different room.");
                        return;
                    }
                }
                string insertQuery = @"
            INSERT INTO Client_table (Client_name, Client_email, Client_nid, Client_phone, Client_roomType, Client_roomNo, Client_in, Client_out)
            VALUES (@Name, @Email, @Nid, @Phone, @RoomType, @RoomNo, @InDate, @OutDate)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@Name", clientName);
                    insertCmd.Parameters.AddWithValue("@Email", clientEmail);
                    insertCmd.Parameters.AddWithValue("@Nid", clientNid);
                    insertCmd.Parameters.AddWithValue("@Phone", clientPhone);
                    insertCmd.Parameters.AddWithValue("@RoomType", clientRoomType);
                    insertCmd.Parameters.AddWithValue("@RoomNo", clientRoomNo);
                    insertCmd.Parameters.AddWithValue("@InDate", clientIn);
                    insertCmd.Parameters.AddWithValue("@OutDate", clientOut);

                    int check = insertCmd.ExecuteNonQuery();
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
                    else
                    {
                        MessageBox.Show("Failed to add client. Please try again.");
                    }
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
