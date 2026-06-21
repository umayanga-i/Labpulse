
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabPulse
{
    public partial class profile : Form
    {
        // Variable to remember which dashboard form opened the profile page
        private Form parentDashboard;
        public profile()
        {
            InitializeComponent();
        }

        // Updated custom constructor that receives the active dashboard
        public profile(Form callingForm)
        {
            InitializeComponent();
            this.parentDashboard = callingForm;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // If a parent dashboard was safely passed, reveal it again
            if (parentDashboard != null)
            {
                parentDashboard.Show();
                this.Close(); // Safely closes the profile form
            }
            else
            {
                // Fallback safety measure: If opened directly without a reference, default to login or close
                MessageBox.Show("Dashboard session lost. Closing window.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        // FormClosed event safety block
        private void profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ensures that if the user clicks the 'X' button instead of the back link, the dashboard still reappears
            if (parentDashboard != null)
            {
                parentDashboard.Show();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Initialize and display the main welcome/entry screen
            Form1 welcomeScreen = new Form1();
            welcomeScreen.Show();

            // 2. Clear out the hidden background dashboard so it isn't left hanging in memory
            if (this.parentDashboard != null)
            {
                // Unregister the FormClosed event temporarily so it doesn't try to reopen the dashboard
                this.FormClosed -= profile_FormClosed;

                this.parentDashboard.Close(); // Closes the underlying dashboard safely
            }

            // 3. Close the profile page itself
            this.Close();
        }
    }
}


