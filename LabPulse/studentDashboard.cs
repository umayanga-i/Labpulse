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
    public partial class studentDashboard : Form
    {
        private string connectionString = "Server=localhost;Database=labpulse_db;Uid=root;Pwd=;";
        public studentDashboard()
        {
            InitializeComponent();
        }

        public studentDashboard(string userName)
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
        {// Pass 'this' (the current dashboard instance) into the profile constructor
            profile profileForm = new profile(this);
            profileForm.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchInput = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(searchInput))
            {
                MessageBox.Show("Please enter an equipment name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL query to pull the matching equipment info
            string query = "SELECT EquipmentID, Name, Status FROM equipment WHERE Name LIKE @SearchName LIMIT 1";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // The % wildcards allow matching partial names (e.g. "Oscilloscope" matches "Digital Oscilloscope DevKitV1")
                        cmd.Parameters.AddWithValue("@SearchName", "%" + searchInput + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Extract database values safely
                                string eqID = reader["EquipmentID"].ToString();
                                string eqName = reader["Name"].ToString();
                                string eqStatus = reader["Status"].ToString();

                                // Initialize search form, pass data via custom constructor, and show it
                                search searchResultForm = new search(eqName, eqID, eqStatus, this);
                                searchResultForm.Show();

                                this.Hide(); // Hide dashboard window temporarily
                            }
                            else
                            {
                                MessageBox.Show("No equipment found matching that name.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
    }
    }
}
