using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Models;
using QuanLyTiemTapHoa.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyTiemTapHoa.DAO
{
    public class ThongKeNoDAO
    {
        private static readonly string _cnn = DbConfig.ConnectionString;

        public static List<(string ThangNam, decimal TongNo)> LayDuLieuThongKeNo(DateTime tuNgay, DateTime denNgay)
        {
            var ketQua = new List<(string, decimal)>();

            using (SqlConnection conn = new SqlConnection(_cnn))
            using (SqlCommand cmd = new SqlCommand("pThongKeTongNoTheoThang", conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
                cmd.Parameters.AddWithValue("@DenNgay", denNgay);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string thangNam = reader["ThangNam"].ToString();
                        decimal tongNo = Convert.ToDecimal(reader["TongNo"]);
                        ketQua.Add((thangNam, tongNo));
                    }
                }
            }

            return ketQua;
        }
    }
}
