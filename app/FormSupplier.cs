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

namespace app
{
    public partial class FormSupplier : Form
    {

        public FormSupplier()
        {
            InitializeComponent();
            LoadDataList();
            listNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void LoadDataList()
        {
            string query = "SELECT ma_nha_cung_cap AS [Mã Nhà Cung Cấp], ten AS [Tên Nhà Cung Cấp], sdt AS [Số Điện Thoại], email AS [EmailLienHe] FROM NhaCungCap;\r\n";
            listNhaCungCap.DataSource = DataProvider.Instance.ExecuteQuery(query, commandType: CommandType.Text);
            listNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


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





        private void EnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        }


        private void UnEnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }

        private void ResetText(List<Control> controls)
        {
            foreach (Control control in controls)
                control.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { textBox1, textBox2, textBox3, textBox4 });
            ResetText(new List<Control> { textBox1, textBox2, textBox3, textBox4 });
        }

        private void listNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = e.RowIndex;

            if (rowId < 0) rowId = 0;

            if (rowId == listNhaCungCap.RowCount - 1) rowId = rowId - 1;

            DataGridViewRow row = listNhaCungCap.Rows[rowId];

            textBox1.Text = row.Cells[0].Value.ToString();

            textBox2.Text = row.Cells[1].Value.ToString();

            textBox3.Text = row.Cells[2].Value.ToString();

            textBox4.Text = row.Cells[3].Value.ToString();

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "sp_InsertNhaCungCap";


                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@ma_nha_cung_cap", SqlDbType.Char, 10) { Value = textBox1.Text.Trim() },
                    new SqlParameter("@ten", SqlDbType.NVarChar, 255) { Value = textBox2.Text.Trim() },
                    new SqlParameter("@sdt", SqlDbType.VarChar, 20) { Value = textBox3.Text.Trim() },
                    new SqlParameter("@email", SqlDbType.VarChar, 255) { Value = textBox4.Text.Trim() }
                };


                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);


                if (result > 0)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    new SqlParameter("@ma_nha_cung_cap", SqlDbType.Char, 10) { Value = textBox1.Text.Trim() },
                    new SqlParameter("@ten", SqlDbType.NVarChar, 255) { Value = textBox2.Text.Trim() },
                    new SqlParameter("@sdt", SqlDbType.VarChar, 20) { Value = textBox3.Text.Trim() },
                    new SqlParameter("@email", SqlDbType.VarChar, 255) { Value = textBox4.Text.Trim() }
                };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                    new SqlParameter("@ma_nha_cung_cap", SqlDbType.Char, 10) { Value = textBox1.Text.Trim() }
                };


                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);


                if (result > 0)
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


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
            LoadDataList();
        }
    }
}
