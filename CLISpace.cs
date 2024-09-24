public class CLISpace
{

    public static List<string?> Galaxy { get; set; } = new List<string?>();
    public static List<string?> Solar_System { get; set; } = new List<string?>();
    public static List<string?> Planet { get; set; } = new List<string?>();
    public static void init()
    {
        int x = CLISpace.Galaxy.Count;
        if (CLISpace.Galaxy.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                CLILogo.logostart("Config " + CLISpace.Galaxy[i]);
            }
        }
        x = CLISpace.Solar_System.Count;
        if (CLISpace.Solar_System.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                CLILogo.logostart("Config " + CLISpace.Solar_System[i]);
            }
        }
        x = CLISpace.Planet.Count;
        if (CLISpace.Planet.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                CLILogo.logostart("Config " + CLISpace.Planet[i]);
            }
        }
    }
}