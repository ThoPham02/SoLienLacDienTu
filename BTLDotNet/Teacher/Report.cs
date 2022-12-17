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
            if (!(search_txt.Text == "" || semesterSearch_txt.Text == "" || yearSearch_txt.Text == ""))
            {
                try
                {
                    HocSinh modelHS = new HocSinh();
                    BaoCao modelBC = new BaoCao();
                    NamHoc modelNH = new NamHoc();
                    HocKi modelHK = new HocKi();
                    Model.EF.hoc_sinh hs = modelHS.GetStudentByID(search_txt.Text);
                    Model.EF.bao_cao bc = modelBC.GetReportByStudentAndYear
                        (search_txt.Text,
                        Convert.ToInt32(semesterSearch_txt.Text),
                        Convert.ToInt32(yearSearch_txt.Text)
                        );


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

                        year_txt.Text = modelNH.GetYearName((int)bc.ma_nam);
                        semester_txt.Text = modelHK.GetSemesterName((int)bc.ma_hoc_ki);

                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Tìm kiếm không hợp lệ!");
                    search_txt.Focus();
                }

            }
            else
            {
                MessageBox.Show("Ô tìm kiếm trống!  Vui lòng nhập đủ thông tin");
                search_txt.Focus();
            }


        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            BaoCao bc = new BaoCao();
            if (id_txt.Text == "") { MessageBox.Show("Chưa tìm kiếm học sinh!"); }
            bool check = bc.CreateReport(
                    id_txt.Text,
                    hanhKiem_cbox.Text,
                    comment_txt.Text,
                    semesterSearch_txt.Text,
                    yearSearch_txt.Text
                );
            if (check == true) { MessageBox.Show("Thêm báo cáo thành công!"); }
            else { MessageBox.Show("Lỗi! Kiểm tra lại thông tin"); }
        }
    }
}
