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
        string user = Controller.Const.userID;
        public ControlHS_KQHT()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
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
    }
}
