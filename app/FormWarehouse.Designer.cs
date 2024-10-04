namespace app
{
    partial class FormWarehouse
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
            panel3 = new Panel();
            btnNhapHang = new FontAwesome.Sharp.IconButton();
            btnXoa = new FontAwesome.Sharp.IconButton();
            btnExcel = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            list = new DataGridView();
            label4 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)list).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNhapHang);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnExcel);
            panel3.Controls.Add(btnReset);
            panel3.Location = new Point(270, 556);
            panel3.Name = "panel3";
            panel3.Size = new Size(541, 47);
            panel3.TabIndex = 12;
            panel3.Paint += panel3_Paint;
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.FromArgb(34, 34, 74);
            btnNhapHang.Dock = DockStyle.Right;
            btnNhapHang.FlatAppearance.BorderSize = 0;
            btnNhapHang.Font = new Font("Times New Roman", 12F);
            btnNhapHang.ForeColor = Color.Gainsboro;
            btnNhapHang.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnNhapHang.IconColor = Color.Gainsboro;
            btnNhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhapHang.IconSize = 32;
            btnNhapHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhapHang.Location = new Point(157, 0);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Padding = new Padding(10, 0, 20, 0);
            btnNhapHang.Size = new Size(128, 47);
            btnNhapHang.TabIndex = 7;
            btnNhapHang.Text = "Nhập";
            btnNhapHang.TextAlign = ContentAlignment.MiddleLeft;
            btnNhapHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhapHang.UseVisualStyleBackColor = false;
            btnNhapHang.Click += btnNhapHang_Click;
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
            btnXoa.Location = new Point(285, 0);
            btnXoa.Name = "btnXoa";
            btnXoa.Padding = new Padding(10, 0, 20, 0);
            btnXoa.Size = new Size(128, 47);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.TextAlign = ContentAlignment.MiddleLeft;
            btnXoa.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXoa.UseVisualStyleBackColor = false;
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
            btnExcel.Location = new Point(413, 0);
            btnExcel.Name = "btnExcel";
            btnExcel.Padding = new Padding(10, 0, 20, 0);
            btnExcel.Size = new Size(128, 47);
            btnExcel.TabIndex = 5;
            btnExcel.Text = "Excel";
            btnExcel.TextAlign = ContentAlignment.MiddleLeft;
            btnExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExcel.UseVisualStyleBackColor = false;
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
            btnReset.Size = new Size(157, 47);
            btnReset.TabIndex = 3;
            btnReset.Text = "Làm mới";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(list);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(6, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 621);
            panel1.TabIndex = 13;
            // 
            // list
            // 
            list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list.Location = new Point(26, 30);
            list.Name = "list";
            list.RowHeadersWidth = 51;
            list.Size = new Size(987, 493);
            list.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(26, 5);
            label4.Name = "label4";
            label4.Size = new Size(174, 22);
            label4.TabIndex = 13;
            label4.Text = "Thông Tin Kho Hàng";
            // 
            // FormWarehouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 74);
            ClientSize = new Size(1052, 628);
            Controls.Add(panel1);
            Name = "FormWarehouse";
            Text = "FormWarehouse";
            Load += FormWarehouse_Load;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)list).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnExcel;
        private FontAwesome.Sharp.IconButton btnReset;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnNhapHang;
        private Label label4;
        private DataGridView list;
    }
}