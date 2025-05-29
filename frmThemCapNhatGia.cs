using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmThemCapNhatGia : Form
    {
        private CapNhatGiaDAO _capNhatGiaDao = new CapNhatGiaDAO();
        private frmCapNhatGia parentForm;
        public frmThemCapNhatGia(frmCapNhatGia parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tbtnThem_Click(object sender, EventArgs e)
        {
            string maHang = txtMaHang.Text.Trim();
            string maLo = txtMaLo.Text.Trim();
            string ngayBDStr = txtNgayBD.Text.Trim();
            string ngayKTStr = txtNgayKT.Text.Trim();
            string donGiaNhapStr = txtDonGiaNhap.Text.Trim();

            // Kiểm tra các trường có bị để trống không
            if (string.IsNullOrEmpty(maHang) ||
                string.IsNullOrEmpty(maLo) ||
                string.IsNullOrEmpty(ngayBDStr) ||
                string.IsNullOrEmpty(ngayKTStr) ||
                string.IsNullOrEmpty(donGiaNhapStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra và chuyển đổi ngày tháng
            if (!DateTime.TryParse(ngayBDStr, out DateTime ngayBD))
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!DateTime.TryParse(ngayKTStr, out DateTime ngayKT))
            {
                MessageBox.Show("Ngày kết thúc không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra và chuyển đổi đơn giá nhập
            if (!decimal.TryParse(donGiaNhapStr, out decimal donGiaNhap))
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool result = _capNhatGiaDao.ThemGiaNhapMoi(maHang, maLo, ngayBD, ngayKT, donGiaNhap);

            if (result)
            {
                MessageBox.Show("Đã thêm giá nhập mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                parentForm?.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm giá nhập mới không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
