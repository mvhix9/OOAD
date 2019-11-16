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

namespace uiBacSi
{
    public partial class BACSIFRM : Form
    {
        public BACSIFRM()
        {
            InitializeComponent();
        }
        #region Demochangepanel
        //static nhanvienfrm obj;
        //public static nhanvienfrm instance
        //{
        //    get
        //    {
        //        if (obj == null)
        //        {
        //            obj = new nhanvienfrm();
        //        }
        //        return obj;
        //    }
        //}

        //public panel contentpanel
        //{
        //    get { return contentpanel; }
        //    set { contentpanel = value; }
        //}
        #endregion
        private void NhanVienFRM_Load(object sender, EventArgs e)
        {
            this.Select();
            lblName.Text = UserCache.Name;
            lblRole.Text = UserCache.Role;
            btnIndex.selected = true;
            btnIndex_Click(sender, e);
            //obj = this;
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

        private void button1_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnQLBN);
            loadUserControl(contentPanel, new BacSiLapPhieuKhamUC());
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnLapDonThuoc);
            loadUserControl(contentPanel, new LapDonThuocUC());
        }

        private void btnLapPhieuKham_Click(object sender, EventArgs e)
        {
            moveActivePanel(btnLapPhieuKham);
            loadUserControl(contentPanel, new NhanVienLapPhieuKhamUC());
        }
    }
}
