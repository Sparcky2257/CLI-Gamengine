public class CLIPlayer
{
    public static string? Name { get; set; } = "alex"; //edit none to alex
    public static ConsoleColor Color { get; set; } = ConsoleColor.Gray; //same
    public static double Health { get; set; } = 20; //same
    public static double life { get; set; } = 20; //new
    public static double Handequipped { get; set; } = 2; //same
    public static double Smarts { get; set; } = 45; //same
    public static double Strength { get; set; } = 32; //same
    public static double Speed { get; set; } = 10; //same
    public static bool parasite { get; set; } = false; //same
    public static bool requireHost { get; set; } = false; //same
    public static bool requirePower { get; set; } = false; //same
    public static double requirePowerLevel { get; set; } = 0; // depcadchon in a futre update ues PowerLevel and PowerLevelmax
    public static double PowerLevel { get; set; } = -1; //new
    public static double PowerLevelmax { get; set; } = -1; //new
    public static double PowerDrain { get; set; } = -1; //new
    public static bool partTech { get; set; } = false; //same
    public static double damageResistance { get; set; } = 1.001; //same
    public static string? speciesAbility { get; set; } = "none"; //same
    public static double Protohexnum { get; set; } = -1; //same
    public static bool canEditName { get; set; } = true; //same
    public static string? Sex { get; set; } = "male"; //same
    public static string? species { get; set; } = "Human"; //same
    public static bool isLatex { get; set; } = false; // depcadchon in a futre update ues isInfected
    public static bool isInfected { get; set; } = false;//new
    public static bool CanTF { get; set; } = false; // depcadchon in a futre update ues CanInfect
    public static bool CanInfect { get; set; } = false;//new
    public static string? latexType { get; set; } = ""; // depcadchon in a futre update ues extraData
    public static string? previousSpecies { get; set; } = ""; // depcadchon in a futre update ues extraData
    public static string? pronouns { get; set; } = "thay him"; //same
    public static List<string?> extraData { get; set; } = new List<string?>();// ex:"data type:data","data type:data:data 2"...
}