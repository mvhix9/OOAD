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
using DAO.UnitOfWork;
using Common;
using Demo.uiNhanVien;
using uiNhanVien;
using uiBacSi;
using uiQuanTriVien;

namespace Demo
{
    public partial class MainFRM : Form
    {
        NhanVienServices nhanVienServices = new NhanVienServices(new UnitOfWork(new QuanLyPhongMachEntities()));
        public MainFRM()
        {
            InitializeComponent();
            txtUsername.Focus();
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
        private bool validInfo()
        {
            bool check = true;
            if (txtUsername.Text == "TÊN ĐĂNG NHẬP" || txtPassword.Text == "MẬT KHẨU")
            {
                msgError("Vui lòng nhập đầy đủ thông tin đăng nhập");
                check = false;
            }
            else if (!ValidateInput.isAlphanumeric(txtUsername))
            {
                msgError("Tên đăng nhập không hợp lệ");
                txtUsername.Focus();
                check = false;
            }
            else if (!ValidateInput.isPassword(txtPassword))
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
            txtPassword.Select(0, 0);
            lblError.Visible = false;
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (validInfo())
            {
                NhanVien nv = nhanVienServices.GetNhanVien(txtUsername.Text, txtPassword.Text);
                if (nv == null)
                {
                    msgError("Tên đăng nhập hoặc mật khẩu không đúng");
                    txtUsername.Focus();
                }
                else if(nv.TrangThai == 0)
                {
                    msgError("Tài khoản đã bị khóa");
                    txtUsername.Focus();
                }
                else
                {
                    switch (nv.MaVaiTro)
                    {
                        case 1:
                            NhanVienFRM nvFRM = new NhanVienFRM();
                            nvFRM.Show();
                            nvFRM.FormClosed += formLogOut;
                            this.Hide();
                            break;
                        case 2:
                            BacSiFRM bsFRM = new BacSiFRM();
                            bsFRM.Show();
                            bsFRM.FormClosed += formLogOut;
                            this.Hide();
                            break;
                        case 3:
                            QuanTriVienFRM qtvFRM = new QuanTriVienFRM();
                            qtvFRM.Show();
                            qtvFRM.FormClosed += formLogOut;
                            this.Hide();
                            break;
                    }
                }
            }
        }
    }
}
