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
    public partial class ControlHS_KQHT : UserControl
    {
        Controller.MonHoc mh = new Controller.MonHoc();
        Controller.DiemKT diem = new Controller.DiemKT();
        Controller.HocKi hocKi = new Controller.HocKi();
        Controller.NamHoc namHoc = new Controller.NamHoc();
        Controller.BaoCao baoCao = new Controller.BaoCao();
        Controller.HanhKiem hanhKiem = new Controller.HanhKiem();

        string user = Controller.Const.userID;
        public ControlHS_KQHT()
        {
            InitializeComponent();
            loadComboBox();
            loadData();
        }

        public void loadComboBox()
        {
            var years = namHoc.GetYearList();
            foreach (var year in years)
            {
                comboBox2.Items.Add(year.ten_nam_hoc);
            }
            comboBox2.SelectedIndex = years.Count - 1;

            var semesters = hocKi.GetSemesterList();
            foreach (var semester in semesters)
            {
                comboBox1.Items.Add(semester.ten_hoc_ki);
            }
            comboBox1.SelectedIndex = semesters.Count - 1;
        }

        public void loadData()
        {
            int maHocKi = comboBox1.SelectedIndex+1;
            int maNamHoc = comboBox2.SelectedIndex+1;
            // Load score 
            listView1.Items.Clear();
            var subjects = mh.GetSubjectsList();
            foreach (var subject in subjects)
            {
                ListViewItem item = new ListViewItem();
                item.Text = subject.ten;
                var scores = diem.GetScoreByCondition(user, subject.ma_mon, maHocKi, maNamHoc);
                if (scores == null)
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        item.SubItems.Add("");
                    }
                }
                else
                {
                    for (int i = 1; i <= 6; i++)
                    {
                        bool checkScore = true;
                        for (int j = 0; j < scores.Count; j++)
                        {
                            if (scores[j].loai == i)
                            {
                                item.SubItems.Add(scores[j].diem.ToString());
                                checkScore = false;
                            }
                        }
                        if (checkScore)
                        {
                            item.SubItems.Add("");
                        }
                    }
                }
                listView1.Items.Add(item);
            }

            //Load report
            var report = baoCao.GetReportByStudentAndYear(user, maHocKi, maNamHoc);
            richTextBox1.Text = report.nhan_xet;
            if (report.ma_hanh_kiem == null)
            {
                textBox1.Text = string.Empty;
            }
            else
            {
                textBox1.Text = hanhKiem.GetConductName((int)report.ma_hanh_kiem);

            }
            richTextBox1.ReadOnly = true;
            textBox1.ReadOnly = true;
        }

        private void ControlHS_KQHT_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_namhoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_namhoc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
