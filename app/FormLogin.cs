using app.Models;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 30;
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            this.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            var userAccount = Account.Instance.Login(userName, password);
            if (userAccount != null)
            {
                FormMainMenu f = new FormMainMenu();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }
        //bool Login(string userName, string passWord)
        //{
        //    return Account.Instance.Login(userName, passWord);
        //}
        bool Login(string userName, string passWord)
        {
            var userAccount = Account.Instance.Login(userName, passWord);
            if (userAccount != null)
            {
                if (userAccount.Role == "Admin")
                {
                    
                    MessageBox.Show("Đăng nhập thành công với quyền Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true; 
                }
                else if (userAccount.Role == "TaiKhoan")
                {
                    
                    MessageBox.Show("Đăng nhập thành công với quyền Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true; 
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister f = new FormRegister();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
