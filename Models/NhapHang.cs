using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.Models
{
    public class NhapHang
    {
        public string MaNH { get; set; }
        public DateTime? NgayNhap { get; set; }
        public string MaNCC { get; set; }
        public decimal NH_TongCong { get; set; }
        public decimal CK_NH { get; set; }
        public decimal NH_ThanhToan { get; set; }
    }
}
