using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabPulse
{
    public partial class adminDashboard : Form
    {
        public adminDashboard()
        {
            InitializeComponent();
        }



        public adminDashboard(string userName)
        {
            InitializeComponent();

            // Displays the user's name inside textBox1 dynamically
            textBox1.Text = userName;

            // Optional: Make textBox1 read-only so users can't manually alter their name display
            textBox1.ReadOnly = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to log out?",
        "Confirm Logout",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            // If the user clicks 'Yes', proceed to log them out
            if (result == DialogResult.Yes)
            {
                // Initialize and display the main welcome screen
                Form1 welcomeScreen = new Form1();
                welcomeScreen.Show();

                // Close this dashboard completely to free up system memory
                this.Close();
            }
            // If they click 'No', the method finishes running and nothing changes, leaving them on the dashboard
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Pass 'this' (the current dashboard instance) into the profile constructor
            profile profileForm = new profile(this);
            profileForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void systemAnalyticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pass 'this' (the adminDashboard) into the constructor
            ManageEquipment manageForm = new ManageEquipment(this);

            manageForm.Show(); // Open the management form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Issue issueForm = new Issue();

            // 2. Display the Issue screen
            issueForm.Show();

            // 3. Hide the current dashboard so the workspace stays clean
            this.Hide();
        }
    }
}
