namespace app
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            panelMenu = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnStatistical = new FontAwesome.Sharp.IconButton();
            btnStaff = new FontAwesome.Sharp.IconButton();
            btnWarehouse = new FontAwesome.Sharp.IconButton();
            btnNewBill = new FontAwesome.Sharp.IconButton();
            btnProduct = new FontAwesome.Sharp.IconButton();
            btnSupplier = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelTiltleBar = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTiltleBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(31, 30, 68);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(btnStatistical);
            panelMenu.Controls.Add(btnStaff);
            panelMenu.Controls.Add(btnWarehouse);
            panelMenu.Controls.Add(btnNewBill);
            panelMenu.Controls.Add(btnProduct);
            panelMenu.Controls.Add(btnSupplier);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 703);
            panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Times New Roman", 12F);
            btnExit.ForeColor = Color.Gainsboro;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnExit.IconColor = Color.Gainsboro;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 32;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 643);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(10, 0, 20, 0);
            btnExit.Size = new Size(220, 60);
            btnExit.TabIndex = 9;
            btnExit.Text = "Đăng Xuất";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // btnStatistical
            // 
            btnStatistical.Dock = DockStyle.Top;
            btnStatistical.FlatAppearance.BorderSize = 0;
            btnStatistical.FlatStyle = FlatStyle.Flat;
            btnStatistical.Font = new Font("Times New Roman", 12F);
            btnStatistical.ForeColor = Color.Gainsboro;
            btnStatistical.IconChar = FontAwesome.Sharp.IconChar.SquarePollHorizontal;
            btnStatistical.IconColor = Color.Gainsboro;
            btnStatistical.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStatistical.IconSize = 32;
            btnStatistical.ImageAlign = ContentAlignment.MiddleLeft;
            btnStatistical.Location = new Point(0, 500);
            btnStatistical.Name = "btnStatistical";
            btnStatistical.Padding = new Padding(10, 0, 20, 0);
            btnStatistical.Size = new Size(220, 60);
            btnStatistical.TabIndex = 8;
            btnStatistical.Text = "Thống kê";
            btnStatistical.TextAlign = ContentAlignment.MiddleLeft;
            btnStatistical.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStatistical.UseVisualStyleBackColor = true;
            btnStatistical.Click += btnStatistical_Click_1;
            // 
            // btnStaff
            // 
            btnStaff.Dock = DockStyle.Top;
            btnStaff.FlatAppearance.BorderSize = 0;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Times New Roman", 12F);
            btnStaff.ForeColor = Color.Gainsboro;
            btnStaff.IconChar = FontAwesome.Sharp.IconChar.ImagePortrait;
            btnStaff.IconColor = Color.Gainsboro;
            btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnStaff.IconSize = 32;
            btnStaff.ImageAlign = ContentAlignment.MiddleLeft;
            btnStaff.Location = new Point(0, 440);
            btnStaff.Name = "btnStaff";
            btnStaff.Padding = new Padding(10, 0, 20, 0);
            btnStaff.Size = new Size(220, 60);
            btnStaff.TabIndex = 7;
            btnStaff.Text = "Nhân viên";
            btnStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnStaff.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click_1;
            // 
            // btnWarehouse
            // 
            btnWarehouse.Dock = DockStyle.Top;
            btnWarehouse.FlatAppearance.BorderSize = 0;
            btnWarehouse.FlatStyle = FlatStyle.Flat;
            btnWarehouse.Font = new Font("Times New Roman", 12F);
            btnWarehouse.ForeColor = Color.Gainsboro;
            btnWarehouse.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            btnWarehouse.IconColor = Color.Gainsboro;
            btnWarehouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnWarehouse.IconSize = 32;
            btnWarehouse.ImageAlign = ContentAlignment.MiddleLeft;
            btnWarehouse.Location = new Point(0, 380);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Padding = new Padding(10, 0, 20, 0);
            btnWarehouse.Size = new Size(220, 60);
            btnWarehouse.TabIndex = 6;
            btnWarehouse.Text = "Kho hàng";
            btnWarehouse.TextAlign = ContentAlignment.MiddleLeft;
            btnWarehouse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnWarehouse.UseVisualStyleBackColor = true;
            btnWarehouse.Click += btnWarehouse_Click_1;
            // 
            // btnNewBill
            // 
            btnNewBill.Dock = DockStyle.Top;
            btnNewBill.FlatAppearance.BorderSize = 0;
            btnNewBill.FlatStyle = FlatStyle.Flat;
            btnNewBill.Font = new Font("Times New Roman", 12F);
            btnNewBill.ForeColor = Color.Gainsboro;
            btnNewBill.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnNewBill.IconColor = Color.Gainsboro;
            btnNewBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewBill.IconSize = 32;
            btnNewBill.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewBill.Location = new Point(0, 320);
            btnNewBill.Name = "btnNewBill";
            btnNewBill.Padding = new Padding(10, 0, 20, 0);
            btnNewBill.Size = new Size(220, 60);
            btnNewBill.TabIndex = 5;
            btnNewBill.Text = "Tạo hóa đơn";
            btnNewBill.TextAlign = ContentAlignment.MiddleLeft;
            btnNewBill.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNewBill.UseVisualStyleBackColor = true;
            btnNewBill.Click += btnNewBill_Click_1;
            // 
            // btnProduct
            // 
            btnProduct.Dock = DockStyle.Top;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Times New Roman", 12F);
            btnProduct.ForeColor = Color.Gainsboro;
            btnProduct.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            btnProduct.IconColor = Color.Gainsboro;
            btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnProduct.IconSize = 32;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(0, 260);
            btnProduct.Name = "btnProduct";
            btnProduct.Padding = new Padding(10, 0, 20, 0);
            btnProduct.Size = new Size(220, 60);
            btnProduct.TabIndex = 4;
            btnProduct.Text = "Sản phẩm";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click_1;
            // 
            // btnSupplier
            // 
            btnSupplier.Dock = DockStyle.Top;
            btnSupplier.FlatAppearance.BorderSize = 0;
            btnSupplier.FlatStyle = FlatStyle.Flat;
            btnSupplier.Font = new Font("Times New Roman", 12F);
            btnSupplier.ForeColor = Color.Gainsboro;
            btnSupplier.IconChar = FontAwesome.Sharp.IconChar.Shop;
            btnSupplier.IconColor = Color.Gainsboro;
            btnSupplier.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSupplier.IconSize = 32;
            btnSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            btnSupplier.Location = new Point(0, 200);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Padding = new Padding(10, 0, 20, 0);
            btnSupplier.Size = new Size(220, 60);
            btnSupplier.TabIndex = 3;
            btnSupplier.Text = "Nhà cung cấp";
            btnSupplier.TextAlign = ContentAlignment.MiddleLeft;
            btnSupplier.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSupplier.UseVisualStyleBackColor = true;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Times New Roman", 12F);
            btnHome.ForeColor = Color.Gainsboro;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.Gainsboro;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 32;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 140);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 20, 0);
            btnHome.Size = new Size(220, 60);
            btnHome.TabIndex = 2;
            btnHome.Text = "Trang chủ";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 140);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(74, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelTiltleBar
            // 
            panelTiltleBar.BackColor = Color.FromArgb(26, 25, 62);
            panelTiltleBar.Controls.Add(panel1);
            panelTiltleBar.Controls.Add(lblTitleChildForm);
            panelTiltleBar.Controls.Add(iconCurrentChildForm);
            panelTiltleBar.Dock = DockStyle.Top;
            panelTiltleBar.Location = new Point(220, 0);
            panelTiltleBar.Name = "panelTiltleBar";
            panelTiltleBar.Size = new Size(1062, 75);
            panelTiltleBar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(917, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 69);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10F);
            label1.ForeColor = Color.FromArgb(172, 126, 241);
            label1.Location = new Point(79, 32);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 2;
            label1.Text = "Admin";
            label1.Click += label1_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.ForeColor = Color.Gainsboro;
            lblTitleChildForm.Location = new Point(53, 32);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(50, 20);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(26, 25, 62);
            iconCurrentChildForm.ForeColor = Color.MediumOrchid;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.MediumOrchid;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 29;
            iconCurrentChildForm.Location = new Point(18, 26);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(29, 32);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(26, 24, 58);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.Location = new Point(220, 75);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1062, 9);
            panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(34, 34, 74);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(220, 84);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1062, 619);
            panelDesktop.TabIndex = 3;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 703);
            Controls.Add(panelDesktop);
            Controls.Add(panelShadow);
            Controls.Add(panelTiltleBar);
            Controls.Add(panelMenu);
            Name = "FormMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += panelTitleBar_MouseDown;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTiltleBar.ResumeLayout(false);
            panelTiltleBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnStatistical;
        private FontAwesome.Sharp.IconButton btnStaff;
        private FontAwesome.Sharp.IconButton btnWarehouse;
        private FontAwesome.Sharp.IconButton btnNewBill;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnSupplier;
        private Panel panelTiltleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExit;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}
