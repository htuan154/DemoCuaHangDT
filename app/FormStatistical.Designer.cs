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
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            textBox5 = new TextBox();
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
            panel3.Controls.Add(iconButton3);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(iconButton2);
            panel3.Location = new Point(595, 434);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 47);
            panel3.TabIndex = 15;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(34, 34, 74);
            iconButton3.Dock = DockStyle.Right;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.Font = new Font("Times New Roman", 12F);
            iconButton3.ForeColor = Color.Gainsboro;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            iconButton3.IconColor = Color.Gainsboro;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(126, 0);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 20, 0);
            iconButton3.Size = new Size(128, 47);
            iconButton3.TabIndex = 7;
            iconButton3.Text = "Xem";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(34, 34, 74);
            iconButton1.Dock = DockStyle.Right;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.Font = new Font("Times New Roman", 12F);
            iconButton1.ForeColor = Color.Gainsboro;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconButton1.IconColor = Color.Gainsboro;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(254, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 20, 0);
            iconButton1.Size = new Size(128, 47);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Excel";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(34, 34, 74);
            iconButton2.Dock = DockStyle.Left;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.Font = new Font("Times New Roman", 12F);
            iconButton2.ForeColor = Color.Gainsboro;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Refresh;
            iconButton2.IconColor = Color.Gainsboro;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(10, 0, 20, 0);
            iconButton2.Size = new Size(127, 47);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Reset";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
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
            panel2.Controls.Add(textBox5);
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
            // textBox5
            // 
            textBox5.Location = new Point(-3, 0);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(449, 27);
            textBox5.TabIndex = 11;
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
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private TextBox textBox5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView list;
    }
}