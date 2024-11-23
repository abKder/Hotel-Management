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
        private void MovePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           DialogResult result = MessageBox.Show("Are you want to Log Out?","Log Out",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }
        private void HomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUsername.Text = username;
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(buttonDashboard);
            panel6.Controls.Clear();
            UserControlDashboard userControlDashboard = new UserControlDashboard();
            userControlDashboard.Dock = DockStyle.Fill;
            panel6.Controls.Add(userControlDashboard);
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            MovePanel(buttonClient);
            panel6.Controls.Clear();
           //// UserControlClient userControlClient = new UserControlClient();
           // userControlClient.Dock = DockStyle.Fill;
            panel6.Controls.Add(userControlClient);
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            MovePanel(buttonRoom);
            panel6.Controls.Clear();
            UserControlRoom userControlRoom = new UserControlRoom();
            userControlRoom.Dock = DockStyle.Fill;
            panel6.Controls.Add(userControlRoom);
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            MovePanel(buttonReservation);
            panel6.Controls.Clear();
            UserControlReservation userControlReservation = new UserControlReservation();
           userControlReservation.Dock = DockStyle.Fill;
            panel6.Controls.Add(userControlReservation);
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            MovePanel(buttonSetting);
            panel6.Controls.Clear();
            UserControlSetting userControlSetting = new UserControlSetting();
            userControlSetting.Dock = DockStyle.Fill;
            panel6.Controls.Add(userControlSetting);

        }


    }
}
