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
            SuspendLayout();
            // 
            // btn_Student
            // 
            btn_Student.Location = new Point(21, 104);
            btn_Student.Name = "btn_Student";
            btn_Student.Size = new Size(168, 29);
            btn_Student.TabIndex = 0;
            btn_Student.Text = "Quản lý sinh viên";
            btn_Student.UseVisualStyleBackColor = true;
            btn_Student.Click += btn_Student_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.Location = new Point(21, 316);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(112, 29);
            btn_Logout.TabIndex = 4;
            btn_Logout.Text = "Thoát";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // btn_StudentMark
            // 
            btn_StudentMark.Location = new Point(21, 245);
            btn_StudentMark.Name = "btn_StudentMark";
            btn_StudentMark.Size = new Size(168, 29);
            btn_StudentMark.TabIndex = 5;
            btn_StudentMark.Text = "Quản lý điểm sinh viên";
            btn_StudentMark.UseVisualStyleBackColor = true;
            btn_StudentMark.Click += btn_StudentMark_Click;
            // 
            // btn_Lecturer
            // 
            btn_Lecturer.Location = new Point(21, 173);
            btn_Lecturer.Name = "btn_Lecturer";
            btn_Lecturer.Size = new Size(168, 29);
            btn_Lecturer.TabIndex = 6;
            btn_Lecturer.Text = "Quản lý giảng viên";
            btn_Lecturer.UseVisualStyleBackColor = true;
            btn_Lecturer.Click += btn_Lecturer_Click;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btn_Lecturer);
            Controls.Add(btn_StudentMark);
            Controls.Add(btn_Logout);
            Controls.Add(btn_Student);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TrangChu";
            Text = "TrangChu";
            Load += TrangChu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Student;
        private Button btn_Logout;
        private Button btn_StudentMark;
        private Button btn_Lecturer;
    }
}