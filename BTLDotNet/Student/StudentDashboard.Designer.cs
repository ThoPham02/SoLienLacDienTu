namespace BTLDotNet
{
    partial class StudentDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlHS_Header1 = new BTLDotNet.ControlHS_Header();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonKQHT = new System.Windows.Forms.Button();
            this.buttonTKB = new System.Windows.Forms.Button();
            this.buttonTT = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.controlHS_KQHT1 = new BTLDotNet.ControlHS_KQHT();
            this.controlHS_TKB1 = new BTLDotNet.ControlHS_TKB();
            this.controlHS_TT1 = new BTLDotNet.ControlHS_TT();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.controlHS_Header1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1902, 150);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // controlHS_Header1
            // 
            this.controlHS_Header1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlHS_Header1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHS_Header1.Location = new System.Drawing.Point(0, 0);
            this.controlHS_Header1.Name = "controlHS_Header1";
            this.controlHS_Header1.Size = new System.Drawing.Size(1902, 150);
            this.controlHS_Header1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonKQHT);
            this.panel2.Controls.Add(this.buttonTKB);
            this.panel2.Controls.Add(this.buttonTT);
            this.panel2.Location = new System.Drawing.Point(12, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 853);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 786);
            this.button1.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonKQHT
            // 
            this.buttonKQHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKQHT.Location = new System.Drawing.Point(16, 154);
            this.buttonKQHT.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonKQHT.Name = "buttonKQHT";
            this.buttonKQHT.Size = new System.Drawing.Size(205, 57);
            this.buttonKQHT.TabIndex = 2;
            this.buttonKQHT.Text = "Kết quả học tập";
            this.buttonKQHT.UseVisualStyleBackColor = true;
            this.buttonKQHT.Click += new System.EventHandler(this.buttonKQHT_Click);
            // 
            // buttonTKB
            // 
            this.buttonTKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTKB.Location = new System.Drawing.Point(16, 81);
            this.buttonTKB.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonTKB.Name = "buttonTKB";
            this.buttonTKB.Size = new System.Drawing.Size(205, 57);
            this.buttonTKB.TabIndex = 1;
            this.buttonTKB.Text = "Thời khóa biểu";
            this.buttonTKB.UseVisualStyleBackColor = true;
            this.buttonTKB.Click += new System.EventHandler(this.btnHvT_Click);
            // 
            // buttonTT
            // 
            this.buttonTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTT.Location = new System.Drawing.Point(16, 8);
            this.buttonTT.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.buttonTT.Name = "buttonTT";
            this.buttonTT.Size = new System.Drawing.Size(205, 57);
            this.buttonTT.TabIndex = 0;
            this.buttonTT.Text = "Thông tin";
            this.buttonTT.UseVisualStyleBackColor = true;
            this.buttonTT.Click += new System.EventHandler(this.btnMaHS_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.controlHS_TT1);
            this.panel3.Controls.Add(this.controlHS_KQHT1);
            this.panel3.Controls.Add(this.controlHS_TKB1);
            this.panel3.Location = new System.Drawing.Point(281, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1609, 853);
            this.panel3.TabIndex = 0;
            // 
            // controlHS_KQHT1
            // 
            this.controlHS_KQHT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHS_KQHT1.Location = new System.Drawing.Point(0, 0);
            this.controlHS_KQHT1.Name = "controlHS_KQHT1";
            this.controlHS_KQHT1.Size = new System.Drawing.Size(1607, 851);
            this.controlHS_KQHT1.TabIndex = 1;
            // 
            // controlHS_TKB1
            // 
            this.controlHS_TKB1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHS_TKB1.Location = new System.Drawing.Point(0, 0);
            this.controlHS_TKB1.Name = "controlHS_TKB1";
            this.controlHS_TKB1.Size = new System.Drawing.Size(1607, 851);
            this.controlHS_TKB1.TabIndex = 0;
            // 
            // controlHS_TT1
            // 
            this.controlHS_TT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlHS_TT1.Location = new System.Drawing.Point(0, 0);
            this.controlHS_TT1.Name = "controlHS_TT1";
            this.controlHS_TT1.Size = new System.Drawing.Size(1607, 851);
            this.controlHS_TT1.TabIndex = 2;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentDashboard";
            this.Text = "studentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonKQHT;
        private System.Windows.Forms.Button buttonTKB;
        private System.Windows.Forms.Button buttonTT;
        private System.Windows.Forms.Panel panel3;
        private ControlHS_Header controlHS_Header1;
        private ControlHS_KQHT controlHS_KQHT1;
        private ControlHS_TKB controlHS_TKB1;
        private System.Windows.Forms.Button button1;
        private ControlHS_TT controlHS_TT1;
    }
}