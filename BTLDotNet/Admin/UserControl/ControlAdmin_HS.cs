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
    public partial class ControlAdmin_HS : UserControl
    {
        Controller.HocSinh hs = new Controller.HocSinh();
        public ControlAdmin_HS()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            listView1.Items.Clear();
            clearTextBox();
            var students = hs.GetStudentList();
            foreach (var student in students)
            {
                ListViewItem item = new ListViewItem();
                item.Text = student.ma_hs;
                item.SubItems.Add(student.pass);
                item.SubItems.Add(student.ten);
                item.SubItems.Add(student.ngaySinh.ToString());
                item.SubItems.Add(student.gioiTinh.ToString());
                item.SubItems.Add(student.khoa.ToString());
                item.SubItems.Add(student.sdt);
                item.SubItems.Add(student.trang_thai);
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
            textBox7.Text = "";
            textBox8.Text = "";

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;


        }
        private void button12_Click(object sender, EventArgs e)
        {
            string maHS = textBox1.Text;
            string pass = textBox2.Text;
            string ten = textBox3.Text;
            DateTime ngaySinh = DateTime.Parse(textBox4.Text);
            string gioiTinhStr = textBox5.Text;
            byte gioiTinh;
            if (gioiTinhStr == "Nam")
            {
                gioiTinh = 1;
            }
            else if (gioiTinhStr == "Nữ")
            {
                gioiTinh = 0;
            }
            else
            {
                MessageBox.Show("Giới tính không hợp lệ!");
            }
            string khoa = textBox6.Text;

            string sdt = textBox7.Text;
            string trangthai = textBox8.Text;

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
            var student = listView1.SelectedItems;
            if (student.Count == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = student[0].SubItems[0].Text;
                textBox2.Text = student[0].SubItems[1].Text;
                textBox3.Text = student[0].SubItems[2].Text;
                textBox4.Text = student[0].SubItems[3].Text;
                textBox5.Text = student[0].SubItems[4].Text;
                textBox6.Text = student[0].SubItems[5].Text;
                textBox7.Text = student[0].SubItems[6].Text;
                textBox8.Text = student[0].SubItems[7].Text;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox7.ReadOnly = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox8.ReadOnly = false;
        }

        private void ControlAdmin_HS_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }
    }
}
