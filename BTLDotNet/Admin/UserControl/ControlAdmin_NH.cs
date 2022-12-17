using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTLDotNet
{
    public partial class ControlAdmin_NH : UserControl
    {
        Controller.NamHoc nh = new Controller.NamHoc();
        public ControlAdmin_NH()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            listView1.Items.Clear();
            clearTextBox();
            var years = nh.GetYearList();
            foreach (var year in years)
            {
                ListViewItem item = new ListViewItem();
                item.Text = year.ma_nam.ToString();
                item.SubItems.Add(year.nam_hoc1);
                listView1.Items.Add(item);
            };

            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

        }
        public void clearTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var year = listView1.SelectedItems;
            if (year.Count == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = year[0].SubItems[0].Text;
                textBox2.Text = year[0].SubItems[1].Text;
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string maNH = textBox1.Text;
            string namhoc = textBox2.Text;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
