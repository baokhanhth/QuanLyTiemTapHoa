using QuanLiTiemTapHoa;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmLoHang : Form
    {
        private readonly LoHangDAO _loHangDAO = new LoHangDAO();

        public frmLoHang()
        {
            InitializeComponent();
            this.Load += frmLoHang_Load;
            dgvLoHang.CellDoubleClick += dgvLoHang_CellDoubleClick; // Đổi sang DoubleClick
        }
        private void frmLoHang_Load(object sender, EventArgs e)
        {
            LoadLoHang();
        }

        private void LoadLoHang()
        {
            try
            {
                var danhSach = _loHangDAO.GetAll();
                dgvLoHang.DataSource = danhSach;
                FormatLoHangGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Lô Hàng","Thông báo");
            }
        }

        private void dgvLoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoHang.Rows[e.RowIndex];

                string maLo = row.Cells["MaLo"].Value.ToString();
                string maHang = row.Cells["MaHang"].Value.ToString();
                DateTime ngaySX = Convert.ToDateTime(row.Cells["NgaySX"].Value);
                DateTime hsd = Convert.ToDateTime(row.Cells["HSD"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuongDongGoi"].Value);

                frmThongTinLoHang frm = new frmThongTinLoHang(maLo, maHang, ngaySX, hsd, soLuong);
                frm.ShowDialog();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            try
            {
                var result = string.IsNullOrEmpty(keyword) ? _loHangDAO.GetAll() : _loHangDAO.Search(keyword);
                dgvLoHang.DataSource = result;
                FormatLoHangGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm","Thông báo");
            }
        }

        private void FormatLoHangGrid()
        {
            dgvLoHang.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 14, FontStyle.Bold);
            dgvLoHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoHang.DefaultCellStyle.Font = new Font("Open Sans", 12, FontStyle.Regular);
            dgvLoHang.RowTemplate.Height = 60;
            dgvLoHang.ColumnHeadersHeight = 60;

            if (dgvLoHang.Columns["MaLo"] != null)
            {
                dgvLoHang.Columns["MaLo"].HeaderText = "Mã Lô";
                dgvLoHang.Columns["MaLo"].Width = 150;
                dgvLoHang.Columns["MaLo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLoHang.Columns["MaHang"] != null)
            {
                dgvLoHang.Columns["MaHang"].HeaderText = "Mã Hàng";
                dgvLoHang.Columns["MaHang"].Width = 150;
                dgvLoHang.Columns["MaHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLoHang.Columns["NgaySX"] != null)
            {
                dgvLoHang.Columns["NgaySX"].HeaderText = "Ngày Sản Xuất";
                dgvLoHang.Columns["NgaySX"].Width = 180;
                dgvLoHang.Columns["NgaySX"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvLoHang.Columns["NgaySX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLoHang.Columns["NgaySX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLoHang.Columns["HSD"] != null)
            {
                dgvLoHang.Columns["HSD"].HeaderText = "Hạn Sử Dụng";
                dgvLoHang.Columns["HSD"].Width = 180;
                dgvLoHang.Columns["HSD"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvLoHang.Columns["HSD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLoHang.Columns["HSD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLoHang.Columns["SoLuongDongGoi"] != null)
            {
                dgvLoHang.Columns["SoLuongDongGoi"].HeaderText = "Số Lượng";
                dgvLoHang.Columns["SoLuongDongGoi"].Width = 180;
                dgvLoHang.Columns["SoLuongDongGoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            frmThemLoHang frm = new frmThemLoHang();
            frm.StartPosition = FormStartPosition.CenterScreen; // Đặt ở giữa màn hình trước khi mở
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoadLoHang(); // Reload lại danh sách sau khi thêm thành công
            }
        }

        private void dgvLoHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoHang.Rows[e.RowIndex];

                string maLo = row.Cells["MaLo"].Value.ToString();
                string maHang = row.Cells["MaHang"].Value.ToString();
                DateTime ngaySX = Convert.ToDateTime(row.Cells["NgaySX"].Value);
                DateTime hsd = Convert.ToDateTime(row.Cells["HSD"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuongDongGoi"].Value);

                frmThongTinLoHang frm = new frmThongTinLoHang(maLo, maHang, ngaySX, hsd, soLuong);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadLoHang(); // Nếu có cập nhật, reload lại danh sách
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
