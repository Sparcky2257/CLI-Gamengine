public class CLISettings
{
    public static bool MainenuOpen { get; set; } = true;
    public static bool Debug { get; set; } = false;
    public static bool ModingIsOn { get; set; } = false;
    public static bool CustomLogoIsOn { get; set; } = false;
    public static double Bootlogo { get; set; } = 1;
    public static double Icons { get; set; } = 1;
    public static ConsoleColor Mcolor { get; set; } = ConsoleColor.Gray;
    public static ConsoleColor Dmcolor { get; set; } = ConsoleColor.DarkGray;
    
    public static bool NfswIsOn { get; set; } = false;
    public static bool BuiltInDemoEnabled { get; set; } = true;
}