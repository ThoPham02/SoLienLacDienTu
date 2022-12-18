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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();

        }

        public void LoadData()
        {
            HocSinh model = new HocSinh();
            Model.EF.hoc_sinh obj = new Model.EF.hoc_sinh();

            obj = model.GetStudentByID(Const.studentID);

            DateTime birth = Convert.ToDateTime(obj.ngaySinh);

            id_txt.Text = obj.ma_hs;
            birth_txt.Text = birth.ToString("dd/MM/yyyy");
            name_txt.Text = obj.ten;


            if (obj.gioiTinh == 1)
            {
                sex_txt.Text = "Nam";
            }
            else
            {
                sex_txt.Text = "Nữ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void search_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!(search_txt.Text == "" || semesterSearch_cbox.SelectedIndex == -1 || yearSearch_cbox.SelectedIndex == -1))
            {
                try
                {
                    //Tạo mới các controller cần thiết
                    HocSinh ctrlHS = new HocSinh();
                    BaoCao ctrlBC = new BaoCao();
                    NamHoc ctrlNH = new NamHoc();
                    HocKi ctrlHKi = new HocKi();
                    HanhKiem ctrlHKiem = new HanhKiem();

                    //Lấy ra học sinh
                    Model.EF.hoc_sinh hs = ctrlHS.GetStudentByID(search_txt.Text);

                    //Tiền xử lý dữ liệu đầu vào controller
                    int maNamHoc = yearSearch_cbox.SelectedIndex + 1;
                    int maHocKi = semesterSearch_cbox.SelectedIndex + 1;

                    //Lấy ra báo cáo
                    var bc = ctrlBC.GetReportByStudentAndYear(search_txt.Text, maHocKi, maNamHoc);

                    //Check và hiển thị dữ liệu
                    if (hs != null && bc != null)
                    {
                        DateTime birth = Convert.ToDateTime(hs.ngaySinh);

                        id_txt.Text = hs.ma_hs;
                        name_txt.Text = hs.ten;
                        birth_txt.Text = birth.ToString("dd/MM/yyyy");

                        if (hs.gioiTinh == 1)
                        {
                            sex_txt.Text = "Nam";
                        }
                        else
                        {
                            sex_txt.Text = "Nữ";
                        }
                        if (!(bc.nhan_xet == "")) { comment_rtxt.Text = bc.nhan_xet; }
                        else { comment_rtxt.Text = "Chưa có nhận xét."; }

                        hanhKiem_txt.Text = ctrlHKiem.GetConductName((int)bc.ma_hanh_kiem);
                        year_txt.Text = ctrlNH.GetYearName(maNamHoc);
                        semester_txt.Text = ctrlHKi.GetSemesterName(maHocKi);
                    }
                    return;
                }
                catch (Exception)
                {
                    id_txt.Text = name_txt.Text = hanhKiem_txt.Text = birth_txt.Text = sex_txt.Text = year_txt.Text = semester_txt.Text = "";
                    MessageBox.Show("Tìm kiếm không hợp lệ hoặc không có dữ liệu tồn tại!");
                }

            }
            else
            {
                MessageBox.Show("Ô tìm kiếm trống!  Vui lòng nhập đủ thông tin");
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            BaoCao ctrlBC = new BaoCao();
            NamHoc ctrlNH = new NamHoc();
            HocKi ctrlHKi = new HocKi();
            HanhKiem ctrlHKiem = new HanhKiem();

            //Xử lý dữ liệu
            int maNamHoc = addYear_cbox.SelectedIndex + 1;
            int maHocKi = addSemester_cbox.SelectedIndex + 1;
            int maHanhKiem = hanhKiem_cbox.SelectedIndex + 1;

            try
            {
                bool check = ctrlBC.CreateReport(
                   id_txt.Text,
                   maHanhKiem,
                   comment_rtxt.Text,
                   maHocKi,
                   maNamHoc
               );
                if (check == true) { MessageBox.Show("Thêm thành công!"); }
                else { MessageBox.Show("Lỗi! Kiểm tra lại thông tin."); }
            }
            catch
            {
                MessageBox.Show("Lỗi! Vui lòng thử lại.");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            BaoCao ctrlBC = new BaoCao();

            int maHanhKiem = hanhKiem_cbox.SelectedIndex + 1;
            int maHocKi = semesterSearch_cbox.SelectedIndex + 1;
            int maNamHoc = yearSearch_cbox.SelectedIndex + 1;

            bool check = ctrlBC.UpdateReportTeacher(
                id_txt.Text,
                maHocKi,
                maNamHoc,
                maHanhKiem,
                comment_rtxt.Text
                );

            if (check == true) { MessageBox.Show("Cập nhật thành công!"); }
            else { MessageBox.Show("Lỗi! Kiểm tra lại thông tin."); }
        }

        private void searchID_btn_Click(object sender, EventArgs e)
        {
            HocSinh ctrlHS = new HocSinh();
            var hs = ctrlHS.GetStudentByID(searchID_txt.Text);

            //clear info
            id_txt.Text =
            name_txt.Text =
            hanhKiem_txt.Text =
            birth_txt.Text =
            sex_txt.Text =
            year_txt.Text =
            semester_txt.Text =
            comment_rtxt.Text = "";

            //clear search
            semesterSearch_cbox.Text =
            yearSearch_cbox.Text =
            search_txt.Text = "";

            if (hs != null)
            {
                DateTime birth = Convert.ToDateTime(hs.ngaySinh);

                id_txt.Text = hs.ma_hs;
                name_txt.Text = hs.ten;
                birth_txt.Text = birth.ToString("dd/MM/yyyy");

                if (hs.gioiTinh == 1)
                {
                    sex_txt.Text = "Nam";
                }
                else
                {
                    sex_txt.Text = "Nữ";
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy học sinh.");
            }
        }
    }
}
