public class CLIGamePrep
{
    // ClIPlayer player = new ClIPlayer();
    // CLISettings settings = new CLISettings();
    ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
    public void newgame()
    {
        CLISettings.MainenuOpen = false;
        Console.Clear();
        Console.WriteLine("set a name for your save:");
        miscellaneous.savename = Console.ReadLine();
        //Playerinfo();
        this.Playerinfo();

    }

    public void Playerinfo()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("===newgame====");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("1. Name:");
        if (CLIPlayer.Caneditname == true)
        {
            Console.ForegroundColor = CLIPlayer.Color;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine(CLIPlayer.Name);
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("2. ");
        Console.ForegroundColor = CLIPlayer.Color;
        Console.WriteLine("Colour");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("3. Species:");
        Console.ForegroundColor = CLIPlayer.Color;
        Console.WriteLine(CLIPlayer.Species);
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("4. Start");
        Console.ForegroundColor = ConsoleColor.Red;
        if (CLIPlayer.Caneditname == false)
        {
            Console.WriteLine("5. unlock");
        }
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("0. Exit");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        var plinfo = Console.ReadLine();
        switch (plinfo)
        {
            case "1":
                //Console.WriteLine("demo 1");
                Console.Clear();
                if (CLIPlayer.Caneditname == true)
                {
                    Console.WriteLine("name:");
                    CLIPlayer.Name = Console.ReadLine();
                }
                Playerinfo();
                break;
            case "2":
                //Console.WriteLine("demo 2");
                if (CLIPlayer.Caneditname == true)
                {
                    Coloursel();
                }
                else
                {
                    Playerinfo();
                }
                break;
            case "3":
                //Console.WriteLine("demo 3");
                if (CLIPlayer.Caneditname == true)
                {
                    Speciessel();
                }
                else
                {
                    Playerinfo();
                }
                break;
            case "4":
                if (CLISettings.BuiltInDemoEnabled == true)
                {
                    start();
                }
                else { }
                break;
            case "5":
                if (CLIPlayer.Caneditname == false)
                {
                    CLIPlayer.Name = "none";
                    CLIPlayer.Caneditname = true;
                    CLIPlayer.Color = ConsoleColor.Gray;
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
                    CLIPlayer.Protohexnum = -1;
                    CLIPlayer.Speciesablaty = "ancientGRool";
                    Playerinfo();
                }
                else
                {
                    Playerinfo();
                }
                break;
            case "0":
                //varpush();
                break;
            default:
                Playerinfo();
                break;
        }
    }

