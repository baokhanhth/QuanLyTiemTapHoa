using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;

namespace QuanLyTiemTapHoa
{
    public partial class frmThemLoHang : Form
    {
        public frmThemLoHang()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (!int.TryParse(txtSLDG.Text.Trim(), out int soLuong))
            {
                MessageBox.Show("Số lượng đóng gói không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaLo.Text) || string.IsNullOrWhiteSpace(txtMaHang.Text))
            {
                MessageBox.Show("Mã Lô và Mã Hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pkNgaySX.Value.Date > pkHSD.Value.Date)
            {
                MessageBox.Show("Ngày sản xuất phải nhỏ hơn hoặc bằng Hạn sử dụng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo đối tượng LoHang
            var loHang = new LoHang
            {
                MaLo = txtMaLo.Text.Trim(),
                MaHang = txtMaHang.Text.Trim(),
                NgaySX = pkNgaySX.Value.Date,
                HSD = pkHSD.Value.Date,
                SoLuongDongGoi = soLuong
            };

            // Gọi DAO để thêm
            var dao = new LoHangDAO();
            try
            {
                bool result = dao.Insert(loHang);
                if (result)
                {
                    MessageBox.Show("Đã thêm lô hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm lô hàng không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lô hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
