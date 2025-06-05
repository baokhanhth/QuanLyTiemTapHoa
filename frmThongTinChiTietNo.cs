using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Helpers;
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
    public partial class frmThongTinChiTietNo : Form
    {
        private readonly string _maNo;
        private readonly ChiTietNoDAO _dao = new ChiTietNoDAO();
        private ChiTietNo _currentChiTietNo;

        public frmThongTinChiTietNo(string maNo)
        {
            _maNo = maNo;
            InitializeComponent();

            Load += Frm_Load;
            btnClose.Click += (_, __) => Close();
            tbtnUpdate.Click += tbtnUpdate_Click;
            tbtnDelete.Click += tbtnDelete_Click;
        }

        private void Frm_Load(object? sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu chi tiết nợ theo mã nợ (cần xác định mã hóa đơn, giả sử lấy cái đầu tiên hoặc lấy theo maNo + maBH)
                // Nếu bạn chỉ có MaNo mà không có MaBH, bạn có thể lấy danh sách hoặc sửa hàm GetById để lấy theo MaNo
                // Ở đây giả sử lấy cái đầu tiên trong danh sách có mã nợ đó:

                var list = _dao.Search(_maNo);
                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu với mã nợ: " + _maNo);
                    return;
                }

                _currentChiTietNo = list[0];

                txtMaNo.Text = _currentChiTietNo.MaNo;
                txtMaBH.Text = _currentChiTietNo.MaBH;
                txtSoTienConNo.Text = _currentChiTietNo.SoTienConNo.ToString();

                txtMaNo.ReadOnly = true;
                txtMaBH.ReadOnly = true;
                txtSoTienConNo.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private void tbtnUpdate_Click(object? sender, EventArgs e)
        {
            if (_currentChiTietNo == null)
            {
                MessageBox.Show("Không có dữ liệu để cập nhật.");
                return;
            }

            if (!decimal.TryParse(txtSoTienConNo.Text.Trim(), out var soTien))
            {
                MessageBox.Show("Số tiền còn nợ không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentChiTietNo.SoTienConNo = soTien;

            try
            {
                _dao.Update(_currentChiTietNo);
                MessageBox.Show("Đã cập nhật chi tiết nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtnDelete_Click(object? sender, EventArgs e)
        {
            if (_currentChiTietNo == null)
            {
                MessageBox.Show("Không có dữ liệu để xóa.");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa chi tiết nợ này?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                _dao.Delete(_currentChiTietNo.MaNo, _currentChiTietNo.MaBH);
                MessageBox.Show("Đã xóa chi tiết nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
