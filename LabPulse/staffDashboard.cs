using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabPulse
{
    public partial class staffDashboard : Form
    {
        public staffDashboard(string? dbName)
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 welcomeScreen = new Form1();
            welcomeScreen.Show();

            // Close this dashboard completely to free up system memory
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Pass 'this' (the current dashboard instance) into the profile constructor
            profile profileForm = new profile(this);
            profileForm.Show();
            this.Hide();
        }
    }
}
