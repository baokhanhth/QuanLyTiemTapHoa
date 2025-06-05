using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLiTiemTapHoa;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;

namespace QuanLyTiemTapHoa
{
    public partial class frmNCC : Form, IReloadNhaCungCap
    {
        private readonly NhaCungCapDAO _nccDAO = new NhaCungCapDAO();

        public frmNCC()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            this.Load += frmNCC_Load;
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            LoadNhaCungCap();
            dgvNCC.CellDoubleClick += dgvNCC_CellDoubleClick;
        }

        public void LoadNhaCungCap()
        {
            List<NhaCungCap> ds = _nccDAO.GetAll();
            dgvNCC.DataSource = ds;

            dgvNCC.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 14, FontStyle.Bold);
            dgvNCC.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNCC.DefaultCellStyle.Font = new Font("Open Sans", 12);
            dgvNCC.RowTemplate.Height = 60;
            dgvNCC.ColumnHeadersHeight = 60;

            if (dgvNCC.Columns.Contains("MaNCC"))
            {
                dgvNCC.Columns["MaNCC"].HeaderText = "Mã NCC";
                dgvNCC.Columns["MaNCC"].Width = 150;
                dgvNCC.Columns["MaNCC"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvNCC.Columns.Contains("TenNCC"))
            {
                dgvNCC.Columns["TenNCC"].HeaderText = "Tên Nhà Cung Cấp";
                dgvNCC.Columns["TenNCC"].Width = 250;
            }

            if (dgvNCC.Columns.Contains("DiaChi"))
            {
                dgvNCC.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvNCC.Columns["DiaChi"].Width = 300;
            }

            if (dgvNCC.Columns.Contains("SDT"))
            {
                dgvNCC.Columns["SDT"].HeaderText = "Số Điện Thoại";
                dgvNCC.Columns["SDT"].Width = 200;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvNCC.DataSource = _nccDAO.GetAll();
            }
            else
            {
                dgvNCC.DataSource = _nccDAO.Search(keyword);
            }
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            frmThemNCC frm = new frmThemNCC(this);
            frm.ShowDialog();
        }

        private void dgvNCC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var ncc = dgvNCC.Rows[e.RowIndex].DataBoundItem as NhaCungCap;
            if (ncc == null) return;

            var frm = new frmThongTinNCC(ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT);
            frm.ShowDialog();

            LoadNhaCungCap();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
