using Microsoft.Data.SqlClient;
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
    public partial class frmThemTongNo : Form
    {
        private readonly TongNoDAO _tongNoDAO = new TongNoDAO();
        public frmThemTongNo()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các textbox
            var tongNo = new TongNo
            {
                MaNo = txtMaNo.Text.Trim(),
                MaKH = txtMaKh.Text.Trim(),
                TongTienNo = decimal.TryParse(txtTN.Text.Trim(), out var tienNo) ? tienNo : 0,
                TrangThai = txtTT.Text.Trim()
            };

            try
            {
                _tongNoDAO.Insert(tongNo); // Gọi DAO để thêm mới bằng stored procedure

                MessageBox.Show("Đã thêm nợ mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Form cha sẽ biết để reload
                this.Close(); // Đóng form sau khi thêm thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nợ mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
