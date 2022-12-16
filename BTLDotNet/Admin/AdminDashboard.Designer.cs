namespace BTLDotNet
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonNH = new System.Windows.Forms.Button();
            this.buttonHocKi = new System.Windows.Forms.Button();
            this.buttonMH = new System.Windows.Forms.Button();
            this.buttonHK = new System.Windows.Forms.Button();
            this.buttonLH = new System.Windows.Forms.Button();
            this.buttonBC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonTKB = new System.Windows.Forms.Button();
            this.buttonHS = new System.Windows.Forms.Button();
            this.buttonGV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlNH1 = new BTLDotNet.ControlAdmin_NH();
            this.controlMH1 = new BTLDotNet.ControlAdmin_MH();
            this.controlLH1 = new BTLDotNet.ControlAdmin_LH();
            this.controlHocKi1 = new BTLDotNet.ControlAdmin_HocKi();
            this.controlTKB1 = new BTLDotNet.ControlAdmin_TKB();
            this.controlHS1 = new BTLDotNet.ControlAdmin_HS();
            this.controlHK1 = new BTLDotNet.ControlAdmin_HK();
            this.controlGV1 = new BTLDotNet.ControlAdmin_GV();
            this.controlD1 = new BTLDotNet.ControlAdmin_D();
            this.controlBC1 = new BTLDotNet.ControlAdmin_BC();
            this.adminHeaderControl2 = new BTLDotNet.ControlAdmin_Header();
            this.panelHeader.SuspendLayout();
            this.panelNavbar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.adminHeaderControl2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1905, 150);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // panelNavbar
            // 
            this.panelNavbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavbar.Controls.Add(this.buttonLogout);
            this.panelNavbar.Controls.Add(this.buttonNH);
            this.panelNavbar.Controls.Add(this.buttonHocKi);
            this.panelNavbar.Controls.Add(this.buttonMH);
            this.panelNavbar.Controls.Add(this.buttonHK);
            this.panelNavbar.Controls.Add(this.buttonLH);
            this.panelNavbar.Controls.Add(this.buttonBC);
            this.panelNavbar.Controls.Add(this.buttonD);
            this.panelNavbar.Controls.Add(this.buttonTKB);
            this.panelNavbar.Controls.Add(this.buttonHS);
            this.panelNavbar.Controls.Add(this.buttonGV);
            this.panelNavbar.Location = new System.Drawing.Point(13, 171);
            this.panelNavbar.Margin = new System.Windows.Forms.Padding(4);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(250, 858);
            this.panelNavbar.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(16, 790);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(205, 58);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Text = "Đăng Xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonNH
            // 
            this.buttonNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNH.Location = new System.Drawing.Point(16, 583);
            this.buttonNH.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonNH.Name = "buttonNH";
            this.buttonNH.Size = new System.Drawing.Size(205, 57);
            this.buttonNH.TabIndex = 9;
            this.buttonNH.Text = "Năm Học";
            this.buttonNH.UseVisualStyleBackColor = true;
            this.buttonNH.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonHocKi
            // 
            this.buttonHocKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHocKi.Location = new System.Drawing.Point(16, 656);
            this.buttonHocKi.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonHocKi.Name = "buttonHocKi";
            this.buttonHocKi.Size = new System.Drawing.Size(205, 57);
            this.buttonHocKi.TabIndex = 8;
            this.buttonHocKi.Text = "Học Kì";
            this.buttonHocKi.UseVisualStyleBackColor = true;
            this.buttonHocKi.Click += new System.EventHandler(this.buttonHocKi_Click);
            // 
            // buttonMH
            // 
            this.buttonMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMH.Location = new System.Drawing.Point(16, 510);
            this.buttonMH.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonMH.Name = "buttonMH";
            this.buttonMH.Size = new System.Drawing.Size(205, 57);
            this.buttonMH.TabIndex = 7;
            this.buttonMH.Text = "Môn Học";
            this.buttonMH.UseVisualStyleBackColor = true;
            this.buttonMH.Click += new System.EventHandler(this.buttonMH_Click);
            // 
            // buttonHK
            // 
            this.buttonHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHK.Location = new System.Drawing.Point(16, 437);
            this.buttonHK.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonHK.Name = "buttonHK";
            this.buttonHK.Size = new System.Drawing.Size(205, 57);
            this.buttonHK.TabIndex = 6;
            this.buttonHK.Text = "Hạnh Kiểm";
            this.buttonHK.UseVisualStyleBackColor = true;
            this.buttonHK.Click += new System.EventHandler(this.buttonHK_Click);
            // 
            // buttonLH
            // 
            this.buttonLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLH.Location = new System.Drawing.Point(16, 364);
            this.buttonLH.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonLH.Name = "buttonLH";
            this.buttonLH.Size = new System.Drawing.Size(205, 57);
            this.buttonLH.TabIndex = 5;
            this.buttonLH.Text = "Lớp học";
            this.buttonLH.UseVisualStyleBackColor = true;
            this.buttonLH.Click += new System.EventHandler(this.buttonLH_Click);
            // 
            // buttonBC
            // 
            this.buttonBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBC.Location = new System.Drawing.Point(16, 291);
            this.buttonBC.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonBC.Name = "buttonBC";
            this.buttonBC.Size = new System.Drawing.Size(205, 57);
            this.buttonBC.TabIndex = 4;
            this.buttonBC.Text = "Báo Cáo";
            this.buttonBC.UseVisualStyleBackColor = true;
            this.buttonBC.Click += new System.EventHandler(this.buttonBC_Click);
            // 
            // buttonD
            // 
            this.buttonD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.Location = new System.Drawing.Point(16, 218);
            this.buttonD.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(205, 57);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "Điểm";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // buttonTKB
            // 
            this.buttonTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTKB.Location = new System.Drawing.Point(16, 154);
            this.buttonTKB.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonTKB.Name = "buttonTKB";
            this.buttonTKB.Size = new System.Drawing.Size(205, 57);
            this.buttonTKB.TabIndex = 2;
            this.buttonTKB.Text = "Thời Khóa Biểu";
            this.buttonTKB.UseVisualStyleBackColor = true;
            this.buttonTKB.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonHS
            // 
            this.buttonHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHS.Location = new System.Drawing.Point(16, 81);
            this.buttonHS.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonHS.Name = "buttonHS";
            this.buttonHS.Size = new System.Drawing.Size(205, 57);
            this.buttonHS.TabIndex = 1;
            this.buttonHS.Text = "Học Sinh";
            this.buttonHS.UseVisualStyleBackColor = true;
            this.buttonHS.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonGV
            // 
            this.buttonGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGV.Location = new System.Drawing.Point(16, 8);
            this.buttonGV.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonGV.Name = "buttonGV";
            this.buttonGV.Size = new System.Drawing.Size(205, 57);
            this.buttonGV.TabIndex = 0;
            this.buttonGV.Text = "Giáo Viên";
            this.buttonGV.UseVisualStyleBackColor = true;
            this.buttonGV.Click += new System.EventHandler(this.buttonGV_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.controlNH1);
            this.panel1.Controls.Add(this.controlMH1);
            this.panel1.Controls.Add(this.controlLH1);
            this.panel1.Controls.Add(this.controlHocKi1);
            this.panel1.Controls.Add(this.controlTKB1);
            this.panel1.Controls.Add(this.controlHS1);
            this.panel1.Controls.Add(this.controlHK1);
            this.panel1.Controls.Add(this.controlGV1);
            this.panel1.Controls.Add(this.controlD1);
            this.panel1.Controls.Add(this.controlBC1);
            this.panel1.Location = new System.Drawing.Point(286, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1606, 858);
            this.panel1.TabIndex = 2;
            // 
            // controlNH1
            // 
            this.controlNH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlNH1.Location = new System.Drawing.Point(0, 0);
            this.controlNH1.Name = "controlNH1";
            this.controlNH1.Size = new System.Drawing.Size(1604, 856);
            this.controlNH1.TabIndex = 9;
            // 
            // controlMH1
            // 
            this.controlMH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMH1.Location = new System.Drawing.Point(0, 0);
            this.controlMH1.Name = "controlMH1";
            this.controlMH1.Size = new System.Drawing.Size(1604, 856);
            this.controlMH1.TabIndex = 8;
            // 
            // controlLH1
            // 
            this.controlLH1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlLH1.Location = new System.Drawing.Point(0, 0);
            this.controlLH1.Name = "controlLH1";
            this.controlLH1.Size = new System.Drawing.Size(1604, 856);
            this.controlLH1.TabIndex = 7;
            // 
            // controlHocKi1
            // 
            this.controlHocKi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHocKi1.Location = new System.Drawing.Point(0, 0);
            this.controlHocKi1.Name = "controlHocKi1";
            this.controlHocKi1.Size = new System.Drawing.Size(1604, 856);
            this.controlHocKi1.TabIndex = 6;
            // 
            // controlTKB1
            // 
            this.controlTKB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlTKB1.Location = new System.Drawing.Point(0, 0);
            this.controlTKB1.Name = "controlTKB1";
            this.controlTKB1.Size = new System.Drawing.Size(1604, 856);
            this.controlTKB1.TabIndex = 5;
            // 
            // controlHS1
            // 
            this.controlHS1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHS1.Location = new System.Drawing.Point(0, 0);
            this.controlHS1.Name = "controlHS1";
            this.controlHS1.Size = new System.Drawing.Size(1604, 856);
            this.controlHS1.TabIndex = 4;
            // 
            // controlHK1
            // 
            this.controlHK1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHK1.Location = new System.Drawing.Point(0, 0);
            this.controlHK1.Name = "controlHK1";
            this.controlHK1.Size = new System.Drawing.Size(1604, 856);
            this.controlHK1.TabIndex = 3;
            // 
            // controlGV1
            // 
            this.controlGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlGV1.Location = new System.Drawing.Point(0, 0);
            this.controlGV1.Name = "controlGV1";
            this.controlGV1.Size = new System.Drawing.Size(1604, 856);
            this.controlGV1.TabIndex = 2;
            // 
            // controlD1
            // 
            this.controlD1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlD1.Location = new System.Drawing.Point(0, 0);
            this.controlD1.Name = "controlD1";
            this.controlD1.Size = new System.Drawing.Size(1604, 856);
            this.controlD1.TabIndex = 1;
            // 
            // controlBC1
            // 
            this.controlBC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlBC1.Location = new System.Drawing.Point(0, 0);
            this.controlBC1.Name = "controlBC1";
            this.controlBC1.Size = new System.Drawing.Size(1604, 856);
            this.controlBC1.TabIndex = 0;
            // 
            // adminHeaderControl2
            // 
            this.adminHeaderControl2.Location = new System.Drawing.Point(-1, -1);
            this.adminHeaderControl2.Name = "adminHeaderControl2";
            this.adminHeaderControl2.Size = new System.Drawing.Size(1905, 150);
            this.adminHeaderControl2.TabIndex = 1;
            this.adminHeaderControl2.Load += new System.EventHandler(this.adminHeaderControl2_Load);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1905, 1042);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNavbar);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboard";
            this.Text = "Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelNavbar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHocKi;
        private System.Windows.Forms.Button buttonMH;
        private System.Windows.Forms.Button buttonHK;
        private System.Windows.Forms.Button buttonLH;
        private System.Windows.Forms.Button buttonBC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonTKB;
        private System.Windows.Forms.Button buttonHS;
        private System.Windows.Forms.Button buttonGV;
        private System.Windows.Forms.Button buttonNH;
        private System.Windows.Forms.Button buttonLogout;
        private ControlAdmin_NH controlNH1;
        private ControlAdmin_MH controlMH1;
        private ControlAdmin_LH controlLH1;
        private ControlAdmin_HocKi controlHocKi1;
        private ControlAdmin_TKB controlTKB1;
        private ControlAdmin_HS controlHS1;
        private ControlAdmin_HK controlHK1;
        private ControlAdmin_GV controlGV1;
        private ControlAdmin_D controlD1;
        private ControlAdmin_BC controlBC1;
        private ControlAdmin_Header adminHeaderControl2;
    }
}