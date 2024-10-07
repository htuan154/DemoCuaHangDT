using app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using Microsoft.Data.SqlClient;
namespace app
{
    public partial class FormStatistical : Form
    {
        private string selectedMaHoaDon;
        public FormStatistical()
        {
            InitializeComponent();
            LoadDataList();
            TinhTongThanhTien();
            OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            // Gán sự kiện CellClick cho DataGridView
            list.CellClick += new DataGridViewCellEventHandler(list_CellClick);
        }

        private void LoadDataList()
        {

            string query = "SELECT h.[ma_hoa_don] AS 'Mã Hóa Đơn', nv.[ten] AS 'Tên Nhân Viên', h.[ngay_tao] AS 'Ngày', " +
               "SUM(ct.[so_luong] * ct.[don_gia]) AS 'Tổng Tiền' " +
               "FROM [QL_CUAHANGDT].[dbo].[HoaDonBan] h " +
               "JOIN [QL_CUAHANGDT].[dbo].[NhanVien] nv ON h.[ma_nhan_vien] = nv.[ma_nhan_vien] " +
               "JOIN [QL_CUAHANGDT].[dbo].[ChiTietHoaDonBan] ct ON h.[ma_hoa_don] = ct.[ma_hoa_don] " +
               "GROUP BY h.[ma_hoa_don], nv.[ten], h.[ngay_tao];";
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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy đường dẫn đến Desktop của người dùng
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "StatisticalData.xlsx");

                // Tạo một file Excel mới
                using (var package = new ExcelPackage())
                {
                    // Tạo một worksheet mới
                    var worksheet = package.Workbook.Worksheets.Add("Statistical Data");

                    // Lấy dữ liệu từ DataGridView (giả sử DataSource là DataTable)
                    DataTable dt = (DataTable)list.DataSource;

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        // Đưa tiêu đề cột vào worksheet
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dt.Columns[i].ColumnName; // Tiêu đề cột
                        }

                        // Đưa dữ liệu vào worksheet
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dt.Rows[i][j]; // Dữ liệu
                            }
                        }

                        // Lưu file Excel ra Desktop
                        package.SaveAs(new FileInfo(filePath));

                        // Thông báo thành công
                        MessageBox.Show($"Xuất file Excel thành công! File đã được lưu tại: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Thông báo lỗi nếu có
                MessageBox.Show("Lỗi khi xuất file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDataList();
        }
        private void TinhTongThanhTien()
        {
            try
            {
                decimal tongThanhTien = 0;

                // Duyệt qua các hàng trong DataGridView (list)
                foreach (DataGridViewRow row in list.Rows)
                {
                    // Kiểm tra xem hàng có hợp lệ và có dữ liệu hay không
                    if (row.Cells["Tổng Tiền"].Value != null)
                    {
                        // Chuyển giá trị trong cột "Tổng Tiền" thành decimal
                        decimal thanhTien = Convert.ToDecimal(row.Cells["Tổng Tiền"].Value);
                        tongThanhTien += thanhTien; // Cộng dồn vào tổng
                    }
                }

                // Hiển thị tổng thành tiền vào Label khi người dùng click
                thanhtien.Text = tongThanhTien.ToString("N0") + " VND"; // Định dạng số có dấu phẩy ngăn cách hàng nghìn và thêm đơn vị tiền
            }
            catch (Exception ex)
            {
                // Thông báo nếu có lỗi xảy ra
                MessageBox.Show("Lỗi khi tính tổng thành tiền: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void thanhtien_Click(object sender, EventArgs e)
        {

        }
        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem hàng có được chọn không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng được chọn
                DataGridViewRow row = list.Rows[e.RowIndex];

                // Sử dụng index của cột (0 nếu "Mã Hóa Đơn" là cột đầu tiên)
                selectedMaHoaDon = row.Cells[0].Value.ToString();

            }
        }
        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có chọn dòng nào trong DataGridView không
            if (list.SelectedRows.Count > 0)
            {
                // Lấy mã hóa đơn từ hàng được chọn (giả sử mã hóa đơn nằm trong cột đầu tiên)
                string maHoaDon = list.SelectedRows[0].Cells["Mã Hóa Đơn"].Value.ToString();

                // Gọi hàm để hiển thị chi tiết hóa đơn dựa trên mã hóa đơn
                HienThiChiTietHoaDon(maHoaDon);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn trước khi xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Hàm hiển thị chi tiết hóa đơn
        private void HienThiChiTietHoaDon(string maHoaDon)
        {
            // Chuẩn bị truy vấn SQL để lấy chi tiết hóa đơn
            string query = "SELECT sp.ten_san_pham AS 'Tên Sản Phẩm', ct.so_luong AS 'Số Lượng', ct.don_gia AS 'Đơn Giá', " +
                           "(ct.so_luong * ct.don_gia) AS 'Thành Tiền' " +
                           "FROM [QL_CUAHANGDT].[dbo].[ChiTietHoaDonBan] ct " +
                           "JOIN [QL_CUAHANGDT].[dbo].[SanPham] sp ON ct.ma_san_pham = sp.ma_san_pham " +
                           "WHERE ct.ma_hoa_don = @maHoaDon";

            var parameters = new SqlParameter[]
            {
                new SqlParameter("@maHoaDon", maHoaDon)
            };

            // Thực thi truy vấn và lấy dữ liệu
            DataTable chiTietHoaDon = DataProvider.Instance.ExecuteQuery(query, parameters);

            // Kiểm tra nếu có kết quả
            if (chiTietHoaDon.Rows.Count > 0)
            {
                // Hiển thị dữ liệu chi tiết hóa đơn lên một DataGridView (ví dụ dgvChiTietHoaDon)
                list.DataSource = chiTietHoaDon;
                list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                MessageBox.Show("Không tìm thấy chi tiết cho hóa đơn này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
