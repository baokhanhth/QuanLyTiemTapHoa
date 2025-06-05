namespace QuanLyTiemTapHoa
{
    internal static class Program
    {
        public static frmLogin frmLoginInstance;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); 

            frmLoginInstance = new frmLogin();
            Application.Run(frmLoginInstance); 
        }
    }
}
