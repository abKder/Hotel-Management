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

namespace Hotel_Management.User_Control
{
    public partial class UserControlReservation : UserControl
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseReservation\ReservationData.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public UserControlReservation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void buttonReservation_Add_Click(object sender, EventArgs e)
        {
            string re_name = textBoxR_name.Text.ToString();
            string re_phone = textBoxR_phone.Text.ToString();
            string re_nid = textBoxR_nid.Text.ToString();
            string re_roomNo = textBoxR_roomno.Text.ToString();
            string re_roomType = textBoxR_nid.Text.ToString();
            string re_in = textBoxR_in.Text.ToString();
            string re_out = textBoxR_out.Text.ToString();
            if (string.IsNullOrEmpty(re_name) || string.IsNullOrEmpty(re_phone) || string.IsNullOrEmpty(re_roomNo) || string.IsNullOrEmpty(re_roomType) || string.IsNullOrEmpty(re_in) || string.IsNullOrEmpty(re_out) || string.IsNullOrEmpty(re_in) || string.IsNullOrEmpty(re_nid))
            {
                MessageBox.Show("No empty fields allowed.");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Reservation_table(R_Name, R_Nid, R_Phone, R_RoomType, R_RoomNo, R_In, R_out) VALUES('" + re_name + "','" + re_nid + "','" + re_phone + "','" + re_roomType+ "','" + re_roomNo + "','" + re_in + "','" + re_out + "')";
                cmd.Connection = conn;
                int check = cmd.ExecuteNonQuery();
                conn.Close();
                if (check > 0)
                {
                    MessageBox.Show("Client added successfully.");
                    textBoxR_name.Text = "";
                    textBoxR_nid.Text = "";
                    textBoxR_phone.Text = "";
                    textBoxR_roomtype.Text = "";
                    textBoxR_roomno.Text = "";
                    textBoxR_in.Text = "";
                    textBoxR_out.Text = "";
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
                conn.ConnectionString = CONNECTION_STRING;
                SqlCommand cmd = new SqlCommand();
                string textToSearch = textBoxRe_Phone.Text.ToString();

                adpt = new SqlDataAdapter("SELECT * FROM Reservation_table WHERE R_Phone = '" + textToSearch + "'", conn);
                dt = new DataTable();
                adpt.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                     dataGridViewSearchReservation.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No records found for the provided phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewSearchReservation.DataSource = null;
                }
                  textBoxRe_Phone.Text = "";
            
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            ShowReservationData();
        }

        private void ShowReservationData()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM Reservation_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAll_Reservation.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            string textToSearch = textBoxRe_phoneNo.Text.Trim();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Reservation_table WHERE R_Phone = @phoneNumber", conn);
                cmd.Parameters.AddWithValue("@phoneNumber", textToSearch);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Reservation_table", conn);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewAll_Reservation.DataSource = dt;
                    MessageBox.Show($"{rowsAffected}deleted successfully.");
                    textBoxRe_phoneNo.Text = "";
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
