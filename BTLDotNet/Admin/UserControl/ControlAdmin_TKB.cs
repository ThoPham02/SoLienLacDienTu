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
            clearTextBox();
            LoadData();
        }
        public void LoadData()
        {
            var schedules = tkb.GetScheduleList();
            LoadListView(schedules);
        }
        public void LoadListView(List<Model.EF.thoi_khoa_bieu> schedules)
        {
            listView1.Items.Clear();
            foreach (var schedule in schedules)
            {
                ListViewItem item = new ListViewItem();
                item.Text = schedule.ma_mon.ToString();
                item.SubItems.Add(schedule.ma_gv);
                item.SubItems.Add(schedule.ma_lop.ToString());
                item.SubItems.Add(schedule.tiet.ToString());
                item.SubItems.Add(schedule.ma_hoc_ki.ToString());
                item.SubItems.Add(schedule.ma_nam_hoc.ToString());
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
            textBox5.Text = "";
            textBox6.Text = "";
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
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
                textBox5.Text = schedule[0].SubItems[4].Text;
                textBox6.Text = schedule[0].SubItems[5].Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int maMH = int.Parse(textBox1.Text);
                string maGV = textBox2.Text;
                int maLop = int.Parse(textBox3.Text);
                int tiet = int.Parse(textBox4.Text);
                int maHocKi = int.Parse(textBox5.Text);
                int maNam = int.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Thông tin thời khóa biểu không hợp lệ!");
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int maMH = int.Parse(textBox1.Text);
                string maGV = textBox2.Text;
                int maLop = int.Parse(textBox3.Text);
                int tiet = int.Parse(textBox4.Text);
                int maHocKi = int.Parse(textBox5.Text);
                int maNam = int.Parse(textBox6.Text);
                if (tkb.CreateSchedule(maMH, maGV, maLop, tiet, maHocKi, maNam))
                {
                    MessageBox.Show("Thêm thời khóa biểu thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin thời khóa biểu không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin thời khóa biểu không hợp lệ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {
                int maMH = int.Parse(textBox1.Text);
                string maGV = textBox2.Text;
                int maLop = int.Parse(textBox3.Text);
                int tiet = int.Parse(textBox4.Text);
                int maHocKi = int.Parse(textBox5.Text);
                int maNam = int.Parse(textBox6.Text);
                if (tkb.UpdateSchedule(maMH, maGV, maLop, tiet, maHocKi, maNam))
                {
                    MessageBox.Show("Cập nhật thông tin thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin thời khóa biểu không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin thời khóa biểu không hợp lệ!");
            }*/
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int maMH = int.Parse(textBox1.Text);
                string maGV = textBox2.Text;
                int maLop = int.Parse(textBox3.Text);
                int tiet = int.Parse(textBox4.Text);
                int maHocKi = int.Parse(textBox5.Text);
                int maNam = int.Parse(textBox6.Text);
                if (tkb.DeleteSchedule(maMH, maGV, maLop, tiet, maHocKi, maNam))
                {
                    MessageBox.Show("Xóa thời khóa biểu thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin thời khóa biểu không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin thời khóa biểu không hợp lệ!");
            }
        }
    }
}
