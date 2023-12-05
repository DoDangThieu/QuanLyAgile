namespace QuanLyAgile
{
    partial class QLSV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbImage = new GroupBox();
            grb_Info = new GroupBox();
            dtpBorn = new DateTimePicker();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            txtAddress = new TextBox();
            txt_Mail = new TextBox();
            txt_Phone = new TextBox();
            txt_Name = new TextBox();
            txt_ID = new TextBox();
            lb_Address = new Label();
            lb_Born = new Label();
            lb_gender = new Label();
            lb_Email = new Label();
            lb_Phone = new Label();
            lb_Name = new Label();
            lb_ID = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grbMenu = new GroupBox();
            btn_Save = new Button();
            btn_Delete = new Button();
            btn_Update = new Button();
            btn_add = new Button();
            dgv_danhSach = new DataGridView();
            grb_List = new GroupBox();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            grbImage.SuspendLayout();
            grb_Info.SuspendLayout();
            grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_danhSach).BeginInit();
            grb_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grbImage
            // 
            grbImage.Controls.Add(button1);
            grbImage.Controls.Add(label1);
            grbImage.Controls.Add(pictureBox1);
            grbImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grbImage.Location = new Point(12, 12);
            grbImage.Name = "grbImage";
            grbImage.Size = new Size(357, 172);
            grbImage.TabIndex = 0;
            grbImage.TabStop = false;
            grbImage.Text = "Ảnh đại diện";
            // 
            // grb_Info
            // 
            grb_Info.Controls.Add(dtpBorn);
            grb_Info.Controls.Add(rdbFemale);
            grb_Info.Controls.Add(rdbMale);
            grb_Info.Controls.Add(txtAddress);
            grb_Info.Controls.Add(txt_Mail);
            grb_Info.Controls.Add(txt_Phone);
            grb_Info.Controls.Add(txt_Name);
            grb_Info.Controls.Add(txt_ID);
            grb_Info.Controls.Add(lb_Address);
            grb_Info.Controls.Add(lb_Born);
            grb_Info.Controls.Add(lb_gender);
            grb_Info.Controls.Add(lb_Email);
            grb_Info.Controls.Add(lb_Phone);
            grb_Info.Controls.Add(lb_Name);
            grb_Info.Controls.Add(lb_ID);
            grb_Info.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grb_Info.Location = new Point(12, 183);
            grb_Info.Name = "grb_Info";
            grb_Info.Size = new Size(363, 574);
            grb_Info.TabIndex = 1;
            grb_Info.TabStop = false;
            grb_Info.Text = "Thông tin sinh viên";
            // 
            // dtpBorn
            // 
            dtpBorn.CustomFormat = "dd-MM-yyyy";
            dtpBorn.Format = DateTimePickerFormat.Custom;
            dtpBorn.Location = new Point(124, 300);
            dtpBorn.Margin = new Padding(3, 2, 3, 2);
            dtpBorn.Name = "dtpBorn";
            dtpBorn.Size = new Size(224, 34);
            dtpBorn.TabIndex = 14;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Location = new Point(249, 256);
            rdbFemale.Margin = new Padding(3, 2, 3, 2);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(60, 32);
            rdbFemale.TabIndex = 13;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Nữ";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(151, 258);
            rdbMale.Margin = new Padding(3, 2, 3, 2);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(75, 32);
            rdbMale.TabIndex = 12;
            rdbMale.TabStop = true;
            rdbMale.Text = "Nam";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(10, 373);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Hà Nội ...";
            txtAddress.Size = new Size(343, 192);
            txtAddress.TabIndex = 10;
            // 
            // txt_Mail
            // 
            txt_Mail.Location = new Point(152, 209);
            txt_Mail.Margin = new Padding(3, 2, 3, 2);
            txt_Mail.Name = "txt_Mail";
            txt_Mail.Size = new Size(196, 34);
            txt_Mail.TabIndex = 10;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(10, 209);
            txt_Phone.Margin = new Padding(3, 2, 3, 2);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(134, 34);
            txt_Phone.TabIndex = 9;
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(10, 127);
            txt_Name.Margin = new Padding(3, 2, 3, 2);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(340, 34);
            txt_Name.TabIndex = 8;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(10, 60);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(340, 34);
            txt_ID.TabIndex = 1;
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Location = new Point(10, 342);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(71, 28);
            lb_Address.TabIndex = 6;
            lb_Address.Text = "Địa chỉ";
            // 
            // lb_Born
            // 
            lb_Born.AutoSize = true;
            lb_Born.Location = new Point(10, 300);
            lb_Born.Name = "lb_Born";
            lb_Born.Size = new Size(99, 28);
            lb_Born.TabIndex = 5;
            lb_Born.Text = "Ngày sinh";
            // 
            // lb_gender
            // 
            lb_gender.AutoSize = true;
            lb_gender.Location = new Point(10, 260);
            lb_gender.Name = "lb_gender";
            lb_gender.Size = new Size(87, 28);
            lb_gender.TabIndex = 4;
            lb_gender.Text = "Giới tính";
            lb_gender.Click += lb_gender_Click;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Location = new Point(152, 179);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(59, 28);
            lb_Email.TabIndex = 3;
            lb_Email.Text = "Email";
            // 
            // lb_Phone
            // 
            lb_Phone.AutoSize = true;
            lb_Phone.Location = new Point(10, 179);
            lb_Phone.Name = "lb_Phone";
            lb_Phone.Size = new Size(47, 28);
            lb_Phone.TabIndex = 2;
            lb_Phone.Text = "SĐT";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Location = new Point(10, 97);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(97, 28);
            lb_Name.TabIndex = 1;
            lb_Name.Text = "Họ và Tên";
            // 
            // lb_ID
            // 
            lb_ID.AutoSize = true;
            lb_ID.Location = new Point(8, 30);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(121, 28);
            lb_ID.TabIndex = 0;
            lb_ID.Text = "Mã sinh viên";
            // 
            // grbMenu
            // 
            grbMenu.Controls.Add(btn_Save);
            grbMenu.Controls.Add(btn_Delete);
            grbMenu.Controls.Add(btn_Update);
            grbMenu.Controls.Add(btn_add);
            grbMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grbMenu.Location = new Point(17, 11);
            grbMenu.Margin = new Padding(3, 2, 3, 2);
            grbMenu.Name = "grbMenu";
            grbMenu.Padding = new Padding(3, 2, 3, 2);
            grbMenu.Size = new Size(728, 74);
            grbMenu.TabIndex = 2;
            grbMenu.TabStop = false;
            grbMenu.Text = "Chức năng";
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(0, 151, 178);
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Save.ForeColor = Color.White;
            btn_Save.Image = Properties.Resources.icons8_save_30;
            btn_Save.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Save.Location = new Point(571, 25);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(151, 41);
            btn_Save.TabIndex = 15;
            btn_Save.Text = "SHOW";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(255, 87, 87);
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Image = Properties.Resources.icons8_trash_30;
            btn_Delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Delete.Location = new Point(383, 25);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(154, 41);
            btn_Delete.TabIndex = 13;
            btn_Delete.Text = "Xóa SV";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(255, 222, 89);
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Image = Properties.Resources.icons8_pencil_30;
            btn_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Update.Location = new Point(190, 25);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(151, 41);
            btn_Update.TabIndex = 14;
            btn_Update.Text = "     UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            btn_Update.Click += btn_Update_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 191, 99);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Image = Properties.Resources.icons8_add_male_user_30;
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(6, 25);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(151, 41);
            btn_add.TabIndex = 12;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dgv_danhSach
            // 
            dgv_danhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_danhSach.Location = new Point(6, 20);
            dgv_danhSach.Margin = new Padding(3, 2, 3, 2);
            dgv_danhSach.Name = "dgv_danhSach";
            dgv_danhSach.RowHeadersWidth = 51;
            dgv_danhSach.RowTemplate.Height = 29;
            dgv_danhSach.Size = new Size(716, 657);
            dgv_danhSach.TabIndex = 3;
            dgv_danhSach.CellContentClick += dgv_danhSach_CellContentClick;
            // 
            // grb_List
            // 
            grb_List.Controls.Add(dgv_danhSach);
            grb_List.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            grb_List.Location = new Point(17, 89);
            grb_List.Margin = new Padding(3, 2, 3, 2);
            grb_List.Name = "grb_List";
            grb_List.Padding = new Padding(3, 2, 3, 2);
            grb_List.Size = new Size(728, 668);
            grb_List.TabIndex = 4;
            grb_List.TabStop = false;
            grb_List.Text = "Danh sách sinh viên";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grb_Info);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grbMenu);
            splitContainer1.Panel2.Controls.Add(grb_List);
            splitContainer1.Size = new Size(1141, 760);
            splitContainer1.SplitterDistance = 380;
            splitContainer1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.avatar_icon;
            pictureBox1.Location = new Point(8, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(136, 56);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 11;
            label1.Text = "Ảnh Đại Diện SV";
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.icons8_picture_30;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(136, 91);
            button1.Name = "button1";
            button1.Size = new Size(212, 49);
            button1.TabIndex = 1;
            button1.Text = "Chọn Ảnh";
            button1.UseVisualStyleBackColor = false;
            // 
            // QLSV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1141, 760);
            Controls.Add(grbImage);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "QLSV";
            Text = "Quản lý sinh viên";
            Load += Form1_Load;
            grbImage.ResumeLayout(false);
            grbImage.PerformLayout();
            grb_Info.ResumeLayout(false);
            grb_Info.PerformLayout();
            grbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_danhSach).EndInit();
            grb_List.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbImage;
        private GroupBox grb_Info;
        private Label lb_Address;
        private Label lb_Born;
        private Label lb_gender;
        private Label lb_Email;
        private Label lb_Phone;
        private Label lb_Name;
        private Label lb_ID;
        private TextBox txt_ID;
        private TextBox txt_Mail;
        private TextBox txt_Phone;
        private TextBox txt_Name;
        private DateTimePicker dtpBorn;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private TextBox txtAddress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbMenu;
        private Button btn_Save;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_add;
        private DataGridView dgv_danhSach;
        private GroupBox grb_List;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer1;
    }
}