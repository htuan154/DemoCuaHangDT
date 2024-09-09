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
    public partial class FormStatistical : Form
    {
        public FormStatistical()
        {
            InitializeComponent();
            LoadDataList();
        }

        private void LoadDataList()
        {

            string query = "SELECT h.[ma_hoa_don] AS 'Mã Hóa Đơn', nv.[ten] AS 'Tên Nhân Viên', h.[ngay_tao] AS 'Ngày', " +
               "SUM(ct.[so_luong] * ct.[don_gia]) AS 'Tổng Tiền' " +
               "FROM [QL_CUAHANGDT3].[dbo].[HoaDonBan] h " +
               "JOIN [QL_CUAHANGDT3].[dbo].[NhanVien] nv ON h.[ma_nhan_vien] = nv.[ma_nhan_vien] " +
               "JOIN [QL_CUAHANGDT3].[dbo].[ChiTietHoaDonBan] ct ON h.[ma_hoa_don] = ct.[ma_hoa_don] " +
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
    }
}
