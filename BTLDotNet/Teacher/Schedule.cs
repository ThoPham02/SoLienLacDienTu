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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
            LoadCbox();
            LoadData();
        }

        HocKi hocKiCtrl = new HocKi();
        NamHoc namHocCtrl = new NamHoc();
        LopHoc lopCtrl = new LopHoc();
        GiaoVien giaoVienCtrl = new GiaoVien();

        public void LoadData()
        {
            int maHocKi = semester_cbox.SelectedIndex + 1;
            int maNamHoc = year_cbox.SelectedIndex + 1;

            var schedules = giaoVienCtrl.GetScheduleTeacher(Const.userID, maNamHoc, maHocKi);
            if (schedules == null)
            {
                tableLayoutPanel1.Visible = true;
                return;
            }
            else
            {
                foreach (var sched in schedules)
                {
                    int x = (sched.tiet - 1) / 10;
                    int y = (sched.tiet - 1) % 10;
                    if (sched.ma_mon != null)
                    {
                        string className = lopCtrl.GetClassNameByID((int)sched.ma_lop);
                        AddControl(x, y, className);
                    }
                }
            }
            tableLayoutPanel1.Visible = true;
        }

        public void AddControl(int col, int row, string className)
        {
            ControlGV_TKB_MH controlTKB = new ControlGV_TKB_MH();
            controlTKB.className = className;
            controlTKB.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(controlTKB, col, row);
        }

        public void LoadCbox()
        {
            var years = namHocCtrl.GetYearList();
            foreach (var year in years)
            {
                year_cbox.Items.Add(year.ten_nam_hoc);
            }
            year_cbox.SelectedIndex = years.Count - 1;

            var semesters = hocKiCtrl.GetSemesterList();
            foreach (var semester in semesters)
            {
                semester_cbox.Items.Add(semester.ten_hoc_ki);
            }
            semester_cbox.SelectedIndex = 0;
        }

        public void clearPanel()
        {
            tableLayoutPanel1.Visible = false;
            while (tableLayoutPanel1.Controls.Count > 0)
            {
                tableLayoutPanel1.Controls[0].Dispose();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            clearPanel();
            LoadData();
        }
    }
}
