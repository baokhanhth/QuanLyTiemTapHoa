using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyTiemTapHoa.DAOs
{
    public class TongNoDAO
    {
        private readonly string _cnn = DbConfig.ConnectionString;

        public List<TongNo> GetAll()
        {
            var list = new List<TongNo>();
            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("sp_TongNo_GetAll", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TongNo
                        {
                            MaNo = reader.GetString(0),
                            MaKH = reader.GetString(1),
                            TongTienNo = reader.GetDecimal(2),
                            TrangThai = reader.GetString(3)
                        });
                    }
                }
            }

            return list;
        }

        public List<TongNo> Search(string keyword)
        {
            var list = new List<TongNo>();
            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("sp_TongNo_Search", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Keyword", keyword);

                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TongNo
                        {
                            MaNo = reader["MaNo"].ToString(),
                            MaKH = reader["MaKH"].ToString(),
                            TongTienNo = reader["TongTienNo"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["TongTienNo"]),
                            TrangThai = reader["TrangThai"].ToString()
                        });
                    }
                }
            }

            return list;
        }

        public string LayMaNoTheoMaKH(string maKH)
        {
            string maNo = null;
            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("usp_LayMaNoTheoMaKH", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaKH", maKH);

                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    maNo = result.ToString();
                }
            }

            return maNo;
        }

        public decimal LayTongTienNoTheoMaNo(string maNo)
        {
            decimal tongNo = 0;
            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("usp_LayTongTienNoTheoMaNo", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNo", maNo);

                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    tongNo = Convert.ToDecimal(result);
                }
            }

            return tongNo;
        }

        public void Insert(TongNo tongNo)
        {
            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("usp_InsertTongNo", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNo", tongNo.MaNo);
                cmd.Parameters.AddWithValue("@MaKH", tongNo.MaKH);
                cmd.Parameters.AddWithValue("@TongNo_MaHoa", tongNo.TongTienNo);
                cmd.Parameters.AddWithValue("@TrangThai", tongNo.TrangThai);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public bool Update(TongNo tongNo)
        {
            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("usp_DeleteTongNo", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNo", tongNo.MaNo);
                cmd.Parameters.AddWithValue("@MaKH", tongNo.MaKH);
                cmd.Parameters.AddWithValue("@TongNo_MaHoa", tongNo.TongTienNo);
                cmd.Parameters.AddWithValue("@TrangThai", tongNo.TrangThai);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

        public bool Delete(string maNo)
        {
            using (var conn = new SqlConnection(_cnn))
            using (var cmd = new SqlCommand("usp_DeleteTongNo", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNo", maNo);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }

    }
}
