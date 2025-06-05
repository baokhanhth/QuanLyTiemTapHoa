using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmThemHangHoa : Form
    {
        private readonly HangHoaDAO _hangHoaDao = new HangHoaDAO();
        private readonly frmHangHoa _parentForm;

        public frmThemHangHoa(frmHangHoa parent = null)
        {
            InitializeComponent();
            _parentForm = parent;
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text.Trim();
            string tenHang = txtTenHang.Text.Trim();
            string donVT = txtDonVT.Text.Trim(); // Có thể để trống
            string soLuongStr = txtSoLuong.Text.Trim();

            // Kiểm tra bắt buộc
            if (string.IsNullOrEmpty(maHang) || string.IsNullOrEmpty(tenHang) || string.IsNullOrEmpty(soLuongStr))
            {
                MessageBox.Show("Mã hàng, tên hàng và số lượng tồn không được để trống.",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra số lượng tồn là số nguyên không âm
            if (!int.TryParse(soLuongStr, out int soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn phải là số nguyên không âm.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra trùng mã hàng
            if (_hangHoaDao.Exists(maHang))
            {
                MessageBox.Show("Mã hàng đã tồn tại.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng hàng hóa
            var hangHoa = new HangHoa
            {
                MaHang = maHang,
                TenHang = tenHang,
                DonVT = string.IsNullOrWhiteSpace(donVT) ? null : donVT,
                SoLuongTon = soLuongTon
            };

            // Thêm vào CSDL
            try
            {
                _hangHoaDao.Insert(hangHoa);
                MessageBox.Show("Thêm hàng hóa thành công.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Gọi LoadData từ form cha nếu có
                _parentForm?.LoadData();

                this.Close(); // Đóng form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hàng hóa",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
