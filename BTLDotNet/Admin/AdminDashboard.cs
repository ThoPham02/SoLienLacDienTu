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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            InitializeUserControl();
            Load += AdminDashboard_Load;
        }

        public void setActivePanel(UserControl control)
        {
            // set all control disable
            controlD1.Visible = false;
            controlBC1.Visible = false;
            controlGV1.Visible = false;
            controlHK1.Visible = false;
            controlHocKi1.Visible = false;
            controlHS1.Visible = false;
            controlLH1.Visible = false;
            controlMH1.Visible = false;
            controlNH1.Visible= false;
            controlTKB1.Visible = false;

            //set active control
            control.Visible = true;
        }

        public void setActiveButton(Button btn)
        {
            List<Button> listBtn = new List<Button>()
            {
                buttonBC, buttonD, buttonGV, buttonHK, buttonHocKi, buttonHS, buttonTKB, buttonNH, buttonMH, buttonLH
            };
            foreach(Button button in listBtn)
            {
                button.BackColor = Color.White;
            }
            btn.BackColor = Color.Aqua;
        }

        public void InitializeUserControl()
        {
            setActivePanel(controlGV1);
            setActiveButton(buttonGV);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            setActivePanel(controlNH1);
            setActiveButton(buttonNH);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setActivePanel(controlHS1);
            setActiveButton(buttonHS);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setActivePanel(controlTKB1);
            setActiveButton(buttonTKB);
        }

        private void adminHeaderControl3_Load(object sender, EventArgs e)
        {

        }

        private void adminHeaderControl2_Load(object sender, EventArgs e)
        {

        }

        private void buttonGV_Click(object sender, EventArgs e)
        {
            setActivePanel(controlGV1);
            setActiveButton(buttonGV);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            setActivePanel(controlD1);
            setActiveButton(buttonD);
        }

        private void buttonBC_Click(object sender, EventArgs e)
        {
            setActivePanel(controlBC1);
            setActiveButton(buttonBC);
        }

        private void buttonLH_Click(object sender, EventArgs e)
        {
            setActivePanel(controlLH1);
            setActiveButton(buttonLH);
        }

        private void buttonHK_Click(object sender, EventArgs e)
        {
            setActivePanel(controlHK1);
            setActiveButton(buttonHK);
        }

        private void buttonMH_Click(object sender, EventArgs e)
        {
            setActivePanel(controlMH1);
            setActiveButton(buttonMH);
        }

        private void buttonHocKi_Click(object sender, EventArgs e)
        {
            setActivePanel(controlHocKi1);
            setActiveButton(buttonHocKi);
        }
    }
}
