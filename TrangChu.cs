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
            QLSV qLSV = new QLSV();
            qLSV.Show();
        }

        private void btn_Lecturer_Click(object sender, EventArgs e)
        {

        }

        private void btn_StudentMark_Click(object sender, EventArgs e)
        {

        }
    }
}
