using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using static QuanLyTiemTapHoa.frmThemKhachHang;

namespace QuanLyTiemTapHoa
{
    public partial class frmKhachHang : Form, IReloadKhachHang
    {
        private readonly KhachHangDAO _khachHangDAO = new KhachHangDAO();
        public frmKhachHang()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.Load += frmKhachHang_Load;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            dgvKhachHang.CellDoubleClick += dgvKhachHang_CellDoubleClick;
        }

        public void LoadKhachHang()
        {
            List<KhachHang> ds = _khachHangDAO.GetAll();
            dgvKhachHang.DataSource = ds;

            // Cấu hình hiển thị
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 14, FontStyle.Bold);
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvKhachHang.DefaultCellStyle.Font = new Font("Open Sans", 12, FontStyle.Regular);

            dgvKhachHang.RowTemplate.Height = 60;
            dgvKhachHang.ColumnHeadersHeight = 60;

            // Cấu hình lại tên cột, kích thước
            if (dgvKhachHang.Columns.Contains("MaKH"))
            {
                dgvKhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
                dgvKhachHang.Columns["MaKH"].Width = 150;
                dgvKhachHang.Columns["MaKH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvKhachHang.Columns.Contains("TenKH"))
            {
                dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
                dgvKhachHang.Columns["TenKH"].Width = 250;
            }

            if (dgvKhachHang.Columns.Contains("DiaChi"))
            {
                dgvKhachHang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvKhachHang.Columns["DiaChi"].Width = 450;
            }

            if (dgvKhachHang.Columns.Contains("SDT_KH"))
            {
                dgvKhachHang.Columns["SDT_KH"].HeaderText = "Số Điện Thoại";
                dgvKhachHang.Columns["SDT_KH"].Width = 250;
            }
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvKhachHang.DataSource = _khachHangDAO.GetAll();
            }
            else
            {
                dgvKhachHang.DataSource = _khachHangDAO.Search(keyword);
            }
        }
        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var kh = dgvKhachHang.Rows[e.RowIndex].DataBoundItem as KhachHang;

            if (kh == null) return;

            var frm = new frmThongTinKhachHang(kh.MaKH, kh.TenKH, kh.DiaChi, kh.SDT_KH);
            frm.ShowDialog();

            LoadKhachHang();
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            frmThemKhachHang themForm = new frmThemKhachHang(this);
            themForm.ShowDialog();
        }
    }
}

