using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Controller;

namespace BTLDotNet.Teacher
{
    public partial class Info : Form
    {
        Model.EF.SoLienLacDienTuEntities db = new Model.EF.SoLienLacDienTuEntities();

        public Info()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            GiaoVien gv = new GiaoVien();
            Model.EF.giao_vien obj = gv.GetTeacherByID(Const.userID);

            DateTime birth = Convert.ToDateTime(obj.ngaySinh);

            id_txt.Text = obj.ma_gv;
            birth_txt.Text = birth.ToString("dd/MM/yyyy");
            name_txt.Text = obj.ten;
            phone_txt.Text = obj.sdt;

            if (obj.gioiTinh == 1)
            {
                sex_txt.Text = "Nam";
            }
            else
            {
                sex_txt.Text = "Nữ";
            }
        }

        private void Info_Load(object sender, EventArgs e)
        {

        }

        private void suaInfo_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            birth_txt.ReadOnly = false;
        }

        private void updateName_btn_Click(object sender, EventArgs e)
        {
            name_txt.ReadOnly = false;
        }

        private void updateSex_btn_Click(object sender, EventArgs e)
        {
            sex_txt.ReadOnly = false;
        }

        private void updatePhone_btn_Click(object sender, EventArgs e)
        {
            phone_txt.ReadOnly = false;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            GiaoVien model = new GiaoVien();

            birth_txt.ReadOnly = name_txt.ReadOnly = phone_txt.ReadOnly = sex_txt.ReadOnly = true;

            if(model.UpdateTeacher(Const.userID, name_txt.Text, birth_txt.Text, phone_txt.Text, sex_txt.Text))
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                LoadData();
                return;
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ vui lòng kiểm tra lại!");
                LoadData();
                return;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void showPass_rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass_rbtn.Checked == true)
            {
                oldPass_txt.UseSystemPasswordChar =              
                newPass_txt.UseSystemPasswordChar =
                confirmPass_txt.UseSystemPasswordChar = false;
            }
            else
            {
                oldPass_txt.UseSystemPasswordChar =
                newPass_txt.UseSystemPasswordChar =
                confirmPass_txt.UseSystemPasswordChar = true;
            }


        }

        private void changePass_btn_Click(object sender, EventArgs e)
        {
            GiaoVien model = new GiaoVien();

            if(oldPass_txt.Text == "" || newPass_txt.Text == "" || confirmPass_txt.Text == "")
            {
                oldPass_txt.Text = newPass_txt.Text = confirmPass_txt.Text = "";
                oldPass_txt.Focus();
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }

            if(model.ChangePassword(Const.userID, oldPass_txt.Text, newPass_txt.Text, confirmPass_txt.Text))
            {
                oldPass_txt.Text = newPass_txt.Text = confirmPass_txt.Text = "";
                MessageBox.Show("Đổi mật khẩu thành công!");
            }
            else
            {
                oldPass_txt.Text = newPass_txt.Text = confirmPass_txt.Text = "";
                MessageBox.Show("Mật khẩu không hợp lệ hoặc không chính xác!");
            }
        }
    }
}
