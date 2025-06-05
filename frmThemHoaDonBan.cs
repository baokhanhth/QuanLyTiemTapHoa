using QuanLyTiemTapHoa.DAOs;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyTiemTapHoa
{
    public partial class frmThemHoaDonBan : Form, IReloadKhachHang
    {
        private readonly HoaDonBanDAO _hoaDonBanDAO = new HoaDonBanDAO();
        private readonly ChiTietBanHangDAO _chiTietBanHangDAO = new ChiTietBanHangDAO();
        private BindingList<ChiTietBanHang> _chiTietList = new BindingList<ChiTietBanHang>();
        private List<HangHoa> _danhSachHangHoa;
        private AutoCompleteStringCollection _autoCompleteTenHang;

        public frmThemHoaDonBan()
        {
            InitializeComponent();
            this.Load += frmThemHoaDonBan_Load;

            dgvChiTietBanHang.CellEndEdit += DgvChiTietBanHang_CellEndEdit;
            dgvChiTietBanHang.EditingControlShowing += DgvChiTietBanHang_EditingControlShowing;
            dgvChiTietBanHang.CellValueChanged += DgvChiTietBanHang_CellValueChanged;
        }

        private void frmThemHoaDonBan_Load(object sender, EventArgs e)
        {
            _danhSachHangHoa = HangHoaDAO.Instance.LayDanhSachHangHoa();
            _autoCompleteTenHang = new AutoCompleteStringCollection();
            foreach (var h in _danhSachHangHoa)
                _autoCompleteTenHang.Add(h.TenHang);

            string maMoi = _hoaDonBanDAO.LayMaBanHangMoi();
            if (string.IsNullOrEmpty(maMoi))
            {
                MessageBox.Show("Lỗi sinh mã bán hàng mới");
                return;
            }
            txtMaBH.Text = maMoi;
            txtMaBH.ReadOnly = true;

            mNgayBan.Text = DateTime.Now.ToString("dd/MM/yyyy");

            dgvChiTietBanHang.AutoGenerateColumns = false;
            dgvChiTietBanHang.Columns.Clear();
            dgvChiTietBanHang.RowTemplate.Height = 50;

            dgvChiTietBanHang.ReadOnly = false;
            dgvChiTietBanHang.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvChiTietBanHang.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MaHang",
                    HeaderText = "Mã Hàng",
                    Width = 100,
                    Visible = false,
                    Name = "MaHang"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "TenHang",
                    HeaderText = "Tên Hàng",
                    Width = 150,
                    ReadOnly = false,
                    Name = "TenHang"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "DonGB",
                    HeaderText = "Đơn Giá Bán",
                    Width = 100,
                    ReadOnly = false,
                    Name = "DonGB"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SoLuongBan",
                    HeaderText = "Số Lượng",
                    Width = 80,
                    ReadOnly = false,
                    Name = "SoLuongBan"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "BH_ThanhTien",
                    HeaderText = "Thành Tiền",
                    Width = 120,
                    ReadOnly = true,
                    Name = "BH_ThanhTien"
                }
            });

            dgvChiTietBanHang.DataSource = _chiTietList;
            dgvChiTietBanHang.ColumnHeadersVisible = true;

            ThemDongMoiChiTiet();
        }

        private void DgvChiTietBanHang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox tb)
            {
                if (dgvChiTietBanHang.CurrentCell.OwningColumn.Name == "TenHang")
                {
                    tb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    tb.AutoCompleteCustomSource = _autoCompleteTenHang;
                }
                else
                {
                    tb.AutoCompleteMode = AutoCompleteMode.None;
                    tb.AutoCompleteSource = AutoCompleteSource.None;
                }
            }
        }

        private void DgvChiTietBanHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var ct = _chiTietList[e.RowIndex];

            if (dgvChiTietBanHang.Columns[e.ColumnIndex].Name == "TenHang")
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

            decimal soLuong = ct.SoLuongBan > 0 ? ct.SoLuongBan : 0;
            ct.BH_ThanhTien = ct.DonGB * soLuong;

            dgvChiTietBanHang.Refresh();
            TinhTongCong();

            if (e.RowIndex == dgvChiTietBanHang.Rows.Count - 1 && !string.IsNullOrWhiteSpace(ct.MaHang))
            {
                ThemDongMoiChiTiet();
                dgvChiTietBanHang.Refresh();
            }
        }

        private void DgvChiTietBanHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _chiTietList.Count) return;

            var ct = _chiTietList[e.RowIndex];
            Console.WriteLine($"Số lượng: {ct.SoLuongBan}, Đơn giá: {ct.DonGB}, Thành tiền: {ct.BH_ThanhTien}");
            if (e.ColumnIndex == dgvChiTietBanHang.Columns["SoLuongBan"].Index ||
                e.ColumnIndex == dgvChiTietBanHang.Columns["DonGB"].Index)
            {
                ct.BH_ThanhTien = ct.DonGB * ct.SoLuongBan;
                dgvChiTietBanHang.Refresh();
                TinhTongCong();
            }
        }

        private void ThemDongMoiChiTiet()
        {
            _chiTietList.Add(new ChiTietBanHang());
        }

        private void TinhTongCong()
        {
            decimal tong = _chiTietList.Sum(x => x.BH_ThanhTien);
            txtTongCong.Text = tong.ToString("N0");
        }

        private decimal TinhGiaBan(string maHang)
        {
            if (string.IsNullOrEmpty(maHang)) return 0;
            decimal donGiaNhap = CapNhatGiaDAO.Instance.LayDonGiaNhapGanNhat(maHang);
            if (donGiaNhap <= 0) return 0;
            return Math.Round(donGiaNhap * 1.15m, 0);
        }

        public void LoadKhachHang()
        {
            // Không cần xử lý gì thêm
        }

        private void FrmTim_OnKhachHangChon(string maKH)
        {
            txtMaKH.Text = maKH;
        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bTim_Click(object sender, EventArgs e)
        {
            string sdt = txtMaKH.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                return;
            }

            var khDAO = new KhachHangDAO();
            var kh = khDAO.TimKhachHangTheoSDT(sdt);

            if (kh != null)
            {
                txtMaKH.Text = kh.MaKH;
                //ThemDongMoiChiTiet();
            }
            else
            {
                var confirm = MessageBox.Show("Không tìm thấy khách hàng. Thêm mới?", "Thông báo",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var frm = new frmThemKhachHang(this, sdt);
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        var moi = khDAO.TimKhachHangTheoSDT(sdt);
                        if (moi != null)
                        {
                            txtMaKH.Text = moi.MaKH;
                            //ThemDongMoiChiTiet();
                        }
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string maBan = txtMaBH.Text.Trim();
                string maKH = string.IsNullOrWhiteSpace(txtMaKH.Text.Trim()) ? null : txtMaKH.Text.Trim();
                DateTime ngayBan = DateTime.ParseExact(mNgayBan.Text, "dd/MM/yyyy", null);
                decimal tongCong = _chiTietList.Sum(x => x.BH_ThanhTien);

                // Tạo hóa đơn
                HoaDonBan hd = new HoaDonBan
                {
                    MaBH = maBan,
                    MaKH = maKH,
                    NgayBan = ngayBan,
                    BH_TongCong = tongCong
                };

                // Tạo danh sách chi tiết
                List<ChiTietBanHang> dsChiTiet = new List<ChiTietBanHang>();
                foreach (var ct in _chiTietList)
                {
                    if (string.IsNullOrEmpty(ct.MaHang)) continue;
                    if (ct.SoLuongBan <= 0) continue;

                    ChiTietBanHang chiTiet = new ChiTietBanHang
                    {
                        MaBH = maBan,
                        MaHang = ct.MaHang,
                        SoLuongBan = ct.SoLuongBan,
                        DonGB = ct.DonGB,
                        BH_ThanhTien = ct.BH_ThanhTien
                    };

                    dsChiTiet.Add(chiTiet);
                }

                if (dsChiTiet.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập ít nhất 1 mặt hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool result = _hoaDonBanDAO.LuuBanHang(hd, dsChiTiet);
                if (result)
                {
                    MessageBox.Show("Lưu hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi khi lưu hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
