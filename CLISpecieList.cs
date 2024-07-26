public class CLISpecieList //: CLIGamePrep
{
    // ClIPlayer player = new ClIPlayer();
    // CLISettings settings = new CLISettings(); // I didn't touch the settings vars commented out
    ClIMiscellaneous miscellaneous = new ClIMiscellaneous();

    public static void Human()
    {
        CLIPlayer.Species = "Human";
        CLIPlayer.Health = 20;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 45;
        CLIPlayer.Speed = 10;
        CLIPlayer.Strength = 32;
        CLIPlayer.Parasite = false;
        CLIPlayer.Requirehost = false;
        CLIPlayer.Requirepower = false;
        CLIPlayer.Requirepowerlev = 0;
        CLIPlayer.PartTeck = false;
        CLIPlayer.Speciesablaty = "ancientGRool";
        CLIPlayer.Caneditname = true;
    }
    /**/

    public static void CatBoyGirl()
    {
        CLIPlayer.Species = "Cat Boy/girl";
        CLIPlayer.Health = 18;
        CLIPlayer.Handequipped = 3;
        CLIPlayer.Smarts = 45;
        CLIPlayer.Speed = 15;
        CLIPlayer.Strength = 32;
        CLIPlayer.Parasite = false;
        CLIPlayer.Requirehost = false;
        CLIPlayer.Requirepower = false;
        CLIPlayer.Requirepowerlev = 0;
        CLIPlayer.PartTeck = false;
        CLIPlayer.Speciesablaty = "ancientGRool";
        CLIPlayer.Caneditname = true;
    }

    public static void Wolf()
    {
        CLIPlayer.Species = "Wolf";
        CLIPlayer.Health = 22;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 47;
        CLIPlayer.Speed = 12;
        CLIPlayer.Strength = 32;
        CLIPlayer.Parasite = false;
        CLIPlayer.Requirehost = false;
        CLIPlayer.Requirepower = false;
        CLIPlayer.Requirepowerlev = 0;
        CLIPlayer.PartTeck = false;
        CLIPlayer.Speciesablaty = "";
        CLIPlayer.Caneditname = true;
    }

    public static void Cat()
    {
        CLIPlayer.Species = "Cat";
        CLIPlayer.Health = 20;
        CLIPlayer.Handequipped = 3;
        CLIPlayer.Smarts = 47;
        CLIPlayer.Speed = 12;
        CLIPlayer.Strength = 32;
        CLIPlayer.Parasite = false;
        CLIPlayer.Requirehost = false;
        CLIPlayer.Requirepower = false;
        CLIPlayer.Requirepowerlev = 0;
        CLIPlayer.PartTeck = false;
        CLIPlayer.Speciesablaty = "";
        CLIPlayer.Caneditname = true;
    }

    public static void Avali()
    {
        CLIPlayer.Species = "Avali";
        CLIPlayer.Health = 30;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 20;
        CLIPlayer.Speed = 16;
        CLIPlayer.Strength = 36;
        CLIPlayer.Parasite = false;
        CLIPlayer.Requirehost = false;
        CLIPlayer.Requirepower = false;
        CLIPlayer.Requirepowerlev = 0;
        CLIPlayer.PartTeck = false;
        CLIPlayer.Speciesablaty = "Fly";
        CLIPlayer.Caneditname = true;
    }

    public static void Protogen()
    {
        CLIPlayer.Species = "protogen";
        CLIPlayer.Health = 22;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 57;
        CLIPlayer.Strength = 32;
        CLIPlayer.Speed = 10;
        CLIPlayer.Parasite = false;
        CLIPlayer.Requirehost = false;
        CLIPlayer.Requirepower = false;
        CLIPlayer.Requirepowerlev = 0;
        CLIPlayer.PartTeck = true;
        CLIPlayer.Damageresistance = 1.3;
        CLIPlayer.Speciesablaty = "none";
        CLIPlayer.Caneditname = true;
    }


    /*void Furrysel()
    {
        Console.Clear();
        Console.ForegroundColor = settings.mcolor;
        Console.WriteLine("===Species====");
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
                player.Species = "Goa'uld";
                player.health = 30;
                player.handequipped = 2;
                player.smarts = 55;
                player.speed = 12;
                player.strength = 40;
                Playerinfo();
                break;
            case "3":
                player.Species = "Tok'ra";
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
                Speciessel();
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
        Console.WriteLine("===Species====");
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
                player.Species = "protogen";
                player.health = 22;
                player.handequipped = 2;
                player.smarts = 57;
                player.strength = 32;
                player.speed = 10;
                player.Parasite = false;
                player.Requirehost = false;
                player.Requirepower = false;
                player.Requirepowerlev = 0;
                player.PartTeck = true;
                player.Damageresistance = 1.3;
                player.Speciesablaty = "none";
                player.caneditname = true;
                Playerinfo();
                break;
            case "4":
                Playerinfo();
                break;
            case "0":
                Speciessel();
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
                player.Species = "Odhex";
                player.health = 30;
                player.handequipped = 2;
                player.smarts = 60;
                player.strength = 32;
                player.speed = 10;
                player.Parasite = false;
                player.Requirehost = false;
                player.Requirepower = false;
                player.Requirepowerlev = 0;
                player.PartTeck = true;
                player.Damageresistance = 1.2;
                player.Speciesablaty = "";
                player.caneditname = true;
                Playerinfo();
                break;
            case "2":
                player.Species = "protohex";
                player.health = 25;
                player.handequipped = 2;
                player.smarts = 55;
                player.strength = 32;
                player.speed = 10;
                player.Parasite = false;
                player.Requirehost = false;
                player.Requirepower = true;
                player.Requirepowerlev = 1700;
                player.PartTeck = true;
                player.Damageresistance = 1.3;
                player.Speciesablaty = "";
                player.protohexnum = 005;
                player.name = "Axel Wrenchblade";
                player.color = ConsoleColor.DarkCyan;
                settings.dmcolor = ConsoleColor.DarkBlue;
                settings.mcolor = ConsoleColor.Cyan;
                player.caneditname = false;
                Playerinfo();
                break;
            case "0":
                Speciessel();
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