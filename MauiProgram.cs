using MiApp.Clases;
using Microsoft.Extensions.Logging;

namespace MiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            string dbPath = FileAccesHelper.GetLocalFilePath("SQLiteDB.db3");
            builder.Services.AddSingleton<HelperSQLite>(s => ActivatorUtilities.CreateInstance<HelperSQLite>(s, dbPath));

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
