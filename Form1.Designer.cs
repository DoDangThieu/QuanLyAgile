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
            btn_add = new Button();
            btn_Update = new Button();
            btn_Delete = new Button();
            btn_Save = new Button();
            dataGridView1 = new DataGridView();
            grb_Info.SuspendLayout();
            grbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grbImage
            // 
            grbImage.Location = new Point(3, 12);
            grbImage.Name = "grbImage";
            grbImage.Size = new Size(217, 84);
            grbImage.TabIndex = 0;
            grbImage.TabStop = false;
            grbImage.Text = "Ảnh đại diện";
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
            grb_Info.Location = new Point(3, 102);
            grb_Info.Name = "grb_Info";
            grb_Info.Size = new Size(264, 336);
            grb_Info.TabIndex = 1;
            grb_Info.TabStop = false;
            grb_Info.Text = "Thông tin sinh viên";
            // 
            // dtpBorn
            // 
            dtpBorn.CustomFormat = "dd-MM-yyyy";
            dtpBorn.Format = DateTimePickerFormat.Custom;
            dtpBorn.Location = new Point(105, 212);
            dtpBorn.Name = "dtpBorn";
            dtpBorn.Size = new Size(99, 27);
            dtpBorn.TabIndex = 14;
            // 
            // rbnFemale
            // 
            rbnFemale.AutoSize = true;
            rbnFemale.Location = new Point(181, 180);
            rbnFemale.Name = "rbnFemale";
            rbnFemale.Size = new Size(50, 24);
            rbnFemale.TabIndex = 13;
            rbnFemale.TabStop = true;
            rbnFemale.Text = "Nữ";
            rbnFemale.UseVisualStyleBackColor = true;
            // 
            // rbnMale
            // 
            rbnMale.AutoSize = true;
            rbnMale.Location = new Point(105, 180);
            rbnMale.Name = "rbnMale";
            rbnMale.Size = new Size(62, 24);
            rbnMale.TabIndex = 12;
            rbnMale.TabStop = true;
            rbnMale.Text = "Nam";
            rbnMale.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(24, 293);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(173, 135);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(87, 27);
            textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(48, 132);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(67, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // lb_Address
            // 
            lb_Address.AutoSize = true;
            lb_Address.Location = new Point(24, 259);
            lb_Address.Name = "lb_Address";
            lb_Address.Size = new Size(55, 20);
            lb_Address.TabIndex = 6;
            lb_Address.Text = "Địa chỉ";
            // 
            // lb_Born
            // 
            lb_Born.AutoSize = true;
            lb_Born.Location = new Point(24, 212);
            lb_Born.Name = "lb_Born";
            lb_Born.Size = new Size(74, 20);
            lb_Born.TabIndex = 5;
            lb_Born.Text = "Ngày sinh";
            // 
            // lb_gender
            // 
            lb_gender.AutoSize = true;
            lb_gender.Location = new Point(24, 177);
            lb_gender.Name = "lb_gender";
            lb_gender.Size = new Size(65, 20);
            lb_gender.TabIndex = 4;
            lb_gender.Text = "Giới tính";
            lb_gender.Click += lb_gender_Click;
            // 
            // lb_Email
            // 
            lb_Email.AutoSize = true;
            lb_Email.Location = new Point(121, 135);
            lb_Email.Name = "lb_Email";
            lb_Email.Size = new Size(46, 20);
            lb_Email.TabIndex = 3;
            lb_Email.Text = "Email";
            // 
            // lb_Phone
            // 
            lb_Phone.AutoSize = true;
            lb_Phone.Location = new Point(6, 135);
            lb_Phone.Name = "lb_Phone";
            lb_Phone.Size = new Size(36, 20);
            lb_Phone.TabIndex = 2;
            lb_Phone.Text = "SĐT";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Location = new Point(24, 93);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(75, 20);
            lb_Name.TabIndex = 1;
            lb_Name.Text = "Họ và Tên";
            // 
            // lb_ID
            // 
            lb_ID.AutoSize = true;
            lb_ID.Location = new Point(8, 23);
            lb_ID.Name = "lb_ID";
            lb_ID.Size = new Size(91, 20);
            lb_ID.TabIndex = 0;
            lb_ID.Text = "Mã sinh viên";
            // 
            // grbMenu
            // 
            grbMenu.Controls.Add(btn_Save);
            grbMenu.Controls.Add(btn_Delete);
            grbMenu.Controls.Add(btn_Update);
            grbMenu.Controls.Add(btn_add);
            grbMenu.Location = new Point(226, 5);
            grbMenu.Name = "grbMenu";
            grbMenu.Size = new Size(562, 74);
            grbMenu.TabIndex = 2;
            grbMenu.TabStop = false;
            grbMenu.Text = "Chức năng";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(48, 26);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(94, 29);
            btn_add.TabIndex = 0;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            btn_Update.Location = new Point(174, 26);
            btn_Update.Name = "btn_Update";
            btn_Update.Size = new Size(94, 29);
            btn_Update.TabIndex = 1;
            btn_Update.Text = "Sửa";
            btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(312, 26);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(94, 29);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(453, 26);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(94, 29);
            btn_Save.TabIndex = 3;
            btn_Save.Text = "Hiển thị";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(269, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(535, 367);
            dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(grbMenu);
            Controls.Add(grb_Info);
            Controls.Add(grbImage);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            grb_Info.ResumeLayout(false);
            grb_Info.PerformLayout();
            grbMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}