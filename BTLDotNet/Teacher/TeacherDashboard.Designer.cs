namespace BTLDotNet
{
    partial class TeacherDashboard
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
            this.view_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonMark = new System.Windows.Forms.Button();
            this.buttonSched = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hello_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // view_panel
            // 
            this.view_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.view_panel.Location = new System.Drawing.Point(201, 142);
            this.view_panel.Name = "view_panel";
            this.view_panel.Size = new System.Drawing.Size(1216, 687);
            this.view_panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.buttonReport);
            this.panel2.Controls.Add(this.buttonStudent);
            this.panel2.Controls.Add(this.buttonMark);
            this.panel2.Controls.Add(this.buttonSched);
            this.panel2.Controls.Add(this.buttonInfo);
            this.panel2.Location = new System.Drawing.Point(8, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 687);
            this.panel2.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(12, 632);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(154, 46);
            this.buttonLogout.TabIndex = 5;
            this.buttonLogout.Text = "Đăng Xuất";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReport.Location = new System.Drawing.Point(10, 244);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(154, 46);
            this.buttonReport.TabIndex = 4;
            this.buttonReport.Text = "Báo cáo";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.Location = new System.Drawing.Point(12, 184);
            this.buttonStudent.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(154, 46);
            this.buttonStudent.TabIndex = 3;
            this.buttonStudent.Text = "Quản lý học sinh";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.student_btn_Click);
            // 
            // buttonMark
            // 
            this.buttonMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMark.Location = new System.Drawing.Point(12, 125);
            this.buttonMark.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.buttonMark.Name = "buttonMark";
            this.buttonMark.Size = new System.Drawing.Size(154, 46);
            this.buttonMark.TabIndex = 2;
            this.buttonMark.Text = "Quản lý điểm";
            this.buttonMark.UseVisualStyleBackColor = true;
            this.buttonMark.Click += new System.EventHandler(this.mark_btn_Click);
            // 
            // buttonSched
            // 
            this.buttonSched.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSched.Location = new System.Drawing.Point(12, 66);
            this.buttonSched.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.buttonSched.Name = "buttonSched";
            this.buttonSched.Size = new System.Drawing.Size(154, 46);
            this.buttonSched.TabIndex = 1;
            this.buttonSched.Text = "Thời khóa biểu";
            this.buttonSched.UseVisualStyleBackColor = true;
            this.buttonSched.Click += new System.EventHandler(this.sched_btn_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(12, 6);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(154, 46);
            this.buttonInfo.TabIndex = 0;
            this.buttonInfo.Text = "Thông tin";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.hello_label);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1426, 122);
            this.panel3.TabIndex = 2;
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hello_label.Location = new System.Drawing.Point(3, 0);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(70, 25);
            this.hello_label.TabIndex = 3;
            this.hello_label.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 302);
            this.button1.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Công tác";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.view_panel);
            this.Name = "TeacherDashboard";
            this.Text = "TeacherDashboard";
            this.Load += new System.EventHandler(this.TeacherDashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel view_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonMark;
        private System.Windows.Forms.Button buttonSched;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label hello_label;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
    }
}