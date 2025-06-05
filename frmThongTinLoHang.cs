using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.Windows.Forms;

namespace QuanLiTiemTapHoa
{
    public partial class frmThongTinLoHang : Form
    {
        public frmThongTinLoHang(string maLo, string maHang, DateTime ngaySX, DateTime hsd, int soLuong)
        {
            InitializeComponent();

            txtMaLo.Text = maLo;
            txtMaHang.Text = maHang;
            txtNgaySX.Value = ngaySX;
            txtHSD.Value = hsd;
            txtSLDG.Text = soLuong.ToString();
        }

        private void tbtnUpdate_Click(object sender, EventArgs e)
        {
            string maLo = txtMaLo.Text.Trim();
            string maHang = txtMaHang.Text.Trim();
            DateTime ngaySX = txtNgaySX.Value.Date;
            DateTime hsd = txtHSD.Value.Date;

            if (!int.TryParse(txtSLDG.Text.Trim(), out int soLuong))
            {
                MessageBox.Show("Giá trị Số lượng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var loHang = new LoHang
            {
                MaLo = maLo,
                MaHang = maHang,
                NgaySX = ngaySX,
                HSD = hsd,
                SoLuongDongGoi = soLuong
            };

            var dao = new LoHangDAO();
            bool result = dao.Update(loHang);

            if (result)
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Không tìm thấy bản ghi cần cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tbtnDelete_Click(object sender, EventArgs e)
        {
            string maLo = txtMaLo.Text.Trim();

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa lô hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes)
                return;

            var dao = new LoHangDAO();
            bool result = dao.Delete(maLo);

            if (result)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy bản ghi cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
