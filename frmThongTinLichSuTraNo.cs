using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;

namespace QuanLyTiemTapHoa
{
    public partial class frmThongTinLichSuTraNo : Form
    {
        private readonly string _maNo;
        private readonly DateTime _ngayTra;
        private readonly LichSuTraNoDAO _dao = new LichSuTraNoDAO();
        private bool _isFormatting = false;

        public frmThongTinLichSuTraNo(string maNo, DateTime ngayTra)
        {
            InitializeComponent();
            _maNo = maNo;
            _ngayTra = ngayTra;

            Load += Frm_Load;
            btnClose.Click += (_, __) => Close();
            tbtnUpdate.Click += tbtnUpdate_Click;
            tbtnDelete.Click += tbtnDelete_Click;
            txtSoTienTra.TextChanged += txtSoTienTra_TextChanged;
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            try
            {
                var list = _dao.Search(_maNo);
                var record = list.Find(r => r.NgayTra.Date == _ngayTra.Date);

                if (record != null)
                {
                    txtMaNo.Text = record.MaNo;
                    txtNgayTra.Text = record.NgayTra.ToString("dd/MM/yyyy");
                    txtSoTienTra.Text = record.SoTienTra.ToString("N0");

                    txtMaNo.ReadOnly = true;
                    txtNgayTra.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu lịch sử trả nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtnUpdate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSoTienTra.Text.Replace(",", "").Trim(), out decimal soTienTra))
            {
                MessageBox.Show("Số tiền trả không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool updated = _dao.Update(_maNo, _ngayTra, soTienTra);

                if (updated)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa bản ghi này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                bool deleted = _dao.Delete(_maNo, _ngayTra);
                MessageBox.Show(deleted
                        ? "Xóa thành công!"
                        : "Không có dữ liệu nào bị xóa.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (deleted) Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSoTienTra_TextChanged(object sender, EventArgs e)
        {
            if (_isFormatting) return;

            _isFormatting = true;
            string input = txtSoTienTra.Text.Replace(",", "").Trim();

            if (decimal.TryParse(input, out decimal soTien))
            {
                txtSoTienTra.Text = soTien.ToString("N0");
                txtSoTienTra.SelectionStart = txtSoTienTra.Text.Length;
            }
            else
            {
                txtSoTienTra.Text = "";
            }

            _isFormatting = false;
        }
    }
}
