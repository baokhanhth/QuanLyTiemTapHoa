using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.DAOs
{
    public class NhapHangDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        // Get all using stored procedure
        public List<NhapHang> GetAll()
        {
            var list = new List<NhapHang>();
            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("sp_GetAllNhapHang", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhapHang
                        {
                            MaNH = reader["MaNH"].ToString(),
                            MaNCC = reader["MaNCC"].ToString(),
                            NH_TongCong = reader.IsDBNull(reader.GetOrdinal("NH_TongCong_MaHoa")) ? 0 : reader.GetDecimal(reader.GetOrdinal("NH_TongCong")),
                            CK_NH = reader.IsDBNull(reader.GetOrdinal("CK_NH_MaHoa")) ? 0 : reader.GetDecimal(reader.GetOrdinal("CK_NH")),
                            NH_ThanhToan = reader.IsDBNull(reader.GetOrdinal("NH_ThanhToan_MaHoa")) ? 0 : reader.GetDecimal(reader.GetOrdinal("NH_ThanhToan"))
                        });
                    }
                }
            }
            return list;
        }

        // Search by keyword using stored procedure
        public List<NhapHang> TimKiemHoaDonNhap(string keyword)
        {
            var list = new List<NhapHang>();
            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("sp_TimKiemNhapHang", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhapHang
                        {
                            MaNH = reader.IsDBNull(reader.GetOrdinal("MaNH")) ? null : reader.GetString(reader.GetOrdinal("MaNH")),
                            MaNCC = reader.IsDBNull(reader.GetOrdinal("MaNCC")) ? null : reader.GetString(reader.GetOrdinal("MaNCC")),
                            NH_TongCong = reader.IsDBNull(reader.GetOrdinal("NH_TongCong_MaHoa")) ? 0 : reader.GetDecimal(reader.GetOrdinal("NH_TongCong")),
                            CK_NH = reader.IsDBNull(reader.GetOrdinal("CK_NH_MaHoa")) ? 0 : reader.GetDecimal(reader.GetOrdinal("CK_NH")),
                            NH_ThanhToan = reader.IsDBNull(reader.GetOrdinal("NH_ThanhToan_MaHoa")) ? 0 : reader.GetDecimal(reader.GetOrdinal("NH_ThanhToan"))
                        });
                    }
                }
            }
            return list;
        }

        // Check if MaNH exists
        public bool Exists(string maNH)
        {
            const string sql = "SELECT COUNT(1) FROM NhapHang WHERE MaNH = @MaNH";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNH", maNH);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        // Insert using stored procedure with encryption inside procedure
        public void Insert(NhapHang nh)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_InsertNhapHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNH", nh.MaNH);
            cmd.Parameters.AddWithValue("@MaNCC", nh.MaNCC);
            cmd.Parameters.AddWithValue("@NH_TongCong", nh.NH_TongCong);
            cmd.Parameters.AddWithValue("@CK_NH", nh.CK_NH);
            cmd.Parameters.AddWithValue("@NH_ThanhToan", nh.NH_ThanhToan);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // Update using stored procedure
        public void Update(NhapHang nh)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_UpdateNhapHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNH", nh.MaNH);
            cmd.Parameters.AddWithValue("@MaNCC", nh.MaNCC);
            cmd.Parameters.AddWithValue("@NH_TongCong", nh.NH_TongCong);
            cmd.Parameters.AddWithValue("@CK_NH", nh.CK_NH);
            cmd.Parameters.AddWithValue("@NH_ThanhToan", nh.NH_ThanhToan);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // Delete using stored procedure
        public void Delete(string maNH)
        {
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_DeleteNhapHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNH", maNH);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // Get new MaNH
        public string LayMaNhapHangMoi()
        {
            string maMoi = "NH00000001";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_LayMaNhapHangMoi", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            var result = cmd.ExecuteScalar();

            if (result != DBNull.Value && result != null)
            {
                maMoi = result.ToString();
            }
            return maMoi;
        }

        public bool LuuNhapHang(NhapHang nhapHang, List<ChiTietNhapHang> chiTietList, List<LoHang> loHangList)
        {
            using var conn = new SqlConnection(_cnn);
            conn.Open();
            using var transaction = conn.BeginTransaction();

            try
            {
                // Insert NhapHang
                using (var cmd = new SqlCommand("sp_InsertNhapHang", conn, transaction))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNH", nhapHang.MaNH);
                    cmd.Parameters.AddWithValue("@MaNCC", nhapHang.MaNCC);
                    cmd.Parameters.AddWithValue("@NH_TongCong", nhapHang.NH_TongCong);
                    cmd.Parameters.AddWithValue("@CK_NH", nhapHang.CK_NH);
                    cmd.Parameters.AddWithValue("@NH_ThanhToan", nhapHang.NH_ThanhToan);
                    cmd.ExecuteNonQuery();
                }

                // Insert từng LoHang
                foreach (var loHang in loHangList)
                {
                    using var cmdLo = new SqlCommand("sp_InsertLoHang", conn, transaction);
                    cmdLo.CommandType = CommandType.StoredProcedure;

                    cmdLo.Parameters.AddWithValue("@MaLo", loHang.MaLo);
                    cmdLo.Parameters.AddWithValue("@MaHH", loHang.MaHang);
                    cmdLo.Parameters.AddWithValue("@NgaySanXuat", loHang.NgaySX);
                    cmdLo.Parameters.AddWithValue("@HSD", loHang.HSD);
                    cmdLo.Parameters.AddWithValue("@SoLuong", loHang.SoLuongDongGoi);

                    cmdLo.ExecuteNonQuery();
                }

                // Insert từng ChiTietNhapHang
                foreach (var ct in chiTietList)
                {
                    using var cmdCT = new SqlCommand("sp_InsertChiTietNhapHang", conn, transaction);
                    cmdCT.CommandType = CommandType.StoredProcedure;

                    cmdCT.Parameters.AddWithValue("@MaNH", ct.MaNH);
                    cmdCT.Parameters.AddWithValue("@MaLo", ct.MaLo);
                    cmdCT.Parameters.AddWithValue("@NgayNhap", ct.NgayNhap);
                    cmdCT.Parameters.AddWithValue("@SoLuongNhap", ct.SoLuongNhap);
                    cmdCT.Parameters.AddWithValue("@GiaNhap", ct.GiaNhap);
                    cmdCT.Parameters.AddWithValue("@NH_ThanhTien", ct.NH_ThanhTien);

                    cmdCT.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Lỗi lưu dữ liệu nhập hàng", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}