using Guna.UI2.WinForms;
using QuanLyTiemTapHoa.DAO;
using QuanLyTiemTapHoa.DAOs;
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
    public partial class fTrangChu : Form
    {
        private readonly BaoCaoDAO _baoCaoDAO = new BaoCaoDAO();
        private readonly TonKhoDAO _tonKhoDAO = new TonKhoDAO();
        private readonly ThongKeNoDAO _thongKeNoDAO = new ThongKeNoDAO();
        public fTrangChu()
        {
            InitializeComponent();
            // Đăng ký event Load (nếu cần)
            this.Load += frmTrangChu_Load;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }
        private void ResetButtonColors()
        {
            Color defaultColor = Color.AntiqueWhite;

            foreach (Control ctrl in panelMenu.Controls)
            {
                if (ctrl is Guna2GradientTileButton btn && btn.Name.StartsWith("tbtn"))
                {
                    btn.FillColor = defaultColor;
                    btn.FillColor2 = defaultColor;
                }
            }
        }

        private void tbtnDoanhThu_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            panelContent.Controls.Clear();
            tbtnDoanhThu.FillColor = Color.Bisque;
            tbtnDoanhThu.FillColor2 = Color.SandyBrown;
            frmBaoCaoDoanhThu frm = new frmBaoCaoDoanhThu();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void tbtnNo_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            panelContent.Controls.Clear();
            tbtnNo.FillColor = Color.Bisque;
            tbtnNo.FillColor2 = Color.SandyBrown;
            frmThongKeNo frm = new frmThongKeNo();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void tbtnTonKho_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            panelContent.Controls.Clear();
            tbtnTonKho.FillColor = Color.Bisque;
            tbtnTonKho.FillColor2 = Color.SandyBrown;
            fBaoCaoTonKho frm = new fBaoCaoTonKho();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
