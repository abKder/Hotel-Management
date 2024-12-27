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
    public partial class UserControlAdminReservation : UserControl
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseReservation\ReservationData.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public UserControlAdminReservation()
        {
            InitializeComponent();
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {
            ShowReservationData();
        }

        private void ShowReservationData()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM Reservation_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAdminAllReservationData.DataSource = dt;
        }

        private void buttonSearchReservation_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            string textToSearch = textBoxReservationPhone.Text.ToString();

            adpt = new SqlDataAdapter("SELECT * FROM Reservation_table WHERE R_Phone = '" + textToSearch + "'", conn);
            dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewSearchReservationData.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No records found for the provided phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewSearchReservationData.DataSource = null;
            }
            textBoxReservationPhone.Text = "";
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            ShowReservationDataDelete();
        }

        private void ShowReservationDataDelete()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM Reservation_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewShowReservationDataafterDelete.DataSource = dt;
        }

        private void buttonDeleteReservationFormAdmin_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            string textToSearch = textBoxReservationphoneNo.Text.Trim();

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
                    dataGridViewShowReservationDataafterDelete.DataSource = dt;
                    MessageBox.Show($"{rowsAffected}deleted successfully.");
                    textBoxReservationphoneNo.Text = "";
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
