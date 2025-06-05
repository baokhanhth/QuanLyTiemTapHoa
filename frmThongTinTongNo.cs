using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmThongTinTongNo : Form
    {
        private readonly string _maNo;
        private readonly TongNoDAO _dao = new TongNoDAO();

        public frmThongTinTongNo(string maNo)
        {
            InitializeComponent();
            _maNo = maNo;

            Load += Frm_Load;
            btnClose.Click += (_, __) => Close();
            tbtnUpdate.Click += tbtnUpdate_Click;
            tbtnDelete.Click += tbtnDelete_Click;
        }

        private void Frm_Load(object? sender, EventArgs e)
        {
            try
            {
                var danhSach = _dao.GetAll();
                var tongNo = danhSach.Find(x => x.MaNo == _maNo);

                if (tongNo == null)
                {
                    MessageBox.Show("Không tìm thấy dữ liệu với mã nợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    return;
                }

                // Gán dữ liệu lên form
                txtMaNo.Text = tongNo.MaNo;
                mNgayTra.Text = tongNo.MaKH;
                txtTongNo.Text = tongNo.TongTienNo.ToString("N0"); // Format tiền với dấu phân cách nghìn
                txtTrangThai.Text = tongNo.TrangThai;

                txtMaNo.ReadOnly = true;

                mNgayTra.ReadOnly = false;
                txtTongNo.ReadOnly = false;
                txtTrangThai.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtnUpdate_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(txtTongNo.Text.Trim(), out var soTien))
            {
                MessageBox.Show("Tổng nợ không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tongNo = new TongNo
            {
                MaNo = txtMaNo.Text.Trim(),
                MaKH = mNgayTra.Text.Trim(),
                TongTienNo = soTien,
                TrangThai = txtTrangThai.Text.Trim()
            };

            try
            {
                bool success = _dao.Update(tongNo);
                if (success)
                {
                    MessageBox.Show("Đã cập nhật tổng nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật không thành công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtnDelete_Click(object? sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa tổng nợ này?",
                "Xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                bool success = _dao.Delete(_maNo);
                if (success)
                {
                    MessageBox.Show("Đã xóa tổng nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
