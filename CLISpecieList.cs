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
    /**/

    public static void CatBoyGirl()
    {
        CLIPlayer.species = "Cat Boy/girl";
        CLIPlayer.Health = 18;
        CLIPlayer.Handequipped = 3;
        CLIPlayer.Smarts = 45;
        CLIPlayer.Speed = 15;
        CLIPlayer.Strength = 32;
        CLIPlayer.parasite = false;
        CLIPlayer.requireHost = false;
        CLIPlayer.requirePower = false;
        CLIPlayer.requirePowerLevel = 0;
        CLIPlayer.partTech = false;
        //CLIPlayer.speciesAbility = "ancientGRool";
        CLIPlayer.canEditName = true;
    }

    public static void Wolf()
    {
        CLIPlayer.species = "Wolf";
        CLIPlayer.Health = 22;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 47;
        CLIPlayer.Speed = 12;
        CLIPlayer.Strength = 32;
        CLIPlayer.parasite = false;
        CLIPlayer.requireHost = false;
        CLIPlayer.requirePower = false;
        CLIPlayer.requirePowerLevel = 0;
        CLIPlayer.partTech = false;
        //CLIPlayer.speciesAbility = "";
        CLIPlayer.canEditName = true;
    }

    public static void Cat()
    {
        CLIPlayer.species = "Cat";
        CLIPlayer.Health = 20;
        CLIPlayer.Handequipped = 3;
        CLIPlayer.Smarts = 47;
        CLIPlayer.Speed = 12;
        CLIPlayer.Strength = 32;
        CLIPlayer.parasite = false;
        CLIPlayer.requireHost = false;
        CLIPlayer.requirePower = false;
        CLIPlayer.requirePowerLevel = 0;
        CLIPlayer.partTech = false;
        //CLIPlayer.speciesAbility = "";
        CLIPlayer.canEditName = true;
    }

    public static void Avali()
    {
        CLIPlayer.species = "Avali";
        CLIPlayer.Health = 30;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 20;
        CLIPlayer.Speed = 16;
        CLIPlayer.Strength = 36;
        CLIPlayer.parasite = false;
        CLIPlayer.requireHost = false;
        CLIPlayer.requirePower = false;
        CLIPlayer.requirePowerLevel = 0;
        CLIPlayer.partTech = false;
        //CLIPlayer.speciesAbility = "Fly";
        CLIPlayer.canEditName = true;
    }

    public static void Protogen()
    {
        CLIPlayer.species = "protogen";
        CLIPlayer.Health = 22;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 57;
        CLIPlayer.Strength = 32;
        CLIPlayer.Speed = 10;
        CLIPlayer.parasite = false;
        CLIPlayer.requireHost = false;
        CLIPlayer.requirePower = false;
        CLIPlayer.requirePowerLevel = 0;
        CLIPlayer.partTech = true;
        CLIPlayer.damageResistance = 1.3;
        //CLIPlayer.speciesAbility = "none";
        CLIPlayer.canEditName = true;
    }
}