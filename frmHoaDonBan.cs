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
    public partial class frmHoaDonBan : Form
    {
        private readonly HoaDonBanDAO _hoaDonBanDAO = new HoaDonBanDAO();
        private BindingSource _bsHoaDonBan;
        private BindingList<HoaDonBan> _listHoaDonBan;
        private string _searchKeyword = "";
        public string MaKH { get; set; }

        public frmHoaDonBan()
        {
            InitializeComponent();
            this.Load += frmHoaDonBan_Load;
        }
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                var list = _hoaDonBanDAO.GetAll();
                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhập hàng nào.");
                }

                _listHoaDonBan = new BindingList<HoaDonBan>(list);
                _bsHoaDonBan = new BindingSource { DataSource = _listHoaDonBan };

                dgvHoaDonBan.DataSource = null; // reset trước
                ConfigureGrid();
                dgvHoaDonBan.DataSource = _bsHoaDonBan;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu" , "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgvHoaDonBan.Columns.Clear();

            dgvHoaDonBan.AllowUserToAddRows = false; // CHỈNH DÒNG NÀY
            dgvHoaDonBan.AllowUserToDeleteRows = false;
            dgvHoaDonBan.ReadOnly = true; // KHÔNG CẦN CHỈNH SỬA NÊN ĐỂ TRUE
            dgvHoaDonBan.AutoGenerateColumns = false;

            dgvHoaDonBan.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaBH",
                HeaderText = "Mã Bán Hàng",
                Name = "MaBH",
                Width = 100
            });

            dgvHoaDonBan.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaKH",
                HeaderText = "Mã Khách Hàng",
                Name = "MaKH",
                Width = 100
            });


            dgvHoaDonBan.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BH_TongCong",
                HeaderText = "Tổng Cộng",
                Name = "BH_TongCong_MaHoa",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });

            var imgCol = new DataGridViewImageColumn
            {
                Name = "ChiTiet",
                HeaderText = "Chi tiết bán hàng",
                Image = Properties.Resources.eye,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 250,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };

            dgvHoaDonBan.Columns.Add(imgCol);

            // Style
            dgvHoaDonBan.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 14, FontStyle.Bold);
            dgvHoaDonBan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHoaDonBan.DefaultCellStyle.Font = new Font("Open Sans", 12, FontStyle.Regular);
            dgvHoaDonBan.RowTemplate.Height = 50;
            dgvHoaDonBan.ColumnHeadersHeight = 50;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            _searchKeyword = txtTimKiem.Text.Trim();

            var filteredList = string.IsNullOrEmpty(_searchKeyword)
                ? _hoaDonBanDAO.GetAll()
                : _hoaDonBanDAO.Search(_searchKeyword);
            _bsHoaDonBan.DataSource = new BindingList<HoaDonBan>(filteredList);
            dgvHoaDonBan.DataSource = _bsHoaDonBan;

            dgvHoaDonBan.Refresh();
        }
        private void cExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmThemHoaDonBan();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Location = new Point(700, 100); // (X, Y) - điều chỉnh tọa độ này để form nằm lệch

            frm.ShowDialog(this);

            LoadData();
        }
        private void dgvHoaDonBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvHoaDonBan.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                string maBH = dgvHoaDonBan.Rows[e.RowIndex].Cells["MaBH"].Value?.ToString();
                if (!string.IsNullOrEmpty(maBH))
                {
                    var frm = new frmChiTietHoaDonBan(maBH); // truyền mã hóa đơn
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog(this);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
