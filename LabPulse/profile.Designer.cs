
namespace LabPulse
{
    partial class profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            pictureusertype = new PictureBox();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            lblname = new Label();
            lblRol = new Label();
            checkBoxEdit = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtemail = new TextBox();
            txtphone = new TextBox();
            txtAddress = new TextBox();
            btnsubmit = new Button();
            newpassLab = new Label();
            ConfpassLab = new Label();
            txtnewpass = new TextBox();
            txtcompass = new TextBox();
            showpasscheck = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureusertype).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureusertype
            // 
            pictureusertype.Location = new Point(61, 54);
            pictureusertype.Name = "pictureusertype";
            pictureusertype.Size = new Size(117, 148);
            pictureusertype.SizeMode = PictureBoxSizeMode.Zoom;
            pictureusertype.TabIndex = 0;
            pictureusertype.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(592, 24);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(86, 20);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Home Page";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(lblname);
            panel1.Controls.Add(lblRol);
            panel1.Controls.Add(pictureusertype);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 537);
            panel1.TabIndex = 5;
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(86, 257);
            lblname.Name = "lblname";
            lblname.Size = new Size(49, 20);
            lblname.TabIndex = 15;
            lblname.Text = "Name";
            lblname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(93, 225);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(39, 20);
            lblRol.TabIndex = 7;
            lblRol.Text = "Role";
            // 
            // checkBoxEdit
            // 
            checkBoxEdit.AutoSize = true;
            checkBoxEdit.Location = new Point(621, 81);
            checkBoxEdit.Name = "checkBoxEdit";
            checkBoxEdit.Size = new Size(57, 24);
            checkBoxEdit.TabIndex = 3;
            checkBoxEdit.Text = "Edit";
            checkBoxEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(288, 129);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 6;
            label1.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 185);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 7;
            label2.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 313);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Address: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 242);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 9;
            label4.Text = "Phone No: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(363, 126);
            txtName.Name = "txtName";
            txtName.Size = new Size(315, 27);
            txtName.TabIndex = 10;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(363, 178);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(315, 27);
            txtemail.TabIndex = 11;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(363, 239);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(315, 27);
            txtphone.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(363, 310);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(315, 27);
            txtAddress.TabIndex = 13;
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new Point(533, 477);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(132, 48);
            btnsubmit.TabIndex = 14;
            btnsubmit.Text = "Submit";
            btnsubmit.UseVisualStyleBackColor = true;
            // 
            // newpassLab
            // 
            newpassLab.AutoSize = true;
            newpassLab.Location = new Point(288, 383);
            newpassLab.Name = "newpassLab";
            newpassLab.Size = new Size(107, 20);
            newpassLab.TabIndex = 15;
            newpassLab.Text = "New Password:";
            // 
            // ConfpassLab
            // 
            ConfpassLab.AutoSize = true;
            ConfpassLab.Location = new Point(288, 416);
            ConfpassLab.Name = "ConfpassLab";
            ConfpassLab.Size = new Size(134, 20);
            ConfpassLab.TabIndex = 16;
            ConfpassLab.Text = "Confirm Password: ";
            // 
            // txtnewpass
            // 
            txtnewpass.Location = new Point(431, 380);
            txtnewpass.Name = "txtnewpass";
            txtnewpass.PasswordChar = '*';
            txtnewpass.Size = new Size(247, 27);
            txtnewpass.TabIndex = 17;
            txtnewpass.TextChanged += textBox5_TextChanged;
            // 
            // txtcompass
            // 
            txtcompass.Location = new Point(431, 413);
            txtcompass.Name = "txtcompass";
            txtcompass.PasswordChar = '*';
            txtcompass.Size = new Size(247, 27);
            txtcompass.TabIndex = 18;
            // 
            // showpasscheck
            // 
            showpasscheck.AutoSize = true;
            showpasscheck.Location = new Point(431, 446);
            showpasscheck.Name = "showpasscheck";
            showpasscheck.Size = new Size(132, 24);
            showpasscheck.TabIndex = 19;
            showpasscheck.Text = "Show Password";
            showpasscheck.UseVisualStyleBackColor = true;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(685, 537);
            Controls.Add(showpasscheck);
            Controls.Add(txtcompass);
            Controls.Add(txtnewpass);
            Controls.Add(ConfpassLab);
            Controls.Add(newpassLab);
            Controls.Add(btnsubmit);
            Controls.Add(txtAddress);
            Controls.Add(txtphone);
            Controls.Add(txtemail);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBoxEdit);
            Controls.Add(panel1);
            Controls.Add(linkLabel2);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "profile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            Load += profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureusertype).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureusertype;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private CheckBox checkBoxEdit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblRol;
        private TextBox txtName;
        private TextBox txtemail;
        private TextBox txtphone;
        private TextBox txtAddress;
        private Button btnsubmit;
        private Label lblname;
        private Label newpassLab;
        private Label ConfpassLab;
        private TextBox txtnewpass;
        private TextBox txtcompass;
        private CheckBox showpasscheck;
    }

}