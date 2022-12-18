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
            clearTextBox();
            var students = hs.GetStudentList();
            LoadListView(students);
        }
        public void LoadListView(List<Model.EF.hoc_sinh> students)
        {
            listView1.Items.Clear();
            foreach (var student in students)
            {
                ListViewItem item = new ListViewItem();
                item.Text = student.ma_hs;
                item.SubItems.Add(student.pass);
                item.SubItems.Add(student.ten);
                item.SubItems.Add(student.ngaySinh.ToString());
                if (student.gioiTinh == 0)
                {
                    item.SubItems.Add("Nữ");
                }
                else
                {
                    item.SubItems.Add("Nam");
                }
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
            try
            {
                string maHS = textBox1.Text;
                string pass = textBox2.Text;
                string ten = textBox3.Text;
                string ngaySinh = textBox4.Text;
                string gioiTinh = textBox5.Text;
                string khoa = textBox6.Text;
                string sdt = textBox7.Text;
                string trangthai = textBox8.Text;
                if (hs.AdminUpdateStudent(maHS, ten, pass, khoa, ngaySinh, gioiTinh, sdt, trangthai))
                {
                    MessageBox.Show("Cập nhật thông tin học sinh thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin học sinh không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin học sinh không hợp lệ!");
            }

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
            textBox8.ReadOnly = false;
            textBox8.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string maHS = textBox1.Text;
                string pass = textBox2.Text;
                string ten = textBox3.Text;
                string ngaySinh = textBox4.Text;
                string gioiTinh = textBox5.Text;
                string khoa = textBox6.Text;
                string sdt = textBox7.Text;
                string trangthai = textBox8.Text;
                if (hs.CreateStudent(maHS, ten, pass, khoa, ngaySinh, gioiTinh, sdt, trangthai))
                {
                    MessageBox.Show("Thêm học sinh thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin học sinh không hợp lệ!");
                }
            } catch
            {
                MessageBox.Show("Thông tin học sinh không hợp lệ!");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string maHS = textBox1.Text;
            string pass = textBox2.Text;
            string ten = textBox3.Text;
            string ngaySinh = textBox4.Text;
            string gioiTinh = textBox5.Text;
            int khoa = -1;
            if (textBox6.Text != "")
            {
                try
                {
                    khoa = int.Parse(textBox6.Text);
                }
                catch
                {
                    MessageBox.Show("Khóa không hợp lệ!");
                    return;
                }
            }
            string sdt = textBox7.Text;
            string trangthai = textBox8.Text;
            var students = hs.SearchStudent(maHS, ten, khoa, ngaySinh, khoa, sdt, trangthai);
            MessageBox.Show("Kết quả tìm kiếm");
            if(students == null)
            {
                return;
            }
            else
            {
                LoadListView(students);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string maHS = textBox1.Text;
            if(hs.DeleteStudent(maHS))
            {
                MessageBox.Show("Xóa học sinh thành công!");
            }
            else
            {
                MessageBox.Show("Mã học sinh không tồn tại");
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox1.Focus();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox2.Focus();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
            textBox3.Focus();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
            textBox4.Focus();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
            textBox5.Focus();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
            textBox6.Focus();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox7.ReadOnly = false;
            textBox7.Focus();
        }
    }
}
