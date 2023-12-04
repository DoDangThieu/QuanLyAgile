using QuanLyAgile;
using QuanLyAgile.Models;
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
       
        quanlydiemContext qld = new quanlydiemContext();
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

            string username = txtusername.Text;
            string password = txtpassword.Text;
            var cbUserName = (from cb in qld.Canbos
                              where cb.Tendn.ToUpper() == username.ToLower()
                              select new
                              {
                                  cb.Tendn,
                                  cb.Matkhau
                              }).FirstOrDefault();
            var gvUserName = (from gv in qld.Giaoviens
                              where gv.Tennd.ToUpper() == username.ToLower()
                              select new
                              {
                                  gv.Tennd,
                                  gv.Matkhau
                              }).FirstOrDefault();
            var svUserName = (from sv in qld.Sinhviens
                              where sv.Tennd.ToUpper() == username.ToLower()
                              select new
                              {
                                  sv.Tennd,
                                  sv.Matkhau
                              }).FirstOrDefault();
            if (cbUserName != null && password.ToUpper() == cbUserName.Matkhau.ToUpper())
            {
                bool isCanBoLoginSuccessful = true;
                MessageBox.Show("Đăng nhập thành công!");
                accountType = "canbo";
                if (isCanBoLoginSuccessful)
                {
                    TrangChu TC = new TrangChu(accountType);
                    TC.Show();
                }
            }
            else if (gvUserName != null && password.ToUpper() == gvUserName.Matkhau.ToUpper())
            {
                bool isGiaoVienLoginSuccessful = true;
                accountType = "giaovien";
                MessageBox.Show("Đăng nhập thành công!");
                if (isGiaoVienLoginSuccessful)
                {
                    TrangChu TC = new TrangChu(accountType);
                    TC.Show();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, false);
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