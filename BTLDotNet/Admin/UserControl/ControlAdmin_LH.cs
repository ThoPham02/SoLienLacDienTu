using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            var classes = lopHoc.GetClassList();
            clearTextBox();
            LoadListView(classes);

        }
        public void clearTextBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
        }

        public void LoadListView(List<Model.EF.lop_hoc> classes)
        {
            listView1.Items.Clear();
            foreach (var lop in classes)
            {
                ListViewItem item = new ListViewItem();
                item.Text = lop.ma_lop.ToString();
                item.SubItems.Add(lop.ten);
                item.SubItems.Add(lop.ma_gv.ToString());
                listView1.Items.Add(item);
            };
            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lh = listView1.SelectedItems;
            if (lh.Count == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = lh[0].SubItems[0].Text;
                textBox2.Text = lh[0].SubItems[1].Text;
                textBox3.Text = lh[0].SubItems[2].Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tenLop = textBox2.Text;
                string maGv = textBox3.Text;
                if (lopHoc.CreateClass(tenLop, maGv))
                {
                    MessageBox.Show("Thêm lớp học thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin lớp học không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin lớp học không hợp lệ!");
            }



        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                int maLop = int.Parse(textBox1.Text);
                string tenLop = textBox2.Text;
                string maGv = textBox3.Text;
                if (lopHoc.UpdateClass(maLop, tenLop, maGv))
                {
                    MessageBox.Show("Cập nhật thông tin lớp học thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin lớp học không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin lớp học không hợp lệ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int maLop = int.Parse(textBox1.Text);
                string tenLop = textBox2.Text;
                string maGv = textBox3.Text;
                var classes = lopHoc.SearchClass(maLop, tenLop, maGv);
                MessageBox.Show("Kết quả tìm kiếm");
                if (classes == null)
                {
                    return;
                }
                else
                {
                    LoadListView(classes);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin lớp học không hợp lệ!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int maLop = int.Parse(textBox1.Text);
                if (lopHoc.DeleteClass(maLop))
                {
                    MessageBox.Show("Xóa lớp học thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lớp học không tồn tại!");
                }

            }
            catch
            {
                MessageBox.Show("Thông tin lớp học không hợp lệ!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox2.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
            textBox3.Focus();
        }
    }
}
