public class CLIIcon
{
    public static double errors { get; set; } = 0;


    public static void rerror()
    {
        errors++;
    }
    public static string Warn()
    {
        string x = "";
        if (CLISettings.Icons == 1)
        {
            x = "";
        }
        else if (CLISettings.Icons == 2)
        {
            x = "⚠️";
        }
        return x;
    }
}