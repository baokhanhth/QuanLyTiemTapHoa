using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using QuanLyTiemTapHoa.Helpers;
using QuanLyTiemTapHoa.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyTiemTapHoa.DAOs
{
    public class LichSuTraNoDAO
    {
         private readonly string _cnn = DbConfig.ConnectionString;

        // 1. GetAll - gọi sp_LichSuTraNo_GetAll
        public List<LichSuTraNo> GetAll()
        {
            var list = new List<LichSuTraNo>();

            using var conn = new SqlConnection(_cnn);
            using var cmd = new SqlCommand("sp_LichSuTraNo_GetAll", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandTimeout = 60; // tăng timeout

            conn.Open();
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new LichSuTraNo
                {
                    MaNo = reader.GetString(0),
                    SoTienTra = reader.GetDecimal(1),
                    NgayTra = reader.GetDateTime(2)
                });
            }
            return list;
        }

    // 2. Search theo MaNo - gọi sp_LichSuTraNo_Search
    public List<LichSuTraNo> Search(string maNo)
    {
        var list = new List<LichSuTraNo>();

        using var conn = new SqlConnection(_cnn);
        using var cmd = new SqlCommand("sp_LichSuTraNo_Search", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@MaNo", maNo);

        conn.Open();
        using var reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            list.Add(new LichSuTraNo
            {
                MaNo = reader.GetString(0),
                SoTienTra = reader.GetDecimal(1),
                NgayTra = reader.GetDateTime(2)
            });
        }
        return list;
    }

    // 3. Insert gọi sp_LichSuTraNo_Insert
    public bool Insert(LichSuTraNo traNo)
    {
        using var conn = new SqlConnection(_cnn);
        using var cmd = new SqlCommand("sp_LichSuTraNo_Insert", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@MaNo", traNo.MaNo);
        cmd.Parameters.AddWithValue("@NgayTra", traNo.NgayTra);
        cmd.Parameters.AddWithValue("@SoTienTra", traNo.SoTienTra);

        try
        {
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }
        catch
        {
            // Ghi log lỗi nếu cần
            return false;
        }
    }
        public bool Update(string maNo, DateTime ngayTra, decimal soTienTra)
        {
            using (SqlConnection conn = new SqlConnection(_cnn))
            {
                using (SqlCommand cmd = new SqlCommand("sp_LichSuTraNo_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaNo", maNo);
                    cmd.Parameters.AddWithValue("@NgayTra", ngayTra);
                    cmd.Parameters.AddWithValue("@SoTienTra", soTienTra);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật lịch sử trả nợ: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // 4. Delete gọi sp_LichSuTraNo_Delete
        public bool Delete(string maNo, DateTime ngayTra)
    {
        using var conn = new SqlConnection(_cnn);
        using var cmd = new SqlCommand("sp_LichSuTraNo_Delete", conn);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@MaNo", maNo);
        cmd.Parameters.AddWithValue("@NgayTra", ngayTra);

        try
        {
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            return rows > 0;
        }
        catch
        {
            // Ghi log lỗi nếu cần
            return false;
        }
    }
    }
}
