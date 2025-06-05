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
    public partial class frmChiTietNhapHang : Form
    {
        private readonly string maNH;
        private BindingList<ChiTietNhapHang> _listChiTietNhapHang;
        private BindingSource _bsChiTietNhapHang;
        private readonly ChiTietNhapHangDAO _chiTietNhapHangDao = new ChiTietNhapHangDAO();

        public frmChiTietNhapHang(string maNH)
        {
            InitializeComponent();
            this.maNH = maNH;
            this.Load += frmChiTietNhapHang_Load;
        }

        private void frmChiTietNhapHang_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            LoadData();
        }

        public void LoadData()
        {
            try
            {
                var rawList = _chiTietNhapHangDao.GetByMaNH(maNH);

                _listChiTietNhapHang = new BindingList<ChiTietNhapHang>(rawList);
                _bsChiTietNhapHang = new BindingSource { DataSource = _listChiTietNhapHang };
                dgvChiTietNhapHang.DataSource = _bsChiTietNhapHang;

                ConfigureGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgvChiTietNhapHang.Columns.Clear();
            dgvChiTietNhapHang.ColumnHeadersHeight = 60;
            dgvChiTietNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietNhapHang.MultiSelect = false;
            dgvChiTietNhapHang.ReadOnly = true;
            dgvChiTietNhapHang.AutoGenerateColumns = false;
            dgvChiTietNhapHang.RowTemplate.Height = 60;

            dgvChiTietNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaNH",
                HeaderText = "Mã Nhập Hàng",
                Name = "MaNH",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvChiTietNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaLo",
                HeaderText = "Mã Lô",
                Name = "MaLo",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvChiTietNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NgayNhap",
                HeaderText = "Ngày Nhập",
                Name = "NgayNhap",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvChiTietNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLuongNhap",
                HeaderText = "Số Lượng Nhập",
                Name = "SoLuongNhap",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dgvChiTietNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "GiaNhap",
                HeaderText = "Giá Nhập",
                Name = "GiaNhap",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "#,##0.##",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvChiTietNhapHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NH_ThanhTien",
                HeaderText = "Thành Tiền",
                Name = "NH_ThanhTien",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "#,##0.##",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvChiTietNhapHang.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 10, FontStyle.Bold);
            dgvChiTietNhapHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietNhapHang.DefaultCellStyle.Font = new Font("Open Sans", 10, FontStyle.Regular);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
