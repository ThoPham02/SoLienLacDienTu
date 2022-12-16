
namespace BTLDotNet.Teacher
{
    partial class Info
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
            this.id_label = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.updatePhone_btn = new System.Windows.Forms.Button();
            this.updateSex_btn = new System.Windows.Forms.Button();
            this.updateBirth_btn = new System.Windows.Forms.Button();
            this.updateName_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.phone_txt = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.sex_txt = new System.Windows.Forms.TextBox();
            this.sex_label = new System.Windows.Forms.Label();
            this.birth_txt = new System.Windows.Forms.TextBox();
            this.birth_label = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oldPass_txt = new System.Windows.Forms.TextBox();
            this.newPass_txt = new System.Windows.Forms.TextBox();
            this.confirmPass_txt = new System.Windows.Forms.TextBox();
            this.changePass_btn = new System.Windows.Forms.Button();
            this.showPass_rbtn = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(22, 6);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(105, 17);
            this.id_label.TabIndex = 0;
            this.id_label.Text = "Mã giáo viên:";
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_txt.Location = new System.Drawing.Point(123, 3);
            this.id_txt.Name = "id_txt";
            this.id_txt.ReadOnly = true;
            this.id_txt.Size = new System.Drawing.Size(301, 23);
            this.id_txt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refresh_btn);
            this.panel1.Controls.Add(this.updatePhone_btn);
            this.panel1.Controls.Add(this.updateSex_btn);
            this.panel1.Controls.Add(this.updateBirth_btn);
            this.panel1.Controls.Add(this.updateName_btn);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(this.phone_txt);
            this.panel1.Controls.Add(this.phone_label);
            this.panel1.Controls.Add(this.sex_txt);
            this.panel1.Controls.Add(this.sex_label);
            this.panel1.Controls.Add(this.birth_txt);
            this.panel1.Controls.Add(this.birth_label);
            this.panel1.Controls.Add(this.name_txt);
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.id_txt);
            this.panel1.Controls.Add(this.id_label);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 243);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.showPass_rbtn);
            this.panel3.Controls.Add(this.changePass_btn);
            this.panel3.Controls.Add(this.oldPass_txt);
            this.panel3.Controls.Add(this.newPass_txt);
            this.panel3.Controls.Add(this.confirmPass_txt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 253);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Đổi mật khẩu:";
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.Location = new System.Drawing.Point(209, 181);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(88, 55);
            this.refresh_btn.TabIndex = 13;
            this.refresh_btn.Text = "Làm mới";
            this.refresh_btn.UseVisualStyleBackColor = false;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // updatePhone_btn
            // 
            this.updatePhone_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updatePhone_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatePhone_btn.Location = new System.Drawing.Point(430, 135);
            this.updatePhone_btn.Name = "updatePhone_btn";
            this.updatePhone_btn.Size = new System.Drawing.Size(75, 23);
            this.updatePhone_btn.TabIndex = 12;
            this.updatePhone_btn.Text = "Sửa";
            this.updatePhone_btn.UseVisualStyleBackColor = false;
            this.updatePhone_btn.Click += new System.EventHandler(this.updatePhone_btn_Click);
            // 
            // updateSex_btn
            // 
            this.updateSex_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateSex_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateSex_btn.Location = new System.Drawing.Point(430, 102);
            this.updateSex_btn.Name = "updateSex_btn";
            this.updateSex_btn.Size = new System.Drawing.Size(75, 23);
            this.updateSex_btn.TabIndex = 11;
            this.updateSex_btn.Text = "Sửa";
            this.updateSex_btn.UseVisualStyleBackColor = false;
            this.updateSex_btn.Click += new System.EventHandler(this.updateSex_btn_Click);
            // 
            // updateBirth_btn
            // 
            this.updateBirth_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateBirth_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBirth_btn.Location = new System.Drawing.Point(430, 70);
            this.updateBirth_btn.Name = "updateBirth_btn";
            this.updateBirth_btn.Size = new System.Drawing.Size(75, 23);
            this.updateBirth_btn.TabIndex = 10;
            this.updateBirth_btn.Text = "Sửa";
            this.updateBirth_btn.UseVisualStyleBackColor = false;
            this.updateBirth_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateName_btn
            // 
            this.updateName_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.updateName_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateName_btn.Location = new System.Drawing.Point(430, 36);
            this.updateName_btn.Name = "updateName_btn";
            this.updateName_btn.Size = new System.Drawing.Size(75, 23);
            this.updateName_btn.TabIndex = 3;
            this.updateName_btn.Text = "Sửa";
            this.updateName_btn.UseVisualStyleBackColor = false;
            this.updateName_btn.Click += new System.EventHandler(this.updateName_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(303, 181);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(121, 55);
            this.update_btn.TabIndex = 4;
            this.update_btn.Text = "Cập nhật thông tin";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // phone_txt
            // 
            this.phone_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_txt.Location = new System.Drawing.Point(123, 135);
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.ReadOnly = true;
            this.phone_txt.Size = new System.Drawing.Size(301, 23);
            this.phone_txt.TabIndex = 9;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.Location = new System.Drawing.Point(22, 138);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(59, 17);
            this.phone_label.TabIndex = 8;
            this.phone_label.Text = "Phone:";
            // 
            // sex_txt
            // 
            this.sex_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_txt.Location = new System.Drawing.Point(123, 102);
            this.sex_txt.Name = "sex_txt";
            this.sex_txt.ReadOnly = true;
            this.sex_txt.Size = new System.Drawing.Size(301, 23);
            this.sex_txt.TabIndex = 7;
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex_label.Location = new System.Drawing.Point(22, 105);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(74, 17);
            this.sex_label.TabIndex = 6;
            this.sex_label.Text = "Giới tính:";
            // 
            // birth_txt
            // 
            this.birth_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_txt.Location = new System.Drawing.Point(123, 69);
            this.birth_txt.Name = "birth_txt";
            this.birth_txt.ReadOnly = true;
            this.birth_txt.Size = new System.Drawing.Size(301, 23);
            this.birth_txt.TabIndex = 5;
            // 
            // birth_label
            // 
            this.birth_label.AutoSize = true;
            this.birth_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_label.Location = new System.Drawing.Point(22, 72);
            this.birth_label.Name = "birth_label";
            this.birth_label.Size = new System.Drawing.Size(85, 17);
            this.birth_label.TabIndex = 4;
            this.birth_label.Text = "Ngày sinh:";
            // 
            // name_txt
            // 
            this.name_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txt.Location = new System.Drawing.Point(123, 36);
            this.name_txt.Name = "name_txt";
            this.name_txt.ReadOnly = true;
            this.name_txt.Size = new System.Drawing.Size(301, 23);
            this.name_txt.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(22, 39);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(41, 17);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Tên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 100);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Thông tin giáo viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nhập lại mật khẩu:";
            // 
            // oldPass_txt
            // 
            this.oldPass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldPass_txt.Location = new System.Drawing.Point(196, 36);
            this.oldPass_txt.Name = "oldPass_txt";
            this.oldPass_txt.Size = new System.Drawing.Size(228, 23);
            this.oldPass_txt.TabIndex = 16;
            this.oldPass_txt.UseSystemPasswordChar = true;
            // 
            // newPass_txt
            // 
            this.newPass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPass_txt.Location = new System.Drawing.Point(196, 77);
            this.newPass_txt.Name = "newPass_txt";
            this.newPass_txt.Size = new System.Drawing.Size(228, 23);
            this.newPass_txt.TabIndex = 17;
            this.newPass_txt.UseSystemPasswordChar = true;
            // 
            // confirmPass_txt
            // 
            this.confirmPass_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPass_txt.Location = new System.Drawing.Point(196, 119);
            this.confirmPass_txt.Name = "confirmPass_txt";
            this.confirmPass_txt.Size = new System.Drawing.Size(228, 23);
            this.confirmPass_txt.TabIndex = 18;
            this.confirmPass_txt.UseSystemPasswordChar = true;
            // 
            // changePass_btn
            // 
            this.changePass_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.changePass_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePass_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.changePass_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePass_btn.Location = new System.Drawing.Point(303, 195);
            this.changePass_btn.Name = "changePass_btn";
            this.changePass_btn.Size = new System.Drawing.Size(121, 55);
            this.changePass_btn.TabIndex = 19;
            this.changePass_btn.Text = "Đổi mật khẩu";
            this.changePass_btn.UseVisualStyleBackColor = false;
            this.changePass_btn.Click += new System.EventHandler(this.changePass_btn_Click);
            // 
            // showPass_rbtn
            // 
            this.showPass_rbtn.AutoSize = true;
            this.showPass_rbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass_rbtn.Location = new System.Drawing.Point(244, 148);
            this.showPass_rbtn.Name = "showPass_rbtn";
            this.showPass_rbtn.Size = new System.Drawing.Size(130, 24);
            this.showPass_rbtn.TabIndex = 20;
            this.showPass_rbtn.TabStop = true;
            this.showPass_rbtn.Text = "Hiện mật khẩu";
            this.showPass_rbtn.UseVisualStyleBackColor = true;
            this.showPass_rbtn.CheckedChanged += new System.EventHandler(this.showPass_rbtn_CheckedChanged);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.update_btn;
            this.ClientSize = new System.Drawing.Size(543, 620);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Info";
            this.Text = "TeacherInfo";
            this.Load += new System.EventHandler(this.Info_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox phone_txt;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.TextBox sex_txt;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.TextBox birth_txt;
        private System.Windows.Forms.Label birth_label;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button updatePhone_btn;
        private System.Windows.Forms.Button updateSex_btn;
        private System.Windows.Forms.Button updateBirth_btn;
        private System.Windows.Forms.Button updateName_btn;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPass_txt;
        private System.Windows.Forms.TextBox newPass_txt;
        private System.Windows.Forms.TextBox confirmPass_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton showPass_rbtn;
        private System.Windows.Forms.Button changePass_btn;
    }
}