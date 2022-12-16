using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace BTLDotNet
{
    public partial class TeacherDashboard : Form
    {
        public TeacherDashboard()
        {
            InitializeComponent();
            InitializeForm();
        }

        private Form currentChildForm;

        private void openChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            view_panel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        public void setActiveButton(Button btn)
        {
            List<Button> listBtn = new List<Button>()
            {
                buttonInfo, buttonMark, buttonReport, buttonSched, buttonStudent
            };
            foreach (Button button in listBtn)
            {
                button.BackColor = Color.White;
            }
            btn.BackColor = Color.Aqua;
        }

        public void InitializeForm()
        {
            openChildForm(new Teacher.Info());
            setActiveButton(buttonInfo);
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            Controller.GiaoVien model = new Controller.GiaoVien();
            Model.EF.giao_vien gv = model.GetTeacherByID(Controller.Const.userID);
            hello_label.Text = "Xin chào, " + gv.ten;
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Teacher.Info());
            setActiveButton(buttonInfo);
        }

        private void sched_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Teacher.Schedule());
            setActiveButton(buttonSched);
        }

        private void mark_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Teacher.MarkManage());
            setActiveButton(buttonMark);
        }

        private void student_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Teacher.StudentManage());
            setActiveButton(buttonStudent);
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new Teacher.Report());
            setActiveButton(buttonReport);
        }
    }
}
