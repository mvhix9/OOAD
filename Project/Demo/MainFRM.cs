using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Demo.uiNhanVien;

namespace Demo
{
    public partial class MainFRM : Form
    {
        public MainFRM()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // custom styles
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "TÊN ĐĂNG NHẬP")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "TÊN ĐĂNG NHẬP";
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "MẬT KHẨU")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "MẬT KHẨU";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }

        // error message show
        private void centerLocation(Control control, int x, int y)
        {
            control.Location = new Point(x, y);
        }

        private void msgError(string msg)
        {
            lblError.Text = "     " + msg;
            int left = (lblError.Parent.Width - lblError.Width) / 2;
            centerLocation(lblError, left, 145);
            lblError.Visible = true;
        }

        // validate username and password
        private bool isUsername(Control control)
        {
            bool match = Regex.IsMatch(control.Text, "^[a-zA-Z0-9]+$");
            return match;
        }

        private bool isPassword(Control control)
        {
            bool match = control.Text.Length >= 6;
            return match;
        }

        private bool validInfo()
        {
            bool check = true;
            if (txtUsername.Text == "TÊN ĐĂNG NHẬP" || txtPassword.Text == "MẬT KHẨU")
            {
                msgError("Vui lòng nhập đầy đủ thông tin đăng nhập");
                check = false;
            }
            else if (!isUsername(txtUsername))
            {
                msgError("Tên đăng nhập không hợp lệ");
                txtUsername.Focus();
                check = false;
            }
            else if (!isPassword(txtPassword))
            {
                msgError("Mật khẩu phải từ 6 ký tự trở lên");
                txtPassword.Focus();
                check = false;
            }
            return check;
        }

        // click btnLogout in child form
        private void formLogOut(object sender, FormClosedEventArgs e)
        {
            txtUsername.Text = "TÊN ĐĂNG NHẬP";
            txtPassword.Text = "MẬT KHẨU";
            txtPassword.UseSystemPasswordChar = false;
            lblError.Visible = false;
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validInfo())
            {
                //User user = UserServices.GetUser(txtUsername.Text, txtPassword.Text);
                //if (user == null)
                //{
                //    msgError("Tên đăng nhập hoặc mật khẩu không đúng");
                //    txtUsername.Focus();
                //}
                //else
                //{
                //    switch (user.RoleId)
                //    {
                //        case 1:
                //            MessageBox.Show("Chào mừng quản trị viên");
                //            break;
                //        case 2:
                //            NhanVienFRM frm = new NhanVienFRM();
                //            frm.Show();
                //            frm.FormClosed += formLogOut;
                //            this.Hide();
                //            break;
                //        case 3:
                //            MessageBox.Show("Chào mừng bác sĩ");
                //            break;
                //    }
                //}
            }
        }
    }
}
