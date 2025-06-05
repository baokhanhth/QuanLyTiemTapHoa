using QuanLyTiemTapHoa.DAOs;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class fBaoCaoTonKho : Form
    {
        public fBaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void btxem_Click(object sender, EventArgs e)
        {
            var dt = TonKhoDAO.LayBaoCaoTonKho();

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu tồn kho để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvsltonkho.DataSource = null;
                return;
            }

            dgvsltonkho.DataSource = dt;
            FormatDGVTonKho();
        }

        private void FormatDGVTonKho()
        {
            if (dgvsltonkho == null || dgvsltonkho.Columns.Count == 0)
                return;

            void SetHeader(string colName, string header)
            {
                if (dgvsltonkho.Columns.Contains(colName))
                    dgvsltonkho.Columns[colName].HeaderText = header;
            }

            SetHeader("ThangNam", "Tháng Năm");
            SetHeader("MaHang", "Mã hàng");
            SetHeader("TenHang", "Tên hàng");
            SetHeader("TongSoLuongNhap", "Tổng Số Lượng Nhập");
            SetHeader("TongSoLuongBan", "Tổng Số Lượng Bán");
            SetHeader("SoLuongTon", "Số Lượng Tồn");

            // Căn giữa tiêu đề và dữ liệu
            foreach (DataGridViewColumn col in dgvsltonkho.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvsltonkho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsltonkho.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvsltonkho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvsltonkho.EnableHeadersVisualStyles = false;
            dgvsltonkho.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgvsltonkho.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvsltonkho.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
