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
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using app.Models;
using System.Text.RegularExpressions;

namespace app
{
    public partial class FormSupplier : Form
    {

        private List<string> mancc = new List<string>();
        public FormSupplier()
        {
            InitializeComponent();
            LoadDataList();
            listNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;



        }


        private void LoadDataList()
        {
            // Lấy danh sách nhà cung cấp từ database và load vào DataGridView
            string query = "SELECT ma_nha_cung_cap AS [Mã Nhà Cung Cấp], ten AS [Tên Nhà Cung Cấp], sdt AS [Số Điện Thoại], email AS [EmailLienHe] FROM NhaCungCap;";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, commandType: CommandType.Text);
            listNhaCungCap.DataSource = dt;
            listNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cập nhật danh sách mã nhà cung cấp
            mancc.Clear();
            foreach (DataRow row in dt.Rows)
            {
                mancc.Add(row["Mã Nhà Cung Cấp"].ToString());
            }
        }

        private void FormSupplier_Load(object sender, EventArgs e)
        {
            AdjustColumnWidths(listNhaCungCap);
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







        private void listNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId < 0) rowId = 0;

            if (rowId == listNhaCungCap.RowCount - 1) rowId = rowId - 1;

            DataGridViewRow row = listNhaCungCap.Rows[rowId];

            txtMaNCC.Text = row.Cells[0].Value.ToString();

            txtTenNCC.Text = row.Cells[1].Value.ToString();

            txtSDTNCC.Text = row.Cells[2].Value.ToString();

            txtEmail.Text = row.Cells[3].Value.ToString();

        }
        private bool IsMaNhaCungCapExist(string maNCC)
        {
            string query = "SELECT COUNT(*) FROM NhaCungCap WHERE ma_nha_cung_cap = @ma_nha_cung_cap";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@ma_nha_cung_cap", SqlDbType.Char, 10) { Value = maNCC }
            };

            // Thực hiện câu lệnh SQL để đếm số dòng có mã nhà cung cấp
            object result = DataProvider.Instance.ExecuteScalar(query, parameters);

            // Nếu số dòng > 0 thì mã đã tồn tại
            return Convert.ToInt32(result) > 0;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra mã nhà cung cấp đã tồn tại hay chưa
                if (IsMaNhaCungCapExist(txtMaNCC.Text.Trim()))
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại, vui lòng nhập mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string query = "sp_InsertNhaCungCap";


                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_nha_cung_cap", SqlDbType.Char, 10) { Value = txtMaNCC.Text.Trim() },
                    new SqlParameter("@ten", SqlDbType.NVarChar, 255) { Value = txtTenNCC.Text.Trim() },
                    new SqlParameter("@sdt", SqlDbType.VarChar, 20) { Value = txtSDTNCC.Text.Trim() },
                    new SqlParameter("@email", SqlDbType.VarChar, 255) { Value = txtEmail.Text.Trim() }
                };


                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);


                if (result > 0)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDataList();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show($"Lỗi khi thêm nhà cung cấp: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "sp_UpdateNhaCungCap";


                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_nha_cung_cap", SqlDbType.Char, 10) { Value = txtMaNCC.Text.Trim() },
                    new SqlParameter("@ten", SqlDbType.NVarChar, 255) { Value = txtTenNCC.Text.Trim() },
                    new SqlParameter("@sdt", SqlDbType.VarChar, 20) { Value = txtSDTNCC.Text.Trim() },
                    new SqlParameter("@email", SqlDbType.VarChar, 255) { Value = txtEmail.Text.Trim() }
                };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadDataList();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show($"Lỗi khi cập nhật nhà cung cấp: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Lỗi khi cập nhật nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "sp_DeleteNhaCungCap";


                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_nha_cung_cap", SqlDbType.Char, 10) { Value = txtMaNCC.Text.Trim() }
                };


                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);


                if (result > 0)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    LoadDataList();
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show($"Lỗi khi xóa nhà cung cấp: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Lỗi khi xóa nhà cung cấp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Clear();
            txtSDTNCC.Clear();
            txtTenNCC.Clear();
            txtTimKiem.Clear();
            txtEmail.Clear();
            LoadDataList();
        }
        private int timkiem(string ktrmancc)
        {
            foreach (string t in mancc)
            {
                if (t.Trim() == ktrmancc)
                {
                    Console.WriteLine(t);
                    return 1;
                }
            }
            return -1;
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để tìm kiếm!");
                return;
            }
            string maNCC = txtTimKiem.Text;
            if (timkiem(maNCC) == 1)
            {
                string query = "SELECT ma_nha_cung_cap AS [Mã Nhà Cung Cấp], ten AS [Tên Nhà Cung Cấp], sdt AS [Số Điện Thoại], email AS [EmailLienHe] " +
                               "FROM NhaCungCap WHERE ma_nha_cung_cap = @ma_nha_cung_cap";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_nha_cung_cap", SqlDbType.Char, 10) { Value = maNCC }
                };

                DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    listNhaCungCap.DataSource = null;
                    listNhaCungCap.Rows.Clear();
                    listNhaCungCap.DataSource = result;
                    AdjustColumnWidths(listNhaCungCap);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp với mã này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Mã nhà cung cấp không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
    }
}
