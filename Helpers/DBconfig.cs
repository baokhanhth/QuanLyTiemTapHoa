using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyTiemTapHoa.Helpers
{
    /// <summary>
    /// Helper class cung cấp chung connection string cho toàn ứng dụng.
    /// </summary>
    public static class DbConfig
    {
        /// <summary>
        /// Lấy connection string từ app.config (hoặc web.config).
        /// </summary>
        public static string ConnectionString =>ConfigurationManager.ConnectionStrings["QuanLyBanHang"].ConnectionString;

        public static string GetConnectionString(string username, string password)
        {
            return $"Data Source=Arus\\BAOKHANH;Initial Catalog=QuanLyBanHang;User ID={username};Password={password};TrustServerCertificate=True;";
        }
    }
}
