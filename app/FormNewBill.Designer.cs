namespace app
{
    partial class FormNewBill
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
            panel3 = new Panel();
            btnXoa = new FontAwesome.Sharp.IconButton();
            btnTaoCTHD = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            panel2 = new Panel();
            cbKH = new ComboBox();
            panel4 = new Panel();
            btnThemHD = new FontAwesome.Sharp.IconButton();
            cbNV = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label1 = new Label();
            txtmahd = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            cbChonSp = new ComboBox();
            label9 = new Label();
            txtSL = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            btnThemSpVaoHD = new FontAwesome.Sharp.IconButton();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)list).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Controls.Add(list);
            panel6.Controls.Add(panel3);
            panel6.Font = new Font("Times New Roman", 9F);
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
            list.Size = new Size(990, 230);
            list.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnTaoCTHD);
            panel3.Controls.Add(btnReset);
            panel3.Location = new Point(325, 236);
            panel3.Name = "panel3";
            panel3.Size = new Size(383, 45);
            panel3.TabIndex = 10;
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
            btnXoa.Location = new Point(127, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(10, 0, 20, 0);
            btnXoa.Size = new Size(128, 45);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleLeft;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnTaoCTHD
            // 
            btnTaoCTHD.BackColor = Color.FromArgb(34, 34, 74);
            btnTaoCTHD.Dock = DockStyle.Right;
            btnTaoCTHD.FlatAppearance.BorderSize = 0;
            btnTaoCTHD.Font = new Font("Times New Roman", 12F);
            btnTaoCTHD.ForeColor = Color.Gainsboro;
            btnTaoCTHD.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnTaoCTHD.IconColor = Color.Gainsboro;
            btnTaoCTHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTaoCTHD.IconSize = 32;
            btnTaoCTHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnTaoCTHD.Location = new Point(255, 0);
            btnTaoCTHD.Name = "btnTaoCTHD";
            btnTaoCTHD.Padding = new Padding(10, 0, 20, 0);
            btnTaoCTHD.Size = new Size(128, 45);
            btnTaoCTHD.TabIndex = 5;
            btnTaoCTHD.Text = "Tạo";
            btnTaoCTHD.TextAlign = ContentAlignment.MiddleLeft;
            btnTaoCTHD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTaoCTHD.UseVisualStyleBackColor = false;
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
            btnReset.Size = new Size(128, 45);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel2);
            panel5.Controls.Add(panel1);
            panel5.Font = new Font("Times New Roman", 9F);
            panel5.Location = new Point(18, 14);
            panel5.Name = "panel5";
            panel5.Size = new Size(1018, 316);
            panel5.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbKH);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(cbNV);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtDiaChi);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtmahd);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(10, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 309);
            panel2.TabIndex = 26;
            // 
            // cbKH
            // 
            cbKH.FormattingEnabled = true;
            cbKH.Location = new Point(176, 91);
            cbKH.Name = "cbKH";
            cbKH.Size = new Size(120, 25);
            cbKH.TabIndex = 28;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnThemHD);
            panel4.Location = new Point(349, 235);
            panel4.Name = "panel4";
            panel4.Size = new Size(140, 45);
            panel4.TabIndex = 28;
            // 
            // btnThemHD
            // 
            btnThemHD.BackColor = Color.FromArgb(34, 34, 74);
            btnThemHD.Dock = DockStyle.Left;
            btnThemHD.FlatAppearance.BorderSize = 0;
            btnThemHD.Font = new Font("Times New Roman", 12F);
            btnThemHD.ForeColor = Color.Gainsboro;
            btnThemHD.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnThemHD.IconColor = Color.Gainsboro;
            btnThemHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThemHD.IconSize = 32;
            btnThemHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemHD.Location = new Point(0, 0);
            btnThemHD.Name = "btnThemHD";
            btnThemHD.Padding = new Padding(10, 0, 20, 0);
            btnThemHD.Size = new Size(130, 45);
            btnThemHD.TabIndex = 3;
            btnThemHD.Text = "Thêm";
            btnThemHD.TextAlign = ContentAlignment.MiddleLeft;
            btnThemHD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemHD.UseVisualStyleBackColor = false;
            btnThemHD.Click += btnThemHD_Click;
            // 
            // cbNV
            // 
            cbNV.FormattingEnabled = true;
            cbNV.Location = new Point(349, 168);
            cbNV.Name = "cbNV";
            cbNV.Size = new Size(120, 25);
            cbNV.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 231);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 25);
            dateTimePicker1.TabIndex = 26;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(349, 91);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(120, 25);
            txtSDT.TabIndex = 25;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(20, 168);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(276, 25);
            txtDiaChi.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(343, 136);
            label10.Name = "label10";
            label10.Size = new Size(126, 19);
            label10.TabIndex = 16;
            label10.Text = "Nhân Viên Xử Lý";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(20, 136);
            label11.Name = "label11";
            label11.Size = new Size(61, 19);
            label11.TabIndex = 15;
            label11.Text = "Địa Chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(6, 285);
            label1.Name = "label1";
            label1.Size = new Size(171, 22);
            label1.TabIndex = 10;
            label1.Text = "Danh Sách Hóa Đơn";
            // 
            // txtmahd
            // 
            txtmahd.Location = new Point(21, 91);
            txtmahd.Name = "txtmahd";
            txtmahd.Size = new Size(120, 25);
            txtmahd.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(20, 209);
            label8.Name = "label8";
            label8.Size = new Size(76, 19);
            label8.TabIndex = 4;
            label8.Text = "Thời Gian";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(349, 53);
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
            label6.Location = new Point(176, 53);
            label6.Name = "label6";
            label6.Size = new Size(117, 19);
            label6.TabIndex = 2;
            label6.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(23, 53);
            label5.Name = "label5";
            label5.Size = new Size(103, 19);
            label5.TabIndex = 1;
            label5.Text = "Mã Đơn Hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(6, 5);
            label4.Name = "label4";
            label4.Size = new Size(191, 22);
            label4.TabIndex = 0;
            label4.Text = "Thông Tin Khách Hàng";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbChonSp);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtSL);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel7);
            panel1.Location = new Point(554, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 304);
            panel1.TabIndex = 25;
            panel1.Paint += panel1_Paint;
            // 
            // cbChonSp
            // 
            cbChonSp.FormattingEnabled = true;
            cbChonSp.Location = new Point(62, 89);
            cbChonSp.Name = "cbChonSp";
            cbChonSp.Size = new Size(320, 25);
            cbChonSp.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(14, 3);
            label9.Name = "label9";
            label9.Size = new Size(133, 22);
            label9.TabIndex = 27;
            label9.Text = "Chọn Sản Phẩm";
            // 
            // txtSL
            // 
            txtSL.Location = new Point(62, 167);
            txtSL.Name = "txtSL";
            txtSL.Size = new Size(136, 25);
            txtSL.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(62, 134);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 25;
            label2.Text = "Số Lượng Mua";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(62, 51);
            label3.Name = "label3";
            label3.Size = new Size(320, 19);
            label3.TabIndex = 22;
            label3.Text = "Mã Sản Phẩm || Tên Sản Phẩm || Số Lượng Tồn";
            // 
            // panel7
            // 
            panel7.Controls.Add(btnThemSpVaoHD);
            panel7.Location = new Point(251, 233);
            panel7.Name = "panel7";
            panel7.Size = new Size(131, 45);
            panel7.TabIndex = 9;
            panel7.Paint += panel7_Paint;
            // 
            // btnThemSpVaoHD
            // 
            btnThemSpVaoHD.BackColor = Color.FromArgb(34, 34, 74);
            btnThemSpVaoHD.Dock = DockStyle.Left;
            btnThemSpVaoHD.FlatAppearance.BorderSize = 0;
            btnThemSpVaoHD.Font = new Font("Times New Roman", 12F);
            btnThemSpVaoHD.ForeColor = Color.Gainsboro;
            btnThemSpVaoHD.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnThemSpVaoHD.IconColor = Color.Gainsboro;
            btnThemSpVaoHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThemSpVaoHD.IconSize = 32;
            btnThemSpVaoHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnThemSpVaoHD.Location = new Point(0, 0);
            btnThemSpVaoHD.Name = "btnThemSpVaoHD";
            btnThemSpVaoHD.Padding = new Padding(10, 0, 20, 0);
            btnThemSpVaoHD.Size = new Size(130, 45);
            btnThemSpVaoHD.TabIndex = 3;
            btnThemSpVaoHD.Text = "Thêm";
            btnThemSpVaoHD.TextAlign = ContentAlignment.MiddleLeft;
            btnThemSpVaoHD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThemSpVaoHD.UseVisualStyleBackColor = false;
            btnThemSpVaoHD.Click += btnThemSpVaoHD_Click;
            // 
            // FormNewBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 74);
            ClientSize = new Size(1052, 628);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Name = "FormNewBill";
            Text = "FormNewBill";
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)list).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panel5;
        private TextBox txtDiaChi;
        private Label label10;
        private Label label11;
        private Label label1;
        private Panel panel7;
        private FontAwesome.Sharp.IconButton btnThemSpVaoHD;
        private TextBox txtmahd;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtSL;
        private Label label2;
        private Label label3;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnTaoCTHD;
        private FontAwesome.Sharp.IconButton btnReset;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSDT;
        private Label label9;
        private DataGridView list;
        private ComboBox cbNV;
        private ComboBox cbChonSp;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton btnThemHD;
        private ComboBox cbKH;
    }
}