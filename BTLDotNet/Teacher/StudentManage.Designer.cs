
namespace BTLDotNet.Teacher
{
    partial class StudentManage
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.sex_txt = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.sex_label = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.birth_txt = new System.Windows.Forms.TextBox();
            this.birth_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colMaHocSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colngaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKhoa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSĐT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTrangThai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(18, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 381);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.id_txt);
            this.panel2.Controls.Add(this.id_label);
            this.panel2.Controls.Add(this.sex_txt);
            this.panel2.Controls.Add(this.name_label);
            this.panel2.Controls.Add(this.sex_label);
            this.panel2.Controls.Add(this.name_txt);
            this.panel2.Controls.Add(this.birth_txt);
            this.panel2.Controls.Add(this.birth_label);
            this.panel2.Location = new System.Drawing.Point(18, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 167);
            this.panel2.TabIndex = 21;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.search_btn);
            this.panel3.Controls.Add(this.search_txt);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(343, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 100);
            this.panel3.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tìm kiếm học sinh";
            // 
            // search_txt
            // 
            this.search_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(16, 20);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(166, 23);
            this.search_txt.TabIndex = 27;
            this.search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.search_btn.Location = new System.Drawing.Point(63, 69);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 28;
            this.search_btn.Text = "Tìm kiếm";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHocSinh,
            this.colTen,
            this.colngaysinh,
            this.colGioiTinh,
            this.colKhoa,
            this.colSĐT,
            this.colTrangThai});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 2);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(769, 373);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.Text = "Mã học sinh";
            this.colMaHocSinh.Width = 120;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên";
            this.colTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTen.Width = 120;
            // 
            // colngaysinh
            // 
            this.colngaysinh.DisplayIndex = 5;
            this.colngaysinh.Text = "Ngày Sinh";
            this.colngaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colngaysinh.Width = 120;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DisplayIndex = 2;
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colGioiTinh.Width = 120;
            // 
            // colKhoa
            // 
            this.colKhoa.DisplayIndex = 3;
            this.colKhoa.Text = "Khóa";
            this.colKhoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colKhoa.Width = 120;
            // 
            // colSĐT
            // 
            this.colSĐT.DisplayIndex = 4;
            this.colSĐT.Text = "SĐT";
            this.colSĐT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSĐT.Width = 120;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Text = "Trạng thái";
            this.colTrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTrangThai.Width = 120;
            // 
            // StudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentManage";
            this.Text = "StudentManage";
            this.Load += new System.EventHandler(this.StudentManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox sex_txt;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox birth_txt;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colMaHocSinh;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colngaysinh;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colKhoa;
        private System.Windows.Forms.ColumnHeader colSĐT;
        private System.Windows.Forms.ColumnHeader colTrangThai;
    }
}