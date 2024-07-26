public class CLISpecieList : CLIGamePrep
{
    // ClIPlayer player = new ClIPlayer();
    // CLISettings settings = new CLISettings(); // I didn't touch the settings vars commented out
    ClIMiscellaneous miscellaneous = new ClIMiscellaneous();

    public void Human()
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
        CLIPlayer.speciesAbility = "ancientGRool";
        CLIPlayer.canEditName = true;
    }
    /**/

    public void CatBoyGirl()
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
        CLIPlayer.speciesAbility = "ancientGRool";
        CLIPlayer.canEditName = true;
    }

    public void Wolf()
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
        CLIPlayer.speciesAbility = "";
        CLIPlayer.canEditName = true;
    }

    public void Cat()
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
        CLIPlayer.speciesAbility = "";
        CLIPlayer.canEditName = true;
    }

    public void Avali()
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
        CLIPlayer.speciesAbility = "Fly";
        CLIPlayer.canEditName = true;
    }

    public void a() { }


    /*void Furrysel()
    {
        Console.Clear();
        Console.ForegroundColor = settings.mcolor;
        Console.WriteLine("===species====");
        Console.ForegroundColor = settings.dmcolor;
        Console.WriteLine("1. K9");
        Console.WriteLine("2. Feline");
        Console.WriteLine("3. ...");
        Console.WriteLine("4. OG speses");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
                K9sel();
                break;
            case "2":
                player.species = "Goa'uld";
                player.health = 30;
                player.handequipped = 2;
                player.smarts = 55;
                player.speed = 12;
                player.strength = 40;
                Playerinfo();
                break;
            case "3":
                player.species = "Tok'ra";
                player.health = 30;
                player.handequipped = 2;
                player.smarts = 55;
                player.speed = 12;
                player.strength = 40;
                Playerinfo();
                break;
            case "4":
                FOGsel();
                break;
            case "0":
                speciessel();
                break;
            default:
                Furrysel();
                break;
        }
    }


    void FOGsel()
    {
        Console.Clear();
        Console.ForegroundColor = settings.mcolor;
        Console.WriteLine("===species====");
        Console.ForegroundColor = settings.dmcolor;
        Console.WriteLine("1. odhex by sparcky_ancientpack");
        Console.WriteLine("2. Corpse crawler by Frico⚠️");
        Console.WriteLine("3. protogen by Malice-Risu HP:22 SM:57 ST:32 SP:10");
        Console.WriteLine("4. Cat Boy/girl HP:18 SM:30 ST:32 SP:15");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
                Odhexsel();
                break;
            case "2":
                Playerinfo();
                break;
            case "3":
                player.species = "protogen";
                player.health = 22;
                player.handequipped = 2;
                player.smarts = 57;
                player.strength = 32;
                player.speed = 10;
                player.parasite = false;
                player.requireHost = false;
                player.requirePower = false;
                player.requirePowerLevel = 0;
                player.partTech = true;
                player.Damageresistance = 1.3;
                player.speciesAbility = "none";
                player.canEditName = true;
                Playerinfo();
                break;
            case "4":
                Playerinfo();
                break;
            case "0":
                speciessel();
                break;
            default:
                K9sel();
                break;
        }
    }

    void Odhexsel()
    {
        Console.Clear();
        Console.ForegroundColor = settings.mcolor;
        Console.WriteLine("====Odhex=====");
        Console.ForegroundColor = settings.dmcolor;
        Console.WriteLine("1. Odhex");
        Console.WriteLine("2. ");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
                player.species = "Odhex";
                player.health = 30;
                player.handequipped = 2;
                player.smarts = 60;
                player.strength = 32;
                player.speed = 10;
                player.parasite = false;
                player.requireHost = false;
                player.requirePower = false;
                player.requirePowerLevel = 0;
                player.partTech = true;
                player.Damageresistance = 1.2;
                player.speciesAbility = "";
                player.canEditName = true;
                Playerinfo();
                break;
            case "2":
                player.species = "protohex";
                player.health = 25;
                player.handequipped = 2;
                player.smarts = 55;
                player.strength = 32;
                player.speed = 10;
                player.parasite = false;
                player.requireHost = false;
                player.requirePower = true;
                player.requirePowerLevel = 1700;
                player.partTech = true;
                player.Damageresistance = 1.3;
                player.speciesAbility = "";
                player.protohexnum = 005;
                player.name = "Axel Wrenchblade";
                player.color = ConsoleColor.DarkCyan;
                settings.dmcolor = ConsoleColor.DarkBlue;
                settings.mcolor = ConsoleColor.Cyan;
                player.canEditName = false;
                Playerinfo();
                break;
            case "0":
                speciessel();
                break;
            default:
                Odhexsel();
                break;
        }
    }

    void Coloursel()
    {
        Console.Clear();
        Console.ForegroundColor = settings.dmcolor;
        Console.Write("1. ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("red");
        Console.ForegroundColor = settings.dmcolor;
        Console.Write("2. ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Magenta");
        Console.ForegroundColor = settings.dmcolor;
        Console.Write("3. ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Yellow");
        Console.ForegroundColor = settings.dmcolor;
        Console.Write("4. ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Green");
        Console.ForegroundColor = settings.dmcolor;
        Console.Write("5. ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        Console.ForegroundColor = settings.dmcolor;
        Console.Write("6. ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Cyan");
        Console.ForegroundColor = settings.dmcolor;
        Console.Write("7. ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Gray");
        Console.ForegroundColor = settings.dmcolor;
        Console.WriteLine("");
        Console.Write(">");
        Console.ForegroundColor = ConsoleColor.White;
        switch (Console.ReadLine())
        {
            case "1":
                player.color = ConsoleColor.Red;
                break;
            case "2":
                player.color = ConsoleColor.Magenta;
                break;
            case "3":
                player.color = ConsoleColor.Yellow;
                break;
            case "4":
                player.color = ConsoleColor.Green;
                break;
            case "5":
                player.color = ConsoleColor.Blue;
                break;
            case "6":
                player.color = ConsoleColor.Cyan;
                break;
            case "7":
                player.color = ConsoleColor.Gray;
                break;
            default:
                Coloursel();
                break;
        }
        Playerinfo();
    }*/

}