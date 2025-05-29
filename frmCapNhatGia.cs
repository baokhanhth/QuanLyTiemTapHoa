using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmCapNhatGia : Form
    {
        private BindingList<CapNhatGia> _listCapNhatGia;
        private BindingSource _bsCapNhatGia;
        private CapNhatGiaDAO _capNhatGiaDao = new CapNhatGiaDAO();
        private string maHang;
        private frmHangHoa _parentForm;

        public frmCapNhatGia(frmHangHoa parentForm, string maHang)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Không viền
            this._parentForm = parentForm;
            this.maHang = maHang;
            this.Load += frmCapNhatGia_Load;  // Đăng ký event Load
        }

        private void frmCapNhatGia_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            LoadData();
        }

        public void LoadData()
        {
            Console.WriteLine("frmCapNhatGia.LoadData() - maHang: " + maHang);

            try
            {
                var rawList = _capNhatGiaDao.GetAll()
                                    .Where(x => x.MaHang == this.maHang)
                                    .OrderByDescending(x => x.NgayBD)
                                    .ToList();

                _listCapNhatGia = new BindingList<CapNhatGia>(rawList);
                _bsCapNhatGia = new BindingSource { DataSource = _listCapNhatGia };
                dgvCapNhatGia.DataSource = _bsCapNhatGia;

                ConfigureGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGrid()
        {
            dgvCapNhatGia.Columns.Clear();
            dgvCapNhatGia.ColumnHeadersHeight = 60;

            dgvCapNhatGia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCapNhatGia.MultiSelect = false;
            dgvCapNhatGia.ReadOnly = true; // Đặt thành true để không sửa trực tiếp
            dgvCapNhatGia.AutoGenerateColumns = false;

            dgvCapNhatGia.RowTemplate.Height = 60;

            dgvCapNhatGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaHang",
                HeaderText = "Mã Hàng",
                Name = "MaHang",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvCapNhatGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MaLo",
                HeaderText = "Mã Lô",
                Name = "MaLo",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvCapNhatGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NgayBD",
                HeaderText = "Ngày Bắt Đầu",
                Name = "NgayBD",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "MM/dd/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvCapNhatGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NgayKT",
                HeaderText = "Ngày Kết Thúc",
                Name = "NgayKT",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "MM/dd/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvCapNhatGia.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DonGN",
                HeaderText = "Đơn Giá Nhập",
                Name = "DonGN",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "#,##0.##",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dgvCapNhatGia.ColumnHeadersDefaultCellStyle.Font = new Font("Open Sans", 10, FontStyle.Bold);
            dgvCapNhatGia.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCapNhatGia.DefaultCellStyle.Font = new Font("Open Sans", 10, FontStyle.Regular);
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            var frmThemGia = new frmThemCapNhatGia(this);
            frmThemGia.StartPosition = FormStartPosition.CenterParent;
            if (frmThemGia.ShowDialog(this) == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _parentForm?.LoadData();
        }
    }
}
