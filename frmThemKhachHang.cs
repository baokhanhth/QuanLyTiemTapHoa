using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;

namespace QuanLyTiemTapHoa
{
    // Interface đặt ngoài class để các form khác cùng implement được
    public interface IReloadKhachHang
    {
        void LoadKhachHang();
    }

    public partial class frmThemKhachHang : Form
    {
        private readonly IReloadKhachHang _parentForm;
        private readonly KhachHangDAO _khachHangDAO = new KhachHangDAO();

        public frmThemKhachHang(IReloadKhachHang parent = null, string sdtMacDinh = "")
        {
            InitializeComponent();
            _parentForm = parent;

            if (!string.IsNullOrEmpty(sdtMacDinh))
            {
                txtSDT.Text = sdtMacDinh;
                txtSDT.ReadOnly = true; // Nếu muốn cho phép sửa thì false
            }
        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            var khachHangMoi = new KhachHang()
            {
                MaKH = txtMaKH.Text.Trim(),
                TenKH = txtTenKH.Text.Trim(),
                SDT_KH = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            try
            {
                bool success = _khachHangDAO.ThemKhachHang(khachHangMoi);

                if (success)
                {
                    MessageBox.Show("Đã thêm khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _parentForm?.LoadKhachHang();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
