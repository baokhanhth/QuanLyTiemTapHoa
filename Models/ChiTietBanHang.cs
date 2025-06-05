using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemTapHoa.Models
{
    public class ChiTietBanHang : INotifyPropertyChanged
    {
        private string _maHang;
        private string _tenHang;
        private int _soLuongBan;
        private decimal _donGB;

        public string MaBH { get; set; }

        public string MaHang
        {
            get => _maHang;
            set
            {
                if (_maHang != value)
                {
                    _maHang = value;
                    OnPropertyChanged(nameof(MaHang));
                }
            }
        }

        public string TenHang
        {
            get => _tenHang;
            set
            {
                if (_tenHang != value)
                {
                    _tenHang = value;
                    OnPropertyChanged(nameof(TenHang));
                }
            }
        }

        public int SoLuongBan
        {
            get => _soLuongBan;
            set
            {
                if (_soLuongBan != value)
                {
                    _soLuongBan = value;
                    OnPropertyChanged(nameof(SoLuongBan));
                    OnPropertyChanged(nameof(BH_ThanhTien)); // cập nhật thành tiền khi số lượng thay đổi
                }
            }
        }

        public decimal DonGB
        {
            get => _donGB;
            set
            {
                if (_donGB != value)
                {
                    _donGB = value;
                    OnPropertyChanged(nameof(DonGB));
                    OnPropertyChanged(nameof(BH_ThanhTien)); // cập nhật thành tiền khi đơn giá thay đổi
                }
            }
        }

        // Thành tiền tính tự động từ đơn giá và số lượng
        public decimal BH_ThanhTien { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
