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
            LoadData();
        }

        public void LoadData()
        {
            listView1.Items.Clear();
            clearTextBox();
            var points = d.GetPointList();
            foreach (var point in points)
            {
                ListViewItem item = new ListViewItem();
                item.Text = point.ma_hs.ToString();
                item.SubItems.Add(point.ma_hs);
                item.SubItems.Add(point.diem);
                item.SubItems.Add(point.loai);
                item.SubItems.Add(point.ma_mon);
                item.SubItems.Add(point.ma_hoc_ki);
                item.SubItems.Add(point.ma_nam);
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
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mahs = textBox1.Text;
            string diemm = textBox2.Text;
            string loai = textBox3.Text;
            string mamon = textBox4.Text;
            string mahk = textBox5.Text;
            string manam = textBox6.Text;
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
    }
}
