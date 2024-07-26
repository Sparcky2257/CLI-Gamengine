public class CLIPlayer
{
    public static string? Name { get; set; } = "none";
    public static ConsoleColor Color { get; set; } = ConsoleColor.Gray;
    public static double Health { get; set; } = 20;
    public static double Handequipped { get; set; } = 2;
    public static double Smarts { get; set; } = 45;
    public static double Strength { get; set; } = 32;
    public static double Speed { get; set; } = 10;
    public static bool parasite { get; set; } = false;
    public static bool requireHost { get; set; } = false;
    public static bool requirePower { get; set; } = false;
    public static double requirePowerLevel { get; set; } = 0;
    public static bool partTech { get; set; } = false;
    public static double damageResistance { get; set; } = 1.001;
    public static string? speciesAbility { get; set; } = "";
    public static double Protohexnum { get; set; } = -1;
    public static bool canEditName { get; set; } = true;
    public static string? Sex { get; set; } = "male";
    public static string? species { get; set; } = "Human";
    public static bool isLatex { get; set; } = false;
    public static bool CanTF { get; set; } = false;
    public static string? latexType { get; set; } = "";
    public static string? previousSpecies { get; set; } = "";
    public static string? pronouns { get; set; } = "thay him";
}