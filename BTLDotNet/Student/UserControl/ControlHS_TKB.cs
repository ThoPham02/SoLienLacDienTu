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
    public partial class ControlHS_TKB : UserControl
    {
        Controller.ThoiKhoaBieu tkb = new Controller.ThoiKhoaBieu();
        Controller.MonHoc monHoc = new Controller.MonHoc();
        Controller.HocKi hocKi = new Controller.HocKi();
        Controller.NamHoc namHoc = new Controller.NamHoc();
        
        Controller.LopHoc lop = new Controller.LopHoc();
        string user = Controller.Const.userID;
        public ControlHS_TKB()
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
            comboBox1.SelectedIndex = 0;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadData()
        {
            int maHocKi = comboBox1.SelectedIndex + 1;
            int maNamHoc = comboBox2.SelectedIndex + 1;
            int maLop = lop.GetClassByStudent(user).ma_lop;
            var schedules = tkb.GetScheduleByCondition(maLop, maHocKi, maNamHoc);
            if (schedules.Count == 0)
            {
                tableLayoutPanel1.Visible = true;
                return;
            }
            else
            {
                foreach (var schedule in schedules)
                {
                    int x = (schedule.tiet - 1) / 10;
                    int y = (schedule.tiet - 1) % 10;
                    if (schedule.ma_mon != null)
                    {
                        string subjectName = monHoc.GetSubjectsById((int)(schedule.ma_mon)).ten;
                        AddControl(x, y, subjectName);
                    }
                }
            }
            tableLayoutPanel1.Visible = true;
        }

        public void clearPanel()
        {
            tableLayoutPanel1.Visible = false;
            while (tableLayoutPanel1.Controls.Count > 0)
            {
                tableLayoutPanel1.Controls[0].Dispose();
            }
        }
        private void ControlHS_TKB_Load(object sender, EventArgs e)
        {
        }

        private void AddControl(int col, int row, string subject)
        {
            ControlHS_TKB_MH controlTKB = new ControlHS_TKB_MH();
            controlTKB.subject = subject;
            controlTKB.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(controlTKB, col, row);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearPanel();
            loadData();
        }
    }
}
