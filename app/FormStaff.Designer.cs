namespace app
{
    partial class FormStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel6 = new Panel();
            list = new DataGridView();
            panel5 = new Panel();
            dtpNgaySinh = new DateTimePicker();
            label12 = new Label();
            txtSDTNV = new TextBox();
            txtTenNV = new TextBox();
            txtMatKhau = new TextBox();
            txtTaiKhoan = new TextBox();
            txtEmail = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel7 = new Panel();
            btnLamMoi = new FontAwesome.Sharp.IconButton();
            btnXoa = new FontAwesome.Sharp.IconButton();
            btnSua = new FontAwesome.Sharp.IconButton();
            btnThem = new FontAwesome.Sharp.IconButton();
            txtDiaChi = new TextBox();
            txtMaNV = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)list).BeginInit();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Controls.Add(list);
            panel6.Location = new Point(16, 331);
            panel6.Name = "panel6";
            panel6.Size = new Size(1020, 284);
            panel6.TabIndex = 10;
            // 
            // list
            // 
            list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list.Location = new Point(12, 1);
            list.Name = "list";
            list.RowHeadersWidth = 51;
            list.Size = new Size(990, 240);
            list.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(dtpNgaySinh);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(txtSDTNV);
            panel5.Controls.Add(txtTenNV);
            panel5.Controls.Add(txtMatKhau);
            panel5.Controls.Add(txtTaiKhoan);
            panel5.Controls.Add(txtEmail);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(txtDiaChi);
            panel5.Controls.Add(txtMaNV);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(18, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(1018, 316);
            panel5.TabIndex = 9;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgaySinh.Location = new Point(578, 173);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(120, 25);
            dtpNgaySinh.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(578, 141);
            label12.Name = "label12";
            label12.Size = new Size(78, 19);
            label12.TabIndex = 23;
            label12.Text = "Ngày Sinh";
            // 
            // txtSDTNV
            // 
            txtSDTNV.Location = new Point(422, 96);
            txtSDTNV.Name = "txtSDTNV";
            txtSDTNV.Size = new Size(120, 27);
            txtSDTNV.TabIndex = 22;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(249, 96);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(120, 27);
            txtTenNV.TabIndex = 21;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(422, 174);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(120, 27);
            txtMatKhau.TabIndex = 20;
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(249, 174);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(120, 27);
            txtTaiKhoan.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(93, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(120, 27);
            txtEmail.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(422, 141);
            label9.Name = "label9";
            label9.Size = new Size(75, 19);
            label9.TabIndex = 17;
            label9.Text = "Mật Khẩu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(248, 141);
            label10.Name = "label10";
            label10.Size = new Size(82, 19);
            label10.TabIndex = 16;
            label10.Text = "Tài Khoản ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(93, 141);
            label11.Name = "label11";
            label11.Size = new Size(49, 19);
            label11.TabIndex = 15;
            label11.Text = "Email";
            // 
            // panel1
            // 
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(txtTimKiem);
            panel1.Location = new Point(96, 242);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 27);
            panel1.TabIndex = 14;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.Black;
            iconButton1.FlatAppearance.MouseOverBackColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.WhiteSmoke;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassChart;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(446, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(42, 27);
            iconButton1.TabIndex = 13;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(-3, 0);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(449, 27);
            txtTimKiem.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(93, 209);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 12;
            label3.Text = "Tìm Kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(94, 209);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 12;
            label2.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(16, 292);
            label1.Name = "label1";
            label1.Size = new Size(171, 22);
            label1.TabIndex = 10;
            label1.Text = "Danh sách nhân viên";
            // 
            // panel7
            // 
            panel7.Controls.Add(btnLamMoi);
            panel7.Controls.Add(btnXoa);
            panel7.Controls.Add(btnSua);
            panel7.Controls.Add(btnThem);
            panel7.Location = new Point(804, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(203, 257);
            panel7.TabIndex = 9;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(34, 34, 74);
            btnLamMoi.Dock = DockStyle.Top;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.Font = new Font("Times New Roman", 12F);
            btnLamMoi.ForeColor = Color.Gainsboro;
            btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.RotateRight;
            btnLamMoi.IconColor = Color.Gainsboro;
            btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLamMoi.IconSize = 32;
            btnLamMoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.Location = new Point(0, 189);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Padding = new Padding(10, 0, 20, 0);
            btnLamMoi.Size = new Size(203, 63);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.TextAlign = ContentAlignment.MiddleLeft;
            btnLamMoi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(34, 34, 74);
            btnXoa.Dock = DockStyle.Top;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.ForeColor = Color.Gainsboro;
            btnXoa.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnXoa.IconColor = Color.Gainsboro;
            btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnXoa.IconSize = 32;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(0, 126);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(10, 0, 20, 0);
            btnXoa.Size = new Size(203, 63);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleLeft;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(34, 34, 74);
            btnSua.Dock = DockStyle.Top;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.ForeColor = Color.Gainsboro;
            btnSua.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnSua.IconColor = Color.Gainsboro;
            btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSua.IconSize = 32;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(0, 63);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(10, 0, 20, 0);
            btnSua.Size = new Size(203, 63);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleLeft;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(34, 34, 74);
            btnThem.Dock = DockStyle.Top;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.Font = new Font("Times New Roman", 12F);
            btnThem.ForeColor = Color.Gainsboro;
            btnThem.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnThem.IconColor = Color.Gainsboro;
            btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThem.IconSize = 32;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(0, 0);
            btnThem.Name = "btnThem";
            btnThem.Padding = new Padding(10, 0, 20, 0);
            btnThem.Size = new Size(203, 63);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.TextAlign = ContentAlignment.MiddleLeft;
            btnThem.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(578, 96);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(120, 27);
            txtDiaChi.TabIndex = 8;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(94, 96);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(120, 27);
            txtMaNV.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(578, 58);
            label8.Name = "label8";
            label8.Size = new Size(61, 19);
            label8.TabIndex = 4;
            label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(422, 58);
            label7.Name = "label7";
            label7.Size = new Size(106, 19);
            label7.TabIndex = 3;
            label7.Text = "Số Điện Thoại";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(249, 58);
            label6.Name = "label6";
            label6.Size = new Size(108, 19);
            label6.TabIndex = 2;
            label6.Text = "Tên Nhân Viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(96, 58);
            label5.Name = "label5";
            label5.Size = new Size(105, 19);
            label5.TabIndex = 1;
            label5.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(16, 12);
            label4.Name = "label4";
            label4.Size = new Size(152, 22);
            label4.TabIndex = 0;
            label4.Text = "Quản lý nhân viên";
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 74);
            ClientSize = new Size(1052, 628);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Name = "FormStaff";
            Text = "FormStaff";
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)list).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel5;
        private TextBox txtTaiKhoan;
        private TextBox txtEmail;
        private Label label9;
        private Label label10;
        private Label label11;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox txtTimKiem;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel7;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private TextBox txtDiaChi;
        private TextBox txtMaNV;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtSDTNV;
        private TextBox txtTenNV;
        private TextBox txtMatKhau;
        private DataGridView list;
        private Label label12;
        private DateTimePicker dtpNgaySinh;
    }
}