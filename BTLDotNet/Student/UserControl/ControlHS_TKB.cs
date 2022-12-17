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
    public partial class ControlHS_TKB : UserControl
    {
        Controller.ThoiKhoaBieu tkb = new Controller.ThoiKhoaBieu();
        public ControlHS_TKB()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlHS_TKB_Load(object sender, EventArgs e)
        {
            
        }
    }
}
