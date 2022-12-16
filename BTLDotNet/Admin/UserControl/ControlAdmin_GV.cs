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
    public partial class ControlAdmin_GV : UserControl
    {
        Controller.GiaoVien gv = new Controller.GiaoVien();
        public ControlAdmin_GV()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            listView1.Items.Clear();
            clearTextBox();
            var teachers = gv.GetTeacherList();
            foreach(var teacher in teachers)
            {
                ListViewItem item = new ListViewItem();
                item.Text = teacher.ma_gv;
                item.SubItems.Add(teacher.ten);
                item.SubItems.Add(teacher.pass);
                item.SubItems.Add(teacher.ngaySinh.ToString());
                item.SubItems.Add(teacher.gioiTinh.ToString());
                item.SubItems.Add(teacher.sdt);
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

        private void button2_Click(object sender, EventArgs e)
        {
            string maGV = textBox1.Text;
            string ten = textBox2.Text;
            string pass = textBox3.Text;
            DateTime ngaySinh = DateTime.Parse(textBox4.Text);
            string gioiTinhStr = textBox5.Text;
            byte gioiTinh;
            if (gioiTinhStr == "Nam")
            {
                gioiTinh = 1;
            } else if (gioiTinhStr == "Nữ")
            {
                gioiTinh = 0;
            }
            else
            {
                MessageBox.Show("Giới tính không hợp lệ!");
            }
            string sdt = textBox6.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var teacher = listView1.SelectedItems;
            if (teacher.Count == 0)
            {
                return;
            }else
            {
                textBox1.Text = teacher[0].SubItems[0].Text;
                textBox2.Text = teacher[0].SubItems[1].Text;
                textBox3.Text = teacher[0].SubItems[2].Text;
                textBox4.Text = teacher[0].SubItems[3].Text;
                textBox5.Text = teacher[0].SubItems[4].Text;
                textBox6.Text = teacher[0].SubItems[5].Text;
            }
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

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
        }
    }
}
