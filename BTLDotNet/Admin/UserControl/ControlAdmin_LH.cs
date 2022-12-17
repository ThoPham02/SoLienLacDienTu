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
    public partial class ControlAdmin_LH : UserControl
    {
        Controller.LopHoc lopHoc = new Controller.LopHoc();
        public ControlAdmin_LH()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            listView1.Items.Clear();
            //clearTextBox();
            var classes = lopHoc.GetClassList();
            foreach (var lop in classes)
            {
                ListViewItem item = new ListViewItem();
                
            };

            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
