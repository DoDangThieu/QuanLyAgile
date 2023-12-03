using QuanLyAgile;
//using QuanLyAgile.Models;
using System.Drawing.Drawing2D;
using System.Text;

namespace Login
{
    public partial class DangNhap : Form
    {
        private string accountType;
        private const int CORNER_RADIUS = 15;
        private bool isDragging = false;
        private int offsetX, offsetY;
       
        public DangNhap()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += DangNhap_Load;
            this.MouseDown += TaskBar_MouseDown;
            this.MouseMove += TaskBar_MouseMove;
            this.MouseUp += TaskBar_MouseUp;

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, CORNER_RADIUS * 2, CORNER_RADIUS * 2), 180, 90);
            path.AddArc(new Rectangle(Width - CORNER_RADIUS * 2, 0, CORNER_RADIUS * 2, CORNER_RADIUS * 2), 270, 90);
            path.AddArc(new Rectangle(Width - CORNER_RADIUS * 2, Height - CORNER_RADIUS * 2, CORNER_RADIUS * 2, CORNER_RADIUS * 2), 0, 90);
            path.AddArc(new Rectangle(0, Height - CORNER_RADIUS * 2, CORNER_RADIUS * 2, CORNER_RADIUS * 2), 90, 90);
            path.CloseFigure();

            Region = new Region(path);
        }

        private void TaskBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                offsetX = e.X;
                offsetY = e.Y;
            }
        }

        private void TaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - offsetX;
                this.Top += e.Y - offsetY;
            }
        }

        private void TaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {

            if (txtusername.Text == "")
            {
                MessageBox.Show("Chua Nhap Tai Khoan !!");
                txtusername.Focus();
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("Chua Nhap Mat Khau !!");
                txtpassword.Focus();
                return;
            }
            else
            {

          
                TrangChu form5 = new TrangChu();
                form5.Show();

            }


        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

       
    }
}