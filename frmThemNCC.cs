using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    // Interface để form gọi có thể reload dữ liệu NCC sau khi thêm thành công
    public interface IReloadNhaCungCap
    {
        void LoadNhaCungCap();
    }

    public partial class frmThemNCC : Form
    {
        private readonly IReloadNhaCungCap _parentForm;
        private readonly NhaCungCapDAO _nccDAO = new NhaCungCapDAO();

        // Thêm tham số sdtMacDinh để truyền SDT từ form gọi (ví dụ: frmThemNhapHang)
        public frmThemNCC(IReloadNhaCungCap parent = null, string sdtMacDinh = "")
        {
            InitializeComponent();
            _parentForm = parent;

            if (!string.IsNullOrEmpty(sdtMacDinh))
            {
                txtSDT.Text = sdtMacDinh;
                txtSDT.ReadOnly = true; // Nếu muốn cho phép sửa thì set false
            }
        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            var nccMoi = new NhaCungCap
            {
                MaNCC = txtMaNCC.Text.Trim(),
                TenNCC = txtTenNCC.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim()
            };

            try
            {
                bool success = _nccDAO.ThemNhaCungCap(nccMoi);

                if (success)
                {
                    MessageBox.Show("Đã thêm nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _parentForm?.LoadNhaCungCap(); // gọi reload dữ liệu

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
