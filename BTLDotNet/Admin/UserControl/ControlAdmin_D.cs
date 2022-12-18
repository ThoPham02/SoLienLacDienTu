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
    public partial class ControlAdmin_D : UserControl
    {
        Controller.DiemKT d = new Controller.DiemKT();

        public ControlAdmin_D()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            var points = d.GetScoreList();
            clearTextBox();
            LoadListView(points);
        }

        public void LoadListView(List<Model.EF.diem_kt> points)
        {
            listView1.Items.Clear();
            foreach (var point in points)
            {
                ListViewItem item = new ListViewItem();
                item.Text = point.ma_hs.ToString();
                item.SubItems.Add(point.diem.ToString());
                item.SubItems.Add(point.loai.ToString());
                item.SubItems.Add(point.ma_mon.ToString());
                item.SubItems.Add(point.ma_hoc_ki.ToString());
                item.SubItems.Add(point.ma_nam.ToString());
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

        private void ControlAdmin_D_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var point = listView1.SelectedItems;
            if (point.Count == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = point[0].SubItems[0].Text;
                textBox2.Text = point[0].SubItems[1].Text;
                textBox3.Text = point[0].SubItems[2].Text;
                textBox4.Text = point[0].SubItems[3].Text;
                textBox5.Text = point[0].SubItems[4].Text;
                textBox6.Text = point[0].SubItems[5].Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string mahs = textBox1.Text;
                float diem = float.Parse(textBox2.Text);
                byte loai = byte.Parse(textBox3.Text);
                byte mamon = byte.Parse(textBox4.Text);
                byte mahk = byte.Parse(textBox5.Text);
                byte manam = byte.Parse(textBox6.Text);
                if (d.UpdateScore(mahs, diem, loai, mamon, mahk, manam))
                {
                    MessageBox.Show("Cập nhật điểm thành công!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Dữ liệu điểm không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu điểm không hợp lệ!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mahs = textBox1.Text;
                byte loai = byte.Parse(textBox3.Text);
                byte mamon = byte.Parse(textBox4.Text);
                byte mahk = byte.Parse(textBox5.Text);
                byte manam = byte.Parse(textBox6.Text);
                if (d.DeleteScore(mahs, loai, mamon, mahk, manam))
                {
                    MessageBox.Show("Xóa điểm thành công!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Dữ liệu điểm không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu điểm không hợp lệ!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string mahs = textBox1.Text;
                int loai = -1, mamon = -1, mahk = -1, manam = -1;
                if (textBox3.Text != "")
                {
                    loai = int.Parse(textBox3.Text);
                }

                if (textBox4.Text != "")
                {
                    mamon = int.Parse(textBox4.Text);
                }

                if (textBox5.Text != "")
                {
                    mahk = int.Parse(textBox5.Text);
                }
                if (textBox6.Text != "")
                {
                    manam = int.Parse(textBox6.Text);
                }
                var scores = d.SearchScore(mahs, loai, mamon, mahk, manam);
                MessageBox.Show("Kết quả tìm kiếm!");
                if (scores != null)
                {
                    LoadListView(scores);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin điểm không hợp lệ!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mahs = textBox1.Text;
                float diem = float.Parse(textBox2.Text);
                byte loai = byte.Parse(textBox3.Text);
                byte mamon = byte.Parse(textBox4.Text);
                byte mahk = byte.Parse(textBox5.Text);
                byte manam = byte.Parse(textBox6.Text);
                if (d.CreateScore(mahs, diem, loai, mamon, mahk, manam))
                {
                    MessageBox.Show("Thêm điểm thành công!");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Thông tin điểm không hợp lệ!");
                }
            }
            catch
            {
                MessageBox.Show("Thông tin điểm không hợp lệ!");
            }
        }
    }
}
