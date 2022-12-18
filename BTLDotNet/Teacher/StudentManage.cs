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
    public partial class StudentManage : Form
    {
        public StudentManage()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            LopHoc lpCtrl = new LopHoc();
            HocSinh hsCtrl = new HocSinh();
            NamHoc nhCtrl = new NamHoc();
            listView1.Items.Clear();
            clearTextBox();
            var students = lpCtrl.GetClassListByTeacherID(Const.userID);


            foreach (var student in students)
            {
                ListViewItem item = new ListViewItem();

                string gioiTinh;
                string khoa = nhCtrl.GetYearName((int)student.khoa);
                DateTime ngaySinh = Convert.ToDateTime(student.ngaySinh);

                if (student.gioiTinh == 1)
                {
                    gioiTinh = "Nam";
                }
                else
                {
                    gioiTinh = "Nữ";
                }

                item.Text = student.ma_hs;
                item.SubItems.Add(student.ten);
                item.SubItems.Add(ngaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(gioiTinh);
                item.SubItems.Add(khoa);
                item.SubItems.Add(student.sdt);
                item.SubItems.Add(student.trang_thai);
                listView1.Items.Add(item);
            };

            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

        }

        public void clearTextBox()
        {
            id_txt.Text = name_txt.Text = birth_txt.Text = sex_txt.Text = "";
        }

        private void StudentManage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LopHoc lpCtrl = new LopHoc();
            HocSinh hsCtrl = new HocSinh();
            Model.EF.hoc_sinh hs = new Model.EF.hoc_sinh();

            var students = lpCtrl.GetClassListByTeacherID(Const.userID);

            foreach (var item in students)
            {
                if (item.ma_hs.ToUpper().Equals(search_txt.Text.ToUpper()))
                {
                    hs = item;
                    break;
                }
                else
                {
                    hs = null;
                }
            }

            if(hs == null) { MessageBox.Show("Không tìm thấy học sinh"); }
            else
            {
                //Insert info
                DateTime ngaySinh = Convert.ToDateTime(hs.ngaySinh);

                id_txt.Text = hs.ma_hs;
                name_txt.Text = hs.ten;
                birth_txt.Text = ngaySinh.ToString("dd/MM/yyyy");

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hs = listView1.SelectedItems;
            if (hs.Count == 0)
            {
                return;
            }
            else
            {
                id_txt.Text = hs[0].SubItems[0].Text;
                name_txt.Text = hs[0].SubItems[1].Text;
                birth_txt.Text = hs[0].SubItems[2].Text;
                sex_txt.Text = hs[0].SubItems[3].Text;
            }
        }
    }
}
