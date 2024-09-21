namespace app
{
    partial class FormStatistical
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
            label4 = new Label();
            panel3 = new Panel();
            btnXemCTHD = new FontAwesome.Sharp.IconButton();
            btnXuatExcel = new FontAwesome.Sharp.IconButton();
            btnReset = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            txtTimKiem = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            list = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)list).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(33, 15);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 16;
            label4.Text = "Thống Kê";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnXemCTHD);
            panel3.Controls.Add(btnXuatExcel);
            panel3.Controls.Add(btnReset);
            panel3.Location = new Point(564, 434);
            panel3.Name = "panel3";
            panel3.Size = new Size(452, 47);
            panel3.TabIndex = 15;
            // 
            // btnXemCTHD
            // 
            btnXemCTHD.BackColor = Color.FromArgb(34, 34, 74);
            btnXemCTHD.Dock = DockStyle.Right;
            btnXemCTHD.FlatAppearance.BorderSize = 0;
            btnXemCTHD.Font = new Font("Times New Roman", 12F);
            btnXemCTHD.ForeColor = Color.Gainsboro;
            btnXemCTHD.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            btnXemCTHD.IconColor = Color.Gainsboro;
            btnXemCTHD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnXemCTHD.IconSize = 32;
            btnXemCTHD.ImageAlign = ContentAlignment.MiddleLeft;
            btnXemCTHD.Location = new Point(204, 0);
            btnXemCTHD.Name = "btnXemCTHD";
            btnXemCTHD.Padding = new Padding(10, 0, 20, 0);
            btnXemCTHD.Size = new Size(119, 47);
            btnXemCTHD.TabIndex = 7;
            btnXemCTHD.Text = "Xem";
            btnXemCTHD.TextAlign = ContentAlignment.MiddleLeft;
            btnXemCTHD.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXemCTHD.UseVisualStyleBackColor = false;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.FromArgb(34, 34, 74);
            btnXuatExcel.Dock = DockStyle.Right;
            btnXuatExcel.FlatAppearance.BorderSize = 0;
            btnXuatExcel.Font = new Font("Times New Roman", 12F);
            btnXuatExcel.ForeColor = Color.Gainsboro;
            btnXuatExcel.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnXuatExcel.IconColor = Color.Gainsboro;
            btnXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnXuatExcel.IconSize = 32;
            btnXuatExcel.ImageAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.Location = new Point(323, 0);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Padding = new Padding(10, 0, 20, 0);
            btnXuatExcel.Size = new Size(129, 47);
            btnXuatExcel.TabIndex = 5;
            btnXuatExcel.Text = "Excel";
            btnXuatExcel.TextAlign = ContentAlignment.MiddleLeft;
            btnXuatExcel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnXuatExcel.UseVisualStyleBackColor = false;
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
            btnReset.Size = new Size(153, 47);
            btnReset.TabIndex = 3;
            btnReset.Text = "Làm mới";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReset.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(33, 413);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 68);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconButton4);
            panel2.Controls.Add(txtTimKiem);
            panel2.Location = new Point(3, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 27);
            panel2.TabIndex = 17;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Right;
            iconButton4.FlatAppearance.BorderColor = Color.Black;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatAppearance.MouseDownBackColor = Color.Black;
            iconButton4.FlatAppearance.MouseOverBackColor = Color.Black;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.WhiteSmoke;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassChart;
            iconButton4.IconColor = Color.WhiteSmoke;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 20;
            iconButton4.Location = new Point(446, 0);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(42, 27);
            iconButton4.TabIndex = 13;
            iconButton4.UseVisualStyleBackColor = true;
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
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 15;
            label3.Text = "Tìm Kiếm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(1, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 16;
            label2.Text = "Tìm Kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(33, 573);
            label1.Name = "label1";
            label1.Size = new Size(345, 29);
            label1.TabIndex = 18;
            label1.Text = "Tổng Doanh Thu Của Của Hàng ";
            // 
            // list
            // 
            list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list.Location = new Point(33, 62);
            list.Name = "list";
            list.RowHeadersWidth = 51;
            list.Size = new Size(983, 345);
            list.TabIndex = 19;
            // 
            // FormStatistical
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 74);
            ClientSize = new Size(1052, 628);
            Controls.Add(list);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(panel3);
            Name = "FormStatistical";
            Text = "FormStatistical";
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnXemCTHD;
        private FontAwesome.Sharp.IconButton btnXuatExcel;
        private FontAwesome.Sharp.IconButton btnReset;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox txtTimKiem;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView list;
    }
}