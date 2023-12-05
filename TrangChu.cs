using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAgile
{
    public partial class TrangChu : Form
    {
        private string _accountType;

        public TrangChu(string accountType)
        {
            InitializeComponent();
            this._accountType = accountType;
        }

        public void loadform(object Form)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (_accountType.Equals("canbo"))
            {
                btn_StudentMark.Enabled = false;
            }
            else if (_accountType.Equals("giaovien"))
            {
                btn_Lecturer.Enabled = false;
                btn_Student.Enabled = false;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
            loadform(new QLSV());
            //QLSV qLSV = new QLSV();
            //qLSV.Show();
            //this.Close();
        }

        private void btn_Lecturer_Click(object sender, EventArgs e)
        {
            loadform(new QLGV());
            //QLGV qLGV = new QLGV();
            //qLGV.Show();
            //this.Close();
        }

        private void btn_StudentMark_Click(object sender, EventArgs e)
        {
            loadform(new QLDSV());
            //QLDSV qLDSV = new QLDSV();
            //qLDSV.Show();
            //this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
