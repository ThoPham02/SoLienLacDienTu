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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginController login = new LoginController();
            string name = txt_user.Text;
            string password = txt_password.Text;
            int isLogin = login.isLogin(name, password);


            switch (isLogin)
            {
                case -1:
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác!");
                    txt_user.Focus();
                    break;
                case 0:
                    AdminDashboard frm = new AdminDashboard();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                    break;
                case 1:
                    TeacherDashboard frm1 = new TeacherDashboard();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                    break;
                case 2:
                    StudentDashboard frm2 = new StudentDashboard();
                    this.Hide();
                    frm2.ShowDialog();
                    this.Show();
                    break;
                default:
                    break;
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void showPass_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass_chkbox.Checked == true)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
    }
}
