namespace LabPulse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            livePulseToolStripMenuItem = new ToolStripMenuItem();
            analyticsToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            chemistryToolStripMenuItem = new ToolStripMenuItem();
            physicsToolStripMenuItem = new ToolStripMenuItem();
            biologyToolStripMenuItem = new ToolStripMenuItem();
            mapToolStripMenuItem = new ToolStripMenuItem();
            componentLibraryToolStripMenuItem = new ToolStripMenuItem();
            equipmentRegistryToolStripMenuItem = new ToolStripMenuItem();
            aboutUsToolStripMenuItem1 = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutUsToolStripMenuItem, categoryToolStripMenuItem, mapToolStripMenuItem, aboutUsToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1108, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { livePulseToolStripMenuItem, analyticsToolStripMenuItem });
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(60, 24);
            aboutUsToolStripMenuItem.Text = "Menu";
            // 
            // livePulseToolStripMenuItem
            // 
            livePulseToolStripMenuItem.Name = "livePulseToolStripMenuItem";
            livePulseToolStripMenuItem.Size = new Size(156, 26);
            livePulseToolStripMenuItem.Text = "Live Pulse";
            // 
            // analyticsToolStripMenuItem
            // 
            analyticsToolStripMenuItem.Name = "analyticsToolStripMenuItem";
            analyticsToolStripMenuItem.Size = new Size(156, 26);
            analyticsToolStripMenuItem.Text = "Analytics";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chemistryToolStripMenuItem, physicsToolStripMenuItem, biologyToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(99, 24);
            categoryToolStripMenuItem.Text = "Instruments";
            // 
            // chemistryToolStripMenuItem
            // 
            chemistryToolStripMenuItem.Name = "chemistryToolStripMenuItem";
            chemistryToolStripMenuItem.Size = new Size(209, 26);
            chemistryToolStripMenuItem.Text = "Multimeters";
            // 
            // physicsToolStripMenuItem
            // 
            physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            physicsToolStripMenuItem.Size = new Size(209, 26);
            physicsToolStripMenuItem.Text = "Signal Generators";
            // 
            // biologyToolStripMenuItem
            // 
            biologyToolStripMenuItem.Name = "biologyToolStripMenuItem";
            biologyToolStripMenuItem.Size = new Size(209, 26);
            biologyToolStripMenuItem.Text = "Calibration";
            // 
            // mapToolStripMenuItem
            // 
            mapToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { componentLibraryToolStripMenuItem, equipmentRegistryToolStripMenuItem });
            mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            mapToolStripMenuItem.Size = new Size(158, 24);
            mapToolStripMenuItem.Text = "Inventory and Assets";
            // 
            // componentLibraryToolStripMenuItem
            // 
            componentLibraryToolStripMenuItem.Name = "componentLibraryToolStripMenuItem";
            componentLibraryToolStripMenuItem.Size = new Size(221, 26);
            componentLibraryToolStripMenuItem.Text = "Component Library";
            // 
            // equipmentRegistryToolStripMenuItem
            // 
            equipmentRegistryToolStripMenuItem.Name = "equipmentRegistryToolStripMenuItem";
            equipmentRegistryToolStripMenuItem.Size = new Size(221, 26);
            equipmentRegistryToolStripMenuItem.Text = "Equipment Registry";
            // 
            // aboutUsToolStripMenuItem1
            // 
            aboutUsToolStripMenuItem1.Name = "aboutUsToolStripMenuItem1";
            aboutUsToolStripMenuItem1.Size = new Size(84, 24);
            aboutUsToolStripMenuItem1.Text = "About Us";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(829, 357);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(829, 442);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(986, 576);
            panel1.Name = "panel1";
            panel1.Size = new Size(73, 55);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1108, 643);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem chemistryToolStripMenuItem;
        private ToolStripMenuItem physicsToolStripMenuItem;
        private ToolStripMenuItem biologyToolStripMenuItem;
        private ToolStripMenuItem mapToolStripMenuItem;
        private Button button1;
        private Button button2;
        private ToolStripMenuItem livePulseToolStripMenuItem;
        private ToolStripMenuItem analyticsToolStripMenuItem;
        private ToolStripMenuItem componentLibraryToolStripMenuItem;
        private ToolStripMenuItem equipmentRegistryToolStripMenuItem;
        private ToolStripMenuItem aboutUsToolStripMenuItem1;
        private Panel panel1;
    }
}
