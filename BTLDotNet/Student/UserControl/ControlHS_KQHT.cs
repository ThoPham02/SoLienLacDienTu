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
                comboBox2.Items.Add(year.nam_hoc1);
            }
            comboBox2.SelectedIndex = years.Count - 1;

            var semesters = hocKi.GetSemesterList();
            foreach (var semester in semesters)
            {
                comboBox1.Items.Add(semester.hoc_ki1);
            }
            comboBox1.SelectedIndex = semesters.Count - 1;
        }

        public void loadData()
        {
            // Load score 
            var subjects = mh.GetSubjectsList();
            foreach (var subject in subjects)
            {
                ListViewItem item = new ListViewItem();
                item.Text = subject.ten;
                var scores = diem.GetScoreByStudentAndSubject(user, subject.ma_mon);
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
    }
}
