using QuanLiTiemTapHoa;

namespace QuanLyTiemTapHoa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmThongTinKhachHang("KH00000001"));
            //Application.Run(new frmThongTinLoHang("LH00000001"));
            //Application.Run(new frmLogin());
            //Application.Run(new frmKhachHang());
            //Application.Run(new frmThongTinChiTietNo("N000000001"));
            //Application.Run(new frmThongTinTongNo("N000000188"));
            Application.Run(new frmLoHang());
        }
    }
}