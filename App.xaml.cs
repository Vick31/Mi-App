using MiApp.Clases;

namespace MiApp
{
    public partial class App : Application
    {
        public static HelperSQLite? HelperSQLite { get; set; }
        public App(HelperSQLite helperSQLite)
        {
            InitializeComponent();

            MainPage = new AppShell();
            HelperSQLite = helperSQLite;
        }
    }
}
