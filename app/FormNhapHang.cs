using app.Models;
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
            string query = "SELECT pn.ma_phieu_nhap AS MaPhieuNhap, pn.ma_nhan_vien AS MaNhanVien, pn.ma_nha_cung_cap AS MaNhaCungCap, pn.ngay_tao AS NgayTao, ctpn.ma_san_pham AS MaSanPham, ctpn.don_gia AS DonGia, ctpn.so_luong AS SoLuong FROM PhieuNhap pn JOIN ChiTietPhieuNhap ctpn ON pn.ma_phieu_nhap = ctpn.ma_phieu_nhap;";
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
        }
    }
}
