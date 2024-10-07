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
using OfficeOpenXml;
using System.IO;

namespace app
{
    public partial class FormWarehouse : Form
    {
        public FormWarehouse()
        {
            InitializeComponent();
            LoadDataList();
        }

        private void LoadDataList()
        {
            string query = "SELECT ma_san_pham AS [Mã Sản Phẩm], ten_san_pham AS [Tên Sản Phẩm], so_luong_ton AS [Số Lượng Tồn], loai AS [Loại], ngay_tao AS [Ngày Tạo] FROM SanPham;\r\n";
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

        private void FormWarehouse_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang f = new FormNhapHang();
            f.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadDataList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count > 0)
            {
                string maSanPham = list.SelectedRows[0].Cells["Mã Sản Phẩm"].Value.ToString();
                string query = "DELETE FROM SanPham WHERE ma_san_pham = @ma_san_pham";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@ma_san_pham", SqlDbType.Char) { Value = maSanPham }
                };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                if (result > 0)
                {
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataList(); // Cập nhật lại danh sách sau khi xóa
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                // Thiết lập bối cảnh giấy phép cho EPPlus
                OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Lấy đường dẫn đến Desktop của người dùng
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "WarehouseData.xlsx");

                // Tạo một file Excel mới
                using (var package = new ExcelPackage())
                {
                    // Tạo một worksheet mới
                    var worksheet = package.Workbook.Worksheets.Add("Warehouse Data");

                    // Lấy dữ liệu từ DataGridView
                    if (list.DataSource is DataTable dt && dt.Rows.Count > 0)
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

                        // Lưu file Excel vào Desktop
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


    }
}
