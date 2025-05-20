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
    public partial class frmLSTN : Form
    {
        private const string Cnn =
            @"Server=HoaHuynh;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True";
        public frmLSTN()
        {
            InitializeComponent();
        }
        

        private void gradientPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            const string sql = "INSERT INTO LichSuTraNo (MaNo, NgayTra, SoTienTra)" +
                "VALUES (@mano, @ngaytra, @sotientra)";
            using var cmd = new SqlCommand(sql, cnn);
            // Truyền string thẳng cho cột varchar, nvarchar
            cmd.Parameters.AddWithValue("@malo", txtMaNo.Text.Trim());
            cmd.Parameters.AddWithValue("@mahang", txtstt.Text.Trim());
            
            try
            {
                cnn.Open();
                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show(rows > 0
                        ? "Đã trả khoảng nợ."
                        : "Trả nợ không thành công.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm trả nợ");
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMaNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
