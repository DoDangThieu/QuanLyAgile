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
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
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
            splitContainer1 = new SplitContainer();
            grbImageGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbMenuGV.SuspendLayout();
            grb_InfoGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhSach).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // grbImageGV
            // 
            grbImageGV.Controls.Add(button1);
            grbImageGV.Controls.Add(label1);
            grbImageGV.Controls.Add(pictureBox1);
            grbImageGV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grbImageGV.Location = new Point(12, 12);
            grbImageGV.Name = "grbImageGV";
            grbImageGV.Size = new Size(357, 172);
            grbImageGV.TabIndex = 2;
            grbImageGV.TabStop = false;
            grbImageGV.Text = "Ảnh đại diện";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.icons8_picture_301;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(134, 87);
            button1.Name = "button1";
            button1.Size = new Size(212, 49);
            button1.TabIndex = 1;
            button1.Text = "Chọn Ảnh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(131, 56);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 11;
            label1.Text = "Ảnh Đại Diện GV";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar_icon1;
            pictureBox1.Location = new Point(6, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // grbMenuGV
            // 
            grbMenuGV.Controls.Add(btn_SaveGV);
            grbMenuGV.Controls.Add(btn_DeleteGV);
            grbMenuGV.Controls.Add(btn_UpdateGV);
            grbMenuGV.Controls.Add(btn_addGV);
            grbMenuGV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbMenuGV.Location = new Point(16, 11);
            grbMenuGV.Margin = new Padding(3, 2, 3, 2);
            grbMenuGV.Name = "grbMenuGV";
            grbMenuGV.Padding = new Padding(3, 2, 3, 2);
            grbMenuGV.Size = new Size(729, 71);
            grbMenuGV.TabIndex = 3;
            grbMenuGV.TabStop = false;
            grbMenuGV.Text = "Chức năng";
            // 
            // btn_SaveGV
            // 
            btn_SaveGV.BackColor = Color.FromArgb(0, 151, 178);
            btn_SaveGV.FlatStyle = FlatStyle.Flat;
            btn_SaveGV.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SaveGV.ForeColor = Color.White;
            btn_SaveGV.Image = Properties.Resources.icons8_save_30;
            btn_SaveGV.ImageAlign = ContentAlignment.MiddleLeft;
            btn_SaveGV.Location = new Point(572, 20);
            btn_SaveGV.Name = "btn_SaveGV";
            btn_SaveGV.Size = new Size(151, 41);
            btn_SaveGV.TabIndex = 15;
            btn_SaveGV.Text = "SHOW";
            btn_SaveGV.UseVisualStyleBackColor = false;
            btn_SaveGV.Click += btn_SaveGV_Click;
            // 
            // btn_DeleteGV
            // 
            btn_DeleteGV.BackColor = Color.FromArgb(255, 87, 87);
            btn_DeleteGV.FlatStyle = FlatStyle.Flat;
            btn_DeleteGV.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DeleteGV.ForeColor = Color.White;
            btn_DeleteGV.Image = Properties.Resources.icons8_trash_30;
            btn_DeleteGV.ImageAlign = ContentAlignment.MiddleLeft;
            btn_DeleteGV.Location = new Point(383, 20);
            btn_DeleteGV.Name = "btn_DeleteGV";
            btn_DeleteGV.Size = new Size(151, 41);
            btn_DeleteGV.TabIndex = 2;
            btn_DeleteGV.Text = "Xóa";
            btn_DeleteGV.UseVisualStyleBackColor = false;
            btn_DeleteGV.Click += btn_DeleteGV_Click;
            // 
            // btn_UpdateGV
            // 
            btn_UpdateGV.BackColor = Color.FromArgb(255, 222, 89);
            btn_UpdateGV.FlatStyle = FlatStyle.Flat;
            btn_UpdateGV.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateGV.ForeColor = Color.White;
            btn_UpdateGV.Image = Properties.Resources.icons8_pencil_30;
            btn_UpdateGV.ImageAlign = ContentAlignment.MiddleLeft;
            btn_UpdateGV.Location = new Point(192, 20);
            btn_UpdateGV.Name = "btn_UpdateGV";
            btn_UpdateGV.Size = new Size(151, 41);
            btn_UpdateGV.TabIndex = 14;
            btn_UpdateGV.Text = "    UPDATE";
            btn_UpdateGV.UseVisualStyleBackColor = false;
            btn_UpdateGV.Click += btn_UpdateGV_Click;
            // 
            // btn_addGV
            // 
            btn_addGV.BackColor = Color.FromArgb(0, 191, 99);
            btn_addGV.FlatStyle = FlatStyle.Flat;
            btn_addGV.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addGV.ForeColor = Color.White;
            btn_addGV.Image = Properties.Resources.icons8_add_male_user_30;
            btn_addGV.ImageAlign = ContentAlignment.MiddleLeft;
            btn_addGV.Location = new Point(6, 20);
            btn_addGV.Name = "btn_addGV";
            btn_addGV.Size = new Size(151, 41);
            btn_addGV.TabIndex = 12;
            btn_addGV.Text = "Thêm";
            btn_addGV.UseVisualStyleBackColor = false;
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
            grb_InfoGV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grb_InfoGV.Location = new Point(18, 192);
            grb_InfoGV.Name = "grb_InfoGV";
            grb_InfoGV.Size = new Size(351, 565);
            grb_InfoGV.TabIndex = 3;
            grb_InfoGV.TabStop = false;
            grb_InfoGV.Text = "Thông tin giảng viên";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(15, 282);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(330, 34);
            txt_password.TabIndex = 18;
            // 
            // lb_Pass
            // 
            lb_Pass.AutoSize = true;
            lb_Pass.Location = new Point(15, 252);
            lb_Pass.Name = "lb_Pass";
            lb_Pass.Size = new Size(94, 28);
            lb_Pass.TabIndex = 17;
            lb_Pass.Text = "Mật khẩu";
            // 
            // lb_UserName
            // 
            lb_UserName.AutoSize = true;
            lb_UserName.Location = new Point(15, 186);
            lb_UserName.Name = "lb_UserName";
            lb_UserName.Size = new Size(94, 28);
            lb_UserName.TabIndex = 16;
            lb_UserName.Text = "Tài khoản";
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(15, 216);
            txt_UserName.Margin = new Padding(3, 2, 3, 2);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(330, 34);
            txt_UserName.TabIndex = 15;
            txt_UserName.TextChanged += txt_UserName_TextChanged;
            // 
            // dtpBornGV
            // 
            dtpBornGV.CustomFormat = "dd-MM-yyyy";
            dtpBornGV.Format = DateTimePickerFormat.Custom;
            dtpBornGV.Location = new Point(120, 367);
            dtpBornGV.Margin = new Padding(3, 2, 3, 2);
            dtpBornGV.Name = "dtpBornGV";
            dtpBornGV.Size = new Size(225, 34);
            dtpBornGV.TabIndex = 14;
            // 
            // rdbFemaleGV
            // 
            rdbFemaleGV.AutoSize = true;
            rdbFemaleGV.Location = new Point(235, 327);
            rdbFemaleGV.Margin = new Padding(3, 2, 3, 2);
            rdbFemaleGV.Name = "rdbFemaleGV";
            rdbFemaleGV.Size = new Size(60, 32);
            rdbFemaleGV.TabIndex = 13;
            rdbFemaleGV.TabStop = true;
            rdbFemaleGV.Text = "Nữ";
            rdbFemaleGV.UseVisualStyleBackColor = true;
            // 
            // rdbMaleGV
            // 
            rdbMaleGV.AutoSize = true;
            rdbMaleGV.Location = new Point(125, 327);
            rdbMaleGV.Margin = new Padding(3, 2, 3, 2);
            rdbMaleGV.Name = "rdbMaleGV";
            rdbMaleGV.Size = new Size(75, 32);
            rdbMaleGV.TabIndex = 12;
            rdbMaleGV.TabStop = true;
            rdbMaleGV.Text = "Nam";
            rdbMaleGV.UseVisualStyleBackColor = true;
            // 
            // txt_AddressGV
            // 
            txt_AddressGV.Location = new Point(15, 436);
            txt_AddressGV.Multiline = true;
            txt_AddressGV.Name = "txt_AddressGV";
            txt_AddressGV.PlaceholderText = "Hà Nội ...";
            txt_AddressGV.Size = new Size(333, 119);
            txt_AddressGV.TabIndex = 10;
            // 
            // txt_MailGV
            // 
            txt_MailGV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MailGV.Location = new Point(152, 136);
            txt_MailGV.Margin = new Padding(3, 2, 3, 2);
            txt_MailGV.Name = "txt_MailGV";
            txt_MailGV.Size = new Size(193, 34);
            txt_MailGV.TabIndex = 10;
            // 
            // txt_PhoneGV
            // 
            txt_PhoneGV.Location = new Point(15, 136);
            txt_PhoneGV.Margin = new Padding(3, 2, 3, 2);
            txt_PhoneGV.Name = "txt_PhoneGV";
            txt_PhoneGV.Size = new Size(131, 34);
            txt_PhoneGV.TabIndex = 9;
            // 
            // txt_NameGV
            // 
            txt_NameGV.Location = new Point(150, 60);
            txt_NameGV.Margin = new Padding(3, 2, 3, 2);
            txt_NameGV.Name = "txt_NameGV";
            txt_NameGV.Size = new Size(195, 34);
            txt_NameGV.TabIndex = 8;
            // 
            // txt_IDGV
            // 
            txt_IDGV.Location = new Point(15, 60);
            txt_IDGV.Margin = new Padding(3, 2, 3, 2);
            txt_IDGV.Name = "txt_IDGV";
            txt_IDGV.Size = new Size(131, 34);
            txt_IDGV.TabIndex = 7;
            // 
            // lb_AddressGV
            // 
            lb_AddressGV.AutoSize = true;
            lb_AddressGV.Location = new Point(15, 405);
            lb_AddressGV.Name = "lb_AddressGV";
            lb_AddressGV.Size = new Size(71, 28);
            lb_AddressGV.TabIndex = 6;
            lb_AddressGV.Text = "Địa chỉ";
            // 
            // lb_BornGV
            // 
            lb_BornGV.AutoSize = true;
            lb_BornGV.Location = new Point(15, 367);
            lb_BornGV.Name = "lb_BornGV";
            lb_BornGV.Size = new Size(99, 28);
            lb_BornGV.TabIndex = 5;
            lb_BornGV.Text = "Ngày sinh";
            // 
            // lb_genderGV
            // 
            lb_genderGV.AutoSize = true;
            lb_genderGV.Location = new Point(15, 327);
            lb_genderGV.Name = "lb_genderGV";
            lb_genderGV.Size = new Size(87, 28);
            lb_genderGV.TabIndex = 4;
            lb_genderGV.Text = "Giới tính";
            // 
            // lb_EmailGV
            // 
            lb_EmailGV.AutoSize = true;
            lb_EmailGV.Location = new Point(152, 106);
            lb_EmailGV.Name = "lb_EmailGV";
            lb_EmailGV.Size = new Size(59, 28);
            lb_EmailGV.TabIndex = 3;
            lb_EmailGV.Text = "Email";
            // 
            // lb_PhoneGV
            // 
            lb_PhoneGV.AutoSize = true;
            lb_PhoneGV.Location = new Point(10, 106);
            lb_PhoneGV.Name = "lb_PhoneGV";
            lb_PhoneGV.Size = new Size(47, 28);
            lb_PhoneGV.TabIndex = 2;
            lb_PhoneGV.Text = "SĐT";
            // 
            // lb_NameGV
            // 
            lb_NameGV.AutoSize = true;
            lb_NameGV.Location = new Point(152, 30);
            lb_NameGV.Name = "lb_NameGV";
            lb_NameGV.Size = new Size(97, 28);
            lb_NameGV.TabIndex = 1;
            lb_NameGV.Text = "Họ và Tên";
            // 
            // lb_IDGV
            // 
            lb_IDGV.AutoSize = true;
            lb_IDGV.Location = new Point(10, 30);
            lb_IDGV.Name = "lb_IDGV";
            lb_IDGV.Size = new Size(136, 28);
            lb_IDGV.TabIndex = 0;
            lb_IDGV.Text = "Mã giảng viên";
            // 
            // dgv_danhSach
            // 
            dgv_danhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhSach.Location = new Point(16, 87);
            dgv_danhSach.Margin = new Padding(3, 2, 3, 2);
            dgv_danhSach.Name = "dgv_danhSach";
            dgv_danhSach.RowHeadersWidth = 51;
            dgv_danhSach.RowTemplate.Height = 29;
            dgv_danhSach.Size = new Size(729, 660);
            dgv_danhSach.TabIndex = 5;
            dgv_danhSach.CellContentClick += dgv_danhSach_CellContentClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grb_InfoGV);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgv_danhSach);
            splitContainer1.Panel2.Controls.Add(grbMenuGV);
            splitContainer1.Size = new Size(1141, 760);
            splitContainer1.SplitterDistance = 380;
            splitContainer1.TabIndex = 6;
            // 
            // QLGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1141, 760);
            Controls.Add(grbImageGV);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "QLGV";
            Text = "QLGV";
            Load += QLGV_Load;
            grbImageGV.ResumeLayout(false);
            grbImageGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbMenuGV.ResumeLayout(false);
            grb_InfoGV.ResumeLayout(false);
            grb_InfoGV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhSach).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer1;
    }
}