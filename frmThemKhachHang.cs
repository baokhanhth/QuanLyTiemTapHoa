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
using Guna.UI2.WinForms;
using LiveCharts.WinForms;
namespace QuanLyTiemTapHoa
{
    public partial class frmThemKhachHang : Form
    {
        private frmKhachHang parentForm;
        public frmThemKhachHang(frmKhachHang parent)
        {
            InitializeComponent();
            parentForm = parent;

        }
        private const string Cnn =  @"Server=.;Database=QuanLyBanHang;Trusted_Connection=True;Encrypt=False;";
        private void btnThemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using var cnn = new SqlConnection(Cnn);
            const string sql = "INSERT INTO KhachHang (MaKH, TenKH, SDT_KH, DiaChi)" +
                "VALUES (@ma, @ten, @sdt, @dc)";

            using var cmd = new SqlCommand(sql, cnn);
            cmd.Parameters.AddWithValue("@ma", txtMaKH.Text.Trim());
            cmd.Parameters.AddWithValue("@ten", txtTenKH.Text.Trim());
            cmd.Parameters.AddWithValue("@sdt", txtSDT.Text.Trim());
            cmd.Parameters.AddWithValue("@dc", txtDiaChi.Text.Trim());

            try
            {
                cnn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Đã thêm khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Gọi lại danh sách khách hàng ở form cha
                    parentForm.LoadKhachHang();

                    // Đóng form hiện tại
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng");
            }
        }
    }
}
