namespace QuanLyAgile
{
    partial class QLDSV
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
            grbImageGV = new GroupBox();
            btn_Find = new Button();
            txt_StudentID = new TextBox();
            lb_StudentID = new Label();
            grbMenuGV = new GroupBox();
            btn_SaveMark = new Button();
            btn_DeleteMark = new Button();
            btn_UpdateMark = new Button();
            btn_addMark = new Button();
            grb_InfoSV = new GroupBox();
            lb_NameClass = new Label();
            txt_SubjectName = new TextBox();
            lb_subjectName = new Label();
            lb_ClassName = new Label();
            lb_class = new Label();
            txt_NameStudent = new TextBox();
            txt_IDStudent = new TextBox();
            lb_AVG = new Label();
            lb_MarkAVG = new Label();
            lb_NameStudent = new Label();
            lb_IDStudent = new Label();
            lb_SubjectMark = new Label();
            txt_SubjectID = new TextBox();
            txt_SubjectMark = new TextBox();
            lb_SubjectID = new Label();
            grb_Subject = new GroupBox();
            dgv_ListMark = new DataGridView();
            btn_Exit = new Button();
            grbImageGV.SuspendLayout();
            grbMenuGV.SuspendLayout();
            grb_InfoSV.SuspendLayout();
            grb_Subject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ListMark).BeginInit();
            SuspendLayout();
            // 
            // grbImageGV
            // 
            grbImageGV.Controls.Add(btn_Find);
            grbImageGV.Controls.Add(txt_StudentID);
            grbImageGV.Controls.Add(lb_StudentID);
            grbImageGV.Location = new Point(12, 2);
            grbImageGV.Name = "grbImageGV";
            grbImageGV.Size = new Size(217, 95);
            grbImageGV.TabIndex = 2;
            grbImageGV.TabStop = false;
            grbImageGV.Text = "Tìm kiếm sinh viên";
            // 
            // btn_Find
            // 
            btn_Find.Location = new Point(6, 62);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(94, 29);
            btn_Find.TabIndex = 4;
            btn_Find.Text = "Tìm kiếm";
            btn_Find.UseVisualStyleBackColor = true;
            btn_Find.Click += btn_Find_Click;
            // 
            // txt_StudentID
            // 
            txt_StudentID.Location = new Point(72, 29);
            txt_StudentID.Name = "txt_StudentID";
            txt_StudentID.Size = new Size(125, 27);
            txt_StudentID.TabIndex = 1;
            // 
            // lb_StudentID
            // 
            lb_StudentID.AutoSize = true;
            lb_StudentID.Location = new Point(12, 32);
            lb_StudentID.Name = "lb_StudentID";
            lb_StudentID.Size = new Size(54, 20);
            lb_StudentID.TabIndex = 0;
            lb_StudentID.Text = "Mã SV:";
            // 
            // grbMenuGV
            // 
            grbMenuGV.Controls.Add(btn_Exit);
            grbMenuGV.Controls.Add(btn_SaveMark);
            grbMenuGV.Controls.Add(btn_DeleteMark);
            grbMenuGV.Controls.Add(btn_UpdateMark);
            grbMenuGV.Controls.Add(btn_addMark);
            grbMenuGV.Location = new Point(235, 12);
            grbMenuGV.Name = "grbMenuGV";
            grbMenuGV.Size = new Size(562, 74);
            grbMenuGV.TabIndex = 4;
            grbMenuGV.TabStop = false;
            grbMenuGV.Text = "Chức năng";
            // 
            // btn_SaveMark
            // 
            btn_SaveMark.Location = new Point(356, 26);
            btn_SaveMark.Name = "btn_SaveMark";
            btn_SaveMark.Size = new Size(94, 29);
            btn_SaveMark.TabIndex = 3;
            btn_SaveMark.Text = "Hiển thị";
            btn_SaveMark.UseVisualStyleBackColor = true;
            btn_SaveMark.Click += btn_SaveMark_Click;
            // 
            // btn_DeleteMark
            // 
            btn_DeleteMark.Location = new Point(256, 26);
            btn_DeleteMark.Name = "btn_DeleteMark";
            btn_DeleteMark.Size = new Size(94, 29);
            btn_DeleteMark.TabIndex = 2;
            btn_DeleteMark.Text = "Xóa";
            btn_DeleteMark.UseVisualStyleBackColor = true;
            btn_DeleteMark.Click += btn_DeleteMark_Click;
            // 
            // btn_UpdateMark
            // 
            btn_UpdateMark.Location = new Point(144, 26);
            btn_UpdateMark.Name = "btn_UpdateMark";
            btn_UpdateMark.Size = new Size(94, 29);
            btn_UpdateMark.TabIndex = 1;
            btn_UpdateMark.Text = "Sửa";
            btn_UpdateMark.UseVisualStyleBackColor = true;
            btn_UpdateMark.Click += btn_UpdateMark_Click;
            // 
            // btn_addMark
            // 
            btn_addMark.Location = new Point(18, 26);
            btn_addMark.Name = "btn_addMark";
            btn_addMark.Size = new Size(94, 29);
            btn_addMark.TabIndex = 0;
            btn_addMark.Text = "Thêm";
            btn_addMark.UseVisualStyleBackColor = true;
            btn_addMark.Click += btn_addMark_Click;
            // 
            // grb_InfoSV
            // 
            grb_InfoSV.Controls.Add(lb_NameClass);
            grb_InfoSV.Controls.Add(txt_SubjectName);
            grb_InfoSV.Controls.Add(lb_subjectName);
            grb_InfoSV.Controls.Add(lb_ClassName);
            grb_InfoSV.Controls.Add(lb_class);
            grb_InfoSV.Controls.Add(txt_NameStudent);
            grb_InfoSV.Controls.Add(txt_IDStudent);
            grb_InfoSV.Controls.Add(lb_AVG);
            grb_InfoSV.Controls.Add(lb_MarkAVG);
            grb_InfoSV.Controls.Add(lb_NameStudent);
            grb_InfoSV.Controls.Add(lb_IDStudent);
            grb_InfoSV.Location = new Point(12, 233);
            grb_InfoSV.Name = "grb_InfoSV";
            grb_InfoSV.Size = new Size(217, 205);
            grb_InfoSV.TabIndex = 5;
            grb_InfoSV.TabStop = false;
            grb_InfoSV.Text = "Thông tin sinh viên";
            grb_InfoSV.Enter += grb_InfoSV_Enter;
            // 
            // lb_NameClass
            // 
            lb_NameClass.AutoSize = true;
            lb_NameClass.Location = new Point(100, 148);
            lb_NameClass.Name = "lb_NameClass";
            lb_NameClass.Size = new Size(25, 20);
            lb_NameClass.TabIndex = 13;
            lb_NameClass.Text = "00";
            // 
            // txt_SubjectName
            // 
            txt_SubjectName.Location = new Point(100, 112);
            txt_SubjectName.Name = "txt_SubjectName";
            txt_SubjectName.Size = new Size(107, 27);
            txt_SubjectName.TabIndex = 12;
            // 
            // lb_subjectName
            // 
            lb_subjectName.AutoSize = true;
            lb_subjectName.Location = new Point(1, 115);
            lb_subjectName.Name = "lb_subjectName";
            lb_subjectName.Size = new Size(69, 20);
            lb_subjectName.TabIndex = 11;
            lb_subjectName.Text = "Tên môn:";
            // 
            // lb_ClassName
            // 
            lb_ClassName.AutoSize = true;
            lb_ClassName.Location = new Point(100, 126);
            lb_ClassName.Name = "lb_ClassName";
            lb_ClassName.Size = new Size(0, 20);
            lb_ClassName.TabIndex = 10;
            // 
            // lb_class
            // 
            lb_class.AutoSize = true;
            lb_class.Location = new Point(6, 148);
            lb_class.Name = "lb_class";
            lb_class.Size = new Size(37, 20);
            lb_class.TabIndex = 9;
            lb_class.Text = "Lớp:";
            // 
            // txt_NameStudent
            // 
            txt_NameStudent.Location = new Point(100, 71);
            txt_NameStudent.Name = "txt_NameStudent";
            txt_NameStudent.Size = new Size(107, 27);
            txt_NameStudent.TabIndex = 8;
            // 
            // txt_IDStudent
            // 
            txt_IDStudent.Location = new Point(100, 38);
            txt_IDStudent.Name = "txt_IDStudent";
            txt_IDStudent.Size = new Size(107, 27);
            txt_IDStudent.TabIndex = 7;
            // 
            // lb_AVG
            // 
            lb_AVG.AutoSize = true;
            lb_AVG.Location = new Point(100, 182);
            lb_AVG.Name = "lb_AVG";
            lb_AVG.Size = new Size(28, 20);
            lb_AVG.TabIndex = 6;
            lb_AVG.Text = "0.0";
            // 
            // lb_MarkAVG
            // 
            lb_MarkAVG.AutoSize = true;
            lb_MarkAVG.Location = new Point(-3, 182);
            lb_MarkAVG.Name = "lb_MarkAVG";
            lb_MarkAVG.Size = new Size(69, 20);
            lb_MarkAVG.TabIndex = 2;
            lb_MarkAVG.Text = "Điểm TB:";
            // 
            // lb_NameStudent
            // 
            lb_NameStudent.AutoSize = true;
            lb_NameStudent.Location = new Point(1, 79);
            lb_NameStudent.Name = "lb_NameStudent";
            lb_NameStudent.Size = new Size(78, 20);
            lb_NameStudent.TabIndex = 1;
            lb_NameStudent.Text = "Họ và Tên:";
            // 
            // lb_IDStudent
            // 
            lb_IDStudent.AutoSize = true;
            lb_IDStudent.Location = new Point(0, 38);
            lb_IDStudent.Name = "lb_IDStudent";
            lb_IDStudent.Size = new Size(94, 20);
            lb_IDStudent.TabIndex = 0;
            lb_IDStudent.Text = "Mã sinh viên:";
            // 
            // lb_SubjectMark
            // 
            lb_SubjectMark.AutoSize = true;
            lb_SubjectMark.Location = new Point(12, 77);
            lb_SubjectMark.Name = "lb_SubjectMark";
            lb_SubjectMark.Size = new Size(48, 20);
            lb_SubjectMark.TabIndex = 16;
            lb_SubjectMark.Text = "Điểm:";
            // 
            // txt_SubjectID
            // 
            txt_SubjectID.Location = new Point(82, 31);
            txt_SubjectID.Name = "txt_SubjectID";
            txt_SubjectID.Size = new Size(125, 27);
            txt_SubjectID.TabIndex = 10;
            // 
            // txt_SubjectMark
            // 
            txt_SubjectMark.Location = new Point(82, 77);
            txt_SubjectMark.Name = "txt_SubjectMark";
            txt_SubjectMark.Size = new Size(92, 27);
            txt_SubjectMark.TabIndex = 9;
            // 
            // lb_SubjectID
            // 
            lb_SubjectID.AutoSize = true;
            lb_SubjectID.Location = new Point(12, 34);
            lb_SubjectID.Name = "lb_SubjectID";
            lb_SubjectID.Size = new Size(67, 20);
            lb_SubjectID.TabIndex = 3;
            lb_SubjectID.Text = "Mã môn:";
            // 
            // grb_Subject
            // 
            grb_Subject.Controls.Add(lb_SubjectID);
            grb_Subject.Controls.Add(txt_SubjectID);
            grb_Subject.Controls.Add(lb_SubjectMark);
            grb_Subject.Controls.Add(txt_SubjectMark);
            grb_Subject.Location = new Point(12, 99);
            grb_Subject.Name = "grb_Subject";
            grb_Subject.Size = new Size(217, 135);
            grb_Subject.TabIndex = 5;
            grb_Subject.TabStop = false;
            grb_Subject.Text = "Thêm điểm";
            // 
            // dgv_ListMark
            // 
            dgv_ListMark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ListMark.Location = new Point(235, 82);
            dgv_ListMark.Name = "dgv_ListMark";
            dgv_ListMark.RowHeadersWidth = 51;
            dgv_ListMark.RowTemplate.Height = 29;
            dgv_ListMark.Size = new Size(562, 371);
            dgv_ListMark.TabIndex = 6;
            dgv_ListMark.CellContentClick += dgv_ListMark_CellContentClick;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(468, 26);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // QLDSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_ListMark);
            Controls.Add(grb_Subject);
            Controls.Add(grb_InfoSV);
            Controls.Add(grbMenuGV);
            Controls.Add(grbImageGV);
            Name = "QLDSV";
            Text = "QLDSV";
            grbImageGV.ResumeLayout(false);
            grbImageGV.PerformLayout();
            grbMenuGV.ResumeLayout(false);
            grb_InfoSV.ResumeLayout(false);
            grb_InfoSV.PerformLayout();
            grb_Subject.ResumeLayout(false);
            grb_Subject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ListMark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbImageGV;
        private Button btn_Find;
        private TextBox txt_StudentID;
        private Label lb_StudentID;
        private GroupBox grbMenuGV;
        private Button btn_SaveMark;
        private Button btn_DeleteMark;
        private Button btn_UpdateMark;
        private Button btn_addMark;
        private GroupBox grb_InfoSV;
        private Label lb_SubjectMark;
        private TextBox txt_SubjectID;
        private TextBox txt_SubjectMark;
        private TextBox txt_NameStudent;
        private TextBox txt_IDStudent;
        private Label lb_SubjectID;
        private Label lb_MarkAVG;
        private Label lb_NameStudent;
        private Label lb_IDStudent;
        private GroupBox grb_Subject;
        private Label lb_AVG;
        private DataGridView dgv_ListMark;
        private Label lb_ClassName;
        private Label lb_class;
        private Label lb_subjectName;
        private TextBox txt_SubjectName;
        private Label lb_NameClass;
        private Button btn_Exit;
    }
}