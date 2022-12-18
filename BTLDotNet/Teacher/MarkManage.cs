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
    public partial class MarkManage : Form
    {
        DiemKT diemCtrl = new DiemKT();

        public MarkManage()
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
                
                item.Text = student.ma_hs;
                item.SubItems.Add(student.ten);
                //item.SubItems.Add(student.)

                listView1.Items.Add(item);
            };

            listView1.FullRowSelect = true;
            listView1.MultiSelect = false;

        }

        public void clearTextBox()
        {
            id_txt.Text = name_txt.Text  = "";
        }
    }
}
