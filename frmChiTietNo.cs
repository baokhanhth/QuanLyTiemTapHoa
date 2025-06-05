using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;

namespace QuanLyTiemTapHoa
{
    public partial class frmChiTietNo : Form
    {
        private readonly ChiTietNoDAO _chiTietNoDao = new ChiTietNoDAO();
        private BindingSource _bsChiTietNo;
        private BindingList<ChiTietNo> _listChiTietNo;
        private string _searchKeyword = "";

        public frmChiTietNo()
        {
            InitializeComponent();
            LoadData();
            dgvChiTietNo.CellDoubleClick += dgvChiTietNo_CellDoubleClick;
        }

        public void LoadData()
        {
            _listChiTietNo = new BindingList<ChiTietNo>(_chiTietNoDao.GetAll());
            _bsChiTietNo = new BindingSource { DataSource = _listChiTietNo };
            dgvChiTietNo.ColumnHeadersHeight = 60;
            dgvChiTietNo.ReadOnly = true;
            dgvChiTietNo.RowTemplate.Height = 60;
            dgvChiTietNo.DataSource = _bsChiTietNo;
            ConfigureGrid();
        }

        private void ConfigureGrid()
        {
            dgvChiTietNo.Columns.Clear();
            dgvChiTietNo.AutoGenerateColumns = false;

            dgvChiTietNo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaNo",
                HeaderText = "Mã Nợ",
                Name = "MaNo",
                Width = 100
            });
            dgvChiTietNo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaBH",
                HeaderText = "Mã BH",
                Name = "MaBH",
                Width = 100
            });
            dgvChiTietNo.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SoTienConNo_MaHoa",
                HeaderText = "Số Tiền Còn Nợ",
                Name = "SoTienConNo_MaHoa",
                Width = 120
            });

            dgvChiTietNo.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dgvChiTietNo.DefaultCellStyle.Font = new Font("Segoe UI", 11);
            dgvChiTietNo.RowTemplate.Height = 45;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            _searchKeyword = txtTimKiem.Text.Trim();

            var filtered = string.IsNullOrEmpty(_searchKeyword)
                ? _chiTietNoDao.GetAll()
                : _chiTietNoDao.Search(_searchKeyword);

            _bsChiTietNo.DataSource = new BindingList<ChiTietNo>(filtered);
            dgvChiTietNo.Refresh();
        }

        private void dgvChiTietNo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvChiTietNo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string maNo = dgvChiTietNo.Rows[e.RowIndex].Cells["MaNo"].Value?.ToString();
                if (!string.IsNullOrEmpty(maNo))
                {
                    using var frm = new frmThongTinChiTietNo(maNo);
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog(this);
                    LoadData();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            frmThemChiTietNo themForm = new frmThemChiTietNo();
            themForm.ShowDialog();
            LoadData();
        }
    }
}
