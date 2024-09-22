using app.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class FormNewBill : Form

    {
        List<string> mahd;
        public FormNewBill()
        {
            InitializeComponent();
            LoadDataList();
            LoadDataToComboBox();
            mahd = LoadDataToCheckMaHD();
            LoadDataToComboBoxNV();
            LoadDataToComboBoxKH();
            list.CellClick += list_CellClick;

        }
        private void LoadDataToComboBoxKH()
        {
            // Gọi phương thức để lấy dữ liệu sản phẩm
            DataTable productData = GetDataMaKH();

            // Xóa các item cũ trong ComboBox nếu có
            cbKH.Items.Clear();

            // Duyệt qua từng dòng dữ liệu và thêm vào ComboBox
            foreach (DataRow row in productData.Rows)
            {
                string ma_nhan_vien = row["ma_kh"].ToString().Trim();
                // Ghép các giá trị thành chuỗi hiển thị
                string displayText = $"{ma_nhan_vien}";

                // Thêm vào ComboBox
                cbKH.Items.Add(displayText);
            }
        }
        private DataTable GetDataMaKH()
        {
            string query = "select ma_kh from KhachHang";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        private void LoadDataToComboBoxNV()
        {
            // Gọi phương thức để lấy dữ liệu sản phẩm
            DataTable productData = GetDataMaNV();

            // Xóa các item cũ trong ComboBox nếu có
            cbNV.Items.Clear();

            // Duyệt qua từng dòng dữ liệu và thêm vào ComboBox
            foreach (DataRow row in productData.Rows)
            {
                string ma_nhan_vien = row["MaNV"].ToString().Trim();
                // Ghép các giá trị thành chuỗi hiển thị
                string displayText = $"{ma_nhan_vien}";

                // Thêm vào ComboBox
                cbNV.Items.Add(displayText);
            }
        }
        private DataTable GetDataMaNV()
        {
            string query = "select ma_nhan_vien as MaNV from TaiKhoan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        private void LoadDataList()
        {
            string query = "SELECT h.[ma_hoa_don] AS 'Mã Hóa Đơn', kh.[loai_khach_hang] AS 'Loại Khách Hàng', kh.[ten] AS 'Tên Khách Hàng', kh.[email] AS 'Email', kh.[sdt] AS 'Số Điện Thoại',kh.[dia_chi] AS 'Địa Chỉ', h.[tinh_trang] AS 'Tình Trạng', h.[ngay_tao] AS 'Ngày Tạo', nv.[ten] AS 'Tên Nhân Viên' " +
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
        private List<string> LoadDataToCheckMaHD()
        {
            DataTable MaHD = GetDataMaHD();
            List<string> mahd = new List<string>();
            foreach (DataRow row in MaHD.Rows)
            {
                string mahoadon = row["ma_hoa_don"].ToString().Trim();
                mahd.Add(mahoadon);
            }
            return mahd;
        }
        private DataTable GetDataMaHD()
        {
            string query = "select ma_hoa_don from HoaDonBan";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        private void LoadDataToComboBox()
        {
            // Gọi phương thức để lấy dữ liệu sản phẩm
            DataTable productData = GetProductData();

            // Xóa các item cũ trong ComboBox nếu có
            cbChonSp.Items.Clear();

            // Duyệt qua từng dòng dữ liệu và thêm vào ComboBox
            foreach (DataRow row in productData.Rows)
            {
                string maSP = row["ma_san_pham"].ToString().Trim();
                string tenSP = row["ten_san_pham"].ToString();
                int soLuongTon = Convert.ToInt32(row["so_luong_ton"]);

                // Ghép các giá trị thành chuỗi hiển thị
                string displayText = $"{maSP} || {tenSP} || Số lượng tồn: {soLuongTon}";

                // Thêm vào ComboBox
                cbChonSp.Items.Add(displayText);
            }
        }
        private DataTable GetProductData()
        {
            // Sử dụng lớp DataProvider để lấy dữ liệu sản phẩm
            string query = "SELECT ma_san_pham, ten_san_pham, so_luong_ton FROM SanPham";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (txtmahd.TextLength != 5 || cbKH.SelectedIndex < 0 || cbNV.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            string addmahd = txtmahd.Text;
            string manv = cbNV.Text;
            string makh = cbKH.Text;
            string tinhtrang = "Chưa thanh toán";
            DateTime ngaytao = dateTimePicker1.Value;

            if (!(addmahd.Length == 5 && addmahd.StartsWith("HD") == true && addmahd.Substring(2).All(char.IsDigit) == true) || ktrMaHD(addmahd) == -1)
            {
                MessageBox.Show("Vui lòng kiểm tra mã hóa đơn!");
                return;
            }
            else
            {
                //insertMaHD(addmahd, makh, manv);
                int rowsAffected = DataProvider.Instance.InsertDataUsingStoredProcedure("sp_InsertHoaDonBan", new SqlParameter[] { new SqlParameter("@ma_hoa_don", addmahd), new SqlParameter("@ma_khach_hang", makh), new SqlParameter("@ma_nhan_vien", manv), new SqlParameter("@tinh_trang", tinhtrang) });

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Data inserted successfully!");
                }
                else
                {
                    Console.WriteLine("An error occurred during insertion. Please check the logs for details.");
                }
            }
        }
        private int ktrMaHD(string ktrmahd)
        {
            foreach (string t in mahd)
            {
                if (t.Trim() == ktrmahd)
                {
                    Console.WriteLine(t);
                    return -1;
                }
            }
            return 1;
        }
        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId < 0) rowId = 0;

            if (rowId == list.RowCount - 1) rowId = rowId - 1;

            DataGridViewRow row = list.Rows[rowId];
            txtmahd.Text = row.Cells[0].Value.ToString();
            txtDiaChi.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[4].Value.ToString();
            cbKH.SelectedItem = row.Cells[2].Value.ToString();
            cbNV.SelectedItem = row.Cells[7].Value.ToString();
            if (DateTime.TryParse(row.Cells[6].Value.ToString(), out DateTime ngayTao))
            {
                dateTimePicker1.Value = ngayTao;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }
            txtmahd.Enabled = false;
            cbKH.Enabled = false;
            panel4.Visible = false;
        }
        private void ResetForm()
        {
            LoadDataList();
            txtmahd.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtSL.Clear();
            cbChonSp.SelectedIndex = 0;
            cbKH.SelectedIndex = 0;
            cbNV.SelectedIndex = 0;
            panel4.Visible = true;
            txtmahd.Enabled = true;
            cbKH.Enabled = true;
            cbNV.Enabled = true;
            dateTimePicker1.Value = DateTime.Now;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnThemSpVaoHD_Click(object sender, EventArgs e)
        {
            if (txtmahd.TextLength == 0 || cbChonSp.SelectedIndex == -1 || txtSL.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (txtSL.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Vui lòng kiểm tra lại số lượng!");
                return;
            }
            int soluongmua = int.Parse(txtSL.Text);


            List<Product> dssanpham = new List<Product>();
            DataTable productData = GetProductData();

            foreach (DataRow row in productData.Rows)
            {
                string maSP = row["ma_san_pham"].ToString().Trim();
                string tenSP = row["ten_san_pham"].ToString();
                int soLuongTon = Convert.ToInt32(row["so_luong_ton"]);
                SqlMoney gia = SqlMoney.Parse(row["gia"].ToString());
                Product sanpham = new Product(maSP, tenSP, soLuongTon, gia);
                dssanpham.Add(sanpham);
            }

            string maspduocchon = cbChonSp.Text.Trim().Substring(0, 5);
            int thutuspduocchon = timkiemsp(dssanpham, maspduocchon);
            string mahd = txtmahd.Text.Trim();

            if (soluongmua > dssanpham[thutuspduocchon].Slt)
            {
                MessageBox.Show("Vui lòng kiểm tra lại số lượng mua(số lượng mua phải bé hơn số lượng tồn kho)!");
                return;
            }
            else
            {
                int rowsAffected = DataProvider.Instance.InsertDataUsingStoredProcedure("sp_InsertChiTietHoaDonBan", new SqlParameter[] { new SqlParameter("@ma_hoa_don", mahd), new SqlParameter("@ma_san_pham", maspduocchon), new SqlParameter("@don_gia", dssanpham[thutuspduocchon].Gia), new SqlParameter("@so_luong", soluongmua) });

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn thành công!");
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra vui lòng kiểm tra!");
                }
            }
        }
        private int timkiemsp(List<Product> dssanpham, string masp)
        {
            for (int i = 0; i < dssanpham.Count; i++)
            {
                if (string.Compare(dssanpham[i].MaSP, masp) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
