using Microsoft.Data.SqlClient;
using QuanLyTiemTapHoa.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.DAOs
{
    internal class TonKhoDAO
    {
        private static readonly string _cnn = DbConfig.ConnectionString;

        public static DataTable LayBaoCaoTonKho()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(_cnn))
                using (SqlCommand cmd = new SqlCommand("pTaoBaoCaoTonKho", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (SqlException ex)
            {
                // Ghi log lỗi hoặc hiển thị thông báo
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return dt;
        }
    }
}
