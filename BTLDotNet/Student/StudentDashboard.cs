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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            InitializeUserControl();
            Load += StudentDashboard_Load;
        }
        public void setActiveControl(UserControl control)
        {
            controlHS_KQHT1.Visible = false;
            controlHS_TKB1.Visible= false;
            controlHS_TT1.Visible= false;

            control.Visible = true;
        }
        public void setActiveButton(Button btn)
        {
            List<Button> listBtn = new List<Button>()
            {
                buttonKQHT, buttonTT, buttonTKB
            };
            foreach (Button button in listBtn)
            {
                button.BackColor = Color.White;
            }
            btn.BackColor = Color.Aqua;
        }
        public void InitializeUserControl()
        {
            setActiveControl(controlHS_TT1);
            setActiveButton(buttonTT);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHvT_Click(object sender, EventArgs e)
        {
            setActiveControl(controlHS_TKB1);
            setActiveButton(buttonTKB);
        }

        private void btnMaHS_Click(object sender, EventArgs e)
        {
            setActiveControl(controlHS_TT1);
            setActiveButton(buttonTT);
        }

        private void buttonKQHT_Click(object sender, EventArgs e)
        {
            setActiveControl(controlHS_KQHT1);
            setActiveButton(buttonKQHT);
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
