using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Management.User_Control;

namespace Hotel_Management
{
    public partial class HomeForm : Form
    {
        public string username;
        public HomeForm()
        {
            InitializeComponent();
        }
        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you want to Log Out?","Log Out",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            UserControlDashboard userControlDashboard = new UserControlDashboard();
            userControlDashboard.Dock = DockStyle.Fill;
            panel6.Controls.Add(userControlDashboard);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            UserControlClient1 userControlClient1 = new UserControlClient1();
            userControlClient1.Dock = DockStyle.Fill;
            panel6.Controls.Add(userControlClient1);
        }

      

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            UserControlReservation userControlReservation = new UserControlReservation();
           userControlReservation.Dock = DockStyle.Fill;
            panel6.Controls.Add(userControlReservation);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            UserControlSetting userControlSetting = new UserControlSetting();
            userControlSetting.Dock = DockStyle.Fill;
            panel6.Controls.Add(userControlSetting);

        }
    }
}
