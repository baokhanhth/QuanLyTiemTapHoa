using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmMain : Form
    {
        private Form currentFormChild;

        public frmMain(string displayName)
        {
            InitializeComponent();
            txtUser.Text = displayName;
            txtUser.ReadOnly = true;
            this.Load += frmMain_Load;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close(); // Đóng form cũ
            }

            currentFormChild = childForm;
            currentFormChild.TopLevel = false;
            currentFormChild.FormBorderStyle = FormBorderStyle.None;
            currentFormChild.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();
            panelContent.Controls.Add(currentFormChild);
            currentFormChild.Show();
        }
        private void ResetButtonColors()
        {
            Color defaultColor = Color.FromArgb(232, 249, 255);

            foreach (Control ctrl in panelSidebar.Controls) // hoặc panelMenu nếu bạn đặt ở đó
            {
                if (ctrl is Guna2GradientTileButton btn && btn.Name.StartsWith("tbtn"))
                {
                    btn.FillColor = defaultColor;
                    btn.FillColor2 = defaultColor;
                }
            }
        }

        private void tbtnTongNo_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnTongNo.FillColor = Color.FromArgb(196, 217, 255);
            tbtnTongNo.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmTongNo());
        }

        private void tbtnNhaCungCap_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnNhaCungCap.FillColor = Color.FromArgb(196, 217, 255);
            tbtnNhaCungCap.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmNCC());
        }

        private void tbtnKhachHang_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnKhachHang.FillColor = Color.FromArgb(196, 217, 255);
            tbtnKhachHang.FillColor2 = Color.FromArgb(196, 217, 255);
            OpenChildForm(new frmKhachHang());
        }

        private void tbtnHoaDonBan_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnHoaDonBan.FillColor = Color.FromArgb(196, 217, 255);
            tbtnHoaDonBan.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmHoaDonBan());
        }

        private void tbtnLoHang_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnLoHang.FillColor = Color.FromArgb(196, 217, 255);
            tbtnLoHang.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmLoHang());
        }

        private void tbtnNhapHang_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnNhapHang.FillColor = Color.FromArgb(196, 217, 255);
            tbtnNhapHang.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmNhapHang());
        }

        private void tbtnHangHoa_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnHangHoa.FillColor = Color.FromArgb(196, 217, 255);
            tbtnHangHoa.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmHangHoa());
        }

        private void tbtnLichSuTraNo_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnLichSuTraNo.FillColor = Color.FromArgb(196, 217, 255);
            tbtnLichSuTraNo.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmLichSuTraNo());
        }

        private void tbtnChiTietNo_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnChiTietNo.FillColor = Color.FromArgb(196, 217, 255);
            tbtnChiTietNo.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmChiTietNo());
        }

        private void tbtnTrangChu_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnTrangChu.FillColor = Color.FromArgb(196, 217, 255);
            tbtnTrangChu.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new fTrangChu());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            // Mở lại frmLogin
            var frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            cLogout.Show(txtUser, new Point(0, txtUser.Height)); // hiện menu ngay dưới control txtUser
        }

        private void tRANGCHỦToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnTrangChu.FillColor = Color.FromArgb(196, 217, 255);
            tbtnTrangChu.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new fTrangChu());
        }

        private void NCCStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnNhaCungCap.FillColor = Color.FromArgb(196, 217, 255);
            tbtnNhaCungCap.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmNCC());
        }

        private void cTNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnChiTietNo.FillColor = Color.FromArgb(196, 217, 255);
            tbtnChiTietNo.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmChiTietNo());
        }

        private void hHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnHangHoa.FillColor = Color.FromArgb(196, 217, 255);
            tbtnHangHoa.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmHangHoa());
        }

        private void kHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnKhachHang.FillColor = Color.FromArgb(196, 217, 255);
            tbtnKhachHang.FillColor2 = Color.FromArgb(196, 217, 255);
            OpenChildForm(new frmKhachHang());
        }

        private void lHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnLoHang.FillColor = Color.FromArgb(196, 217, 255);
            tbtnLoHang.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmLoHang());
        }

        private void nHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnNhapHang.FillColor = Color.FromArgb(196, 217, 255);
            tbtnNhapHang.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmNhapHang());
        }

        private void hDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnHoaDonBan.FillColor = Color.FromArgb(196, 217, 255);
            tbtnHoaDonBan.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmHoaDonBan());
        }

        private void tNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnTongNo.FillColor = Color.FromArgb(196, 217, 255);
            tbtnTongNo.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmTongNo());
        }

        private void lSTNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetButtonColors();

            tbtnLichSuTraNo.FillColor = Color.FromArgb(196, 217, 255);
            tbtnLichSuTraNo.FillColor2 = Color.FromArgb(196, 217, 255);

            OpenChildForm(new frmLichSuTraNo());
        }
    }
}
