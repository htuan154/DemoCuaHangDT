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

namespace app
{
    public partial class FormNewBill : Form
    {
        public FormNewBill()
        {
            InitializeComponent();
            LoadDataList();
        }
        private void LoadDataList()
        {
            string query = "SELECT h.[ma_hoa_don] AS 'Mã Hóa Đơn', kh.[loai_khach_hang] AS 'Loại Khách Hàng', kh.[ten] AS 'Tên Khách Hàng', kh.[email] AS 'Email', kh.[sdt] AS 'Số Điện Thoại', h.[tinh_trang] AS 'Tình Trạng', h.[ngay_tao] AS 'Ngày Tạo', nv.[ten] AS 'Tên Nhân Viên' " +
               "FROM [QL_CUAHANGDT3].[dbo].[HoaDonBan] h " +
               "JOIN [QL_CUAHANGDT3].[dbo].[KhachHang] kh ON h.[ma_khach_hang] = kh.[ma_kh] " +
               "JOIN [QL_CUAHANGDT3].[dbo].[NhanVien] nv ON h.[ma_nhan_vien] = nv.[ma_nhan_vien];";

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
        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
