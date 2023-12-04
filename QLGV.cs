using Login;
using QuanLyAgile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyAgile
{
    public partial class QLGV : Form
    {
        public QLGV()
        {
            InitializeComponent();
        }
        quanlydiemContext qld = new quanlydiemContext();
        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_danhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_IDGV.Text = dgv_danhSach.Rows[d].Cells[0].Value.ToString();
            txt_NameGV.Text = dgv_danhSach.Rows[d].Cells[1].Value.ToString();
            txt_MailGV.Text = dgv_danhSach.Rows[d].Cells[4].Value.ToString();
            txt_AddressGV.Text = dgv_danhSach.Rows[d].Cells[5].Value.ToString();
            txt_PhoneGV.Text = dgv_danhSach.Rows[d].Cells[6].Value.ToString();
            txt_UserName.Text = dgv_danhSach.Rows[d].Cells[7].Value.ToString();
            txt_password.Text = dgv_danhSach.Rows[d].Cells[8].Value.ToString();
            dtpBornGV.Value = Convert.ToDateTime(dgv_danhSach.Rows[d].Cells[2].Value.ToString());
            if (dgv_danhSach.Rows[d].Cells[3].Value.ToString().Equals("Nam"))
                rdbMaleGV.Checked = true;
            else
                rdbFemaleGV.Checked = true;
        }

        private void btn_addGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_IDGV.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_NameGV.Text))
                {
                    MessageBox.Show("Tên sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_MailGV.Text))
                {
                    MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_AddressGV.Text))
                {
                    MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_PhoneGV.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_UserName.Text))
                {
                    MessageBox.Show("Tài khoàn không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_password.Text))
                {
                    MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Sinhvien sv = qld.Sinhviens.Where(sv => sv.Masv.Equals(txt_IDGV)).SingleOrDefault();
                    //Dl TextBox
                    if (sv != null)
                    {
                        MessageBox.Show("Mã giáo viên đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string gt = "";
                        if (rdbMaleGV.Checked == true)
                        {
                            gt = "Nam";
                        }
                        else
                        {
                            gt = "Nữ";
                        }
                        //Khoi tAO
                        Giaovien giaoVien = new Giaovien()
                        {
                            Magv = txt_IDGV.Text,
                            Hoten = txt_NameGV.Text,
                            Gioitinh = gt,
                            Ngaysinh = DateTime.ParseExact(dtpBornGV.Text.Trim(), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                            Diachi = txt_AddressGV.Text,
                            Sdt = txt_PhoneGV.Text,
                            Email = txt_MailGV.Text,
                            Tennd = txt_UserName.Text,
                            Matkhau = txt_password.Text
                        };
                        qld.Giaoviens.Add(giaoVien);
                        qld.SaveChanges();
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_UpdateGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_IDGV.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_NameGV.Text))
                {
                    MessageBox.Show("Tên sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_MailGV.Text))
                {
                    MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_AddressGV.Text))
                {
                    MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_PhoneGV.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_UserName.Text))
                {
                    MessageBox.Show("Tài khoản không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_password.Text))
                {
                    MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Tim id xem co ton taai hay khong
                    string idnvSua = txt_IDGV.Text;
                    Giaovien nvSua = qld.Giaoviens.Find(idnvSua);
                    Giaovien sv = qld.Giaoviens.Where(sv => sv.Magv.Equals(txt_IDGV)).SingleOrDefault();
                    //Dl TextBox
                    if (sv == null)
                    {
                        MessageBox.Show("Mã giáo viên không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string gt = "";
                        if (rdbMaleGV.Checked == true)
                        {
                            gt = "Nam";
                        }
                        else
                        {
                            gt = "Nữ";
                        }
                        //Khoi tAO
                        Giaovien giaoVien = new Giaovien()
                        {
                            Magv = txt_IDGV.Text,
                            Hoten = txt_NameGV.Text,
                            Gioitinh = gt,
                            Ngaysinh = DateTime.ParseExact(dtpBornGV.Text.Trim(), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                            Diachi = txt_AddressGV.Text,
                            Sdt = txt_PhoneGV.Text,
                            Email = txt_MailGV.Text,
                            Tennd = txt_UserName.Text,
                            Matkhau = txt_password.Text
                        };
                        qld.Giaoviens.Add(giaoVien);
                        qld.SaveChanges();
                    }
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void LoadData()
        {
            //liq dung de lay du lieu cua bang nhan vien
            var result = from nv in qld.Giaoviens
                         select
                         new
                         {
                             ID = nv.Magv,
                             nv.Hoten,
                             nv.Ngaysinh,
                             nv.Gioitinh,
                             nv.Email,
                             nv.Diachi,
                             nv.Sdt,
                             nv.Tennd,
                             nv.Matkhau
                         };
            //sap xep danh nhan vien the ten
            //dgvdanhsach.DataSource = result.OrderBy(x => x.HoTen).ToList();

            dgv_danhSach.Columns[0].HeaderText = "Mã nhân viên";
            dgv_danhSach.Columns[1].HeaderText = "Họ Tên";
            dgv_danhSach.Columns[2].HeaderText = "Ngày sinh";
            dgv_danhSach.Columns[3].HeaderText = "Giới Tính";
            dgv_danhSach.Columns[4].HeaderText = "Email";
            dgv_danhSach.Columns[5].HeaderText = "Địa chỉ";
            dgv_danhSach.Columns[6].HeaderText = "Số điện thoại";
            dgv_danhSach.Columns[7].HeaderText = "Tên tài khoản";
            dgv_danhSach.Columns[7].HeaderText = "Mật khẩu";
            ////chuyển formaat về dạng d/m/y
            dgv_danhSach.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
        private void QLGV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_DeleteGV_Click(object sender, EventArgs e)
        {
            string idNvXoa = txt_IDGV.Text;
            Giaovien nvXoa = qld.Giaoviens.Find(idNvXoa);
            if (nvXoa != null)
            {
                DialogResult re = MessageBox.Show("Ban co chac chan muon xoa", "Canh Bao", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    qld.Giaoviens.Remove(nvXoa);
                    qld.SaveChanges();
                }
            }
            LoadData();
        }

        private void btn_SaveGV_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dangNhap = new DangNhap();
            dangNhap.Show();
        }
    }
}
