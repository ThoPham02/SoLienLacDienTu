namespace BTLDotNet
{
    partial class ControlHS_KQHT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_hocki = new System.Windows.Forms.Label();
            this.textBox_hocki = new System.Windows.Forms.TextBox();
            this.textBox_namhoc = new System.Windows.Forms.TextBox();
            this.label_namhoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_hocki
            // 
            this.label_hocki.AutoSize = true;
            this.label_hocki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hocki.Location = new System.Drawing.Point(75, 41);
            this.label_hocki.Name = "label_hocki";
            this.label_hocki.Size = new System.Drawing.Size(72, 25);
            this.label_hocki.TabIndex = 0;
            this.label_hocki.Text = "Học kì";
            // 
            // textBox_hocki
            // 
            this.textBox_hocki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hocki.Location = new System.Drawing.Point(153, 38);
            this.textBox_hocki.Name = "textBox_hocki";
            this.textBox_hocki.Size = new System.Drawing.Size(100, 30);
            this.textBox_hocki.TabIndex = 1;
            // 
            // textBox_namhoc
            // 
            this.textBox_namhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_namhoc.Location = new System.Drawing.Point(420, 36);
            this.textBox_namhoc.Name = "textBox_namhoc";
            this.textBox_namhoc.Size = new System.Drawing.Size(185, 30);
            this.textBox_namhoc.TabIndex = 3;
            // 
            // label_namhoc
            // 
            this.label_namhoc.AutoSize = true;
            this.label_namhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namhoc.Location = new System.Drawing.Point(317, 39);
            this.label_namhoc.Name = "label_namhoc";
            this.label_namhoc.Size = new System.Drawing.Size(97, 25);
            this.label_namhoc.TabIndex = 2;
            this.label_namhoc.Text = "Năm học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bảng điểm:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(58, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 688);
            this.panel1.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(935, 688);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ControlHS_KQHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_namhoc);
            this.Controls.Add(this.label_namhoc);
            this.Controls.Add(this.textBox_hocki);
            this.Controls.Add(this.label_hocki);
            this.Name = "ControlHS_KQHT";
            this.Size = new System.Drawing.Size(1607, 851);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_hocki;
        private System.Windows.Forms.TextBox textBox_hocki;
        private System.Windows.Forms.TextBox textBox_namhoc;
        private System.Windows.Forms.Label label_namhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
    }
}
