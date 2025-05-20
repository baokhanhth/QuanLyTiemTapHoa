using Microsoft.Data.SqlClient;
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
        private const string Cnn =
    @"Server=arus;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True";

        public frmThemTongNo()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            const string sql = "INSERT INTO TongNo (MaNo, MaKH, TongNo,TrangThai)" +
                "VALUES (@mano, @makh, @tongno, @trangthai)";


            using var cmd = new SqlCommand(sql, cnn);
            // Truyền string thẳng cho cột varchar, nvarchar
            cmd.Parameters.AddWithValue("@mano", txtMaNo.Text.Trim());
            cmd.Parameters.AddWithValue("@makh", txtMaKh.Text.Trim());
            cmd.Parameters.AddWithValue("@tongno", txtTN.Text.Trim());
            cmd.Parameters.AddWithValue("@trangthai", txtTT.Text.Trim());
            try
            {
                cnn.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0
                        ? "Đã thêm nợ mới ."
                        : "Thêm nợ thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nợ mới");
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

        }

        private void cpbAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
