using System;
using System.Runtime.InteropServices;
public class CLIRuntimevar
{
    public static double errors { get; set; } = 0;

    public static double warns { get; set; } = 0;

    public static string OS { get; set; } = "0";
    public static bool crt { get; set; }
    public static void rerror()
    {
        errors++;
    }
    public static void rwarns()
    {
        warns++;
    }
    public static void OSGet()
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            OS = "1"; //1 Linux
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            OS = "2"; //2 Mac
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            OS = "3"; //3 Windows
        }
        else
        {
            OS = "4"; //Unknown
            rwarns();
        }
    }
    public static string OSName()
    {
        switch (OS)
        {
            case "1":
                return "Linux";
            case "2":
                return "MacOS";
            case "3":
                return "Windows";
            case "4":
                return "Unknown";
            default:
                return "error";
        }
    }
}