public class CLISettings
{
    public static bool mainMenuOpen { get; set; } = true;
    public static bool Debug { get; set; } = false;
    public static bool moddingIsOn { get; set; } = false;
    public static bool customLogoIsOn { get; set; } = false;
    public static double Bootlogo { get; set; } = 1;
    public static double Icons { get; set; } = 1;
    public static ConsoleColor Mcolor { get; set; } = ConsoleColor.Gray;
    public static ConsoleColor Dmcolor { get; set; } = ConsoleColor.DarkGray;
    public static char audioeng {get; set;} = '1';
    // 1 dot net defult. (widnows)
    //
    public static bool NSFWIsOn { get; set; } = false;
    public static bool BuiltInDemoEnabled { get; set; } = true;
}