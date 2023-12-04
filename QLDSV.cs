using Login;
using QuanLyAgile.ManModels;
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
    public partial class QLDSV : Form
    {
        public QLDSV()
        {
            InitializeComponent();
        }
        quanlydiemContext qld = new quanlydiemContext();
        public void LoadData()
        {
            //liq dung de lay du lieu cua bang nhan vien
            var result = from sv in qld.Sinhviens
                         join diem in qld.Diems on sv.Masv equals diem.Masv
                         join mon in qld.Monhocs on diem.Mamon equals mon.Mamon
                         join lop in qld.Lops on sv.Malop equals lop.Malop
                         select
                         new
                         {
                             sv.Masv,
                             sv.Tensv,
                             diem.Diem1,
                             mon.Mamon,
                             mon.Tenmon,
                             lop.Malop,
                             lop.Tenlop
                         };
            //sap xep danh nhan vien the ten
            //dgvdanhsach.DataSource = result.OrderBy(x => x.HoTen).ToList();

            dgv_ListMark.Columns[0].HeaderText = "Mã sinh viên";
            dgv_ListMark.Columns[1].HeaderText = "Họ Tên";
            dgv_ListMark.Columns[2].HeaderText = "Điểm";
            dgv_ListMark.Columns[3].HeaderText = "Mã môn";
            dgv_ListMark.Columns[4].HeaderText = "Tên môn";
            dgv_ListMark.Columns[5].HeaderText = "Mã lớp";
            dgv_ListMark.Columns[6].HeaderText = "Tên lớp";
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string find = txt_StudentID.Text;
            Sinhvien sinhvien = qld.Sinhviens.Find(find);
            if (find != null)
            {
                dgv_ListMark.Rows.Clear();

                // Lấy thông tin sinh viên
                string studentID = sinhvien.Masv;
                string studentName = sinhvien.Tensv;

                // Lấy điểm của sinh viên
                List<Diem> diems = qld.Diems.Where(d => d.Masv == studentID).ToList();

                foreach (Diem diem in diems)
                {
                    // Lấy thông tin môn học từ lớp Môn học
                    Monhoc monhoc = qld.Monhocs.Find(diem.Mamon);
                    string subjectName = monhoc != null ? monhoc.Tenmon : "Unknown";

                    // Thêm dòng vào GridView
                    dgv_ListMark.Rows.Add(studentID, studentName, diems, subjectName);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã " + find);
            }

        }

        private void dgv_ListMark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_IDStudent.Text = dgv_ListMark.Rows[d].Cells[0].Value.ToString();
            txt_NameStudent.Text = dgv_ListMark.Rows[d].Cells[1].Value.ToString();
            txt_SubjectID.Text = dgv_ListMark.Rows[d].Cells[3].Value.ToString();
            txt_SubjectName.Text = dgv_ListMark.Rows[d].Cells[4].Value.ToString();
            lb_NameClass.Text = dgv_ListMark.Rows[d].Cells[6].Value.ToString();
        }

        private void grb_InfoSV_Enter(object sender, EventArgs e)
        {

        }

        private void btn_SaveMark_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_addMark_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_StudentID.Text))
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_SubjectID.Text))
                {
                    MessageBox.Show("Mã môn học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                 if (string.IsNullOrWhiteSpace(txt_SubjectName.Text))
                {
                    MessageBox.Show("Tên môn học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                 if (string.IsNullOrWhiteSpace(txt_SubjectMark.Text))
                {
                    MessageBox.Show("Điểm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string studentID = txt_StudentID.Text;
                    string subjectID = txt_SubjectID.Text;
                    string subjectName = txt_SubjectName.Text;
                    float subjectMark = float.Parse(txt_SubjectMark.Text);

                    // Kiểm tra xem sinh viên có tồn tại hay không
                    Sinhvien sinhvien = qld.Sinhviens.Find(studentID);
                    try
                    {
                        if (sinhvien == null)
                        {
                            MessageBox.Show("Sinh viên không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Kiểm tra xem môn học đã tồn tại trong cơ sở dữ liệu hay chưa
                            Monhoc monhoc = qld.Monhocs.Find(subjectID);
                            if (monhoc == null)
                            {
                                MessageBox.Show("Môn học không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                // Thêm điểm cho sinh viên
                                Diem newMark = new Diem()
                                {
                                    Masv = studentID,
                                    Mamon = subjectID,
                                    Diem1 = subjectMark
                                };
                                qld.Diems.Add(newMark);
                                qld.SaveChanges();

                                MessageBox.Show("Thêm điểm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear các ô nhập liệu
                                txt_StudentID.Text = "";
                                txt_SubjectID.Text = "";
                                txt_SubjectName.Text = "";
                                txt_SubjectMark.Text = "";

                                // Refresh GridView nếu cần
                                // dgv_Marks.Refresh();
                            }
                        }
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_UpdateMark_Click(object sender, EventArgs e)
        {
            string ID = txt_StudentID.Text;
            Sinhvien sinhvien = qld.Sinhviens.Find(ID);
            try
            {
                if (sinhvien == null)
                {
                    MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string IdSubject = txt_SubjectID.Text;
                    Monhoc monhoc = qld.Monhocs.Find(IdSubject);
                    if (string.IsNullOrWhiteSpace(IdSubject))
                    {
                        MessageBox.Show("Mã môn học không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        float Mark = float.Parse(txt_SubjectMark.Text);
                        if (Mark == null || Convert.ToString(Mark) == "")
                        {
                            MessageBox.Show("Điểm không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Diem diem1 = new Diem()
                            {

                                Diem1 = Mark,
                            };
                            qld.Diems.Add(diem1);
                            qld.SaveChanges();
                        }

                    }
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi: " + ex.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DeleteMark_Click(object sender, EventArgs e)
        {
            float Mark = float.Parse(txt_SubjectMark.Text);
            Diem sinhvien = qld.Diems.Find(Mark);
            if (Mark == null && Convert.ToString(Mark) == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult re = MessageBox.Show("Ban co chac chan muon xoa", "Canh Bao", MessageBoxButtons.YesNo);
                if (re == DialogResult.Yes)
                {
                    qld.Diems.Remove(sinhvien);
                    qld.SaveChanges();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap dang = new DangNhap();
            dang.Show();
        }
    }
}
