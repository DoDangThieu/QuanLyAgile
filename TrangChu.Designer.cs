namespace QuanLyAgile
{
    partial class TrangChu
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
            btn_Student = new Button();
            btn_Logout = new Button();
            btn_StudentMark = new Button();
            btn_Lecturer = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Student
            // 
            btn_Student.BackColor = Color.LightSkyBlue;
            btn_Student.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Student.FlatStyle = FlatStyle.Flat;
            btn_Student.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Student.ForeColor = Color.White;
            btn_Student.Image = Properties.Resources.icons8_management_30;
            btn_Student.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Student.Location = new Point(0, 263);
            btn_Student.Name = "btn_Student";
            btn_Student.Size = new Size(250, 101);
            btn_Student.TabIndex = 3;
            btn_Student.Text = "   Quản lý sinh viên";
            btn_Student.UseVisualStyleBackColor = false;
            btn_Student.Click += btn_Student_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.LightSkyBlue;
            btn_Logout.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Logout.FlatStyle = FlatStyle.Flat;
            btn_Logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Logout.ForeColor = Color.White;
            btn_Logout.Image = Properties.Resources.icons8_logout_40;
            btn_Logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Logout.Location = new Point(0, 733);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(250, 67);
            btn_Logout.TabIndex = 3;
            btn_Logout.Text = "     LogOut";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_StudentMark
            // 
            btn_StudentMark.BackColor = Color.LightSkyBlue;
            btn_StudentMark.BackgroundImageLayout = ImageLayout.Zoom;
            btn_StudentMark.FlatStyle = FlatStyle.Flat;
            btn_StudentMark.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_StudentMark.ForeColor = Color.White;
            btn_StudentMark.Image = Properties.Resources.icons8_management_302;
            btn_StudentMark.ImageAlign = ContentAlignment.MiddleLeft;
            btn_StudentMark.Location = new Point(0, 501);
            btn_StudentMark.Name = "btn_StudentMark";
            btn_StudentMark.Size = new Size(250, 101);
            btn_StudentMark.TabIndex = 3;
            btn_StudentMark.Text = "    Quản lý điểm SV";
            btn_StudentMark.UseVisualStyleBackColor = false;
            btn_StudentMark.Click += btn_StudentMark_Click;
            // 
            // btn_Lecturer
            // 
            btn_Lecturer.BackColor = Color.LightSkyBlue;
            btn_Lecturer.BackgroundImageLayout = ImageLayout.Zoom;
            btn_Lecturer.FlatStyle = FlatStyle.Flat;
            btn_Lecturer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Lecturer.ForeColor = Color.White;
            btn_Lecturer.Image = Properties.Resources.icons8_management_301;
            btn_Lecturer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Lecturer.Location = new Point(0, 382);
            btn_Lecturer.Name = "btn_Lecturer";
            btn_Lecturer.Size = new Size(250, 101);
            btn_Lecturer.TabIndex = 3;
            btn_Lecturer.Text = "    Quản lý giảng viên";
            btn_Lecturer.UseVisualStyleBackColor = false;
            btn_Lecturer.Click += btn_Lecturer_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btn_StudentMark);
            panel1.Controls.Add(btn_Lecturer);
            panel1.Controls.Add(btn_Logout);
            panel1.Controls.Add(btn_Student);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 800);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1401, 28);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(256, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(1132, 754);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngfind_com_random_guy_png_3605619;
            pictureBox1.Location = new Point(-58, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(148, 177);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 5;
            label1.Text = "Chạy đi Code";
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1400, 800);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChu";
            Load += TrangChu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Student;
        private Button btn_Logout;
        private Button btn_StudentMark;
        private Button btn_Lecturer;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}