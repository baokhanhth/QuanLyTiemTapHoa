using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using System.Data;

public class BaoCaoDAO
{
    private static readonly string _cnn = DbConfig.ConnectionString;

    public static List<(string ThangNam, decimal TongDoanhThu)> LayBaoCaoDoanhThu(DateTime tuNgay, DateTime denNgay)
    {
        var ketQua = new List<(string, decimal)>();

        using (SqlConnection conn = new SqlConnection(_cnn))
        using (SqlCommand cmd = new SqlCommand("pTaoBaoCaoDoanhThu", conn))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TuNgay", tuNgay);
            cmd.Parameters.AddWithValue("@DenNgay", denNgay);
            cmd.CommandTimeout = 120; // <-- Thêm dòng này

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string thangNam = reader["ThangNam"].ToString();
                    decimal tongDoanhThu = Convert.ToDecimal(reader["TongDoanhThu"]);
                    ketQua.Add((thangNam, tongDoanhThu));
                }
            }
        }

        return ketQua;
    }
}
