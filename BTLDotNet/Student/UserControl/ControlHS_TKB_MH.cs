﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLDotNet
{
    public partial class ControlHS_TKB_MH : UserControl
    {
        public string subject = "";
        public ControlHS_TKB_MH()
        {
            InitializeComponent();
        }

        private void ControlHS_TKB_MH_Load(object sender, EventArgs e)
        {
            label1.Text = subject;
        }
    }
}
