using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
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

namespace QuanLyTiemTapHoa
{
    public partial class frmThongTinNCC : Form
    {
        private readonly string _maNCC;
        private readonly NhaCungCapDAO _nccDAO = new NhaCungCapDAO();
        public frmThongTinNCC(string maNCC, string tenNCC, string diaChi, string sdt)
        {
            InitializeComponent();
            _maNCC = maNCC;

            txtMaNCC.Text = maNCC;
            txtTenNCC.Text = tenNCC;
            txtDiaChi.Text = diaChi;
            txtSDT.Text = sdt;

            Load += frmThongTinNCC_Load;
        }
        private void frmThongTinNCC_Load(object? sender, EventArgs e)
        {
            var ncc = _nccDAO.GetById(txtMaNCC.Text.Trim()); // Tìm theo SDT để lấy thông tin mới nhất

            if (ncc == null)
            {
                MessageBox.Show("Không tìm thấy nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            txtMaNCC.Text = ncc.MaNCC;
            txtTenNCC.Text = ncc.TenNCC;
            txtSDT.Text = ncc.SDT;
            txtDiaChi.Text = ncc.DiaChi;

            txtTenNCC.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
        }
        private void tbtnUpdate_Click(object sender, EventArgs e)
        {
            var ncc = new NhaCungCap
            {
                MaNCC = _maNCC,
                TenNCC = txtTenNCC.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            bool success = _nccDAO.CapNhatNhaCungCap(ncc);

            MessageBox.Show(success
                ? "Đã cập nhật nhà cung cấp."
                : "Cập nhật không thành công.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa nhà cung cấp này?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            bool success = _nccDAO.XoaNhaCungCap(_maNCC);

            MessageBox.Show(success
                ? "Đã xóa nhà cung cấp."
                : "Xóa thất bại.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (success) Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
