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
    public partial class frmChiTietHoaDonBan : Form
    {
        private string _maBH;
        private BindingList<ChiTietBanHang> _listChiTietBanHang;
        private BindingSource _bsChiTietBanHang;
        private ChiTietBanHangDAO _chiTietBanHangDao = new ChiTietBanHangDAO();
        private string maBH;
        public frmChiTietHoaDonBan(string maBH)
        {
            InitializeComponent();
            this.maBH = maBH;
            this.Load += frmChiTietHoaDonBan_Load;
        }
        private void frmChiTietHoaDonBan_Load(object sender, EventArgs e)
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
                var rawList = _chiTietBanHangDao.GetAll()
                                     .Where(x => x.MaBH == this.maBH)
                                     .ToList();

                // Gán TenHang dựa theo MaHang
                var allHangHoa = HangHoaDAO.Instance.LayDanhSachHangHoa();
                foreach (var item in rawList)
                {
                    var hang = allHangHoa.FirstOrDefault(h => h.MaHang == item.MaHang);
                    if (hang != null)
                    {
                        item.TenHang = hang.TenHang;
                    }
                }

                _listChiTietBanHang = new BindingList<ChiTietBanHang>(rawList);
                _bsChiTietBanHang = new BindingSource { DataSource = _listChiTietBanHang };
                dgvChiTietBanHang.DataSource = _bsChiTietBanHang;

                ConfigureGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureGrid()
        {
            dgvChiTietBanHang.Columns.Clear();
            dgvChiTietBanHang.ColumnHeadersHeight = 60;
            dgvChiTietBanHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietBanHang.MultiSelect = false;
            dgvChiTietBanHang.ReadOnly = true;
            dgvChiTietBanHang.AutoGenerateColumns = false;
            dgvChiTietBanHang.RowTemplate.Height = 60;

            dgvChiTietBanHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaBH",
                HeaderText = "Mã Bán Hàng",
                Name = "MaBH",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvChiTietBanHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaHang",
                HeaderText = "Mã Hàng",
                Name = "MaHang",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvChiTietBanHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLuongBan",
                HeaderText = "Số Lượng Bán",
                Name = "SoLuongBan",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvChiTietBanHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DonGB_maHoa",
                HeaderText = "Đơn Giá Bán",
                Name = "DonGB_maHoa",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "#,##0.##",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvChiTietBanHang.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BH_ThanhTien_MaHoa",
                HeaderText = "Thành Tiền",
                Name = "BH_ThanhTien_MaHoa",
                Width = 140,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "#,##0.##",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvChiTietBanHang.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 10, FontStyle.Bold);
            dgvChiTietBanHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietBanHang.DefaultCellStyle.Font = new Font("Open Sans", 10, FontStyle.Regular);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            var frmThem = new frmThemCTBH(maBH);
            frmThem.Location = new Point(700, 100);
            frmThem.FormClosed += (s, args) => LoadData(); // Reload dữ liệu khi form thêm đóng
            frmThem.ShowDialog();
        }
    }
}
