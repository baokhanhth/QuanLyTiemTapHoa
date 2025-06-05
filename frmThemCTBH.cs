using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmThemCTBH : Form
    {
        private readonly string _maBH;
        private readonly ChiTietBanHangDAO _chiTietBanHangDAO = new ChiTietBanHangDAO();
        private readonly List<HangHoa> _danhSachHangHoa;
        private readonly BindingList<ChiTietBanHang> _chiTietList = new BindingList<ChiTietBanHang>();

        public frmThemCTBH(string maBH)
        {
            InitializeComponent();
            _maBH = maBH;
            _danhSachHangHoa = HangHoaDAO.Instance.LayDanhSachHangHoa();

            Load += frmThemCTBH_Load;
            dgvThemCTBH.CellEndEdit += Dgv_CellEndEdit;
            dgvThemCTBH.EditingControlShowing += Dgv_EditingControlShowing;
        }

        private void frmThemCTBH_Load(object sender, EventArgs e)
        {
            dgvThemCTBH.ReadOnly = false;
            dgvThemCTBH.AllowUserToAddRows = false;
            dgvThemCTBH.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvThemCTBH.AutoGenerateColumns = false;
            dgvThemCTBH.Columns.Clear();

            dgvThemCTBH.RowTemplate.Height = 50;
            dgvThemCTBH.ColumnHeadersHeight = 50;
            dgvThemCTBH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvThemCTBH.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Mã BH",
                DataPropertyName = "MaBH",
                Name = "MaBH",
                ReadOnly = true,
                Width = 80
            });

            dgvThemCTBH.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên Hàng",
                DataPropertyName = "TenHang",
                Name = "TenHang",
                Width = 150
            });

            dgvThemCTBH.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Đơn Giá Bán",
                DataPropertyName = "DonGB_MaHoa",
                Name = "DonGB_MaHoa",
                Width = 100
            });

            dgvThemCTBH.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Số Lượng",
                DataPropertyName = "SoLuongBan",
                Name = "SoLuongBan",
                Width = 80
            });

            dgvThemCTBH.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Thành Tiền",
                DataPropertyName = "BH_ThanhTien_MaHoa",
                Name = "BH_ThanhTien_MaHoa",
                Width = 120,
                ReadOnly = true
            });

            dgvThemCTBH.DataSource = _chiTietList;

            ThemDongMoi();
        }


        private decimal TinhGiaBan(string maHang)
        {
            if (string.IsNullOrEmpty(maHang)) return 0;
            decimal donGiaNhap = CapNhatGiaDAO.Instance.LayDonGiaNhapGanNhat(maHang);
            if (donGiaNhap <= 0) return 0;
            return Math.Round(donGiaNhap * 1.15m, 0);
        }
        private void Dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvThemCTBH.CurrentCell.OwningColumn.Name == "TenHang" && e.Control is TextBox tb)
            {
                tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tb.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var source = new AutoCompleteStringCollection();
                source.AddRange(_danhSachHangHoa.Select(h => h.TenHang).ToArray());
                tb.AutoCompleteCustomSource = source;
            }
        }

        private void Dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _chiTietList.Count) return;

            var ct = _chiTietList[e.RowIndex];
            ct.MaBH = _maBH;

            if (dgvThemCTBH.Columns[e.ColumnIndex].Name == "TenHang")
            {
                var hang = _danhSachHangHoa.FirstOrDefault(h => h.TenHang.Equals(ct.TenHang, StringComparison.OrdinalIgnoreCase));
                if (hang != null)
                {
                    ct.MaHang = hang.MaHang;
                    ct.DonGB = TinhGiaBan(ct.MaHang);
                }
                else
                {
                    ct.MaHang = null;
                    ct.DonGB = 0;
                }
            }

            if (ct.SoLuongBan > 0 && ct.DonGB > 0)
            {
                ct.BH_ThanhTien = ct.SoLuongBan * ct.DonGB;
            }

            dgvThemCTBH.Refresh();

            if (e.RowIndex == _chiTietList.Count - 1 && !string.IsNullOrWhiteSpace(ct.MaHang))
                ThemDongMoi();
        }

        private void ThemDongMoi()
        {
            _chiTietList.Add(new ChiTietBanHang { MaBH = _maBH });
        }

        private void tbtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = _chiTietList
                    .Where(ct => !string.IsNullOrWhiteSpace(ct.MaHang) && ct.SoLuongBan > 0)
                    .ToList();

                foreach (var ct in ds)
                {
                    var ctBH = new ChiTietBanHang
                    {
                        MaBH = ct.MaBH,
                        MaHang = ct.MaHang,
                        SoLuongBan = ct.SoLuongBan,
                        DonGB = ct.DonGB
                    };
                    _chiTietBanHangDAO.ThemChiTietBanHang(ctBH); 
                }

                MessageBox.Show("Đã thêm chi tiết bán hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chi tiết bán hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
