public class CLISpecieList //: CLIGamePrep
{
    public static List<string?> List { get; set; } = new List<string?>();// ex:"type:data"
    public static void Human()
    {
        CLIPlayer.species = "Human";
        CLIPlayer.Health = 20;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 45;
        CLIPlayer.Speed = 10;
        CLIPlayer.Strength = 32;
        CLIPlayer.parasite = false;
        CLIPlayer.requireHost = false;
        CLIPlayer.requirePower = false;
        CLIPlayer.requirePowerLevel = 0;
        CLIPlayer.partTech = false;
        //CLIPlayer.speciesAbility = "ancientGRool";
        CLIPlayer.canEditName = true;
    }
}