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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLDSV));
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
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            grbImageGV.SuspendLayout();
            grbMenuGV.SuspendLayout();
            grb_InfoSV.SuspendLayout();
            grb_Subject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ListMark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grbImageGV
            // 
            grbImageGV.BackColor = Color.White;
            grbImageGV.Controls.Add(pictureBox1);
            grbImageGV.Controls.Add(btn_Find);
            grbImageGV.Controls.Add(txt_StudentID);
            grbImageGV.Controls.Add(lb_StudentID);
            resources.ApplyResources(grbImageGV, "grbImageGV");
            grbImageGV.Name = "grbImageGV";
            grbImageGV.TabStop = false;
            // 
            // btn_Find
            // 
            btn_Find.BackColor = Color.WhiteSmoke;
            resources.ApplyResources(btn_Find, "btn_Find");
            btn_Find.Name = "btn_Find";
            btn_Find.UseVisualStyleBackColor = false;
            btn_Find.Click += btn_Find_Click;
            // 
            // txt_StudentID
            // 
            resources.ApplyResources(txt_StudentID, "txt_StudentID");
            txt_StudentID.Name = "txt_StudentID";
            // 
            // lb_StudentID
            // 
            resources.ApplyResources(lb_StudentID, "lb_StudentID");
            lb_StudentID.Name = "lb_StudentID";
            // 
            // grbMenuGV
            // 
            grbMenuGV.BackColor = Color.White;
            grbMenuGV.Controls.Add(btn_SaveMark);
            grbMenuGV.Controls.Add(btn_DeleteMark);
            grbMenuGV.Controls.Add(btn_UpdateMark);
            grbMenuGV.Controls.Add(btn_addMark);
            resources.ApplyResources(grbMenuGV, "grbMenuGV");
            grbMenuGV.Name = "grbMenuGV";
            grbMenuGV.TabStop = false;
            // 
            // btn_SaveMark
            // 
            btn_SaveMark.BackColor = Color.FromArgb(0, 151, 178);
            resources.ApplyResources(btn_SaveMark, "btn_SaveMark");
            btn_SaveMark.ForeColor = Color.White;
            btn_SaveMark.Image = Properties.Resources.icons8_save_30;
            btn_SaveMark.Name = "btn_SaveMark";
            btn_SaveMark.UseVisualStyleBackColor = false;
            btn_SaveMark.Click += btn_SaveMark_Click;
            // 
            // btn_DeleteMark
            // 
            btn_DeleteMark.BackColor = Color.FromArgb(255, 87, 87);
            resources.ApplyResources(btn_DeleteMark, "btn_DeleteMark");
            btn_DeleteMark.ForeColor = Color.White;
            btn_DeleteMark.Image = Properties.Resources.icons8_trash_30;
            btn_DeleteMark.Name = "btn_DeleteMark";
            btn_DeleteMark.UseVisualStyleBackColor = false;
            btn_DeleteMark.Click += btn_DeleteMark_Click;
            // 
            // btn_UpdateMark
            // 
            btn_UpdateMark.BackColor = Color.FromArgb(255, 222, 89);
            resources.ApplyResources(btn_UpdateMark, "btn_UpdateMark");
            btn_UpdateMark.ForeColor = Color.White;
            btn_UpdateMark.Image = Properties.Resources.icons8_pencil_30;
            btn_UpdateMark.Name = "btn_UpdateMark";
            btn_UpdateMark.UseVisualStyleBackColor = false;
            btn_UpdateMark.Click += btn_UpdateMark_Click;
            // 
            // btn_addMark
            // 
            btn_addMark.BackColor = Color.FromArgb(0, 191, 99);
            resources.ApplyResources(btn_addMark, "btn_addMark");
            btn_addMark.ForeColor = Color.White;
            btn_addMark.Image = Properties.Resources.icons8_add_male_user_30;
            btn_addMark.Name = "btn_addMark";
            btn_addMark.UseVisualStyleBackColor = false;
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
            resources.ApplyResources(grb_InfoSV, "grb_InfoSV");
            grb_InfoSV.Name = "grb_InfoSV";
            grb_InfoSV.TabStop = false;
            grb_InfoSV.Enter += grb_InfoSV_Enter;
            // 
            // lb_NameClass
            // 
            resources.ApplyResources(lb_NameClass, "lb_NameClass");
            lb_NameClass.Name = "lb_NameClass";
            // 
            // txt_SubjectName
            // 
            resources.ApplyResources(txt_SubjectName, "txt_SubjectName");
            txt_SubjectName.Name = "txt_SubjectName";
            // 
            // lb_subjectName
            // 
            resources.ApplyResources(lb_subjectName, "lb_subjectName");
            lb_subjectName.ForeColor = Color.FromArgb(84, 84, 84);
            lb_subjectName.Name = "lb_subjectName";
            // 
            // lb_ClassName
            // 
            resources.ApplyResources(lb_ClassName, "lb_ClassName");
            lb_ClassName.Name = "lb_ClassName";
            // 
            // lb_class
            // 
            resources.ApplyResources(lb_class, "lb_class");
            lb_class.ForeColor = Color.FromArgb(84, 84, 84);
            lb_class.Name = "lb_class";
            // 
            // txt_NameStudent
            // 
            resources.ApplyResources(txt_NameStudent, "txt_NameStudent");
            txt_NameStudent.Name = "txt_NameStudent";
            // 
            // txt_IDStudent
            // 
            resources.ApplyResources(txt_IDStudent, "txt_IDStudent");
            txt_IDStudent.Name = "txt_IDStudent";
            // 
            // lb_AVG
            // 
            resources.ApplyResources(lb_AVG, "lb_AVG");
            lb_AVG.Name = "lb_AVG";
            // 
            // lb_MarkAVG
            // 
            resources.ApplyResources(lb_MarkAVG, "lb_MarkAVG");
            lb_MarkAVG.ForeColor = Color.FromArgb(84, 84, 84);
            lb_MarkAVG.Name = "lb_MarkAVG";
            // 
            // lb_NameStudent
            // 
            resources.ApplyResources(lb_NameStudent, "lb_NameStudent");
            lb_NameStudent.ForeColor = Color.FromArgb(84, 84, 84);
            lb_NameStudent.Name = "lb_NameStudent";
            // 
            // lb_IDStudent
            // 
            resources.ApplyResources(lb_IDStudent, "lb_IDStudent");
            lb_IDStudent.ForeColor = Color.FromArgb(84, 84, 84);
            lb_IDStudent.Name = "lb_IDStudent";
            // 
            // lb_SubjectMark
            // 
            resources.ApplyResources(lb_SubjectMark, "lb_SubjectMark");
            lb_SubjectMark.ForeColor = Color.FromArgb(84, 84, 84);
            lb_SubjectMark.Name = "lb_SubjectMark";
            // 
            // txt_SubjectID
            // 
            resources.ApplyResources(txt_SubjectID, "txt_SubjectID");
            txt_SubjectID.Name = "txt_SubjectID";
            // 
            // txt_SubjectMark
            // 
            resources.ApplyResources(txt_SubjectMark, "txt_SubjectMark");
            txt_SubjectMark.Name = "txt_SubjectMark";
            // 
            // lb_SubjectID
            // 
            resources.ApplyResources(lb_SubjectID, "lb_SubjectID");
            lb_SubjectID.ForeColor = Color.FromArgb(84, 84, 84);
            lb_SubjectID.Name = "lb_SubjectID";
            // 
            // grb_Subject
            // 
            grb_Subject.Controls.Add(lb_SubjectID);
            grb_Subject.Controls.Add(txt_SubjectID);
            grb_Subject.Controls.Add(lb_SubjectMark);
            grb_Subject.Controls.Add(txt_SubjectMark);
            resources.ApplyResources(grb_Subject, "grb_Subject");
            grb_Subject.Name = "grb_Subject";
            grb_Subject.TabStop = false;
            // 
            // dgv_ListMark
            // 
            dgv_ListMark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dgv_ListMark, "dgv_ListMark");
            dgv_ListMark.Name = "dgv_ListMark";
            dgv_ListMark.RowTemplate.Height = 29;
            dgv_ListMark.CellContentClick += dgv_ListMark_CellContentClick;
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grb_InfoSV);
            splitContainer1.Panel1.Controls.Add(grb_Subject);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.WhiteSmoke;
            splitContainer1.Panel2.Controls.Add(grbMenuGV);
            splitContainer1.Panel2.Controls.Add(dgv_ListMark);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Image = Properties.Resources.icons8_find;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // QLDSV
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(grbImageGV);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QLDSV";
            grbImageGV.ResumeLayout(false);
            grbImageGV.PerformLayout();
            grbMenuGV.ResumeLayout(false);
            grb_InfoSV.ResumeLayout(false);
            grb_InfoSV.PerformLayout();
            grb_Subject.ResumeLayout(false);
            grb_Subject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ListMark).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
    }
}