using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabPulse
{
    public partial class Catelog : Form
    {
        private Form dashboardInstance;

        public Catelog()
        {
            InitializeComponent();
        }

        public Catelog(Form callingDashboard)
        {
            InitializeComponent();
            this.dashboardInstance = callingDashboard; // Save it for back-navigation later
        }

        private void Catelog_Load(object sender, EventArgs e)
        {

        }
    }
}
