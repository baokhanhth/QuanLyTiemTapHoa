using Microsoft.Data.SqlClient;
using QuanLiTiemTapHoa;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmLoHang : Form
    {
        private SqlConnection _cnn = new SqlConnection(@"Data Source=TANPHUC;Initial Catalog=QuanLyBanHang;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        public frmLoHang()
        {
            InitializeComponent();
            this.Load += frmLoHang_Load;
            dgvLoHang.CellClick += dgvLoHang_CellClick; // Thêm dòng này
        }

        private void frmLoHang_Load(object sender, EventArgs e)
        {
            LoadLoHang();
        }

        private void dgvLoHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoHang.Rows[e.RowIndex];

                string maLo = row.Cells["MaLo"].Value.ToString();
                string maHang = row.Cells["MaHang"].Value.ToString();
                DateTime ngaySX = Convert.ToDateTime(row.Cells["NgaySX"].Value);
                DateTime hsd = Convert.ToDateTime(row.Cells["HSD"].Value);
                int soLuong = Convert.ToInt32(row.Cells["SoLuongDongGoi"].Value);

                frmThongTinLoHang frm = new frmThongTinLoHang(maLo, maHang, ngaySX, hsd, soLuong);
                frm.ShowDialog();
            }
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmLoHang themForm = new frmLoHang();
            themForm.ShowDialog();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvLoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadLoHang(); // Hiển thị toàn bộ nếu trống
            }
            else
            {
                dgvLoHang.DataSource = SearchLoHang(keyword);
                FormatLoHangGrid(); // Đảm bảo hiển thị lại format
            }
        }

        public void LoadLoHang()
        {
            DataTable dt = new DataTable();
            try
            {
                if (_cnn.State != ConnectionState.Open)
                    _cnn.Open();

                string query = "SELECT MaLo, MaHang, NgaySX, HSD, SoLuongDongGoi FROM LoHang";
                SqlDataAdapter da = new SqlDataAdapter(query, _cnn);
                da.Fill(dt);
                dgvLoHang.DataSource = dt;

                FormatLoHangGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu Lô Hàng: " + ex.Message);
            }
            finally
            {
                if (_cnn.State == ConnectionState.Open)
                    _cnn.Close();
            }
        }

        private DataTable SearchLoHang(string keyword)
        {
            DataTable dt = new DataTable();
            try
            {
                if (_cnn.State != ConnectionState.Open)
                    _cnn.Open();

                string query = @"
                    SELECT MaLo, MaHang, NgaySX, HSD, SoLuongDongGoi 
                    FROM LoHang 
                    WHERE MaLo LIKE @kw OR MaHang LIKE @kw
                ";

                using (SqlCommand cmd = new SqlCommand(query, _cnn))
                {
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
            finally
            {
                if (_cnn.State == ConnectionState.Open)
                    _cnn.Close();
            }

            return dt;
        }

        private void FormatLoHangGrid()
        {
            dgvLoHang.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 14, FontStyle.Bold);
            dgvLoHang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoHang.DefaultCellStyle.Font = new Font("Open Sans", 12, FontStyle.Regular);
            dgvLoHang.RowTemplate.Height = 60;
            dgvLoHang.ColumnHeadersHeight = 60;

            if (dgvLoHang.Columns["MaLo"] != null)
            {
                dgvLoHang.Columns["MaLo"].HeaderText = "Mã Lô";
                dgvLoHang.Columns["MaLo"].Width = 150;
                dgvLoHang.Columns["MaLo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLoHang.Columns["MaHang"] != null)
            {
                dgvLoHang.Columns["MaHang"].HeaderText = "Mã Hàng";
                dgvLoHang.Columns["MaHang"].Width = 150;
                dgvLoHang.Columns["MaHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLoHang.Columns["NgaySX"] != null)
            {
                dgvLoHang.Columns["NgaySX"].HeaderText = "Ngày Sản Xuất";
                dgvLoHang.Columns["NgaySX"].Width = 180;
                dgvLoHang.Columns["NgaySX"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvLoHang.Columns["NgaySX"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLoHang.Columns["NgaySX"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLoHang.Columns["HSD"] != null)
            {
                dgvLoHang.Columns["HSD"].HeaderText = "Hạn Sử Dụng";
                dgvLoHang.Columns["HSD"].Width = 180;
                dgvLoHang.Columns["HSD"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvLoHang.Columns["HSD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvLoHang.Columns["HSD"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvLoHang.Columns["SoLuongDongGoi"] != null)
            {
                dgvLoHang.Columns["SoLuongDongGoi"].HeaderText = "Số Lượng";
                dgvLoHang.Columns["SoLuongDongGoi"].Width = 180;
                dgvLoHang.Columns["SoLuongDongGoi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }
    }
}

