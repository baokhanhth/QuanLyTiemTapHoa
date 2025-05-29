using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;

namespace QuanLyTiemTapHoa
{
    public partial class frmHangHoa : Form
    {
        private readonly HangHoaDAO _hangHoaDao = new HangHoaDAO();
        private BindingSource _bsHangHoa;
        private BindingList<HangHoa> _listHangHoa;
        private string _searchKeyword = "";

        public frmHangHoa()
        {
            InitializeComponent();
            this.Load += frmHangHoa_Load;
            dgvHangHoa.CellClick += dgvHangHoa_CellClick;
            dgvHangHoa.UserDeletingRow += dgvHangHoa_UserDeletingRow;
            dgvHangHoa.RowValidated += dgvHangHoa_RowValidated;
            dgvHangHoa.CellPainting += dgvHangHoa_CellPainting;
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            _listHangHoa = new BindingList<HangHoa>(_hangHoaDao.GetAll());
            _bsHangHoa = new BindingSource { DataSource = _listHangHoa };
            dgvHangHoa.DataSource = _bsHangHoa;
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            dgvHangHoa.Columns.Clear();

            dgvHangHoa.AllowUserToAddRows = true;
            dgvHangHoa.AllowUserToDeleteRows = true;
            dgvHangHoa.ReadOnly = false;
            dgvHangHoa.AutoGenerateColumns = false;

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaHang",
                HeaderText = "Mã Hàng",
                Name = "MaHang",
                Width = 100,
                ReadOnly = false
            });
            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TenHang",
                HeaderText = "Tên Hàng",
                Name = "TenHang",
                Width = 100
            });
            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DonVT",
                HeaderText = "Đơn Vị Tính",
                Name = "DonVT",
                Width = 80
            });
            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoLuongTon",
                HeaderText = "Số Lượng",
                Name = "SoLuongTon",
                Width = 80
            });

            var imgCol = new DataGridViewImageColumn
            {
                Name = "History",
                HeaderText = "Giá Nhập",
                Image = Properties.Resources.eye,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 150,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            };
            dgvHangHoa.Columns.Add(imgCol);

            dgvHangHoa.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 14, FontStyle.Bold);
            dgvHangHoa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvHangHoa.DefaultCellStyle.Font = new Font("Open Sans", 12, FontStyle.Regular);
            dgvHangHoa.RowTemplate.Height = 50;
            dgvHangHoa.ColumnHeadersHeight = 50;
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string maHang = dgvHangHoa.Rows[e.RowIndex].Cells["MaHang"].Value?.ToString();
            if (string.IsNullOrEmpty(maHang)) return;

            if (dgvHangHoa.Columns[e.ColumnIndex].Name == "History")
            {
                var frmGia = new frmCapNhatGia(this, maHang);
                frmGia.FormBorderStyle = FormBorderStyle.None;
                frmGia.StartPosition = FormStartPosition.CenterParent;
                frmGia.TopMost = true;
                frmGia.ShowDialog(this);
            }
            else
            {
                var frmTT = new frmThongTinHangHoa(maHang);
                frmTT.StartPosition = FormStartPosition.CenterParent;
                frmTT.ShowDialog(this);
                LoadData();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            _searchKeyword = txtTimKiem.Text.Trim();

            var filteredList = string.IsNullOrEmpty(_searchKeyword)
                ? _hangHoaDao.GetAll()
                : _hangHoaDao.Search(_searchKeyword);

            _bsHangHoa.DataSource = new BindingList<HangHoa>(filteredList);
            dgvHangHoa.DataSource = _bsHangHoa;

            dgvHangHoa.Refresh();
        }

        private void dgvHangHoa_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvHangHoa.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            var hh = row.DataBoundItem as HangHoa;
            if (hh == null) return;

            if (string.IsNullOrEmpty(hh.MaHang))
            {
                MessageBox.Show("Mã hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool exists = _hangHoaDao.Exists(hh.MaHang);
            if (exists)
                _hangHoaDao.Update(hh);
            else
                _hangHoaDao.Insert(hh);
        }

        private void dgvHangHoa_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var hh = e.Row.DataBoundItem as HangHoa;
            if (hh == null) return;

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xoá mã hàng {hh.MaHang}?",
                "Xác nhận xoá",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                _hangHoaDao.Delete(hh.MaHang);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmThemHangHoa();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog(this);

            LoadData();
        }

        private void dgvHangHoa_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var cellValue = e.FormattedValue?.ToString();
            if (string.IsNullOrEmpty(cellValue) || string.IsNullOrEmpty(_searchKeyword))
                return;

            string keyword = _searchKeyword.ToLower();
            string cellText = cellValue.ToLower();
            int index = cellText.IndexOf(keyword);

            if (index >= 0)
            {
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                string before = cellValue.Substring(0, index);
                string match = cellValue.Substring(index, keyword.Length);
                string after = cellValue.Substring(index + keyword.Length);

                using var font = e.CellStyle.Font;
                using var brushNormal = new SolidBrush(e.CellStyle.ForeColor);
                using var brushHighlight = new SolidBrush(Color.Red);

                var bounds = e.CellBounds;
                int padding = 5;
                int x = bounds.X + padding;
                int y = bounds.Y + (bounds.Height - TextRenderer.MeasureText(cellValue, font).Height) / 2;

                TextRenderer.DrawText(e.Graphics, before, font, new Point(x, y), e.CellStyle.ForeColor);
                int beforeWidth = TextRenderer.MeasureText(before, font).Width;
                x += beforeWidth;

                TextRenderer.DrawText(e.Graphics, match, font, new Point(x, y), Color.Red);
                int matchWidth = TextRenderer.MeasureText(match, font).Width;
                x += matchWidth;

                TextRenderer.DrawText(e.Graphics, after, font, new Point(x, y), e.CellStyle.ForeColor);

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
            }
        }
    }
}
