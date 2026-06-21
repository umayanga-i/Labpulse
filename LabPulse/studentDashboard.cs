using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LabPulse
{
    public partial class studentDashboard : Form
    {
        // -------------------------------------------------------
        // Fields
        // -------------------------------------------------------
        private readonly string connectionString = "Server=localhost;Database=labpulse_db;Uid=root;Pwd=;";

        /// <summary>Display name of the currently logged-in student.</summary>
        private string currentUserName = string.Empty;

        /// <summary>Primary key of the currently logged-in student.</summary>
        private int currentUserID = 0;

        // -------------------------------------------------------
        // Constructors
        // -------------------------------------------------------

        /// <summary>
        /// Called by login.cs — receives the student's name and
        /// resolves the UserID from the database automatically.
        /// </summary>
        public studentDashboard(string userName)
        {
            InitializeComponent();
            currentUserName = userName ?? string.Empty;

            // Resolve UserID from the name that login.cs already validated
            if (!string.IsNullOrEmpty(currentUserName))
                currentUserID = FetchUserID(currentUserName);
        }

        /// <summary>
        /// Extended constructor — receives both the name and the
        /// UserID directly, skipping the extra DB round-trip.
        /// </summary>
        public studentDashboard(string userName, int userID)
        {
            InitializeComponent();
            currentUserName = userName ?? string.Empty;
            currentUserID   = userID;
        }

        /// <summary>Parameterless constructor kept for designer compatibility.</summary>
        public studentDashboard()
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
        {// Pass 'this' (the current dashboard instance) into the profile constructor
            profile profileForm = new profile(this);
            profileForm.Show();
            this.Hide();
        }
    }
}
