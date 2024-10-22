public class CLISpecieList //: CLIGamePrep
{

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
    /*
    //text
    public static string textboxname { get; set; } = "";
    public static string textboxvar { get; set; } = "1";
    static string textboxstylevar = "1";
    static ConsoleColor textboxnameCL { get; set; } = ConsoleColor.White;
    static ConsoleColor CLtemmp { get; set; } = ConsoleColor.White;
    public static List<string?> textdata { get; set; } = new List<string?>();
    public static void textbox()
    {
        textboxstyle();
        int line = 1;
        int x = textdata.Count;
        for (int i = 0; i < x; i++)
        {

            switch (textdata[i])
            {
                case "CL":
                    Color();
                    break;
                case "MC":
                    Console.ForegroundColor = CLISettings.Mcolor;
                    break;
                case "DMC":
                    Console.ForegroundColor = CLISettings.Dmcolor;
                    break;
                case "CR":
                    Console.ResetColor();
                    break;
                case "WL":
                    line++;
                    if (CLISettings.Debug == true)
                    {
                        Console.WriteLine($" {line - 1}/{CLISettings.textmaxline - 1}");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    if (line >= CLISettings.textmaxline)
                    {
                        textboxstylenext();
                        line = 1;
                        textboxstyle();
                    }


                    break;
                case "RS":
                    textdata.Clear();
                    break;
                case "TP":
                    textboxstyle();
                    break;
                case "NX":
                    if (line != CLISettings.textmaxline)
                    {
                        //int z = line;
                        for (int z = line; z < CLISettings.textmaxline; z++)
                        {
                            if (CLISettings.Debug == true)
                            {
                                Console.WriteLine($" {line - 1}/{CLISettings.textmaxline - 1}");
                            }
                            else
                            {
                                Console.WriteLine();
                            }
                        }
                        line = 1;
                    }
                    textboxstylenext();
                    break;
                default:
                    Console.Write(textdata[i]);
                    break;

            }
            void Color()
            {
                i++;
                switch (textdata[i])
                {
                    case "Red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "Magenta":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case "Yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case "Green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case "Blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "Cyan":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case "Gray":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case "DarkRed":
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case "DarkMagenta":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    case "DarkYellow":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "DarkGreen":
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case "DarkBlue":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case "DarkCyan":
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case "DarkGray":
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    default:
                        break;
                }
            }

        }
    }

    static void textboxstyle()
    {
        switch (textboxstylevar)
        {
            case "1":
                Console.Clear();
                Console.WriteLine();
                CLtemmp = Console.ForegroundColor;
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"####/");
                Console.WriteLine(textboxname, Console.ForegroundColor = textboxnameCL);
                Console.ForegroundColor = CLtemmp;
                break;
            default:
                break;
        }
    }
    static void textboxstylenext()
    {
        //Console.WriteLine();
        CLtemmp = Console.ForegroundColor;
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.Write($"next");
        Console.ReadLine();
        Console.ForegroundColor = CLtemmp;
        //return "null";
    }
    //old
    public string textboxvarold { get; set; } = "1";
    public string textboxnameold { get; set; } = "";
    public ConsoleColor textboxnamecold { get; set; } = ConsoleColor.White;

    public void TextBoxstartold()
    {
        switch (textboxvarold)
        {
            case "1":
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"####/");
                Console.WriteLine(textboxnameold, Console.ForegroundColor = textboxnamecold);
                Console.ForegroundColor = CLISettings.Mcolor;
                break;
            case "0":
                Console.WriteLine();
                Console.Clear();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"####/");
                Console.WriteLine(textboxnameold, Console.ForegroundColor = textboxnamecold);
                Console.ForegroundColor = CLISettings.Mcolor;
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("textvar mode:error 404 perss enter to contue.");
                Console.ForegroundColor = ConsoleColor.White;
                CLIRuntimevar.rerror();
                Console.ReadLine();
                break;
        }
    }
    public void TextBoxsendold()
    {
        switch (textboxvarold)
        {
            case "1":

                //return r;
                InGameControls();
                break;
            case "0":
                Console.WriteLine();
                Console.ForegroundColor = CLISettings.Mcolor;
                Console.Write($"next");
                Console.ReadLine();
                //return "null";
                break;
            default:
                break;
        }
    }
    //still good
    static public void InGameControls()
    {
        //Console.ForegroundColor = CLISettings.Mcolor;
        //Console.WriteLine("enter a action uns /help for available options.");
        //Console.Write(">");
        //Console.ForegroundColor = CLIPlayer.Color;
        Console.WriteLine();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.Write($">_");
        Console.ForegroundColor = CLIPlayer.Color;
        //var r = Console.ReadLine();
        Console.ForegroundColor = CLISettings.Mcolor;
        switch (Console.ReadLine())
        {
            case "inventory":
                Console.WriteLine("not implemented");
                CLIRuntimevar.rerror();
                InGameControls();
                break;
            case "inv":
                Console.WriteLine("not implemented");
                CLIRuntimevar.rerror();
                InGameControls();
                break;
            case "chat":
                Console.WriteLine("not implemented");
                CLIRuntimevar.rerror();
                InGameControls();
                break;
            case "thalk":
                Console.WriteLine("not implemented");
                CLIRuntimevar.rerror();
                InGameControls();
                break;
            case "next":
                Console.Clear();
                //Items.sustoygun.InUse = true;
                //Items.Start();
                break;
            case "/help":
                Console.WriteLine("inv/inventory for your inventory");
                Console.WriteLine("next to Continue");
                Console.WriteLine("chat/thalk to thalk");
                InGameControls();
                break;
            case "help":
                Console.WriteLine("try /help");
                InGameControls();
                break;
            default:
                break;
        }
    }
    */
}