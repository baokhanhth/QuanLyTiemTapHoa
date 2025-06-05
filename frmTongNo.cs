using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
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
    public partial class frmTongNo : Form
    {
        private readonly TongNoDAO _tongNoDAO = new TongNoDAO();

        public frmTongNo()
        {
            InitializeComponent();
            this.Load += frmTongNo_Load;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            tbtnThem.Click += tbtnThem_Click;

            dgvTongNo.CellDoubleClick += dgvTongNo_CellDoubleClick; // Thêm dòng này

        }

        private void frmTongNo_Load(object sender, EventArgs e)
        {
            LoadTongNo();
        }

        private void LoadTongNo()
        {
            try
            {
                var danhSach = _tongNoDAO.GetAll();

                if (danhSach == null || danhSach.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu Tổng Nợ trong CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvTongNo.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 14, FontStyle.Bold);
                dgvTongNo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvTongNo.DefaultCellStyle.Font = new Font("Open Sans", 12);

                // CHỈNH CHIỀU CAO
                dgvTongNo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                dgvTongNo.AllowUserToResizeRows = false;
                dgvTongNo.RowTemplate.Height = 50;
                dgvTongNo.ColumnHeadersHeight = 50;
                dgvTongNo.DataSource = danhSach;

                FormatTongNoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Tổng Nợ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            try
            {
                var result = string.IsNullOrEmpty(keyword)
                    ? _tongNoDAO.GetAll()
                    : _tongNoDAO.Search(keyword);

                dgvTongNo.DataSource = result;
                FormatTongNoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatTongNoGrid()
        {
            // Định dạng cột
            if (dgvTongNo.Columns["MaNo"] != null)
            {
                dgvTongNo.Columns["MaNo"].HeaderText = "Mã Nợ";
                dgvTongNo.Columns["MaNo"].Width = 120;
            }

            if (dgvTongNo.Columns["MaKH"] != null)
            {
                dgvTongNo.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
                dgvTongNo.Columns["MaKH"].Width = 100;
            }

            if (dgvTongNo.Columns["TongTienNo"] != null)
            {
                dgvTongNo.Columns["TongTienNo"].HeaderText = "Tổng Nợ";
                dgvTongNo.Columns["TongTienNo"].DefaultCellStyle.Format = "#,##0 VNĐ";
                dgvTongNo.Columns["TongTienNo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvTongNo.Columns["TongTienNo"].Width = 100;
            }

            if (dgvTongNo.Columns["TrangThai"] != null)
            {
                dgvTongNo.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvTongNo.Columns["TrangThai"].Width = 250;
            }
        }

        private void dgvTongNo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // tránh click header hoặc ngoài vùng dữ liệu

            // Cast về đối tượng TongNo (model)
            var tongNo = dgvTongNo.Rows[e.RowIndex].DataBoundItem as TongNo;

            if (tongNo == null) return;

            string maNo = tongNo.MaNo;

            var frm = new frmThongTinTongNo(maNo);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

            LoadTongNo();
        }
        private void tbtnThem_Click(object sender, EventArgs e)
        {
            frmThemTongNo frm = new frmThemTongNo();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)  // kiểm tra DialogResult
            {
                LoadTongNo();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Đóng ứng dụng
        }
    }
}
