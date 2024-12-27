using Hotel_Management.Admin_Control;
using Hotel_Management.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management.AdminHomePage
{
    public partial class FormAdminHomePage : Form
    {
        public FormAdminHomePage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                this.Hide();
                FormAdminLogin formAdminLogin = new FormAdminLogin();
                formAdminLogin.Show();
            }
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            UserControlEmployee userControlEmployee = new UserControlEmployee();
            userControlEmployee.Dock = DockStyle.Fill;
            panel4.Controls.Add(userControlEmployee);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            UserControlAdminClient userControlAdminClient = new UserControlAdminClient();
            userControlAdminClient.Dock = DockStyle.Fill;
            panel4.Controls.Add(userControlAdminClient);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            UserControlAdminSetting userControlAdminSetting = new UserControlAdminSetting();
            userControlAdminSetting.Dock = DockStyle.Fill;
            panel4.Controls.Add(userControlAdminSetting);
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            UserControlAdminReservation userControlAdminReservation = new UserControlAdminReservation();
            userControlAdminReservation.Dock = DockStyle.Fill;
            panel4.Controls.Add(userControlAdminReservation);
        }
    }
}
