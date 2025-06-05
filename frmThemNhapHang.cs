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
    public partial class frmThemNhapHang : Form, IReloadNhaCungCap
    {
        private readonly NhapHangDAO _nhapHangDAO = new NhapHangDAO();
        private readonly ChiTietNhapHangDAO _chiTietNhapHangDAO = new ChiTietNhapHangDAO();
        private BindingList<ChiTietNhapHang> _chiTietList = new BindingList<ChiTietNhapHang>();

        public frmThemNhapHang()
        {
            InitializeComponent();
            this.Load += FrmThemNhapHang_Load;
            dgvChiTietNhapHang.CellEndEdit += DgvChiTietNhapHang_CellEndEdit;
            dgvChiTietNhapHang.CellValueChanged += DgvChiTietNhapHang_CellValueChanged;
            dgvChiTietNhapHang.CurrentCellDirtyStateChanged += DgvChiTietNhapHang_CurrentCellDirtyStateChanged;
        }

        private void FrmThemNhapHang_Load(object sender, EventArgs e)
        {
            dgvChiTietNhapHang.AutoGenerateColumns = false;
            dgvChiTietNhapHang.Columns.Clear();
            dgvChiTietNhapHang.RowTemplate.Height = 50;
            dgvChiTietNhapHang.ReadOnly = false;
            dgvChiTietNhapHang.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;

            dgvChiTietNhapHang.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "MaLo",
                    HeaderText = "Mã Lô",
                    Width = 120,
                    ReadOnly = false,
                    Name = "MaLo"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NgayNhap",
                    HeaderText = "Ngày Nhập",
                    Width = 120,
                    Name = "NgayNhap",
                    ReadOnly = false,
                    Visible = true,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "dd/MM/yyyy"
                    }
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SoLuongNhap",
                    HeaderText = "Số Lượng Nhập",
                    Width = 120,
                    ReadOnly = false,
                    Name = "SoLuongNhap"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "GiaNhap",
                    HeaderText = "Giá Nhập",
                    Width = 120,
                    ReadOnly = false,
                    Name = "GiaNhap_MaHoa"
                },
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "NH_ThanhTien",
                    HeaderText = "Thành Tiền",
                    Width = 140,
                    ReadOnly = true,
                    Name = "NH_ThanhTien"
                }
            });

            dgvChiTietNhapHang.DataSource = _chiTietList;
            dgvChiTietNhapHang.ColumnHeadersVisible = true;

            string maMoi = _nhapHangDAO.LayMaNhapHangMoi();
            if (string.IsNullOrEmpty(maMoi))
            {
                MessageBox.Show("Lỗi sinh mã nhập hàng mới");
                return;
            }
            txtMaNH.Text = maMoi;
            txtMaNH.ReadOnly = true;
            mNgayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy");

            ThemDongMoiChiTiet();
        }

        private void DgvChiTietNhapHang_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvChiTietNhapHang.IsCurrentCellDirty)
            {
                dgvChiTietNhapHang.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DgvChiTietNhapHang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _chiTietList.Count) return;

            var ct = _chiTietList[e.RowIndex];

            if (e.ColumnIndex == dgvChiTietNhapHang.Columns["SoLuongNhap"].Index ||
                e.ColumnIndex == dgvChiTietNhapHang.Columns["GiaNhap"].Index)
            {
                ct.NH_ThanhTien = ct.SoLuongNhap * ct.GiaNhap;
                dgvChiTietNhapHang.Refresh();
                TinhTongCong();
            }

            if (e.RowIndex == dgvChiTietNhapHang.Rows.Count - 1 && !string.IsNullOrWhiteSpace(ct.MaLo))
            {
                ThemDongMoiChiTiet();
                dgvChiTietNhapHang.Refresh();
            }
        }

        private void DgvChiTietNhapHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _chiTietList.Count) return;

            var ct = _chiTietList[e.RowIndex];

            if (e.ColumnIndex == dgvChiTietNhapHang.Columns["SoLuongNhap"].Index ||
                e.ColumnIndex == dgvChiTietNhapHang.Columns["GiaNhap"].Index)
            {
                ct.NH_ThanhTien = ct.SoLuongNhap * ct.GiaNhap;
                dgvChiTietNhapHang.Refresh();
                TinhTongCong();
            }
            else if (e.ColumnIndex == dgvChiTietNhapHang.Columns["NgayNhap"].Index)
            {
                var cellValue = dgvChiTietNhapHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (cellValue != null)
                {
                    if (DateTime.TryParseExact(cellValue.ToString(), "dd/MM/yyyy", null,
                        System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                    {
                        ct.NgayNhap = parsedDate;
                    }
                    else
                    {
                        MessageBox.Show("Ngày nhập không hợp lệ. Vui lòng nhập theo định dạng dd/MM/yyyy.");
                        dgvChiTietNhapHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ct.NgayNhap.ToString("dd/MM/yyyy");
                    }
                }
            }
        }

        public void LoadNhaCungCap()
        {
            // Nếu cần load lại danh sách nhà cung cấp khi thêm mới, xử lý tại đây
        }

        private void ThemDongMoiChiTiet()
        {
            var chiTiet = new ChiTietNhapHang
            {
                NgayNhap = DateTime.Now
            };
            _chiTietList.Add(chiTiet);
        }

        private void TinhTongCong()
        {
            decimal tong = _chiTietList.Sum(x => x.NH_ThanhTien);
            txtTongCong.Text = tong.ToString("N0");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DateTime.TryParseExact(mNgayNhap.Text, "dd/MM/yyyy", null,
                    System.Globalization.DateTimeStyles.None, out DateTime ngayNhap))
                {
                    MessageBox.Show("Ngày nhập không hợp lệ.");
                    return;
                }

                var chiTietHopLe = _chiTietList.Where(ct =>
                    !string.IsNullOrWhiteSpace(ct.MaLo) &&
                    ct.SoLuongNhap > 0 &&
                    ct.GiaNhap > 0).ToList();

                if (chiTietHopLe.Count == 0)
                {
                    MessageBox.Show("Chưa có chi tiết nhập hợp lệ.");
                    return;
                }

                decimal tongCong = chiTietHopLe.Sum(ct => ct.NH_ThanhTien);

                var nhapHang = new NhapHang
                {
                    MaNH = txtMaNH.Text,
                    MaNCC = txtMaNCC.Text.Trim(),
                    CK_NH = 0,
                    NH_TongCong = tongCong,
                    NH_ThanhToan = tongCong
                };

                _nhapHangDAO.Insert(nhapHang);

                foreach (var ct in chiTietHopLe)
                {
                    ct.MaNH = nhapHang.MaNH;
                    if (ct.NgayNhap == default(DateTime))
                        ct.NgayNhap = ngayNhap;

                    _chiTietNhapHangDAO.ThemChiTietNhapHang(ct);
                }

                MessageBox.Show("Đã lưu phiếu nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bTim_Click(object sender, EventArgs e)
        {
            string sdt = txtMaNCC.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.");
                return;
            }

            var nccDAO = new NhaCungCapDAO();
            var ncc = nccDAO.TimNhaCungCapTheoSDT(sdt);

            if (ncc != null)
            {
                txtMaNCC.Text = ncc.MaNCC;
            }
            else
            {
                var confirm = MessageBox.Show("Không tìm thấy nhà cung cấp. Thêm mới?", "Thông báo",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    var frm = new frmThemNCC(this, sdt);
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        var moi = nccDAO.TimNhaCungCapTheoSDT(sdt);
                        if (moi != null)
                        {
                            txtMaNCC.Text = moi.MaNCC;
                        }
                    }
                }
            }
        }

        private void btnThemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
