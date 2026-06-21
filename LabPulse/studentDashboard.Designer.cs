namespace LabPulse
{
    partial class studentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentDashboard));
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            backToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            menuToolStripMenuItem1 = new ToolStripMenuItem();
            catelogToolStripMenuItem = new ToolStripMenuItem();
            rulesRegulationsToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(1302, 14);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log Out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.FromArgb(64, 64, 64);
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(1409, 14);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(52, 20);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Profile";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1390, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(linkLabel2);
            panel1.Location = new Point(12, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1482, 119);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(64, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(255, 224, 192);
            textBox1.Location = new Point(204, 55);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(477, 32);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 255);
            label1.Location = new Point(189, 14);
            label1.Name = "label1";
            label1.Size = new Size(511, 38);
            label1.TabIndex = 4;
            label1.Text = "Welcome to the Student Dashboard ! ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(156, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { backToolStripMenuItem, menuToolStripMenuItem1, aboutUsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1506, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            backToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            backToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            backToolStripMenuItem.Name = "backToolStripMenuItem";
            backToolStripMenuItem.Size = new Size(54, 24);
            backToolStripMenuItem.Text = "Back";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(129, 26);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // menuToolStripMenuItem1
            // 
            menuToolStripMenuItem1.BackColor = Color.FromArgb(192, 255, 192);
            menuToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { catelogToolStripMenuItem, rulesRegulationsToolStripMenuItem, historyToolStripMenuItem });
            menuToolStripMenuItem1.Name = "menuToolStripMenuItem1";
            menuToolStripMenuItem1.Size = new Size(60, 24);
            menuToolStripMenuItem1.Text = "Menu";
            // 
            // catelogToolStripMenuItem
            // 
            catelogToolStripMenuItem.Name = "catelogToolStripMenuItem";
            catelogToolStripMenuItem.Size = new Size(213, 26);
            catelogToolStripMenuItem.Text = "Catelog";
            // 
            // rulesRegulationsToolStripMenuItem
            // 
            rulesRegulationsToolStripMenuItem.Name = "rulesRegulationsToolStripMenuItem";
            rulesRegulationsToolStripMenuItem.Size = new Size(213, 26);
            rulesRegulationsToolStripMenuItem.Text = "Rules & Regulations";
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(213, 26);
            historyToolStripMenuItem.Text = "History";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(84, 24);
            aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Location = new Point(12, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(1482, 530);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1302, 164);
            button1.Name = "button1";
            button1.Size = new Size(110, 44);
            button1.TabIndex = 6;
            button1.Text = "SEARCH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(1062, 164);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(234, 44);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(824, 170);
            label2.Name = "label2";
            label2.Size = new Size(232, 30);
            label2.TabIndex = 8;
            label2.Text = "Search Equipment Here :";
            // 
            // studentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1506, 756);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "studentDashboard";
            Text = "studentDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem backToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem menuToolStripMenuItem1;
        private ToolStripMenuItem catelogToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem rulesRegulationsToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private Panel panel2;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
    }
}