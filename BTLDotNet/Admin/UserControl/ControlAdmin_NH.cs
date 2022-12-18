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
            clearTextBox();
            var years = nh.GetYearList();
            loadListView(years);
        }
        public void loadListView(List<Model.EF.nam_hoc> years)
        {
            listView1.Items.Clear();
            foreach (var year in years)
            {
                ListViewItem item = new ListViewItem();
                item.Text = year.ma_nam.ToString();
                item.SubItems.Add(year.ten_nam_hoc);
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
            try
            {
                int maNH = int.Parse(textBox1.Text);
                string namhoc = textBox2.Text;
                if (nh.DeleteYear(maNH))
                {
                    MessageBox.Show("Xóa năm học thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin năm học không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin năm học không hợp lệ!");
            }
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
            try
            {
                int maNH = int.Parse(textBox1.Text);
                string namhoc = textBox2.Text;
                if (nh.UpdateYear(maNH, namhoc))
                {
                    MessageBox.Show("Cập nhật năm học thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin năm học không hợp lệ!");
                }
            } catch
            {
                MessageBox.Show("Thông tin năm học không hợp lệ!");
            }
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
            try
            {
                int maNH = int.Parse(textBox1.Text);
                string namhoc = textBox2.Text;
                if (nh.CreateYear(namhoc))
                {
                    MessageBox.Show("Thêm năm học thành công!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thông tin năm học không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin năm học không hợp lệ!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int maNH = int.Parse(textBox1.Text);
                string namhoc = textBox2.Text;
                var years = nh.SearchYear(maNH, namhoc);
                MessageBox.Show("Kết quả tìm kiếm!");
                if (years == null)
                {
                    return;
                }
                else
                {
                    loadListView(years);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin năm học không hợp lệ!");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox1.Focus();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
            textBox2.Focus();
        }
    }
}
