using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;

namespace QuanLyTiemTapHoa.DAOs
{
    public class ChiTietNoDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        // 1. Lấy tất cả chi tiết nợ
        public List<ChiTietNo> GetAll()
        {
            var list = new List<ChiTietNo>();
            try
            {
                using var conn = new SqlConnection(_cnn);
                using var cmd = new SqlCommand("sp_ChiTietNo_GetAll", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                conn.Open();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(ReadChiTietNo(reader));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetAll: " + ex.Message);
            }
            return list;
        }

        // 2. Tìm kiếm theo mã nợ hoặc mã hóa đơn
        public List<ChiTietNo> Search(string keyword)
        {
            var list = new List<ChiTietNo>();
            try
            {
                using var conn = new SqlConnection(_cnn);
                using var cmd = new SqlCommand("sp_ChiTietNo_Search", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@Keyword", keyword);
                conn.Open();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(ReadChiTietNo(reader));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Search","Lỗi",MessageBoxButtons.OK);
            }
            return list;
        }

        // 3. Kiểm tra mã chi tiết nợ tồn tại (dựa trên MaNo và MaBH)
        public bool Exists(string maNo, string maBH)
        {
            try
            {
                using var conn = new SqlConnection(_cnn);
                using var cmd = new SqlCommand("sp_ChiTietNo_Exists", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@MaNo", maNo);
                cmd.Parameters.AddWithValue("@MaBH", maBH);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Exists","Lỗi",MessageBoxButtons.OK);
                return false;
            }
        }

        // 4. Thêm chi tiết nợ
        public void Insert(ChiTietNo ct)
        {
            try
            {
                using var conn = new SqlConnection(_cnn);
                using var cmd = new SqlCommand("sp_ChiTietNo_Insert", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@MaNo", ct.MaNo);
                cmd.Parameters.AddWithValue("@MaBH", ct.MaBH);
                cmd.Parameters.AddWithValue("@SoTienConNo_MaHoa", ct.SoTienConNo);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Insert","Lỗi",MessageBoxButtons.OK);
            }
        }

        // 5. Cập nhật chi tiết nợ
        public void Update(ChiTietNo ct)
        {
            try
            {
                using var conn = new SqlConnection(_cnn);
                using var cmd = new SqlCommand("sp_ChiTietNo_Update", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@MaNo", ct.MaNo);
                cmd.Parameters.AddWithValue("@MaBH", ct.MaBH);
                cmd.Parameters.AddWithValue("@SoTienConNo_MaHoa", ct.SoTienConNo);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Update", "Lỗi", MessageBoxButtons.OK);
            }
        }

        // 6. Xoá chi tiết nợ
        public void Delete(string maNo, string maBH)
        {
            try
            {
                using var conn = new SqlConnection(_cnn);
                using var cmd = new SqlCommand("sp_ChiTietNo_Delete", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@MaNo", maNo);
                cmd.Parameters.AddWithValue("@MaBH", maBH);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi Delete", "Lỗi", MessageBoxButtons.OK);
            }
        }

        // 7. Lấy chi tiết nợ theo MaNo + MaBH
        public ChiTietNo GetById(string maNo, string maBH)
        {
            try
            {
                using var conn = new SqlConnection(_cnn);
                using var cmd = new SqlCommand("sp_ChiTietNo_GetById", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@MaNo", maNo);
                cmd.Parameters.AddWithValue("@MaBH", maBH);

                conn.Open();
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return ReadChiTietNo(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetById","Lỗi",MessageBoxButtons.OK);
            }
            return null;
        }

        // 👉 Hàm hỗ trợ đọc dữ liệu ChiTietNo từ SqlDataReader
        private ChiTietNo ReadChiTietNo(SqlDataReader reader)
        {
            return new ChiTietNo
            {
                MaNo = reader.IsDBNull(0) ? null : reader.GetString(0),
                MaBH = reader.IsDBNull(1) ? null : reader.GetString(1),
                SoTienConNo = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2)
            };
        }
    }
}
