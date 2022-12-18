using System;
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
    public partial class ControlGV_TKB_MH : UserControl
    {
        public string className = "";
        public ControlGV_TKB_MH()
        {
            InitializeComponent();
        }

        private void ControlHS_TKB_MH_Load(object sender, EventArgs e)
        {
            label1.Text = className;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
