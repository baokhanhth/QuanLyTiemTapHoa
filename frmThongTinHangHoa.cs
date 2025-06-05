using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmThongTinHangHoa : Form
    {
        private readonly HangHoaDAO _hangHoaDao = new HangHoaDAO();
        private readonly string _maHang;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        public frmThongTinHangHoa(string maHang)
        {
            InitializeComponent();
            _maHang = maHang;

            // Giao diện form không viền và bo góc
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            // Sự kiện
            this.Load += frmThongTinHangHoa_Load;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            btnClose.Click += btnClose_Click;
            tbtnXoa.Click += tbtnXoa_Click;
            tbtnSua.Click += tbtnSua_Click;
        }

        private void frmThongTinHangHoa_Load(object sender, EventArgs e)
        {
            LoadHangHoa();
            txtMaHang.ReadOnly = true;
        }

        private void LoadHangHoa()
        {
            var hang = _hangHoaDao.GetById(_maHang);
            if (hang != null)
            {
                txtMaHang.Text = hang.MaHang;
                txtTenHang.Text = hang.TenHang;
                txtDonVT.Text = hang.DonVT;
                txtSoLuong.Text = hang.SoLuongTon.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnXoa_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa hàng hóa \"{txtTenHang.Text}\" (Mã: {txtMaHang.Text}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string maHang = txtMaHang.Text.Trim();
                    _hangHoaDao.Delete(maHang);
                    MessageBox.Show("Xóa hàng hóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbtnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong < 0)
            {
                MessageBox.Show("Số lượng không hợp lệ! Vui lòng nhập số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var hh = new HangHoa
                {
                    MaHang = txtMaHang.Text.Trim(),
                    TenHang = txtTenHang.Text.Trim(),
                    DonVT = txtDonVT.Text.Trim(),
                    SoLuongTon = soLuong
                };

                _hangHoaDao.Update(hh);
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // KHÔNG ĐƯỢC đặt DialogResult = OK ở đây nếu không đóng form
                // this.DialogResult = DialogResult.OK; ❌
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
