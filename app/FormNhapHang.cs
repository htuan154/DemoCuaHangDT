using app.Models;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace app
{
    public partial class FormNhapHang : Form
    {
        public FormNhapHang()
        {
            InitializeComponent();
            LoadDataToComboBoxNCC();
            LoadDataToComboBoxNV();
            list.CellClick += list_CellClick;
            LoadDataToComboBox();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            string query = "SELECT pn.ma_phieu_nhap AS MaPhieuNhap, pn.ma_nhan_vien AS MaNhanVien, pn.ma_nha_cung_cap AS MaNhaCungCap, ctpn.ngay_tao AS NgayTao, ctpn.ma_san_pham AS MaSanPham, ctpn.don_gia AS DonGia, ctpn.so_luong AS SoLuong FROM PhieuNhap pn JOIN ChiTietPhieuNhap ctpn ON pn.ma_phieu_nhap = ctpn.ma_phieu_nhap;";
            list.DataSource = DataProvider.Instance.ExecuteQuery(query, commandType: CommandType.Text);
            list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
        private DataTable GetDataMaNV()
        {
            string query = "SELECT ma_nhan_vien FROM PhieuNhap";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        private void LoadDataToComboBoxNV()
        {
            DataTable nvtData = GetDataMaNV();
            cbMaNV.Items.Clear();

            foreach (DataRow row in nvtData.Rows)
            {
                // Kiểm tra xem cột có tồn tại và có dữ liệu không
                if (row.Table.Columns.Contains("ma_nhan_vien"))
                {
                    string ma_nhan_vien = row["ma_nhan_vien"].ToString().Trim(); // Đảm bảo sử dụng đúng tên cột
                    string displayText = $"{ma_nhan_vien}"; // Ghép các giá trị thành chuỗi hiển thị
                    cbMaNV.Items.Add(displayText); // Thêm vào ComboBox
                }
            }
            if (cbMaNV.Items.Count > 0) // Kiểm tra xem có item nào trong ComboBox
            {
                cbMaNV.SelectedIndex = 0; // Đặt chỉ mục mặc định cho ComboBox
            }
        }
        private DataTable GetDataNCC()
        {
            string query = "SELECT ma_nha_cung_cap FROM PhieuNhap"; // Câu truy vấn lấy mã nhà cung cấp
            return DataProvider.Instance.ExecuteQuery(query);
        }

        private void LoadDataToComboBoxNCC()
        {
            DataTable nccData = GetDataNCC(); // Lấy dữ liệu từ cơ sở dữ liệu
            cbNCC.Items.Clear(); // Xóa dữ liệu cũ trong ComboBox

            foreach (DataRow row in nccData.Rows)
            {
                // Kiểm tra xem cột có tồn tại và có dữ liệu không
                if (row.Table.Columns.Contains("ma_nha_cung_cap"))
                {
                    string ma_nha_cung_cap = row["ma_nha_cung_cap"].ToString().Trim(); // Đảm bảo sử dụng đúng tên cột
                    string displayText = $"{ma_nha_cung_cap}"; // Ghép các giá trị thành chuỗi hiển thị
                    cbNCC.Items.Add(displayText); // Thêm vào ComboBox
                }
            }

            // Đặt chỉ mục mặc định cho ComboBox nếu có item nào
            if (cbNCC.Items.Count > 0)
            {
                cbNCC.SelectedIndex = 0; // Đặt chỉ mục mặc định cho ComboBox
            }
        }
        private DataTable GetProductData()
        {
            // Sử dụng lớp DataProvider để lấy dữ liệu sản phẩm
            string query = "SELECT ma_san_pham, ten_san_pham, so_luong_ton FROM SanPham";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        private void LoadDataToComboBox()
        {
            // Gọi phương thức để lấy dữ liệu sản phẩm
            DataTable productData = GetProductData();

            // Xóa các item cũ trong ComboBox nếu có
            cbChonSP.Items.Clear();

            // Duyệt qua từng dòng dữ liệu và thêm vào ComboBox
            foreach (DataRow row in productData.Rows)
            {
                string maSP = row["ma_san_pham"].ToString().Trim();
                string tenSP = row["ten_san_pham"].ToString();
                int soLuongTon = Convert.ToInt32(row["so_luong_ton"]);

                // Ghép các giá trị thành chuỗi hiển thị
                string displayText = $"{maSP} || {tenSP} || Số lượng tồn: {soLuongTon}";

                // Thêm vào ComboBox
                cbChonSP.Items.Add(displayText);
            }
            cbChonSP.SelectedIndex = 0;
        }
        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId < 0) rowId = 0;

            if (rowId == list.RowCount - 1) rowId = rowId - 1;

            DataGridViewRow row = list.Rows[rowId];
            string maPhieuNhap = row.Cells[0].Value.ToString().Trim();
            txtMaPN.Text = maPhieuNhap;
            // Tìm và chọn giá trị khớp trong ComboBox cbNV (Nhân viên)
            string maNhanVien = row.Cells[1].Value.ToString().Trim();  // Xóa khoảng trắng
            int nhanVienIndex = cbMaNV.FindStringExact(maNhanVien);
            if (nhanVienIndex != -1)
            {
                cbMaNV.SelectedIndex = nhanVienIndex;
            }
            else
            {
                cbMaNV.SelectedIndex = -1; // Không tìm thấy
            }

            // Tìm và chọn giá trị khớp trong ComboBox cbNCC (Nhà cung cấp)
            string maNhaCungCap = row.Cells[2].Value.ToString().Trim();  // Xóa khoảng trắng
            int nhaCungCapIndex = cbNCC.FindStringExact(maNhaCungCap);
            if (nhaCungCapIndex != -1)
            {
                cbNCC.SelectedIndex = nhaCungCapIndex;
            }
            else
            {
                cbNCC.SelectedIndex = -1; // Không tìm thấy
            }

            if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngayTao))
            {
                dateTimePicker1.Value = ngayTao;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }

            string dongia = row.Cells[5].Value.ToString().Trim();
            txtDonGia.Text = dongia;
            string SoLuong = row.Cells[6].Value.ToString().Trim();
            txtSL.Text = SoLuong;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            txtDonGia.Clear();
            txtMaPN.Clear();
            txtSL.Clear();
            cbChonSP.SelectedIndex = 0;
            cbNCC.SelectedIndex = 0;
            cbNCC.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;

        }
        //NhapHang


        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đầu vào trước khi thực hiện
            if (string.IsNullOrEmpty(txtMaPN.Text) ||
                cbMaNV.SelectedItem == null ||
                cbNCC.SelectedItem == null ||
                string.IsNullOrEmpty(txtDonGia.Text) ||
                string.IsNullOrEmpty(txtSL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện gọi stored procedure sp_InsertPhieuNhap
            string maNhanVien = cbMaNV.SelectedItem.ToString();
            string maNhaCungCap = cbNCC.SelectedItem.ToString();
            DateTime ngayTao = dateTimePicker1.Value;

            // Thực thi sp_InsertPhieuNhap
            string insertPhieuNhapQuery = "sp_InsertPhieuNhap";

            var parametersPN = new List<SqlParameter>
    {
        new SqlParameter("@ma_nhan_vien", maNhanVien),
        new SqlParameter("@ma_nha_cung_cap", maNhaCungCap),
        new SqlParameter("@ngay_tao", ngayTao)
    };

            // Gọi ExecuteNonQuery với command type cho stored procedure
            int resultPN = DataProvider.Instance.ExecuteNonQuery(insertPhieuNhapQuery, parametersPN.ToArray());

            if (resultPN <= 0)
            {
                MessageBox.Show("Thêm phiếu nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sau khi thêm phiếu nhập thành công, thêm chi tiết phiếu nhập
            string maPhieuNhap = txtMaPN.Text; // Giả định rằng ma_phieu_nhap đã được tạo và bạn đã có nó
            string maSanPham = cbChonSP.SelectedItem.ToString().Split(new string[] { " || " }, StringSplitOptions.None)[0]; // Lấy mã sản phẩm từ ComboBox
            decimal donGia = Convert.ToDecimal(txtDonGia.Text);
            int soLuong = Convert.ToInt32(txtSL.Text);

            // Thực thi sp_InsertChiTietPhieuNhap
            string insertChiTietQuery = "sp_InsertChiTietPhieuNhap";

            var parametersCTPN = new List<SqlParameter>
    {
        new SqlParameter("@ma_phieu_nhap", maPhieuNhap),
        new SqlParameter("@ma_san_pham", maSanPham),
        new SqlParameter("@don_gia", donGia),
        new SqlParameter("@so_luong", soLuong)
    };

            // Gọi ExecuteNonQuery với command type cho stored procedure
            int resultCTPN = DataProvider.Instance.ExecuteNonQuery(insertChiTietQuery, parametersCTPN.ToArray());

            if (resultCTPN <= 0)
            {
                MessageBox.Show("Thêm chi tiết phiếu nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị thông báo thành công
            MessageBox.Show("Nhập hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật lại dữ liệu trên giao diện
            FormNhapHang_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đầu vào trước khi thực hiện
            if (string.IsNullOrEmpty(txtMaPN.Text) ||
                cbMaNV.SelectedItem == null ||
                cbNCC.SelectedItem == null ||
                string.IsNullOrEmpty(txtDonGia.Text) ||
                string.IsNullOrEmpty(txtSL.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy các giá trị từ giao diện
            string maPhieuNhap = txtMaPN.Text;
            string maNhanVien = cbMaNV.SelectedItem.ToString();
            string maNhaCungCap = cbNCC.SelectedItem.ToString();
            DateTime ngayTao = dateTimePicker1.Value;
            string maSanPham = cbChonSP.SelectedItem.ToString().Split(new string[] { " || " }, StringSplitOptions.None)[0]; // Lấy mã sản phẩm
            decimal donGia = Convert.ToDecimal(txtDonGia.Text);
            int soLuong = Convert.ToInt32(txtSL.Text);

            // Thực hiện cập nhật thông tin phiếu nhập
            string updatePhieuNhapQuery = "UPDATE PhieuNhap SET ma_nhan_vien = @ma_nhan_vien, ma_nha_cung_cap = @ma_nha_cung_cap, ngay_tao = @ngay_tao WHERE ma_phieu_nhap = @ma_phieu_nhap";

            var parametersPN = new List<SqlParameter>
    {
        new SqlParameter("@ma_nhan_vien", maNhanVien),
        new SqlParameter("@ma_nha_cung_cap", maNhaCungCap),
        new SqlParameter("@ngay_tao", ngayTao),
        new SqlParameter("@ma_phieu_nhap", maPhieuNhap)
    };

            int resultPN = DataProvider.Instance.ExecuteNonQuery(updatePhieuNhapQuery, parametersPN.ToArray());

            if (resultPN <= 0)
            {
                MessageBox.Show("Cập nhật phiếu nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện cập nhật thông tin chi tiết phiếu nhập
            string updateChiTietQuery = "UPDATE ChiTietPhieuNhap SET don_gia = @don_gia, so_luong = @so_luong WHERE ma_phieu_nhap = @ma_phieu_nhap AND ma_san_pham = @ma_san_pham";

            var parametersCTPN = new List<SqlParameter>
    {
        new SqlParameter("@don_gia", donGia),
        new SqlParameter("@so_luong", soLuong),
        new SqlParameter("@ma_phieu_nhap", maPhieuNhap),
        new SqlParameter("@ma_san_pham", maSanPham)
    };

            int resultCTPN = DataProvider.Instance.ExecuteNonQuery(updateChiTietQuery, parametersCTPN.ToArray());

            if (resultCTPN <= 0)
            {
                MessageBox.Show("Cập nhật chi tiết phiếu nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị thông báo thành công
            MessageBox.Show("Cập nhật hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật lại dữ liệu trên giao diện
            FormNhapHang_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin đầu vào trước khi thực hiện
    if (string.IsNullOrEmpty(txtMaPN.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu nhập để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy mã phiếu nhập từ giao diện
            string maPhieuNhap = txtMaPN.Text;

            // Câu truy vấn xóa chi tiết phiếu nhập
            string deleteChiTietQuery = "DELETE FROM ChiTietPhieuNhap WHERE ma_phieu_nhap = @ma_phieu_nhap";

            var parametersCTPN = new List<SqlParameter>
    {
        new SqlParameter("@ma_phieu_nhap", maPhieuNhap)
    };

            // Thực hiện xóa chi tiết phiếu nhập
            int resultCTPN = DataProvider.Instance.ExecuteNonQuery(deleteChiTietQuery, parametersCTPN.ToArray());

            if (resultCTPN < 0)
            {
                MessageBox.Show("Xóa chi tiết phiếu nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Câu truy vấn xóa phiếu nhập
            string deletePhieuNhapQuery = "DELETE FROM PhieuNhap WHERE ma_phieu_nhap = @ma_phieu_nhap";

            // Thực hiện xóa phiếu nhập
            int resultPN = DataProvider.Instance.ExecuteNonQuery(deletePhieuNhapQuery, parametersCTPN.ToArray());

            if (resultPN < 0)
            {
                MessageBox.Show("Xóa phiếu nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị thông báo thành công
            MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cập nhật lại dữ liệu trên giao diện
            FormNhapHang_Load(sender, e);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Tạo một file Excel mới
            using (ExcelPackage excel = new ExcelPackage())
            {
                // Tạo một worksheet mới
                var workSheet = excel.Workbook.Worksheets.Add("Sheet1");

                // Đặt tiêu đề cho các cột
                workSheet.Cells[1, 1].Value = "Mã Phiếu Nhập";
                workSheet.Cells[1, 2].Value = "Mã Nhân Viên";
                workSheet.Cells[1, 3].Value = "Mã Nhà Cung Cấp";
                workSheet.Cells[1, 4].Value = "Ngày Tạo";
                workSheet.Cells[1, 5].Value = "Mã Sản Phẩm";
                workSheet.Cells[1, 6].Value = "Đơn Giá";
                workSheet.Cells[1, 7].Value = "Số Lượng";

                // Lấy dữ liệu từ DataGridView và thêm vào worksheet
                for (int i = 0; i < list.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < list.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1].Value = list.Rows[i].Cells[j].Value?.ToString(); // Sử dụng null-conditional operator
                    }
                }

                // Lưu file Excel vào Desktop
                var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "PhieuNhap.xlsx");
                FileInfo excelFile = new FileInfo(filePath);
                excel.SaveAs(excelFile);

                MessageBox.Show("File Excel đã được tạo tại: " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
