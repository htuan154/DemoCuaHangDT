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
    }
}