    void Speciessel()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("===Species====");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("1. Humans");
        Console.WriteLine("2. Anthros");
        Console.WriteLine("3. Custom");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
                Humanssel();
                break;
            case "2":
                Furrysel();
                break;
            case "3":
                Custommenu();
                break;
            case "0":
                Playerinfo();
                break;
            default:
                Speciessel();
                break;
        }
    }

    void Humanssel()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("===Species====");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("1. Human HP:20 SM:45 ST:32 SP:10");
        Console.Write("2. Goa'uld HP:30 SM:55 ST:40 SP:12(");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("evil");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine(")");
        Console.WriteLine("3. Tok'ra HP:30 SM:52 ST:40 SP:12");
        Console.WriteLine("4. Cat Boy/girl HP:18 SM:30 ST:32 SP:15 (HQ+1)");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
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
                this.Playerinfo();
                break;
            case "2":
                CLIPlayer.Species = "Goa'uld";
                CLIPlayer.Health = 30;
                CLIPlayer.Handequipped = 2;
                CLIPlayer.Smarts = 55;
                CLIPlayer.Speed = 12;
                CLIPlayer.Strength = 40;
                CLIPlayer.Parasite = true;
                CLIPlayer.Requirehost = true;
                CLIPlayer.Requirepower = false;
                CLIPlayer.Requirepowerlev = 0;
                CLIPlayer.PartTeck = false;
                CLIPlayer.Speciesablaty = "";
                CLIPlayer.Caneditname = true;
                this.Playerinfo();
                break;
            case "3":
                CLIPlayer.Species = "Tok'ra";
                CLIPlayer.Health = 30;
                CLIPlayer.Handequipped = 2;
                CLIPlayer.Smarts = 55;
                CLIPlayer.Speed = 12;
                CLIPlayer.Strength = 40;
                CLIPlayer.Parasite = true;
                CLIPlayer.Requirehost = true;
                CLIPlayer.Requirepower = false;
                CLIPlayer.Requirepowerlev = 0;
                CLIPlayer.PartTeck = false;
                CLIPlayer.Speciesablaty = "";
                CLIPlayer.Caneditname = true;
                this.Playerinfo();
                break;
            case "4":
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
                this.Playerinfo();
                break;
            case "0":
                Speciessel();
                break;
            default:
                Humanssel();
                break;
        }
    }

    void Furrysel()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("===Species====");
        Console.ForegroundColor = CLISettings.Dmcolor;
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
                CLIPlayer.Species = "Goa'uld";
                CLIPlayer.Health = 30;
                CLIPlayer.Handequipped = 2;
                CLIPlayer.Smarts = 55;
                CLIPlayer.Speed = 12;
                CLIPlayer.Strength = 40;
                Playerinfo();
                break;
            case "3":
                CLIPlayer.Species = "Tok'ra";
                CLIPlayer.Health = 30;
                CLIPlayer.Handequipped = 2;
                CLIPlayer.Smarts = 55;
                CLIPlayer.Speed = 12;
                CLIPlayer.Strength = 40;
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

    void K9sel()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("===Species====");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("1. Wolf HP:22 SM:47 ST:32 SP:12");
        Console.WriteLine("2. Goa'uld HP:30 SM:55 ST:40 SP:12");
        Console.WriteLine("3. Tok'ra HP:30 SM:52 ST:40 SP:12");
        Console.WriteLine("4. Cat Boy/girl HP:18 SM:30 ST:32 SP:15 (HQ+1)");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
                CLIPlayer.Species = "Wolf";
                CLIPlayer.Health = 22;
                CLIPlayer.Handequipped = 2;
                CLIPlayer.Smarts = 47;
                CLIPlayer.Speed = 12;
                CLIPlayer.Strength = 32;
                Playerinfo();
                break;
            case "2":
                CLIPlayer.Species = "Goa'uld";
                CLIPlayer.Health = 30;
                CLIPlayer.Handequipped = 2;
                CLIPlayer.Smarts = 55;
                CLIPlayer.Speed = 12;
                CLIPlayer.Strength = 40;
                Playerinfo();
                break;
            case "3":
                CLIPlayer.Species = "Tok'ra";
                CLIPlayer.Health = 30;
                CLIPlayer.Handequipped = 2;
                CLIPlayer.Smarts = 55;
                CLIPlayer.Speed = 12;
                CLIPlayer.Strength = 40;
                Playerinfo();
                break;
            case "4":
                CLIPlayer.Species = "Cat Boy/girl";
                CLIPlayer.Health = 18;
                CLIPlayer.Handequipped = 3;
                CLIPlayer.Smarts = 45;
                CLIPlayer.Speed = 15;
                CLIPlayer.Strength = 32;
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

    void FOGsel()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("===Species====");
        Console.ForegroundColor = CLISettings.Dmcolor;
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
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("====Odhex=====");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("1. Odhex");
        Console.WriteLine("2. ");
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
        {
            case "1":
                CLIPlayer.Species = "Odhex";
                CLIPlayer.Health = 30;
                CLIPlayer.Handequipped = 2;
                CLIPlayer.Smarts = 60;
                CLIPlayer.Strength = 32;
                CLIPlayer.Speed = 10;
                CLIPlayer.Parasite = false;
                CLIPlayer.Requirehost = false;
                CLIPlayer.Requirepower = false;
                CLIPlayer.Requirepowerlev = 0;
                CLIPlayer.PartTeck = true;
                CLIPlayer.Damageresistance = 1.2;
                CLIPlayer.Speciesablaty = "";
                CLIPlayer.Caneditname = true;
                Playerinfo();
                break;
            case "2":
                CLIPlayer.Species = "protohex";
                CLIPlayer.Health = 25;
                CLIPlayer.Handequipped = 2;
                CLIPlayer.Smarts = 55;
                CLIPlayer.Strength = 32;
                CLIPlayer.Speed = 10;
                CLIPlayer.Parasite = false;
                CLIPlayer.Requirehost = false;
                CLIPlayer.Requirepower = true;
                CLIPlayer.Requirepowerlev = 1700;
                CLIPlayer.PartTeck = true;
                CLIPlayer.Damageresistance = 1.3;
                CLIPlayer.Speciesablaty = "";
                CLIPlayer.Protohexnum = 005;
                CLIPlayer.Name = "Axel Wrenchblade";
                CLIPlayer.Color = ConsoleColor.DarkCyan;
                CLISettings.Dmcolor = ConsoleColor.DarkBlue;
                CLISettings.Mcolor = ConsoleColor.Cyan;
                CLIPlayer.Caneditname = false;
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
    
    void Custommenu()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("====Custom====");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("1. Code");
        Console.Write("2. ");
         if (CLISettings.ModingIsOn == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine("Mod");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("0. Back");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        switch (Console.ReadLine())
            {
                case"1":
                CustomCode();
                break;
                case"2":
                CustomMod();
                break;
                case"0":
                Speciessel();
                break;
                default:
                Custommenu();
                break;
            }
    }

    void CustomCode()
    {
 Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("====Custom====");
        Console.WriteLine($"{CLIIcon.Warn}Use 0 to go back");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("Code:");
        switch (Console.ReadLine())
            {
                case"1":
                
                break;
                case"2257":
                
                break;
                case"0":
                Custommenu();
                break;
                default:
                CustomCode();
                break;
            }
    }

    void CustomMod()
    {
    Custommenu();
    }

    void Coloursel()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("1. ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("red");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("2. ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Magenta");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("3. ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Yellow");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("4. ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Green");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("5. ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("6. ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Cyan");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("7. ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Gray");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("");
        Console.Write(">");
        Console.ForegroundColor = ConsoleColor.White;
        switch (Console.ReadLine())
        {
            case "1":
                CLIPlayer.Color = ConsoleColor.Red;
                break;
            case "2":
                CLIPlayer.Color = ConsoleColor.Magenta;
                break;
            case "3":
                CLIPlayer.Color = ConsoleColor.Yellow;
                break;
            case "4":
                CLIPlayer.Color = ConsoleColor.Green;
                break;
            case "5":
                CLIPlayer.Color = ConsoleColor.Blue;
                break;
            case "6":
                CLIPlayer.Color = ConsoleColor.Cyan;
                break;
            case "7":
                CLIPlayer.Color = ConsoleColor.Gray;
                break;
            default:
                Coloursel();
                break;
        }
        Playerinfo();
    }

    void start()
    {
        //Console.ForegroundColor= settings.mcolor;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("1. Standard game");
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("2. Demo game");
        switch (Console.ReadLine())
        {
            case "1":
                start();
                break;
            case "2":
                //demo.demo1();
                break;
            default:
                start();
                break;
        }
    }
}