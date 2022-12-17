
namespace BTLDotNet.Teacher
{
    partial class Report
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
            this.comment_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.sex_txt = new System.Windows.Forms.TextBox();
            this.sex_label = new System.Windows.Forms.Label();
            this.birth_txt = new System.Windows.Forms.TextBox();
            this.birth_label = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hanhKiem_cbox = new System.Windows.Forms.ComboBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.yearSearch_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.semesterSearch_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.semester_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.year_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comment_txt
            // 
            this.comment_txt.Location = new System.Drawing.Point(81, 29);
            this.comment_txt.Multiline = true;
            this.comment_txt.Name = "comment_txt";
            this.comment_txt.Size = new System.Drawing.Size(540, 103);
            this.comment_txt.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comment_txt);
            this.panel1.Location = new System.Drawing.Point(12, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 143);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhận xét của giáo viên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(14, 171);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(89, 17);
            this.phone_label.TabIndex = 18;
            this.phone_label.Text = "Hạnh kiểm:";
            // 
            // sex_txt
            // 
            this.sex_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_txt.Location = new System.Drawing.Point(115, 135);
            this.sex_txt.Name = "sex_txt";
            this.sex_txt.ReadOnly = true;
            this.sex_txt.Size = new System.Drawing.Size(166, 23);
            this.sex_txt.TabIndex = 17;
            this.sex_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_label.Location = new System.Drawing.Point(14, 138);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(74, 17);
            this.sex_label.TabIndex = 16;
            this.sex_label.Text = "Giới tính:";
            // 
            // birth_txt
            // 
            this.birth_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_txt.Location = new System.Drawing.Point(115, 102);
            this.birth_txt.Name = "birth_txt";
            this.birth_txt.ReadOnly = true;
            this.birth_txt.Size = new System.Drawing.Size(166, 23);
            this.birth_txt.TabIndex = 15;
            this.birth_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_label.Location = new System.Drawing.Point(14, 105);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(85, 17);
            this.birth_label.TabIndex = 14;
            this.birth_label.Text = "Ngày sinh:";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(115, 69);
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.Size = new System.Drawing.Size(166, 23);
            this.name_txt.TabIndex = 13;
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(14, 72);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(41, 17);
            this.name_label.TabIndex = 12;
            this.name_label.Text = "Tên:";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(115, 36);
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(166, 23);
            this.id_txt.TabIndex = 11;
            this.id_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(14, 39);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(100, 17);
            this.id_label.TabIndex = 10;
            this.id_label.Text = "Mã học sinh:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.hanhKiem_cbox);
            this.panel2.Controls.Add(this.id_txt);
            this.panel2.Controls.Add(this.phone_label);
            this.panel2.Controls.Add(this.id_label);
            this.panel2.Controls.Add(this.sex_txt);
            this.panel2.Controls.Add(this.name_label);
            this.panel2.Controls.Add(this.sex_label);
            this.panel2.Controls.Add(this.name_txt);
            this.panel2.Controls.Add(this.birth_txt);
            this.panel2.Controls.Add(this.birth_label);
            this.panel2.Location = new System.Drawing.Point(12, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 232);
            this.panel2.TabIndex = 20;
            // 
            // hanhKiem_cbox
            // 
            this.hanhKiem_cbox.FormattingEnabled = true;
            this.hanhKiem_cbox.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Yếu",
            "Kém",
            "(Chưa có)"});
            this.hanhKiem_cbox.Location = new System.Drawing.Point(115, 171);
            this.hanhKiem_cbox.Name = "hanhKiem_cbox";
            this.hanhKiem_cbox.Size = new System.Drawing.Size(166, 21);
            this.hanhKiem_cbox.TabIndex = 19;
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(178, 102);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(166, 23);
            this.search_txt.TabIndex = 20;
            this.search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.yearSearch_txt);
            this.panel3.Controls.Add(this.search_btn);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.search_txt);
            this.panel3.Controls.Add(this.semesterSearch_txt);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(305, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 232);
            this.panel3.TabIndex = 22;
            // 
            // yearSearch_txt
            // 
            this.yearSearch_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearSearch_txt.Location = new System.Drawing.Point(178, 69);
            this.yearSearch_txt.Name = "yearSearch_txt";
            this.yearSearch_txt.Size = new System.Drawing.Size(166, 23);
            this.yearSearch_txt.TabIndex = 23;
            this.yearSearch_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(202, 131);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(126, 45);
            this.search_btn.TabIndex = 22;
            this.search_btn.Text = "Tìm kiếm học sinh";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Năm học:";
            // 
            // semesterSearch_txt
            // 
            this.semesterSearch_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterSearch_txt.Location = new System.Drawing.Point(178, 36);
            this.semesterSearch_txt.Name = "semesterSearch_txt";
            this.semesterSearch_txt.Size = new System.Drawing.Size(166, 23);
            this.semesterSearch_txt.TabIndex = 21;
            this.semesterSearch_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Học kỳ:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Location = new System.Drawing.Point(262, 444);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(170, 55);
            this.add_btn.TabIndex = 23;
            this.add_btn.Text = "Thêm/Sửa Báo Cáo";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.year_txt);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.semester_txt);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 39);
            this.panel4.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã học sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(78, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Thông tin học sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, -3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tìm kiếm";
            // 
            // semester_txt
            // 
            this.semester_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_txt.Location = new System.Drawing.Point(115, 3);
            this.semester_txt.Name = "semester_txt";
            this.semester_txt.ReadOnly = true;
            this.semester_txt.Size = new System.Drawing.Size(166, 23);
            this.semester_txt.TabIndex = 23;
            this.semester_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Học kỳ:";
            // 
            // year_txt
            // 
            this.year_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_txt.Location = new System.Drawing.Point(471, 3);
            this.year_txt.Name = "year_txt";
            this.year_txt.ReadOnly = true;
            this.year_txt.Size = new System.Drawing.Size(166, 23);
            this.year_txt.TabIndex = 25;
            this.year_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Năm học:";
            // 
            // Report
            // 
            this.AcceptButton = this.search_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(742, 506);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox comment_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.TextBox sex_txt;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.TextBox birth_txt;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ComboBox hanhKiem_cbox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox yearSearch_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox semesterSearch_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox year_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox semester_txt;
        private System.Windows.Forms.Label label7;
    }
}