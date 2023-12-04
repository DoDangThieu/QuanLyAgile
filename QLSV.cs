using QuanLyAgile.Models;
using System.Globalization;

namespace QuanLyAgile
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }
        quanlydiemContext qld = new quanlydiemContext();
        private void lb_gender_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            //liq dung de lay du lieu cua bang nhan vien
            var result = from nv in qld.Sinhviens
                         select
                         new
                         {
                             ID = nv.Masv,
                             nv.Tensv,
                             nv.Ngaysinh,
                             nv.Gioitinh,
                             nv.Email,
                             nv.Diachi,
                             nv.Sdt
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
            ////chuyển formaat về dạng d/m/y
            dgv_danhSach.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void dgv_danhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_ID.Text = dgv_danhSach.Rows[d].Cells[0].Value.ToString();
            txt_Name.Text = dgv_danhSach.Rows[d].Cells[1].Value.ToString();
            txt_Mail.Text = dgv_danhSach.Rows[d].Cells[4].Value.ToString();
            txtAddress.Text = dgv_danhSach.Rows[d].Cells[5].Value.ToString();
            txt_Phone.Text = dgv_danhSach.Rows[d].Cells[6].Value.ToString();
            dtpBorn.Value = Convert.ToDateTime(dgv_danhSach.Rows[d].Cells[2].Value.ToString());
            if (dgv_danhSach.Rows[d].Cells[3].Value.ToString().Equals("Nam"))
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ID.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_Name.Text))
                {
                    MessageBox.Show("Tên sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_Mail.Text))
                {
                    MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_Phone.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Sinhvien sv = qld.Sinhviens.Where(sv => sv.Masv.Equals(txt_ID)).SingleOrDefault();
                    //Dl TextBox
                    if (sv != null)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string gt = "";
                        if (rdbMale.Checked == true)
                        {
                            gt = "Nam";
                        }
                        else
                        {
                            gt = "Nữ";
                        }
                        //Khoi tAO
                        Sinhvien SinhVien = new Sinhvien()
                        {
                            Masv = txt_ID.Text,
                            Tensv = txt_Name.Text,
                            Gioitinh = gt,
                            Ngaysinh = DateTime.ParseExact(dtpBorn.Text.Trim(), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                            Diachi = txtAddress.Text,
                            Sdt = txt_Phone.Text,
                            Email = txt_Mail.Text,
                            Tennd = "Anh",
                            Matkhau = "123MNS"
                        };
                        qld.Sinhviens.Add(SinhVien);
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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_ID.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_Name.Text))
                {
                    MessageBox.Show("Tên sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_Mail.Text))
                {
                    MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    MessageBox.Show("Địa chỉ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (string.IsNullOrWhiteSpace(txt_Phone.Text))
                {
                    MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Tim id xem co ton taai hay khong
                    string idnvSua = txt_ID.Text;
                    Sinhvien nvSua = qld.Sinhviens.Find(idnvSua);
                    Sinhvien sv = qld.Sinhviens.Where(sv => sv.Masv.Equals(txt_ID)).SingleOrDefault();
                    //Dl TextBox
                    if (sv == null)
                    {
                        MessageBox.Show("Mã sinh viên không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string gt = "";
                        if (rdbMale.Checked == true)
                        {
                            gt = "Nam";
                        }
                        else
                        {
                            gt = "Nữ";
                        }
                        //Khoi tAO
                        Sinhvien SinhVien = new Sinhvien()
                        {
                            Masv = txt_ID.Text,
                            Tensv = txt_Name.Text,
                            Gioitinh = gt,
                            Ngaysinh = DateTime.ParseExact(dtpBorn.Text.Trim(), "dd-MM-yyyy", CultureInfo.InvariantCulture),
                            Diachi = txtAddress.Text,
                            Sdt = txt_Phone.Text,
                            Email = txt_Mail.Text,
                            Tennd = "Anh",
                            Matkhau = "123MNS"
                        };
                        qld.Sinhviens.Add(SinhVien);
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string idNvXoa = txt_ID.Text;
            Sinhvien nvXoa = qld.Sinhviens.Find(idNvXoa);
            if (nvXoa != null)
            {
                DialogResult re = MessageBox.Show("Ban co chac chan muon xoa", "Canh Bao", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    qld.Sinhviens.Remove(nvXoa);
                    qld.SaveChanges();
                }
            }
            LoadData();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}