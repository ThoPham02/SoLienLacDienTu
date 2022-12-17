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
            listView1.Items.Clear();
            clearTextBox();
            var conducts = hk.GetConductList();
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
    }
}
