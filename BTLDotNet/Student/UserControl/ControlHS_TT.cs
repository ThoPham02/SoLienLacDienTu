using Controller;
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
    public partial class ControlHS_TT : UserControl
    {
        string userId = Const.userID;
        HocSinh hs = new HocSinh();
        public ControlHS_TT()
        {
            InitializeComponent();
            LoadData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void clearData()
        {
            id_txt.Text = name_txt.Text = birth_txt.Text = sex_txt.Text = phone_txt.Text = textBox1.Text = textBox2.Text = string.Empty;
            id_txt.ReadOnly = name_txt.ReadOnly = birth_txt.ReadOnly = sex_txt.ReadOnly = phone_txt.ReadOnly = textBox1.ReadOnly = textBox2.ReadOnly = true;
        }

        public void LoadData()
        {
            var info = hs.GetStudentByID(userId);
            clearData();
            id_txt.Text = info.ma_hs;
            name_txt.Text = info.ten;
            birth_txt.Text = info.ngaySinh.ToString();
            if(info.gioiTinh == 0)
            {
                sex_txt.Text = "Nữ";
            } else
            {
                sex_txt.Text = "Nam";
            }
            phone_txt.Text = info.sdt;
            textBox1.Text = info.khoa.ToString();
            textBox2.Text = info.trang_thai;
        }

        private void ControlHS_TT_Load(object sender, EventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string ten = name_txt.Text;
            string ngaySinh = birth_txt.Text;
            string gioiTinh = sex_txt.Text;
            string sdt = phone_txt.Text;
            if(hs.UpdateStudent(ten, ngaySinh, gioiTinh, sdt))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            } else
            {
                MessageBox.Show("Giới tính không hợp lệ!");
                LoadData();
            }
        }

        private void updateName_btn_Click(object sender, EventArgs e)
        {
            name_txt.ReadOnly =false;
            name_txt.Focus();
        }

        private void updateBirth_btn_Click(object sender, EventArgs e)
        {
            birth_txt.ReadOnly = false;
            birth_txt.Focus();
        }

        private void updateSex_btn_Click(object sender, EventArgs e)
        {
            sex_txt.ReadOnly = false;
            sex_txt.Focus();
        }

        private void updatePhone_btn_Click(object sender, EventArgs e)
        {
            phone_txt.ReadOnly = false;
            phone_txt.Focus();
        }
    }
}
