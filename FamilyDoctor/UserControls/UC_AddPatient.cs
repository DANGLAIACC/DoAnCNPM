﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class UC_AddPatient : UserControl
    {
        public UC_AddPatient()
        {
            InitializeComponent();
        }

        private void UC_AddPatient_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
        }
    }
}