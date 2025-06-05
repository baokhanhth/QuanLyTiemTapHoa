using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmThemLSTN : Form
    {
        private readonly string _cnn = DbConfig.ConnectionString;
        private readonly LichSuTraNoDAO _dao = new LichSuTraNoDAO();
        private bool _isClosingByUser = false;

        public string MaNo
        {
            get => txtMaNo.Text;
            set => txtMaNo.Text = value;
        }

        public decimal SoTienTra
        {
            get => decimal.TryParse(txtSoTienTra.Text, out var val) ? val : 0;
            set => txtSoTienTra.Text = value.ToString("N0");
        }

        public frmThemLSTN()
        {
            InitializeComponent();
            this.FormClosing += frmThemLSTN_FormClosing;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (SoTienTra <= 0)
            {
                MessageBox.Show("Số tiền trả phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var traNo = new LichSuTraNo
                {
                    MaNo = MaNo.Trim(),
                    NgayTra = pkNgaytra.Value.Date,
                    SoTienTra = SoTienTra
                };

                _dao.Insert(traNo);

                MessageBox.Show("Đã trả khoản nợ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _isClosingByUser = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm trả nợ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            _isClosingByUser = true;
            this.Close();
        }

        private void frmThemLSTN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isClosingByUser)
            {
              
            }
        }
    }
}
