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
using Demo;

namespace uiBacSi
{
    public partial class BacSiFRM : Form
    {
        public BacSiFRM()
        {
            InitializeComponent();
        }

        private void BacSiFRM_Load(object sender, EventArgs e)
        {
            lblName.Text = UserCache.Name;
            int left = (lblName.Parent.Width - lblName.Width) / 2;
            centerLocation(lblName, left, 146);
            lblRole.Text = UserCache.Role;
            btnIndex.selected = true;
            btnIndex_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btnMaximize.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btnMaximize.Visible = true;
            btnRestore.Visible = false;
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

        public static void centerLocation(Control control, int x, int y)
        {
            control.Location = new Point(x, y);
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

        private void btnLapPhieuKham_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnLapPhieuKham);
            loadUserControl(contentPanel, new BacSiLapPhieuKhamUC());
        }

        private void btnLapDonThuoc_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnLapDonThuoc);
            loadUserControl(contentPanel, new LapDonThuocUC());
        }

        private void btnTuyChon_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnTuyChon);
            loadUserControl(contentPanel, new TuyChonUC());
        }
    }
}
