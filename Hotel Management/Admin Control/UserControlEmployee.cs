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
    public partial class UserControlEmployee : UserControl
    {
        private string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Project SDP2\DatabaseEmployee\EmployeeData.mdf"";Integrated Security=True;Connect Timeout=30";
        SqlDataAdapter adpt;
        DataTable dt;
        SqlConnection conn = new SqlConnection();
        public UserControlEmployee()
        {
            InitializeComponent();
        }

        private void buttonEmployeeAdd_Click(object sender, EventArgs e)
        {
            string E_name = textBoxEmployeeName.Text.ToString();
            string E_phone = textBoxEmployeePhoneNo.Text.ToString();
            string E_nid = textBoxEmployeeNIDNo.Text.ToString();
            string E_email = textBoxEmployeeEmailID.Text.ToString();
            string E_gender = comboGender.SelectedIndex.ToString();
            if (string.IsNullOrEmpty(E_name) || string.IsNullOrEmpty(E_phone) || string.IsNullOrEmpty(E_nid) || string.IsNullOrEmpty(E_email) || string.IsNullOrEmpty(E_gender))
            {
                MessageBox.Show("No empty fields allowed.");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = CONNECTION_STRING;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Employee_table(E_Name, E_Nid, E_Phone, E_Email, E_Gender) VALUES('" + E_name + "','" + E_nid + "','" + E_phone + "','" + E_email + "','" + E_gender + "')";
                cmd.Connection = conn;
                int check = cmd.ExecuteNonQuery();
                conn.Close();
                if (check > 0)
                {
                    MessageBox.Show("Client added successfully.");
                    textBoxEmployeePhoneNo.Text = "";
                    textBoxEmployeeEmailID.Text = "";
                    textBoxEmployeeNIDNo.Text = "";
                    textBoxEmployeeName.Text = "";
                    comboGender.SelectedIndex = 0;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            SqlCommand cmd = new SqlCommand();
            string textToSearch = textBoxEmployeePhnoneNo.Text.ToString();

            adpt = new SqlDataAdapter("SELECT * FROM Employee_table WHERE E_Phone = '" + textToSearch + "'", conn);
            dt = new DataTable();
            adpt.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                dataGridViewEmployeeSearch.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No records found for the provided phone number.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewEmployeeSearch.DataSource = null;
            }
            textBoxEmployeePhnoneNo.Text = "";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            ShowEmployeeData();
        }

        private void ShowEmployeeData()
        {
            conn.ConnectionString = CONNECTION_STRING;
            adpt = new SqlDataAdapter("SELECT * FROM Employee_table", conn);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridViewAllEmployee.DataSource = dt;
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = CONNECTION_STRING;
            string textToSearch = textBoxEmployeePhone.Text.Trim();

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Employee_table WHERE E_Phone = @phoneNumber", conn);
                cmd.Parameters.AddWithValue("@phoneNumber", textToSearch);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Employee_table", conn);
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);
                    dataGridViewAllEmployee.DataSource = dt;
                    MessageBox.Show($"{rowsAffected}deleted successfully.");
                    textBoxEmployeePhone.Text = "";
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
