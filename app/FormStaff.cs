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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
            LoadDataList();
        }
        private void LoadDataList()
        {
            string query = "SELECT NhanVien.ma_nhan_vien AS [Mã Nhân Viên], NhanVien.ten AS [Tên Nhân Viên], NhanVien.ngay_sinh AS [Ngày Sinh], NhanVien.so_dien_thoai AS [Số Điện Thoại], NhanVien.dia_chi AS [Địa Chỉ], TaiKhoan.tai_khoan AS [Tài Khoản], TaiKhoan.email AS [Email] FROM NhanVien JOIN TaiKhoan ON NhanVien.ma_nhan_vien = TaiKhoan.ma_nhan_vien;\r\n";
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
