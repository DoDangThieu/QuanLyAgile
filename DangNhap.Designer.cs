namespace Login
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            Close = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            TaskBar = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            Login = new Button();
            panel4 = new Panel();
            txtpassword = new TextBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            txtusername = new TextBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TaskBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // Close
            // 
            Close.Cursor = Cursors.Hand;
            Close.FlatAppearance.BorderSize = 0;
            Close.FlatStyle = FlatStyle.Flat;
            Close.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Close.ForeColor = SystemColors.ActiveCaption;
            Close.Location = new Point(868, 0);
            Close.Name = "Close";
            Close.Size = new Size(28, 24);
            Close.TabIndex = 0;
            Close.Text = "X";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(50, 55);
            label1.Name = "label1";
            label1.Size = new Size(263, 37);
            label1.TabIndex = 1;
            label1.Text = "Đăng Nhập Quản Lý";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(895, 556);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // TaskBar
            // 
            TaskBar.BackColor = Color.FromArgb(10, 18, 80);
            TaskBar.Controls.Add(label2);
            TaskBar.Controls.Add(pictureBox2);
            TaskBar.Controls.Add(Close);
            TaskBar.Location = new Point(-2, -1);
            TaskBar.Name = "TaskBar";
            TaskBar.Size = new Size(899, 27);
            TaskBar.TabIndex = 5;
            TaskBar.Paint += TaskBar_Paint;
            TaskBar.MouseDown += TaskBar_MouseDown;
            TaskBar.MouseMove += TaskBar_MouseMove;
            TaskBar.MouseUp += TaskBar_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(35, 5);
            label2.Name = "label2";
            label2.Size = new Size(211, 15);
            label2.TabIndex = 6;
            label2.Text = "Đăng Nhập Quản Lý Dữ Liệu Sinh Viên";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Login);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 346);
            panel1.TabIndex = 6;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(41, 128, 185);
            Login.Cursor = Cursors.Hand;
            Login.FlatAppearance.MouseOverBackColor = Color.FromArgb(128, 255, 128);
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.White;
            Login.Location = new Point(104, 232);
            Login.Name = "Login";
            Login.Size = new Size(166, 42);
            Login.TabIndex = 4;
            Login.Text = "Đăng Nhập";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(txtpassword);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(0, 163);
            panel4.Name = "panel4";
            panel4.Size = new Size(365, 45);
            panel4.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.FromArgb(41, 128, 185);
            txtpassword.Location = new Point(60, 10);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(290, 21);
            txtpassword.TabIndex = 2;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 42);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.MouseDown += pictureBox4_MouseDown;
            pictureBox4.MouseUp += pictureBox4_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txtusername);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(0, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(365, 45);
            panel2.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.BackColor = Color.White;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.ForeColor = Color.FromArgb(41, 128, 185);
            txtusername.Location = new Point(60, 10);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(290, 25);
            txtusername.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(6, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(33, 471);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 6;
            label3.Text = "Nhóm 2 : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(39, 492);
            label4.Name = "label4";
            label4.Size = new Size(180, 15);
            label4.TabIndex = 7;
            label4.Text = "Support : Thịu , Ngọc , Hiền , Hải";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(895, 556);
            ControlBox = false;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(TaskBar);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DangNhap";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TaskBar.ResumeLayout(false);
            TaskBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Close;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel TaskBar;
        private Label label2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Button Login;
        private Panel panel4;
        private PictureBox pictureBox4;
        private TextBox txtusername;
        private PictureBox pictureBox3;
        private TextBox txtpassword;
        private Label label3;
        private Label label4;
    }
}