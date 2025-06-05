using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;  


namespace QuanLyTiemTapHoa
{
    public partial class frmThongTinKhachHang : Form
    {
        private readonly string _maKH;
        private readonly KhachHangDAO _khDAO = new KhachHangDAO();

        public frmThongTinKhachHang(string maKH, string tenKH, string diaChi, string sdt)
        {
            InitializeComponent();
            _maKH = maKH;

            txtMaKH.Text = maKH;
            txtTenKH.Text = tenKH;
            txtDiaChi.Text = diaChi;
            txtSDT.Text = sdt;

            Load += Frm_Load;
            btnClose.Click += (_, __) => Close();
            tbtnUpdate.Click += tbtnUpdate_Click;
            tbtnDelete.Click += tbtnDelete_Click;
        }

        private void Frm_Load(object? sender, EventArgs e)
        {
            var kh = _khDAO.GetById(txtMaKH.Text.Trim()); // Dựa vào SDT tìm lại để lấy thông tin mới nhất
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }

            txtMaKH.Text = kh.MaKH;
            txtTenKH.Text = kh.TenKH;
            txtSDT.Text = kh.SDT_KH;
            txtDiaChi.Text = kh.DiaChi;

            txtTenKH.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
        }

        private void tbtnUpdate_Click(object? sender, EventArgs e)
        {
            var kh = new KhachHang
            {
                MaKH = _maKH,
                TenKH = txtTenKH.Text.Trim(),
                SDT_KH = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            bool success = _khDAO.CapNhatKhachHang(kh);

            MessageBox.Show(success
                ? "Đã cập nhật khách hàng."
                : "Cập nhật không thành công.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbtnDelete_Click(object? sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa khách hàng này?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            bool success = _khDAO.XoaKhachHang(_maKH);

            MessageBox.Show(success
                ? "Đã xóa khách hàng."
                : "Xóa thất bại.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (success) Close();
        }
    }
}

