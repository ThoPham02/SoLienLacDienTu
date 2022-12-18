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
            LoadData();


        }
        public void LoadData()
        {
            clearTextBox();
            var subjects = mh.GetSubjectsList();
            LoadListView(subjects);
        }
        public void LoadListView(List<Model.EF.mon_hoc> subjects)
        {
            listView1.Items.Clear();
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
            try
            {
                int maMon = int.Parse(textBox1.Text);
                string tenMon = textBox2.Text;
                if (mh.UpdateSubjects(maMon, tenMon))
                {
                    MessageBox.Show("Cập nhật môn học thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin môn học không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin môn học không hợp lệ!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenMon = textBox2.Text;
            if (mh.CreateSubjects(tenMon))
            {
                MessageBox.Show("Cập nhật môn học thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thông tin môn học không hợp lệ!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int maMon = int.Parse(textBox1.Text);
                if (mh.DeleteSubjects(maMon))
                {
                    MessageBox.Show("Xóa môn học thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin môn học không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin môn học không hợp lệ!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                int maMon = -1;
                if(textBox1.Text != "")
                {
                    maMon = int.Parse(textBox1.Text);
                }
                string tenMon = textBox2.Text;
                var subjects = mh.SearchSubject(maMon, tenMon);
                MessageBox.Show("Kết quả tìm kiếm!");
                if (subjects == null)
                {
                    return;
                }
                else
                {
                    LoadListView(subjects);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin môn học không hợp lệ!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox2.Focus();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox1.Focus();
        }
    }
}
