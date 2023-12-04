namespace QuanLyAgile
{
    partial class QLGV
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
            grbMenuGV = new GroupBox();
            btn_SaveGV = new Button();
            btn_DeleteGV = new Button();
            btn_UpdateGV = new Button();
            btn_addGV = new Button();
            grb_InfoGV = new GroupBox();
            txt_password = new TextBox();
            lb_Pass = new Label();
            lb_UserName = new Label();
            txt_UserName = new TextBox();
            dtpBornGV = new DateTimePicker();
            rdbFemaleGV = new RadioButton();
            rdbMaleGV = new RadioButton();
            txt_AddressGV = new TextBox();
            txt_MailGV = new TextBox();
            txt_PhoneGV = new TextBox();
            txt_NameGV = new TextBox();
            txt_IDGV = new TextBox();
            lb_AddressGV = new Label();
            lb_BornGV = new Label();
            lb_genderGV = new Label();
            lb_EmailGV = new Label();
            lb_PhoneGV = new Label();
            lb_NameGV = new Label();
            lb_IDGV = new Label();
            dgv_danhSach = new DataGridView();
            btn_Exit = new Button();
            grbMenuGV.SuspendLayout();
            grb_InfoGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhSach).BeginInit();
            SuspendLayout();
            // 
            // grbImageGV
            // 
            grbImageGV.Location = new Point(3, 2);
            grbImageGV.Name = "grbImageGV";
            grbImageGV.Size = new Size(217, 84);
            grbImageGV.TabIndex = 1;
            grbImageGV.TabStop = false;
            grbImageGV.Text = "Ảnh đại diện";
            // 
            // grbMenuGV
            // 
            grbMenuGV.Controls.Add(btn_Exit);
            grbMenuGV.Controls.Add(btn_SaveGV);
            grbMenuGV.Controls.Add(btn_DeleteGV);
            grbMenuGV.Controls.Add(btn_UpdateGV);
            grbMenuGV.Controls.Add(btn_addGV);
            grbMenuGV.Location = new Point(226, 2);
            grbMenuGV.Name = "grbMenuGV";
            grbMenuGV.Size = new Size(562, 74);
            grbMenuGV.TabIndex = 3;
            grbMenuGV.TabStop = false;
            grbMenuGV.Text = "Chức năng";
            // 
            // btn_SaveGV
            // 
            btn_SaveGV.Location = new Point(322, 26);
            btn_SaveGV.Name = "btn_SaveGV";
            btn_SaveGV.Size = new Size(94, 29);
            btn_SaveGV.TabIndex = 3;
            btn_SaveGV.Text = "Hiển thị";
            btn_SaveGV.UseVisualStyleBackColor = true;
            btn_SaveGV.Click += btn_SaveGV_Click;
            // 
            // btn_DeleteGV
            // 
            btn_DeleteGV.Location = new Point(222, 26);
            btn_DeleteGV.Name = "btn_DeleteGV";
            btn_DeleteGV.Size = new Size(94, 29);
            btn_DeleteGV.TabIndex = 2;
            btn_DeleteGV.Text = "Xóa";
            btn_DeleteGV.UseVisualStyleBackColor = true;
            btn_DeleteGV.Click += btn_DeleteGV_Click;
            // 
            // btn_UpdateGV
            // 
            btn_UpdateGV.Location = new Point(122, 26);
            btn_UpdateGV.Name = "btn_UpdateGV";
            btn_UpdateGV.Size = new Size(94, 29);
            btn_UpdateGV.TabIndex = 1;
            btn_UpdateGV.Text = "Sửa";
            btn_UpdateGV.UseVisualStyleBackColor = true;
            btn_UpdateGV.Click += btn_UpdateGV_Click;
            // 
            // btn_addGV
            // 
            btn_addGV.Location = new Point(6, 26);
            btn_addGV.Name = "btn_addGV";
            btn_addGV.Size = new Size(94, 29);
            btn_addGV.TabIndex = 0;
            btn_addGV.Text = "Thêm";
            btn_addGV.UseVisualStyleBackColor = true;
            btn_addGV.Click += btn_addGV_Click;
            // 
            // grb_InfoGV
            // 
            grb_InfoGV.Controls.Add(txt_password);
            grb_InfoGV.Controls.Add(lb_Pass);
            grb_InfoGV.Controls.Add(lb_UserName);
            grb_InfoGV.Controls.Add(txt_UserName);
            grb_InfoGV.Controls.Add(dtpBornGV);
            grb_InfoGV.Controls.Add(rdbFemaleGV);
            grb_InfoGV.Controls.Add(rdbMaleGV);
            grb_InfoGV.Controls.Add(txt_AddressGV);
            grb_InfoGV.Controls.Add(txt_MailGV);
            grb_InfoGV.Controls.Add(txt_PhoneGV);
            grb_InfoGV.Controls.Add(txt_NameGV);
            grb_InfoGV.Controls.Add(txt_IDGV);
            grb_InfoGV.Controls.Add(lb_AddressGV);
            grb_InfoGV.Controls.Add(lb_BornGV);
            grb_InfoGV.Controls.Add(lb_genderGV);
            grb_InfoGV.Controls.Add(lb_EmailGV);
            grb_InfoGV.Controls.Add(lb_PhoneGV);
            grb_InfoGV.Controls.Add(lb_NameGV);
            grb_InfoGV.Controls.Add(lb_IDGV);
            grb_InfoGV.Location = new Point(3, 82);
            grb_InfoGV.Name = "grb_InfoGV";
            grb_InfoGV.Size = new Size(264, 356);
            grb_InfoGV.TabIndex = 4;
            grb_InfoGV.TabStop = false;
            grb_InfoGV.Text = "Thông tin giảng viên";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(83, 179);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(87, 27);
            txt_password.TabIndex = 18;
            // 
            // lb_Pass
            // 
            lb_Pass.AutoSize = true;
            lb_Pass.Location = new Point(4, 179);
            lb_Pass.Name = "lb_Pass";
            lb_Pass.Size = new Size(70, 20);
            lb_Pass.TabIndex = 17;
            lb_Pass.Text = "Mật khẩu";
            // 
            // lb_UserName
            // 
            lb_UserName.AutoSize = true;
            lb_UserName.Location = new Point(6, 140);
            lb_UserName.Name = "lb_UserName";
            lb_UserName.Size = new Size(71, 20);
            lb_UserName.TabIndex = 16;
            lb_UserName.Text = "Tài khoản";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(83, 140);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(87, 27);
            txt_UserName.TabIndex = 15;
            txt_UserName.TextChanged += txt_UserName_TextChanged;
            // 
            // dtpBornGV
            // 
            dtpBornGV.CustomFormat = "dd-MM-yyyy";
            dtpBornGV.Format = DateTimePickerFormat.Custom;
            dtpBornGV.Location = new Point(122, 268);
            dtpBornGV.Name = "dtpBornGV";
            dtpBornGV.Size = new Size(99, 27);
            dtpBornGV.TabIndex = 14;
            // 
            // rdbFemaleGV
            // 
            rdbFemaleGV.AutoSize = true;
            rdbFemaleGV.Location = new Point(186, 218);
            rdbFemaleGV.Name = "rdbFemaleGV";
            rdbFemaleGV.Size = new Size(50, 24);
            rdbFemaleGV.TabIndex = 13;
            rdbFemaleGV.TabStop = true;
            rdbFemaleGV.Text = "Nữ";
            rdbFemaleGV.UseVisualStyleBackColor = true;
            // 
            // rdbMaleGV
            // 
            rdbMaleGV.AutoSize = true;
            rdbMaleGV.Location = new Point(105, 218);
            rdbMaleGV.Name = "rdbMaleGV";
            rdbMaleGV.Size = new Size(62, 24);
            rdbMaleGV.TabIndex = 12;
            rdbMaleGV.TabStop = true;
            rdbMaleGV.Text = "Nam";
            rdbMaleGV.UseVisualStyleBackColor = true;
            // 
            // txt_AddressGV
            // 
            txt_AddressGV.Location = new Point(9, 329);
            txt_AddressGV.Name = "txt_AddressGV";
            txt_AddressGV.Size = new Size(125, 27);
            txt_AddressGV.TabIndex = 11;
            // 
            // txt_MailGV
            // 
            txt_MailGV.Location = new Point(171, 88);
            txt_MailGV.Name = "txt_MailGV";
            txt_MailGV.Size = new Size(87, 27);
            txt_MailGV.TabIndex = 10;
            // 
            // txt_PhoneGV
            // 
            txt_PhoneGV.Location = new Point(44, 88);
            txt_PhoneGV.Name = "txt_PhoneGV";
            txt_PhoneGV.Size = new Size(67, 27);
            txt_PhoneGV.TabIndex = 9;
            // 
            // txt_NameGV
            // 
            txt_NameGV.Location = new Point(121, 46);
            txt_NameGV.Name = "txt_NameGV";
            txt_NameGV.Size = new Size(125, 27);
            txt_NameGV.TabIndex = 8;
            // 
            // txt_IDGV
            // 
            txt_IDGV.Location = new Point(9, 46);
            txt_IDGV.Name = "txt_IDGV";
            txt_IDGV.Size = new Size(80, 27);
            txt_IDGV.TabIndex = 7;
            // 
            // lb_AddressGV
            // 
            lb_AddressGV.AutoSize = true;
            lb_AddressGV.Location = new Point(16, 306);
            lb_AddressGV.Name = "lb_AddressGV";
            lb_AddressGV.Size = new Size(55, 20);
            lb_AddressGV.TabIndex = 6;
            lb_AddressGV.Text = "Địa chỉ";
            // 
            // lb_BornGV
            // 
            lb_BornGV.AutoSize = true;
            lb_BornGV.Location = new Point(0, 257);
            lb_BornGV.Name = "lb_BornGV";
            lb_BornGV.Size = new Size(74, 20);
            lb_BornGV.TabIndex = 5;
            lb_BornGV.Text = "Ngày sinh";
            // 
            // lb_genderGV
            // 
            lb_genderGV.AutoSize = true;
            lb_genderGV.Location = new Point(9, 218);
            lb_genderGV.Name = "lb_genderGV";
            lb_genderGV.Size = new Size(65, 20);
            lb_genderGV.TabIndex = 4;
            lb_genderGV.Text = "Giới tính";
            // 
            // lb_EmailGV
            // 
            lb_EmailGV.AutoSize = true;
            lb_EmailGV.Location = new Point(121, 76);
            lb_EmailGV.Name = "lb_EmailGV";
            lb_EmailGV.Size = new Size(46, 20);
            lb_EmailGV.TabIndex = 3;
            lb_EmailGV.Text = "Email";
            // 
            // lb_PhoneGV
            // 
            lb_PhoneGV.AutoSize = true;
            lb_PhoneGV.Location = new Point(6, 76);
            lb_PhoneGV.Name = "lb_PhoneGV";
            lb_PhoneGV.Size = new Size(36, 20);
            lb_PhoneGV.TabIndex = 2;
            lb_PhoneGV.Text = "SĐT";
            // 
            // lb_NameGV
            // 
            lb_NameGV.AutoSize = true;
            lb_NameGV.Location = new Point(142, 23);
            lb_NameGV.Name = "lb_NameGV";
            lb_NameGV.Size = new Size(75, 20);
            lb_NameGV.TabIndex = 1;
            lb_NameGV.Text = "Họ và Tên";
            // 
            // lb_IDGV
            // 
            lb_IDGV.AutoSize = true;
            lb_IDGV.Location = new Point(8, 23);
            lb_IDGV.Name = "lb_IDGV";
            lb_IDGV.Size = new Size(103, 20);
            lb_IDGV.TabIndex = 0;
            lb_IDGV.Text = "Mã giảng viên";
            // 
            // dgv_danhSach
            // 
            dgv_danhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhSach.Location = new Point(269, 82);
            dgv_danhSach.Name = "dgv_danhSach";
            dgv_danhSach.RowHeadersWidth = 51;
            dgv_danhSach.RowTemplate.Height = 29;
            dgv_danhSach.Size = new Size(535, 367);
            dgv_danhSach.TabIndex = 5;
            dgv_danhSach.CellContentClick += dgv_danhSach_CellContentClick;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(432, 26);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 5;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // QLGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_danhSach);
            Controls.Add(grb_InfoGV);
            Controls.Add(grbMenuGV);
            Controls.Add(grbImageGV);
            Name = "QLGV";
            Text = "QLGV";
            Load += QLGV_Load;
            grbMenuGV.ResumeLayout(false);
            grb_InfoGV.ResumeLayout(false);
            grb_InfoGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhSach).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbImageGV;
        private GroupBox grbMenuGV;
        private Button btn_SaveGV;
        private Button btn_DeleteGV;
        private Button btn_UpdateGV;
        private Button btn_addGV;
        private GroupBox grb_InfoGV;
        private DateTimePicker dtpBornGV;
        private RadioButton rdbFemaleGV;
        private RadioButton rdbMaleGV;
        private TextBox txt_AddressGV;
        private TextBox txt_MailGV;
        private TextBox txt_PhoneGV;
        private TextBox txt_NameGV;
        private TextBox txt_IDGV;
        private Label lb_AddressGV;
        private Label lb_BornGV;
        private Label lb_genderGV;
        private Label lb_EmailGV;
        private Label lb_PhoneGV;
        private Label lb_NameGV;
        private Label lb_IDGV;
        private DataGridView dgv_danhSach;
        private TextBox txt_password;
        private Label lb_Pass;
        private Label lb_UserName;
        private TextBox txt_UserName;
        private Button btn_Exit;
    }
}