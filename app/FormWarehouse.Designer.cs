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
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label4 = new Label();
            list = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)list).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButton3);
            panel3.Controls.Add(iconButton4);
            panel3.Controls.Add(iconButton1);
            panel3.Controls.Add(iconButton2);
            panel3.Location = new Point(270, 556);
            panel3.Name = "panel3";
            panel3.Size = new Size(511, 47);
            panel3.TabIndex = 12;
            panel3.Paint += panel3_Paint;
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
            iconButton3.Location = new Point(127, 0);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(10, 0, 20, 0);
            iconButton3.Size = new Size(128, 47);
            iconButton3.TabIndex = 7;
            iconButton3.Text = "Nhập";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(34, 34, 74);
            iconButton4.Dock = DockStyle.Right;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.Font = new Font("Times New Roman", 12F);
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.SquareXmark;
            iconButton4.IconColor = Color.Gainsboro;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(255, 0);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(10, 0, 20, 0);
            iconButton4.Size = new Size(128, 47);
            iconButton4.TabIndex = 6;
            iconButton4.Text = "Hủy";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
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
            iconButton1.Location = new Point(383, 0);
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
            iconButton2.Size = new Size(128, 47);
            iconButton2.TabIndex = 3;
            iconButton2.Text = "Reset";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
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
            // list
            // 
            list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            list.Location = new Point(26, 30);
            list.Name = "list";
            list.RowHeadersWidth = 51;
            list.Size = new Size(987, 493);
            list.TabIndex = 14;
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
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label4;
        private DataGridView list;
    }
}