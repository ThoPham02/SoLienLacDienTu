using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace BTLDotNet.Teacher
{
    public partial class MarkManage : Form
    {
        DiemKT diemCtrl = new DiemKT();
        LopHoc lpCtrl = new LopHoc();
        HocSinh hsCtrl = new HocSinh();
        NamHoc nhCtrl = new NamHoc();
        HocKi hkCtrl = new HocKi();

        public MarkManage()
        {
            InitializeComponent();
            LoadCbox();
            LoadData();
        }

        public void LoadData()
        {
            listView1.Items.Clear();
            clearTextBox();
            var students = lpCtrl.GetClassListByTeacherID(Const.userID);


            foreach (var student in students)
            {
                ListViewItem item = new ListViewItem();
                
                item.Text = student.ma_hs;
                item.SubItems.Add(student.ten);
                //item.SubItems.Add(student.)

                listView1.Items.Add(item);
            };

            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

        }

        public void LoadCbox()
        {
            var years = nhCtrl.GetYearList();
            foreach (var year in years)
            {
                year_cbox.Items.Add(year.ten_nam_hoc);
            }
            year_cbox.SelectedIndex = years.Count - 1;

            var semesters = hkCtrl.GetSemesterList();
            foreach (var semester in semesters)
            {
                semester_cbox.Items.Add(semester.ten_hoc_ki);
            }
            semester_cbox.SelectedIndex = 0;
        }

        public void clearTextBox()
        {
            id_txt.Text = name_txt.Text  = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
