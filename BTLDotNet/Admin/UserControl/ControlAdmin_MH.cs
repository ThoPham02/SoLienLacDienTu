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
    public partial class ControlAdmin_MH : UserControl
    {
        Controller.MonHoc mh = new Controller.MonHoc();
        public ControlAdmin_MH()
        {
            InitializeComponent();
            
        }
        public void LoadData()
        {
            listView1.Items.Clear();
            clearTextBox();
            var subjects = mh.GetSubjectsList();
            foreach (var subject in subjects)
            {
                ListViewItem item = new ListViewItem();
                item.Text = subject.ma_mon.ToString();
                item.SubItems.Add(subject.ten);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var teacher = listView1.SelectedItems;
            if (teacher.Count == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = teacher[0].SubItems[0].Text;
                textBox2.Text = teacher[0].SubItems[1].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string maMon = textBox1.Text;
            string tenMon = textBox2.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }
    }
}
