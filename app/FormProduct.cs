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
    public partial class FormProduct : Form
    {
        private string tenSP;
        private string hangSP;
        private string loaiSP;
        private string xuatxuSP;
        public FormProduct()
        {
            InitializeComponent();
            LoadDataList();
            LoadComboBoxData();

        }
        private void LoadDataList()
        {
            try
            {
                string query = "SELECT ma_san_pham AS [Mã Sản Phẩm], ma_nha_cung_cap AS [Mã Nhà Cung Cấp], ten_san_pham AS [Tên Sản Phẩm], so_luong_ton AS [Số Lượng Tồn], hang AS [Hãng], gia AS [Giá], xuat_xu AS [Xuất Xứ], loai AS [Loại], ngay_tao AS [Ngày Tạo] FROM SanPham;";
                DataTable table = DataProvider.Instance.ExecuteQuery(query, commandType: CommandType.Text);

                if (table != null && table.Rows.Count > 0)
                {
                    list.DataSource = table;
                    list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }


        private void FormSupplier_Load(object sender, EventArgs e)
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
        private void List_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId < 0) rowId = 0;
            if (rowId == list.RowCount - 1) rowId = rowId - 1;

            DataGridViewRow row = list.Rows[rowId];

            txtMaSP.Text = row.Cells[0].Value.ToString();
            txtNCC.Text = row.Cells[1].Value.ToString();
            cbTenSP.Text = row.Cells[2].Value.ToString();
            cbHang.Text = row.Cells[4].Value.ToString();
            cbLoai.Text = row.Cells[7].Value.ToString();
            cbXuatXu.Text = row.Cells[6].Value.ToString();


            txtGia.Text = Convert.ToDouble(row.Cells[5].Value).ToString();

        }
        private void LoadComboBoxData()
        {

            try
            {
                
                string query1 = "SELECT ten_san_pham FROM SanPham";
                DataTable table1 = DataProvider.Instance.ExecuteQuery(query1, commandType: CommandType.Text);
                if (table1 != null && table1.Rows.Count > 0)
                {
                    cbTenSP.DataSource = table1;
                    cbTenSP.DisplayMember = "ten_san_pham"; 
                    cbTenSP.ValueMember = "ten_san_pham"; 
                }

                // ComboBox2 - Hiển thị danh sách hãng sản xuất
                string query2 = "SELECT DISTINCT hang FROM SanPham";
                DataTable table2 = DataProvider.Instance.ExecuteQuery(query2, commandType: CommandType.Text);
                if (table2 != null && table2.Rows.Count > 0)
                {
                    cbHang.DataSource = table2;
                    cbHang.DisplayMember = "hang";
                    cbHang.ValueMember = "hang";
                }

                // ComboBox3 - Hiển thị danh sách loại sản phẩm
                string query3 = "SELECT DISTINCT loai FROM SanPham";
                DataTable table3 = DataProvider.Instance.ExecuteQuery(query3, commandType: CommandType.Text);
                if (table3 != null && table3.Rows.Count > 0)
                {
                    cbLoai.DataSource = table3;
                    cbLoai.DisplayMember = "loai";
                    cbLoai.ValueMember = "loai";
                }

                // ComboBox4 - Hiển thị danh sách xuất xứ
                string query4 = "SELECT DISTINCT xuat_xu FROM SanPham";
                DataTable table4 = DataProvider.Instance.ExecuteQuery(query4, commandType: CommandType.Text);
                if (table4 != null && table4.Rows.Count > 0)
                {
                    cbXuatXu.DataSource = table4;
                    cbXuatXu.DisplayMember = "xuat_xu";
                    cbXuatXu.ValueMember = "xuat_xu";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu cho ComboBox: " + ex.Message);
            }
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Load_listBox1()
        {


        }

        private void Load_listBox2()
        {

        }

        private void Load_listBox3()
        {

        }

        private void Load_listBox4()
        {

        }



        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox1 = sender as ComboBox;
            tenSP = comboBox1.SelectedValue.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox2 = sender as ComboBox;
            hangSP = comboBox2.SelectedValue.ToString();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox3 = sender as ComboBox;
            loaiSP = comboBox3.SelectedValue.ToString();

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox4 = sender as ComboBox;
            xuatxuSP = comboBox4.SelectedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                
                string query = "sp_InsertSanPham";

                
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_san_pham", SqlDbType.NVarChar, 10) { Value = txtMaSP.Text },
                    new SqlParameter("@ma_nha_cung_cap", SqlDbType.NVarChar, 50) { Value = txtNCC.Text },
                    new SqlParameter("@ten_san_pham", SqlDbType.NVarChar, 100) { Value = tenSP },
                    new SqlParameter("@hang", SqlDbType.NVarChar, 50) { Value = hangSP },
                    new SqlParameter("@gia", SqlDbType.Decimal) { Value = Convert.ToDecimal(txtGia.Text) },
                    new SqlParameter("@loai", SqlDbType.NVarChar, 50) { Value = loaiSP },
                    new SqlParameter("@xuat_xu", SqlDbType.NVarChar, 50) { Value = xuatxuSP }
                };

                
                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    LoadDataList();
                    MessageBox.Show("Thêm dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                
                string maSanPham = txtMaSP.Text.Trim();
                string tenSanPham = tenSP; 
                string hang = hangSP; 
                decimal gia = Convert.ToDecimal(txtGia.Text.Trim());
                string xuatXu = xuatxuSP; 
                string loai = loaiSP; 

                
                if (string.IsNullOrEmpty(maSanPham))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "sp_UpdateSanPham";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_san_pham", SqlDbType.Char, 10) { Value = maSanPham },
                    new SqlParameter("@ten_san_pham", SqlDbType.NVarChar, 255) { Value = tenSanPham },
                    new SqlParameter("@hang", SqlDbType.NVarChar, 255) { Value = hang },
                    new SqlParameter("@gia", SqlDbType.Decimal) { Value = gia },
                    new SqlParameter("@xuat_xu", SqlDbType.NVarChar, 255) { Value = xuatXu },
                    new SqlParameter("@loai", SqlDbType.NVarChar, 255) { Value = loai }
                };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);


                if (result > 0)
                {
                    
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại! Không tìm thấy mã sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Lỗi khi cập nhật dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                
                string maSanPham = txtMaSP.Text.Trim();

                if (string.IsNullOrEmpty(maSanPham))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string query = "sp_DeleteSanPham";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_san_pham", SqlDbType.Char, 10) { Value = maSanPham }
                };


                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Xóa dữ liệu thất bại! Không tìm thấy mã sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
 
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {sqlEx.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDataList();
        }
    }
}
