using app.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            LoadDataList();
            list.CellClick += list_CellClick;
        }
        private void LoadDataList()
        {
            string query = "SELECT NhanVien.ma_nhan_vien AS [Mã Nhân Viên], NhanVien.ten AS [Tên Nhân Viên], NhanVien.ngay_sinh AS [Ngày Sinh], NhanVien.so_dien_thoai AS [Số Điện Thoại], NhanVien.dia_chi AS [Địa Chỉ], TaiKhoan.tai_khoan AS [Tài Khoản], TaiKhoan.email AS [Email] ,TaiKhoan.mat_khau AS [Mật Khẩu]  FROM NhanVien JOIN TaiKhoan ON NhanVien.ma_nhan_vien = TaiKhoan.ma_nhan_vien;\r\n";
            list.DataSource = DataProvider.Instance.ExecuteQuery(query, commandType: CommandType.Text);
            list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            AdjustColumnWidths(list);
        }

        private void AdjustColumnWidths(DataGridView dataGridView)
        {

            if (dataGridView.Columns.Count == 0)
                return;


            int totalWidth = dataGridView.ClientSize.Width;
            int columnWidth = totalWidth / dataGridView.Columns.Count;


            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string adminId = Account.Instance.AdminId;

                string queryNhanVien = "sp_InsertNhanVien";

                SqlParameter[] parametersNhanVien = new SqlParameter[]
                {
                    new SqlParameter("@ma_nhan_vien", SqlDbType.Char, 10) { Value = txtMaNV.Text.Trim() },
                    new SqlParameter("@ma_admin", SqlDbType.Char, 10) { Value =  adminId }, 
                    new SqlParameter("@ten", SqlDbType.NVarChar, 255) { Value = txtTenNV.Text.Trim() },
                    new SqlParameter("@ngay_sinh", SqlDbType.Date) { Value = dtpNgaySinh.Value }, 
                    new SqlParameter("@so_dien_thoai", SqlDbType.VarChar, 20) { Value = txtSDTNV.Text.Trim() },
                    new SqlParameter("@dia_chi", SqlDbType.NVarChar, 255) { Value = txtDiaChi.Text.Trim() }
                };

                int resultNhanVien = DataProvider.Instance.ExecuteNonQuery(queryNhanVien, parametersNhanVien);

                string queryTaiKhoan = "sp_InsertTaiKhoan";

                SqlParameter[] parametersTaiKhoan = new SqlParameter[]
                {
                    new SqlParameter("@ma_nhan_vien", SqlDbType.Char, 10) { Value = txtMaNV.Text.Trim() },
                    new SqlParameter("@tai_khoan", SqlDbType.VarChar, 255) { Value = txtTaiKhoan.Text.Trim() },
                    new SqlParameter("@mat_khau", SqlDbType.VarChar, 255) { Value = txtMatKhau.Text.Trim() },
                    new SqlParameter("@email", SqlDbType.VarChar, 255) { Value = txtEmail.Text.Trim() }
                };

                int resultTaiKhoan = DataProvider.Instance.ExecuteNonQuery(queryTaiKhoan, parametersTaiKhoan);

                if (resultNhanVien > 0 && resultTaiKhoan > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDataList();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy adminId từ tài khoản hiện tại
                string adminId = Account.Instance.AdminId;

                // Cập nhật thông tin nhân viên
                string queryNhanVien = "sp_UpdateNhanVien";
                SqlParameter[] parametersNhanVien = new SqlParameter[]
                {
                    new SqlParameter("@ma_nhan_vien", SqlDbType.Char, 10) { Value = txtMaNV.Text.Trim() },
                    new SqlParameter("@ma_admin", SqlDbType.Char, 10) { Value = adminId },
                    new SqlParameter("@ten", SqlDbType.NVarChar, 255) { Value = txtTenNV.Text.Trim() },
                    new SqlParameter("@ngay_sinh", SqlDbType.Date) { Value = dtpNgaySinh.Value },
                    new SqlParameter("@so_dien_thoai", SqlDbType.VarChar, 20) { Value = txtSDTNV.Text.Trim() },
                    new SqlParameter("@dia_chi", SqlDbType.NVarChar, 255) { Value = txtDiaChi.Text.Trim() }
                };

                int resultNhanVien = DataProvider.Instance.ExecuteNonQuery(queryNhanVien, parametersNhanVien);

                // Cập nhật thông tin tài khoản
                string queryTaiKhoan = "sp_UpdateTaiKhoan";
                SqlParameter[] parametersTaiKhoan = new SqlParameter[]
                {
                    new SqlParameter("@ma_nhan_vien", SqlDbType.Char, 10) { Value = txtMaNV.Text.Trim() },
                    new SqlParameter("@tai_khoan", SqlDbType.VarChar, 255) { Value = txtTaiKhoan.Text.Trim() },
                    new SqlParameter("@mat_khau", SqlDbType.VarChar, 255) { Value = txtMatKhau.Text.Trim() },
                    new SqlParameter("@email", SqlDbType.VarChar, 255) { Value = txtEmail.Text.Trim() }
                };

                int resultTaiKhoan = DataProvider.Instance.ExecuteNonQuery(queryTaiKhoan, parametersTaiKhoan);

                if (resultNhanVien > 0 && resultTaiKhoan > 0)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDataList();  // Tải lại danh sách nhân viên
                    ResetForm();     // Reset các field trong form
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Lỗi khi cập nhật nhân viên: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã nhân viên từ textbox
                string maNhanVien = txtMaNV.Text.Trim();

                // Xóa tài khoản của nhân viên
                string queryTaiKhoan = "sp_DeleteTaiKhoan";
                SqlParameter[] parametersTaiKhoan = new SqlParameter[]
                {
                    new SqlParameter("@ma_nhan_vien", SqlDbType.Char, 10) { Value = maNhanVien }
                };

                int resultTaiKhoan = DataProvider.Instance.ExecuteNonQuery(queryTaiKhoan, parametersTaiKhoan);

                // Xóa thông tin nhân viên
                string queryNhanVien = "sp_DeleteNhanVien";
                SqlParameter[] parametersNhanVien = new SqlParameter[]
                {
                    new SqlParameter("@ma_nhan_vien", SqlDbType.Char, 10) { Value = maNhanVien }
                };

                int resultNhanVien = DataProvider.Instance.ExecuteNonQuery(queryNhanVien, parametersNhanVien);

                if (resultTaiKhoan > 0 && resultNhanVien > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDataList();  // Tải lại danh sách nhân viên
                    ResetForm();     // Reset các field trong form
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Lỗi khi xóa nhân viên: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa nhân viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                int rowId = e.RowIndex;

                if (rowId < 0) rowId = 0;

                if (rowId == list.RowCount - 1) rowId = rowId - 1;

                DataGridViewRow row = list.Rows[rowId];
                txtMaNV.Text = row.Cells[0].Value.ToString().Trim();   // Mã Nhân Viên
                txtTenNV.Text = row.Cells[1].Value.ToString().Trim();   // Tên Nhân Viên
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells[2].Value); // Ngày Sinh
                txtSDTNV.Text = row.Cells[3].Value.ToString().Trim();   // Số Điện Thoại
                txtDiaChi.Text = row.Cells[4].Value.ToString().Trim();  // Địa Chỉ
                txtTaiKhoan.Text = row.Cells[5].Value.ToString().Trim(); // Tài Khoản
                txtEmail.Text = row.Cells[6].Value.ToString().Trim();    // Email
                txtMatKhau.Text = row.Cells[7].Value.ToString().Trim();   // Mật Khẩu
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn dòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ResetForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSDTNV.Clear();
            txtDiaChi.Clear();
            txtTimKiem.Clear();
            txtEmail.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            LoadDataList();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
