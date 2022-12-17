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
    public partial class ControlAdmin_BC : UserControl
    {
        Controller.BaoCao bc = new Controller.BaoCao();
        public ControlAdmin_BC()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            listView1.Items.Clear();
            clearTextBox();
            var reports = bc.GetReportList();
            foreach (var report in reports)
            {
                ListViewItem item = new ListViewItem();
                item.Text = report.id.ToString();
                item.SubItems.Add(report.ma_hs);
                item.SubItems.Add(report.ma_hanh_kiem.ToString());
                item.SubItems.Add(report.diem_tong_ket.ToString());
                item.SubItems.Add(report.nhan_xet.ToString());
                item.SubItems.Add(report.ma_hoc_ki.ToString());
                item.SubItems.Add(report.ma_nam.ToString());
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
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
        }
        private void ControlAdmin_BC_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string mahs = textBox2.Text;
            string mahk = textBox3.Text;
            string diemtk = textBox4.Text;
            string nx = textBox5.Text;
            string mahki = textBox6.Text;
            string manam = textBox7.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            textBox7.ReadOnly = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var report = listView1.SelectedItems;
            if (report.Count == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = report[0].SubItems[0].Text;
                textBox2.Text = report[0].SubItems[1].Text;
                textBox3.Text = report[0].SubItems[2].Text;
                textBox4.Text = report[0].SubItems[3].Text;
                textBox5.Text = report[0].SubItems[4].Text;
                textBox6.Text = report[0].SubItems[5].Text;
                textBox7.Text = report[0].SubItems[5].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
