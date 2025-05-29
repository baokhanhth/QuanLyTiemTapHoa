using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyTiemTapHoa.DAOs
{
    public class HangHoaDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        // 1. Lấy tất cả hàng hóa
        public List<HangHoa> GetAll()
        {
            var list = new List<HangHoa>();
            string sql = "SELECT MaHang, TenHang, DonVT, SoLuongTon FROM HangHoa";

            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new HangHoa
                        {
                            MaHang = reader.IsDBNull(0) ? null : reader.GetString(0),
                            TenHang = reader.IsDBNull(1) ? null : reader.GetString(1),
                            DonVT = reader.IsDBNull(2) ? null : reader.GetString(2),
                            SoLuongTon = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                        });
                    }
                }
            }
            return list;
        }

        public List<HangHoa> Search(string keyword)
        {
            var list = new List<HangHoa>();
            string sql = @"SELECT MaHang, TenHang, DonVT, SoLuongTon
                            FROM HangHoa
                            WHERE MaHang LIKE @p
                               OR TenHang LIKE @p";

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
                        list.Add(new HangHoa
                        {
                            MaHang = reader.IsDBNull(0) ? null : reader.GetString(0),
                            TenHang = reader.IsDBNull(1) ? null : reader.GetString(1),
                            DonVT = reader.IsDBNull(2) ? null : reader.GetString(2),
                            SoLuongTon = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                        });
                    }
                }
            }
            return list;
        }

    // 3. Kiểm tra món hàng đã tồn tại?
    public bool Exists(string maHang)
        {
            const string sql = "SELECT COUNT(1) FROM HangHoa WHERE MaHang = @MaHang";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHang", maHang);
            conn.Open();
            return (int)cmd.ExecuteScalar() > 0;
        }

        // 4. Thêm mới
        public void Insert(HangHoa hh)
        {
            const string sql = @"
                INSERT INTO HangHoa(MaHang, TenHang, DonVT, SoLuongTon)
                VALUES(@MaHang, @TenHang, @DonVT, @SoLuongTon)";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHang", hh.MaHang);
            cmd.Parameters.AddWithValue("@TenHang", hh.TenHang);
            cmd.Parameters.AddWithValue("@DonVT", hh.DonVT);
            cmd.Parameters.AddWithValue("@SoLuongTon", hh.SoLuongTon);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Update(HangHoa hh)
        {
            const string sql = @"
                UPDATE HangHoa
                SET TenHang = @TenHang,
                    DonVT = @DonVT,
                    SoLuongTon = @SoLuongTon
                WHERE MaHang = @MaHang";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHang", hh.MaHang);
            cmd.Parameters.AddWithValue("@TenHang", hh.TenHang);
            cmd.Parameters.AddWithValue("@DonVT", hh.DonVT);
            cmd.Parameters.AddWithValue("@SoLuongTon", hh.SoLuongTon);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public void Delete(string maHang)
        {
            const string sql = "DELETE FROM HangHoa WHERE MaHang = @MaHang";
            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHang", maHang);
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public HangHoa GetById(string maHang)
        {
            const string sql = @"SELECT MaHang, TenHang, DonVT, SoLuongTon 
                         FROM HangHoa 
                         WHERE MaHang = @MaHang";

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@MaHang", maHang);

            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new HangHoa
                {
                    MaHang = reader.IsDBNull(0) ? null : reader.GetString(0),
                    TenHang = reader.IsDBNull(1) ? null : reader.GetString(1),
                    DonVT = reader.IsDBNull(2) ? null : reader.GetString(2),
                    SoLuongTon = reader.IsDBNull(3) ? 0 : reader.GetInt32(3)
                };
            }
            return null;
        }
    }
}
