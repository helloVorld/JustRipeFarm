﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JustRipeFarm
{
    public partial class AdminDashboard : Form
    {
        
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // back to login screen
            JRF.Logout(this);
        }
    }
}
