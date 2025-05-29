using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.Models
{
    public class ChiTietNhapHang
    {
        public string MaNH { get; set; }
        public string MaLo { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal NH_ThanhTien { get; set; }
        public decimal GiaNhap { get; set; }
    }
}
