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
    public partial class ControlAdmin_HocKi : UserControl
    {
        Controller.HocKi hocKi = new Controller.HocKi();
        public ControlAdmin_HocKi()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            clearTextBox();
            var semesters = hocKi.GetSemesterList();
            LoadListView(semesters);
        }

        public void LoadListView(List<Model.EF.hoc_ki> semesters)
        {
            listView1.Items.Clear();
            foreach (var semester in semesters)
            {
                ListViewItem item = new ListViewItem();
                item.Text = semester.ma_hoc_ki.ToString();
                item.SubItems.Add(semester.ten_hoc_ki);
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int mahk = int.Parse(textBox1.Text);
                if(hocKi.DeleteSemester(mahk))
                {
                    MessageBox.Show("Xóa Học Kì Thành Công!");
                    LoadData();
                }

                else
                {
                    MessageBox.Show("Thông tin không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var semester = listView1.SelectedItems;
            if (semester.Count == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = semester[0].SubItems[0].Text;
                textBox2.Text = semester[0].SubItems[1].Text;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int maHocKi = int.Parse(textBox1.Text);
                string tenHocKi = textBox2.Text;
                var semesters = hocKi.GetSemesterByCondition(maHocKi, tenHocKi);
                MessageBox.Show("Kết quả tìm kiếm!");
                if (semesters == null)
                {
                    return;
                }
                else
                {
                    LoadListView(semesters);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int mahk = int.Parse(textBox1.Text);
                string loai = textBox2.Text;
                if (hocKi.UpdateSemester(mahk, loai))
                {
                    MessageBox.Show("Cập nhật học kì thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string loai = textBox2.Text;
                
                if (hocKi.CreateSemester(loai))
                {
                    MessageBox.Show("Thêm học kì thành công!");

                }
                else
                {
                    MessageBox.Show("Thông tin không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
        }
    }
}
