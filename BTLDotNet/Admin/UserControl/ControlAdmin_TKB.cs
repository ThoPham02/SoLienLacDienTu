using BTLDotNet.Teacher;
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
    public partial class ControlAdmin_TKB : UserControl
    {
        Controller.ThoiKhoaBieu tkb = new Controller.ThoiKhoaBieu();
        public ControlAdmin_TKB()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            listView1.Items.Clear();
            clearTextBox();
            var schedules = tkb.GetScheduleList();
            foreach (var schedule in schedules)
            {
                ListViewItem item = new ListViewItem();
                item.Text = schedule.ma_gv;
                item.Text = schedule.ma_mon.ToString();
                item.Text = schedule.ma_lop.ToString();
                item.SubItems.Add(schedule.tiet.ToString());
                listView1.Items.Add(item);
            };

            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

        }
        public void clearTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var schedule = listView1.SelectedItems;
            if (schedule.Count == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = schedule[0].SubItems[0].Text;
                textBox2.Text = schedule[0].SubItems[1].Text;
                textBox3.Text = schedule[0].SubItems[2].Text;
                textBox4.Text = schedule[0].SubItems[3].Text;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string maMH = textBox1.Text;
            string maGV = textBox2.Text;
            string maLop = textBox3.Text;
            string tiet = textBox4.Text;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
        }
    }
}
