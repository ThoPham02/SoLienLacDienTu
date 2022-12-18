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
    public partial class ControlAdmin_HK : UserControl
    {
        Controller.HanhKiem hk = new Controller.HanhKiem();
        public ControlAdmin_HK()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            clearTextBox();
            var conducts = hk.GetConductList();
            LoadListView(conducts);
        }

        public void LoadListView(List<Model.EF.hanh_kiem> conducts)
        {
            listView1.Items.Clear();
            foreach (var conduct in conducts)
            {
                ListViewItem item = new ListViewItem();
                item.Text = conduct.ma_hanh_kiem.ToString();
                item.SubItems.Add(conduct.loai.ToString());
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
            var conduct = listView1.SelectedItems;
            if (conduct.Count == 0)
            {
                return;
            }
            else
            {
                textBox1.Text = conduct[0].SubItems[0].Text;
                textBox2.Text = conduct[0].SubItems[1].Text;

            }
        }

        private void ControlAdmin_HK_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int mahk = int.Parse(textBox1.Text);
                string loai = textBox2.Text;
                if (hk.UpdateConduct(mahk, loai))
                {
                    MessageBox.Show("Cập nhật hạnh kiểm thành công!");
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                int mahk = int.Parse(textBox1.Text);
                string loai = textBox2.Text;
                var conducts = hk.GetConductByCondition(mahk, loai);
                MessageBox.Show("Kết quả tìm kiếm!");
                if (conducts == null)
                {
                    return;
                }
                else
                {
                    LoadListView(conducts);
                }
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string loai = textBox2.Text;
                if (hk.CreateConduct(loai))
                {
                    MessageBox.Show("Thêm hạnh kiểm thành công!");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int maHanhKiem = int.Parse(textBox1.Text);
                if (hk.DeleteConduct(maHanhKiem))
                {
                    MessageBox.Show("Xóa hạnh kiểm thành công!");
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
    }
}
