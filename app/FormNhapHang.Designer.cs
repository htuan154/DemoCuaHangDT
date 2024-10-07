namespace app
{
    partial class FormNhapHang
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
            list = new DataGridView();
            label4 = new Label();
            panel3 = new Panel();
            btnSua = new FontAwesome.Sharp.IconButton();
            btnXoa = new FontAwesome.Sharp.IconButton();
            btnExcel = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            cbMaNV = new ComboBox();
            cbNCC = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtMaPN = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            txtSL = new TextBox();
            panel6 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            cbChonSP = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtDonGia = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)list).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // list
            // 
            list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list.Location = new Point(31, 335);
            list.Name = "list";
            list.RowHeadersWidth = 51;
            list.Size = new Size(957, 202);
            list.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(31, 24);
            label4.Name = "label4";
            label4.Size = new Size(188, 22);
            label4.TabIndex = 16;
            label4.Text = "Thông Tin Nhập  Hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnExcel);
            panel3.Controls.Add(btnReset);
            panel3.Location = new Point(196, 560);
            panel3.Name = "panel3";
            panel3.Size = new Size(543, 47);
            panel3.TabIndex = 15;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(34, 34, 74);
            btnSua.Dock = DockStyle.Right;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.ForeColor = Color.Gainsboro;
            btnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnSua.IconColor = Color.Gainsboro;
            btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSua.IconSize = 32;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(159, 0);
            btnSua.Name = "btnSua";
            btnSua.Padding = new Padding(10, 0, 20, 0);
            btnSua.Size = new Size(128, 47);
            btnSua.TabIndex = 7;
            btnSua.Text = "Sửa";
            btnSua.TextAlign = ContentAlignment.MiddleLeft;
            btnSua.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(34, 34, 74);
            btnXoa.Dock = DockStyle.Right;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.ForeColor = Color.Gainsboro;
            btnXoa.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            btnXoa.IconColor = Color.Gainsboro;
            btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnXoa.IconSize = 32;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(287, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(10, 0, 20, 0);
            btnXoa.Size = new Size(128, 47);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleLeft;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.FromArgb(34, 34, 74);
            btnExcel.Dock = DockStyle.Right;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.Font = new Font("Times New Roman", 12F);
            btnExcel.ForeColor = Color.Gainsboro;
            btnExcel.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnExcel.IconColor = Color.Gainsboro;
            btnExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExcel.IconSize = 32;
            btnExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcel.Location = new Point(415, 0);
            btnExcel.Name = "btnExcel";
            btnExcel.Padding = new Padding(10, 0, 20, 0);
            btnExcel.Size = new Size(128, 47);
            btnExcel.TabIndex = 5;
            btnExcel.Text = "Excel";
            btnExcel.TextAlign = ContentAlignment.MiddleLeft;
            btnExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(34, 34, 74);
            btnReset.Dock = DockStyle.Left;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.Font = new Font("Times New Roman", 12F);
            btnReset.ForeColor = Color.Gainsboro;
            btnReset.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            btnReset.IconColor = Color.Gainsboro;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 32;
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(0, 0);
            btnReset.Name = "btnReset";
            btnReset.Padding = new Padding(10, 0, 20, 0);
            btnReset.Size = new Size(159, 47);
            btnReset.TabIndex = 3;
            btnReset.Text = "Làm mới";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(cbMaNV);
            panel1.Controls.Add(cbNCC);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMaPN);
            panel1.Location = new Point(31, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 194);
            panel1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(17, 146);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 9;
            label5.Text = "Ngày Tạo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 141);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // cbMaNV
            // 
            cbMaNV.FormattingEnabled = true;
            cbMaNV.Location = new Point(419, 30);
            cbMaNV.Name = "cbMaNV";
            cbMaNV.Size = new Size(78, 28);
            cbMaNV.TabIndex = 7;
            // 
            // cbNCC
            // 
            cbNCC.FormattingEnabled = true;
            cbNCC.Location = new Point(165, 86);
            cbNCC.Name = "cbNCC";
            cbNCC.Size = new Size(94, 28);
            cbNCC.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(285, 33);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 5;
            label3.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(17, 86);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 3;
            label2.Text = "Mã Nhà Cung Cấp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(17, 36);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã Phiếu Nhập";
            // 
            // txtMaPN
            // 
            txtMaPN.Location = new Point(165, 33);
            txtMaPN.Name = "txtMaPN";
            txtMaPN.Size = new Size(94, 27);
            txtMaPN.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(31, 296);
            label6.Name = "label6";
            label6.Size = new Size(200, 22);
            label6.TabIndex = 19;
            label6.Text = "Danh Sách Phiếu Nhập  ";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtSL);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(cbChonSP);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(txtDonGia);
            panel5.Location = new Point(543, 82);
            panel5.Name = "panel5";
            panel5.Size = new Size(445, 194);
            panel5.TabIndex = 20;
            panel5.Paint += panel5_Paint;
            // 
            // txtSL
            // 
            txtSL.Location = new Point(161, 87);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(94, 27);
            txtSL.TabIndex = 21;
            // 
            // panel6
            // 
            panel6.Controls.Add(iconButton1);
            panel6.Location = new Point(298, 124);
            panel6.Name = "panel6";
            panel6.Size = new Size(130, 44);
            panel6.TabIndex = 20;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(34, 34, 74);
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.Font = new Font("Times New Roman", 12F);
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(2, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(128, 44);
            iconButton1.TabIndex = 8;
            iconButton1.Text = "Nhập";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // cbChonSP
            // 
            cbChonSP.FormattingEnabled = true;
            cbChonSP.Location = new Point(161, 28);
            cbChonSP.Name = "cbChonSP";
            cbChonSP.Size = new Size(267, 28);
            cbChonSP.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(17, 33);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 5;
            label8.Text = "Sản Phẩm";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(17, 86);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 3;
            label9.Text = "Số Lượng ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(17, 136);
            label10.Name = "label10";
            label10.Size = new Size(63, 20);
            label10.TabIndex = 1;
            label10.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(161, 133);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(94, 27);
            txtDonGia.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(543, 24);
            label7.Name = "label7";
            label7.Size = new Size(0, 22);
            label7.TabIndex = 21;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton2);
            panel2.Location = new Point(807, 560);
            panel2.Name = "panel2";
            panel2.Size = new Size(166, 47);
            panel2.TabIndex = 22;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(34, 34, 74);
            iconButton2.Dock = DockStyle.Right;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.Font = new Font("Times New Roman", 12F);
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Reply;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(166, 47);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "Quay lại";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // FormNhapHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 74);
            ClientSize = new Size(1014, 637);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(list);
            Controls.Add(label4);
            Controls.Add(panel3);
            Name = "FormNhapHang";
            Text = "FormNhapHang";
            Load += FormNhapHang_Load;
            ((System.ComponentModel.ISupportInitialize)list).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView list;
        private Label label4;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnExcel;
        private FontAwesome.Sharp.IconButton btnReset;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbMaNV;
        private ComboBox cbNCC;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtMaPN;
        private Label label5;
        private Label label6;
        private Panel panel5;
        private Panel panel6;
        private ComboBox cbChonSP;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtDonGia;
        private TextBox txtSL;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}