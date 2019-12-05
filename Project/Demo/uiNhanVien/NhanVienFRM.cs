using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using Demo.uiNhanVien;
using uiNhanVien;
using Demo;

namespace uiNhanVien
{
    public partial class NhanVienFRM : Form
    {
        public NhanVienFRM()
        {
            InitializeComponent();
        }

        public void NhanVienFRM_Load(object sender, EventArgs e)
        {
            lblName.Text = UserCache.Name;
            int left = (lblName.Parent.Width - lblName.Width) / 2;
            //centerLocation(lblName, left, 146);
            lblName.Left = left;
            btnIndex.selected = true;
            btnIndex_Click(sender, e);
        }

        public static void centerLocation(Control control, int x, int y)
        {
            control.Location = new Point(x, y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // custom styles
        private void moveActivePanel(Control button)
        {
            activePanel.Height = button.Height;
            activePanel.Top = button.Top;
            activePanel.Visible = false;
            if (!activePanel.Visible)
                bunifuTransition1.ShowSync(activePanel);
        }

        // load user control into panel
        private void loadUserControl(Panel panel, Control control)
        {
            panel.Controls.Clear();
            panel.Controls.Add(control);
        }

        private void btnIndex_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnIndex);
            loadUserControl(contentPanel, new IndexUC());
        }

        private void btnQLBenhNhan_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnQLBenhNhan);
            loadUserControl(contentPanel, new QLBenhNhanUC());
        }

        private void btnQLThuoc_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnQLThuoc);
            loadUserControl(contentPanel, new QLThuocUC());
        }

        private void btnLapPhieuKham_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnLapPhieuKham);
            loadUserControl(contentPanel, new NhanVienLapPhieuKhamUC());
        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnTuyChon);
            loadUserControl(contentPanel, new TuyChonUC());
        }

        private void btnQLBenh_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnQLBenh);
            loadUserControl(contentPanel, new QLBenhUC());
        }
    }
}
