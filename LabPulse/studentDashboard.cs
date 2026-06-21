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

        // -------------------------------------------------------
        // UserID resolution helper
        // -------------------------------------------------------

        /// <summary>
        /// Queries the database for the UserID matching the given
        /// name with Role = 'student'. Returns 0 on failure.
        /// </summary>
        private int FetchUserID(string name)
        {
            const string query =
                "SELECT UserID FROM User WHERE Name = @name AND Role = 'student' LIMIT 1";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error resolving user session: " + ex.Message,
                        "Session Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            return 0;
        }

        // -------------------------------------------------------
        // Navigation — Log Out (linkLabel1)
        // -------------------------------------------------------
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 welcomeScreen = new Form1();
            welcomeScreen.Show();
            this.Close();
        }

        // -------------------------------------------------------
        // Navigation — Home Page (linkLabel2)
        // -------------------------------------------------------
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 welcomeScreen = new Form1();
            welcomeScreen.Show();
            this.Close();
        }

        // -------------------------------------------------------
        // Profile button — open profile form
        // -------------------------------------------------------
        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (currentUserID == 0)
            {
                MessageBox.Show(
                    "Unable to load profile: user session not found. Please log in again.",
                    "Session Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            profile profileForm = new profile(currentUserID);

            // Restore dashboard when profile window closes
            profileForm.FormClosed += (s, args) => this.Show();

            this.Hide();
            profileForm.Show();
        }
    }
}
