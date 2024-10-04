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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            LoadDataList();
            list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            list.CellClick += list_CellClick;
        }
        private void LoadDataList()
        {
            string query = "SELECT ma_kh AS [Mã Khách Hàng], ten AS [Tên Khách Hàng], sdt AS [Số Điện Thoại], email AS [Email Liên Hệ], dia_chi AS [Địa Chỉ], loai_khach_hang AS [Loại Khách Hàng] FROM KhachHang;\r\n";
            list.DataSource = DataProvider.Instance.ExecuteQuery(query, commandType: CommandType.Text);
            list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            AdjustColumnWidths(list);
        }
        private static void AdjustColumnWidths(DataGridView dataGridView)
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

        private void list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId < 0) rowId = 0;

            if (rowId == list.RowCount - 1) rowId = rowId - 1;

            DataGridViewRow row = list.Rows[rowId];

            txtMaKH.Text = row.Cells[0].Value.ToString(); // Mã Khách Hàng
            txtTenKH.Text = row.Cells[1].Value.ToString(); // Tên Khách Hàng
            txtSDTKH.Text = row.Cells[2].Value.ToString(); // Số Điện Thoại
            txtEmailKH.Text = row.Cells[3].Value.ToString(); // Email Liên Hệ
            txtDiaChiKH.Text = row.Cells[4].Value.ToString(); // Địa Chỉ
            txtLoaiKH.Text = row.Cells[5].Value.ToString();
        }

        private void ClearTextBoxes()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSDTKH.Clear();
            txtEmailKH.Clear();
            txtDiaChiKH.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "sp_InsertKhachHang";


                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_kh", SqlDbType.Char, 10) { Value = txtMaKH.Text.Trim() },
                    new SqlParameter("@ten", SqlDbType.NVarChar, 255) { Value = txtTenKH.Text.Trim() },
                    new SqlParameter("@sdt", SqlDbType.VarChar, 20) { Value = txtSDTKH.Text.Trim() },
                    new SqlParameter("@email", SqlDbType.VarChar, 255) { Value = txtEmailKH.Text.Trim() },
                    new SqlParameter("@dia_chi", SqlDbType.NVarChar, 255) { Value = txtDiaChiKH.Text.Trim() },
                    new SqlParameter("@loai_khach_hang", SqlDbType.NVarChar, 50) { Value = txtLoaiKH.Text.Trim() } // Thêm loại khách hàng
                };


                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);


                if (result > 0)
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show($"Lỗi khi thêm khách hàng: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "sp_UpdateKhachHang_new";


                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_kh", SqlDbType.Char, 10) { Value = txtMaKH.Text.Trim() },
                    new SqlParameter("@ten", SqlDbType.NVarChar, 255) { Value = txtTenKH.Text.Trim() },
                    new SqlParameter("@sdt", SqlDbType.VarChar, 20) { Value = txtSDTKH.Text.Trim() },
                    new SqlParameter("@email", SqlDbType.VarChar, 255) { Value = txtEmailKH.Text.Trim() },
                    new SqlParameter("@dia_chi", SqlDbType.NVarChar, 255) { Value = txtDiaChiKH.Text.Trim() },
                     new SqlParameter("@loai_khach_hang", SqlDbType.NVarChar, 50) { Value = txtLoaiKH.Text.Trim() } // Thêm loại khách hàng
                };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {

                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearTextBoxes();
                    LoadDataList();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Lỗi khi cập nhật khách hàng: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "sp_DeleteKhachHang";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_kh", SqlDbType.Char, 10) { Value = txtMaKH.Text.Trim() }
                };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    ClearTextBoxes();

                }
                else
                {
                    MessageBox.Show("Xóa khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Lỗi khi xóa khách hàng: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa khách hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDataList();
            ClearTextBoxes();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
