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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            labelError.Visible = false;
        }
        public void ResetForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                this.Hide();
                frmKhachHang khachHangForm = new frmKhachHang();
                khachHangForm.Show();
        }

    }
}
