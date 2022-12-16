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
            if (!(search_txt.Text == null || search_txt.Text == ""))
            {
                try
                {
                    HocSinh model = new HocSinh();
                    Model.EF.hoc_sinh hs = model.GetStudentByID(search_txt.Text);

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

                }
                catch(Exception)
                {
                    MessageBox.Show("Mã học sinh không hợp lệ!");
                    search_txt.Focus();
                }

            }
            else
            {
                MessageBox.Show("Ô tìm kiếm trống!");
                search_txt.Focus();
            }


        }
    }
}
