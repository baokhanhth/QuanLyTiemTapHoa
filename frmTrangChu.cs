using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.frmLoginInstance.ResetForm();
            Program.frmLoginInstance.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang khachHangForm = new frmKhachHang();
            khachHangForm.Show();
        }
    }
}
