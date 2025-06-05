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

namespace QuanLyTiemTapHoa
{
    public partial class frmNhapHang : Form
    {
        private readonly NhapHangDAO _nhapHangDAO = new NhapHangDAO();
        private BindingSource _bsNhapHang = new BindingSource();

        public frmNhapHang()
        {
            InitializeComponent();

            this.Load += frmNhapHang_Load;
            dgvNhapHang.CellClick += dgvNhapHang_CellClick;
            nhTimKiem.TextChanged += nhTimKiem_TextChanged;

            ConfigureGrid();  // Cấu hình lưới chỉ 1 lần
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string keyword = nhTimKiem.Text.Trim();
                var list = string.IsNullOrWhiteSpace(keyword)
                    ? _nhapHangDAO.GetAll()
                    : _nhapHangDAO.TimKiemHoaDonNhap(keyword);

                _bsNhapHang.DataSource = list;
                dgvNhapHang.DataSource = _bsNhapHang;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu nhập hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgvNhapHang.Columns.Clear();
            dgvNhapHang.AutoGenerateColumns = false;
            dgvNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhapHang.ReadOnly = true;
            dgvNhapHang.ColumnHeadersHeight = 50;

            // Set chiều cao hàng
            dgvNhapHang.RowTemplate.Height = 40;

            dgvNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaNH",
                HeaderText = "Mã NH",
                Width = 100,
                Name = "MaNH"
            });

            dgvNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NgayNhap",
                HeaderText = "Ngày nhập",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaNCC",
                HeaderText = "Mã NCC",
                Width = 100
            });

            dgvNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NH_TongCong",
                HeaderText = "Tổng cộng",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "#,##0.##" }
            });

            dgvNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CK_NH",
                HeaderText = "Chiết khấu",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "#,##0.##" }
            });

            dgvNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NH_ThanhToan",
                HeaderText = "Thanh toán",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "#,##0.##" }
            });

            DataGridViewImageColumn colDetail = new DataGridViewImageColumn
            {
                Name = "XemChiTiet",
                HeaderText = "Chi Tiết",
                Width = 30, 
                ImageLayout = DataGridViewImageCellLayout.Zoom, 
                ReadOnly = true,
                Image = Properties.Resources.eye
            };
            dgvNhapHang.Columns.Add(colDetail);
        }

        private void nhbtnThem_Click(object sender, EventArgs e)
        {
            using (var form = new frmThemNhapHang())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvNhapHang.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                var maNHObj = dgvNhapHang.Rows[e.RowIndex].Cells["MaNH"].Value;
                if (maNHObj != null)
                {
                    var maNH = maNHObj.ToString();
                    var chiTietForm = new frmChiTietNhapHang(maNH);
                    chiTietForm.ShowDialog();
                }
            }
        }

        private void nhTimKiem_TextChanged(object sender, EventArgs e)
        {
            // Nếu muốn, có thể debounce ở đây để tránh gọi LoadData liên tục khi gõ nhanh
            LoadData();
        }

        private void cExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Đóng form hẳn thay vì ẩn
        }
    }
}
