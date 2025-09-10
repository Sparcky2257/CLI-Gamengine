using System.Reflection;
public class CLIFile
{
    public static string? DefaultPath { get; set; } //edit none to alex
    public static void load()
    {
        //detecif windiows or unix based system to know how to access files
        if (CLIRuntimevar.OS == "3") // Windows
        {
            loadWindows();
        }
        else // Unix based system
        {
            loadUnix();
        }
    }
    static void loadWindows()
    {
        // Load Windows specific file handling
        // setes default path to gamengine executable folder
        string exePath = Assembly.GetExecutingAssembly().Location;
        DefaultPath = Path.GetDirectoryName(exePath) ?? "";
        CLILogo.logostart($"CLIFile: Windows default path set to {DefaultPath}", 898);
    }
    static void loadUnix()
    {
        // Load Unix specific file handling
        // setes default path to gamengine executable folder
        string exePath = Assembly.GetExecutingAssembly().Location;
        DefaultPath = Path.GetDirectoryName(exePath) ?? "";
        CLILogo.logostart($"CLIFile: default path set to {DefaultPath}", 898);
    }
    

}