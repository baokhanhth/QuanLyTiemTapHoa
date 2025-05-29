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

        public List<NhapHang> GetAll()
        {
            var list = new List<NhapHang>();
            string sql = "SELECT MaNH, MaNCC, NH_TongCong, CK_NH, NH_ThanhToan FROM NhapHang";

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhapHang
                        {
                            MaNH = reader.IsDBNull(0) ? null : reader.GetString(0),
                            MaNCC = reader.IsDBNull(1) ? null : reader.GetString(1),
                            NH_TongCong = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                            CK_NH = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                            NH_ThanhToan = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4)
                        });
                    }
                }
            }
            return list;
        }

        public List<NhapHang> TimKiemHoaDonNhap(string keyword)
        {
            var list = new List<NhapHang>();
            string sql = @"SELECT MaNH, MaNCC, NH_TongCong, CK_NH, NH_ThanhToan
                            FROM NhapHang
                            WHERE MaNH LIKE @p
                               OR MaNCC LIKE @p
                               OR NH_TongCong LIKE @p";

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                string p = "%" + keyword + "%";
                cmd.Parameters.AddWithValue("@p", p);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhapHang
                        {
                            MaNH = reader.IsDBNull(0) ? null : reader.GetString(0),
                            MaNCC = reader.IsDBNull(1) ? null : reader.GetString(1),
                            NH_TongCong = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                            CK_NH = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                            NH_ThanhToan = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4)
                        });
                    }
                }
            }
            return list;
        }
        public bool Exists(string maNH)
        {
            const string sql = "SELECT COUNT(1) FROM NhapHang WHERE MaNH = @MaNH";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHang", maNH);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }
        public void Insert(NhapHang nh)
        {
            const string sql = @"
                INSERT INTO NhapHang(MaNH, MaNCC, NH_TongCong, CK_NH, NH_ThanhToan)
                VALUES(@MaNH, @MaNCC, @NH_TongCong, @CK_NH, @NH_ThanhToan)";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNH", nh.MaNH);
            cmd.Parameters.AddWithValue("@MaNCC", nh.MaNCC);
            cmd.Parameters.AddWithValue("@NH_TongCong", nh.NH_TongCong);
            cmd.Parameters.AddWithValue("@CK_NH", nh.CK_NH);
            cmd.Parameters.AddWithValue("@NH_ThanhToan", nh.NH_ThanhToan);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(NhapHang nh)
        {
            const string sql = @"
                UPDATE  NhapHang
                SET MaNH = @MaNH,
                    MaNCC = @@MaNCC,
                    NH_TongCong = @NH_TongCong,
                    CK_NH = @CK_NH,
                    NH_ThanhToan = @NH_ThanhToan    
                    WHERE MaNH = @MaNH";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNH", nh.MaNH);
            cmd.Parameters.AddWithValue("@MaNCC", nh.MaNCC);
            cmd.Parameters.AddWithValue("@NH_TongCong", nh.NH_TongCong);
            cmd.Parameters.AddWithValue("@CK_NH", nh.CK_NH);
            cmd.Parameters.AddWithValue("@NH_ThanhToan", nh.NH_ThanhToan);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(string maHang)
        {
            const string sql = "DELETE FROM NhapHang WHERE MaNH = @MaNH";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaNH", maHang);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

    }
}
