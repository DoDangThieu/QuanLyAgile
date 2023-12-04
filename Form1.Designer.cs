namespace QuanLyAgile
{
    partial class Form1
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
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            grb_Info = new GroupBox();
            dtpBorn = new DateTimePicker();
            rbnFemale = new RadioButton();
            rbnMale = new RadioButton();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            dataGridView1 = new DataGridView();
            splitContainer1 = new SplitContainer();
            grbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grb_Info.SuspendLayout();
            grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // grbImage
            // 
            grbImage.Controls.Add(label1);
            grbImage.Controls.Add(button1);
            grbImage.Controls.Add(pictureBox1);
            grbImage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            grbImage.Location = new Point(12, 12);
            grbImage.Name = "grbImage";
            grbImage.Size = new Size(357, 172);
            grbImage.TabIndex = 0;
            grbImage.TabStop = false;
            grbImage.Text = "Ảnh đại diện";
            // 
            // label1
            // 
            label1.AutoSize = true;
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
            button1.Image = Properties.Resources.icons8_picture_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(136, 91);
            button1.Name = "button1";
            button1.Size = new Size(212, 49);
            button1.TabIndex = 1;
            button1.Text = "Chọn Ảnh";
            button1.UseVisualStyleBackColor = false;
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
            // grb_Info
            // 
            grb_Info.Controls.Add(dtpBorn);
            grb_Info.Controls.Add(rbnFemale);
            grb_Info.Controls.Add(rbnMale);
            grb_Info.Controls.Add(textBox5);
            grb_Info.Controls.Add(textBox4);
            grb_Info.Controls.Add(textBox3);
            grb_Info.Controls.Add(textBox2);
            grb_Info.Controls.Add(textBox1);
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
            grb_Info.Text = "Thông Tin Sinh Viên";
            // 
            // dtpBorn
            // 
            dtpBorn.CustomFormat = "dd-MM-yyyy";
            dtpBorn.Format = DateTimePickerFormat.Custom;
            dtpBorn.Location = new Point(136, 298);
            dtpBorn.Margin = new Padding(3, 2, 3, 2);
            dtpBorn.Name = "dtpBorn";
            dtpBorn.Size = new Size(221, 34);
            dtpBorn.TabIndex = 14;
            // 
            // rbnFemale
            // 
            rbnFemale.AutoSize = true;
            rbnFemale.Location = new Point(248, 254);
            rbnFemale.Margin = new Padding(3, 2, 3, 2);
            rbnFemale.Name = "rbnFemale";
            rbnFemale.Size = new Size(60, 32);
            rbnFemale.TabIndex = 13;
            rbnFemale.TabStop = true;
            rbnFemale.Text = "Nữ";
            rbnFemale.UseVisualStyleBackColor = true;
            // 
            // rbnMale
            // 
            rbnMale.AutoSize = true;
            rbnMale.Location = new Point(148, 254);
            rbnMale.Margin = new Padding(3, 2, 3, 2);
            rbnMale.Name = "rbnMale";
            rbnMale.Size = new Size(75, 32);
            rbnMale.TabIndex = 12;
            rbnMale.TabStop = true;
            rbnMale.Text = "Nam";
            rbnMale.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 372);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Hà Nội ...";
            textBox5.Size = new Size(343, 196);
            textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(164, 201);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 34);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 201);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(144, 34);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 126);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(340, 34);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 60);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 34);
            textBox1.TabIndex = 1;
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Location = new Point(21, 342);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(71, 28);
            lb_Address.TabIndex = 6;
            lb_Address.Text = "Địa chỉ";
            // 
            // lb_Born
            // 
            lb_Born.AutoSize = true;
            lb_Born.Location = new Point(21, 298);
            lb_Born.Name = "lb_Born";
            lb_Born.Size = new Size(99, 28);
            lb_Born.TabIndex = 5;
            lb_Born.Text = "Ngày sinh";
            // 
            // lb_gender
            // 
            lb_gender.AutoSize = true;
            lb_gender.Location = new Point(21, 254);
            lb_gender.Name = "lb_gender";
            lb_gender.Size = new Size(87, 28);
            lb_gender.TabIndex = 4;
            lb_gender.Text = "Giới tính";
            lb_gender.Click += lb_gender_Click;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Location = new Point(164, 171);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(59, 28);
            lb_Email.TabIndex = 3;
            lb_Email.Text = "Email";
            // 
            // lb_Phone
            // 
            lb_Phone.AutoSize = true;
            lb_Phone.Location = new Point(21, 171);
            lb_Phone.Name = "lb_Phone";
            lb_Phone.Size = new Size(47, 28);
            lb_Phone.TabIndex = 2;
            lb_Phone.Text = "SĐT";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Location = new Point(21, 96);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(97, 28);
            lb_Name.TabIndex = 1;
            lb_Name.Text = "Họ và Tên";
            // 
            // lb_ID
            // 
            lb_ID.AutoSize = true;
            lb_ID.Location = new Point(14, 30);
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
            grbMenu.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            grbMenu.Location = new Point(3, 2);
            grbMenu.Margin = new Padding(3, 2, 3, 2);
            grbMenu.Name = "grbMenu";
            grbMenu.Padding = new Padding(3, 2, 3, 2);
            grbMenu.Size = new Size(752, 72);
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
            btn_Save.Location = new Point(592, 20);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(151, 41);
            btn_Save.TabIndex = 15;
            btn_Save.Text = "SHOW";
            btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(255, 87, 87);
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Image = Properties.Resources.icons8_trash_30;
            btn_Delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Delete.Location = new Point(391, 20);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(154, 41);
            btn_Delete.TabIndex = 13;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            btn_Update.BackColor = Color.FromArgb(255, 222, 89);
            btn_Update.FlatStyle = FlatStyle.Flat;
            btn_Update.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Update.ForeColor = Color.White;
            btn_Update.Image = Properties.Resources.icons8_pencil_30;
            btn_Update.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Update.Location = new Point(200, 20);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(151, 41);
            btn_Update.TabIndex = 14;
            btn_Update.Text = "UPDATE";
            btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(0, 191, 99);
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Image = Properties.Resources.icons8_add_male_user_30;
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(6, 20);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(151, 41);
            btn_add.TabIndex = 12;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 78);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(752, 680);
            dataGridView1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grbMenu);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(1141, 760);
            splitContainer1.SplitterDistance = 379;
            splitContainer1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1141, 760);
            Controls.Add(grb_Info);
            Controls.Add(grbImage);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            grbImage.ResumeLayout(false);
            grbImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grb_Info.ResumeLayout(false);
            grb_Info.PerformLayout();
            grbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DateTimePicker dtpBorn;
        private RadioButton rbnFemale;
        private RadioButton rbnMale;
        private TextBox textBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbMenu;
        private Button btn_Save;
        private Button btn_Delete;
        private Button btn_Update;
        private Button btn_add;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}