using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmLichSuTraNo : Form
    {
        private readonly LichSuTraNoDAO _lichSuTraNoDAO = new LichSuTraNoDAO();
        private BindingSource _bsLSTNo;
        private BindingList<LichSuTraNo> _listLichSuTraNo;
        private string _searchKeyword = "";

        public frmLichSuTraNo()
        {
            InitializeComponent();
            this.Load += frmLichSuTraNo_Load;
            dgvLSTN.CellPainting += dgvLSTN_CellPainting;
            dgvLSTN.CellDoubleClick += dgvLSTN_CellDoubleClick;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            tbtnThem.Click += tbtnThem_Click;
        }

        private void frmLichSuTraNo_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            _listLichSuTraNo = new BindingList<LichSuTraNo>(_lichSuTraNoDAO.GetAll());
            _bsLSTNo = new BindingSource { DataSource = _listLichSuTraNo };
            dgvLSTN.ColumnHeadersHeight = 60;
            dgvLSTN.ReadOnly = true;
            dgvLSTN.RowTemplate.Height = 60;
            dgvLSTN.DataSource = _bsLSTNo;
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            dgvLSTN.Columns.Clear();
            dgvLSTN.AutoGenerateColumns = false;

            dgvLSTN.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaNo",
                HeaderText = "Mã Nợ",
                Name = "MaNo",
                Width = 120
            });

            dgvLSTN.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NgayTra",
                HeaderText = "Ngày Trả",
                Name = "NgayTra",
                Width = 150,
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            dgvLSTN.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoTienTra",
                HeaderText = "Số Tiền Trả",
                Name = "SoTienTra",
                Width = 150,
                DefaultCellStyle = {
                    Format = "#,##0 VNĐ",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvLSTN.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvLSTN.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgvLSTN.RowTemplate.Height = 45;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            _searchKeyword = txtTimKiem.Text.Trim();

            var filtered = string.IsNullOrEmpty(_searchKeyword)
                ? _lichSuTraNoDAO.GetAll()
                : _lichSuTraNoDAO.Search(_searchKeyword);

            _bsLSTNo.DataSource = new BindingList<LichSuTraNo>(filtered);
            dgvLSTN.Refresh();
        }

        private void dgvLSTN_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var cellValue = e.FormattedValue?.ToString();
            if (string.IsNullOrEmpty(cellValue) || string.IsNullOrEmpty(_searchKeyword)) return;

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

                var font = e.CellStyle.Font;
                int x = e.CellBounds.X + 5;
                int y = e.CellBounds.Y + (e.CellBounds.Height - TextRenderer.MeasureText(cellValue, font).Height) / 2;

                TextRenderer.DrawText(e.Graphics, before, font, new Point(x, y), e.CellStyle.ForeColor);
                x += TextRenderer.MeasureText(before, font).Width;

                TextRenderer.DrawText(e.Graphics, match, font, new Point(x, y), Color.Red);
                x += TextRenderer.MeasureText(match, font).Width;

                TextRenderer.DrawText(e.Graphics, after, font, new Point(x, y), e.CellStyle.ForeColor);
                e.Paint(e.ClipBounds, DataGridViewPaintParts.Border);
            }
        }
        private void dgvLSTN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvLSTN.Rows[e.RowIndex];

                string maNo = row.Cells["MaNo"].Value?.ToString();
                bool ngayTraParsed = DateTime.TryParse(row.Cells["NgayTra"].Value?.ToString(), out DateTime ngayTra);

                if (!string.IsNullOrEmpty(maNo) && ngayTraParsed)
                {
                    var frm = new frmThongTinLichSuTraNo(maNo, ngayTra);
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog(this);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể lấy thông tin chi tiết từ dòng được chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void tbtnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmThemLSTN();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Location = new Point(700, 100); // điều chỉnh vị trí nếu cần
            frm.ShowDialog(this);
            LoadData();
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
