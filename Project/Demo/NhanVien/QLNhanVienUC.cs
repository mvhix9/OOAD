using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Demo.NhanVien
{
    public partial class QLNhanVienUC : UserControl
    {
        public QLNhanVienUC()
        {
            InitializeComponent();
        }

        private void QLNhanVienUC_Load(object sender, EventArgs e)
        {
            nhanVienBindingSource.DataSource = NhanVienServices.GetAll();
        }
    }
}
