using ClassManagementSystemMAUIVersion.Model;
using Microsoft.Maui.Devices.Sensors;
using System.Data.SQLite;
using CommunityToolkit.Maui;
using UraniumUI;

namespace ClassManagementSystemMAUIVersion;
public static class MauiProgram
{
    static SQLiteConnection CreateConnection()
    {
        SQLiteConnection sqlite_conn;
        Console.WriteLine(FileSystem.Current.AppDataDirectory);
        // Create a new database connection:
        sqlite_conn = new SQLiteConnection($"Data Source={FileSystem.Current.AppDataDirectory}/ClassManagement.db; Version = 3; New = True; Compress = True; ");
        sqlite_conn = ConnectionSingleton.GetInstance(sqlite_conn).Value;
        // Open the connection:
        try
        {
            sqlite_conn.Open();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Connection created");
        return sqlite_conn;
    }

    public static MauiApp CreateMauiApp()
    {
        var conn = CreateConnection();
        new Student().createTable();
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
            fonts.AddFont("Poppins-Semibold.ttf", "PoppinsSemibold");
            fonts.AddFont("SourceSans3-VariableFont_wght.ttf", "SourceSans");
            fonts.AddFontAwesomeIconFonts(); // 👈 Add this line
        }).UseMauiCommunityToolkit().ConfigureMauiHandlers(
            handlers =>
            {
                handlers.AddUraniumUIHandlers(); // 👈 This line should be added.
            }
            );
        return builder.Build();
    }
}