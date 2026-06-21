using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LabPulse
{
    public partial class profile : Form
    {
        // -------------------------------------------------------
        // Fields
        // -------------------------------------------------------
        private readonly string connectionString = "Server=localhost;Database=labpulse_db;Uid=root;Pwd=;";

        /// <summary>Primary key of the student whose profile is being viewed/edited.</summary>
        private int userID = 0;

        // -------------------------------------------------------
        // Constructors
        // -------------------------------------------------------

        /// <summary>
        /// Primary constructor — called by studentDashboard.
        /// Receives the logged-in student's UserID.
        /// </summary>
        public profile(int id)
        {
            InitializeComponent();
            userID = id;
        }

        /// <summary>Parameterless constructor kept for designer compatibility.</summary>
        public profile()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------
        // Form Load — wired by designer: Load += profile_Load
        // Sets initial UI state, then fetches data from the DB.
        // -------------------------------------------------------
        private void profile_Load(object sender, EventArgs e)
        {
            // --- Initial read-only state ---
            txtName.ReadOnly  = true;
            txtemail.ReadOnly = true;
            txtphone.ReadOnly = true;

            // --- Hide password section and Save button ---
            txtnewpass.Visible           = false;
            txtcompass.Visible           = false;
            newpassLab.Visible           = false;
            ConfpassLab.Visible          = false;
            checkBoxShowPassword.Visible = false;
            btnsubmit.Visible            = false;

            // --- Mask password characters ---
            txtnewpass.PasswordChar = '*';
            txtcompass.PasswordChar = '*';

            // --- Populate fields from database ---
            LoadUserData();
        }

        // -------------------------------------------------------
        // Load Name, Email, PhoneNumber from the User table
        // -------------------------------------------------------
        private void LoadUserData()
        {
            if (userID == 0)
            {
                MessageBox.Show(
                    "No user session found. Please log in again.",
                    "Session Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            const string query =
                "SELECT Name, Email, PhoneNumber, Role FROM User WHERE UserID = @UserID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtName.Text  = reader["Name"].ToString();
                                txtemail.Text = reader["Email"].ToString();
                                txtphone.Text = reader["PhoneNumber"].ToString();

                                lblname.Text = reader["Name"].ToString();
                                lblRol.Text  = reader["Role"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "User record not found in the database.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error loading profile: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // -------------------------------------------------------
        // checkBoxEdit — toggle editing mode
        // -------------------------------------------------------
        private void checkBoxEdit_CheckedChanged(object sender, EventArgs e)
        {
            bool editing = checkBoxEdit.Checked;

            // Toggle read-only on main fields
            txtName.ReadOnly  = !editing;
            txtemail.ReadOnly = !editing;
            txtphone.ReadOnly = !editing;

            // Show / hide password section
            txtnewpass.Visible           = editing;
            txtcompass.Visible           = editing;
            newpassLab.Visible           = editing;
            ConfpassLab.Visible          = editing;
            checkBoxShowPassword.Visible = editing;

            // Show / hide Save button
            btnsubmit.Visible = editing;

            // Clear password fields when leaving edit mode
            if (!editing)
            {
                txtnewpass.Text = string.Empty;
                txtcompass.Text = string.Empty;
            }
        }

        // -------------------------------------------------------
        // checkBoxShowPassword — reveal / mask password text
        // -------------------------------------------------------
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            char mask = checkBoxShowPassword.Checked ? '\0' : '*';
            txtnewpass.PasswordChar = mask;
            txtcompass.PasswordChar = mask;
        }

        // -------------------------------------------------------
        // btnsubmit — Save Changes
        // -------------------------------------------------------
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            // --- Field validation ---
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtphone.Text))
            {
                MessageBox.Show("Phone Number is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Determine whether a password change is requested ---
            bool changingPassword = !string.IsNullOrWhiteSpace(txtnewpass.Text) ||
                                    !string.IsNullOrWhiteSpace(txtcompass.Text);

            if (changingPassword)
            {
                if (string.IsNullOrWhiteSpace(txtnewpass.Text))
                {
                    MessageBox.Show("New Password cannot be empty.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtnewpass.Text != txtcompass.Text)
                {
                    MessageBox.Show(
                        "New Password and Confirm Password do not match.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
            }

            // --- Build the appropriate UPDATE query ---
            string query = changingPassword
                ? @"UPDATE User
                    SET Name        = @Name,
                        Email       = @Email,
                        PhoneNumber = @Phone,
                        Password    = @Password
                    WHERE UserID = @UserID"
                : @"UPDATE User
                    SET Name        = @Name,
                        Email       = @Email,
                        PhoneNumber = @Phone
                    WHERE UserID = @UserID";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name",   txtName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email",  txtemail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone",  txtphone.Text.Trim());
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        if (changingPassword)
                            cmd.Parameters.AddWithValue("@Password", txtnewpass.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Profile updated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // Update sidebar display name
                            lblname.Text = txtName.Text.Trim();

                            // Return to read-only mode
                            checkBoxEdit.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show(
                                "No changes were saved. Please try again.",
                                "Update Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error saving profile: " + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // -------------------------------------------------------
        // textBox5_TextChanged — required by designer event binding
        // -------------------------------------------------------
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // Intentionally empty — control bound in designer
        }

        // -------------------------------------------------------
        // linkLabel1 — "Back" → close profile (dashboard re-shows)
        // -------------------------------------------------------
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // studentDashboard wired FormClosed to Show() itself
            this.Close();
        }

        // -------------------------------------------------------
        // linkLabel2 — "Home Page" → navigate to welcome screen
        // -------------------------------------------------------
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 welcomeScreen = new Form1();
            welcomeScreen.Show();
            this.Close();
        }

        // -------------------------------------------------------
        // pictureBox2 click — same as Home Page / logout
        // -------------------------------------------------------
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 welcomeScreen = new Form1();
            welcomeScreen.Show();
            this.Close();
        }
    }
}
