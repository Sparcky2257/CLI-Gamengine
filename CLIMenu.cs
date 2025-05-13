using System;
using System.IO;

public class CLIMenu
{
    //CLILogo logo = new CLILogo();
    // CLIPlayer player = new CLIPlayer();
    //CLISettings settings = new CLISettings();
    CLIGamePrep gameprep = new CLIGamePrep();

    public static void MainMenu()
    {
        // why are you doing it like this??
        // do
        // {
        //     mainenu();
        // }
        // while (CLISettings.mainMenuOpen == true);
        // void mainenu()
        while (CLISettings.mainMenuOpen)
        {
            //Optionload();
            if (CLISettings.Debug == false)
            {
                Console.Clear(); // stawp clearing for nowww
            }
            CLIConfig.bootlogo();
            Console.ForegroundColor = CLISettings.Mcolor;
            Console.WriteLine("=====menu=====");
            Console.ForegroundColor = CLISettings.Dmcolor;
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.WriteLine("3. Options");
            Console.WriteLine("0. Exit");
            Console.ResetColor();
            Console.WriteLine("");
            Console.Write(">");
            var menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    CLIConfig.newgame();
                    break;
                case "2":
                    //Console.WriteLine("demo 2");
                    //loadgame();
                    CLIConfig.loadgame();
                    break;
                case "3":
                    //Console.WriteLine("demo 3");
                    //options();
                    CLIConfig.options();
                    break;
                case "0":
                    // break; // nothing happens after the break
                    CLISettings.mainMenuOpen = false;
                    break;
                //ClIGameBackup.WriteBackup(/*i dont know waht to put here*/); // don't do it here!
                default:

                    break;
            }
        }

    }

    public static void options()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor; ;
        Console.WriteLine("====option====");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("1. Menu Colour");
        Console.WriteLine("2. Advancedoptions");
        Console.WriteLine("3. Credits");
        Console.WriteLine("4. Save");
        Console.WriteLine("0. Exit");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        var optionsmenu = Console.ReadLine();

        switch (optionsmenu)
        {
            case "1":
                //Console.WriteLine("demo 3");
                MMAColoursel();
                break;
            case "4":
                //Console.WriteLine("demo 3");
                CLIGameBackup.WriteBackup("s");
                break;
            case "2":
                //Console.WriteLine("demo 3");
                //Advancedoptions();
                CLIConfig.Advancedoptions();
                break;
            case "3":
                //Console.WriteLine("demo 3");
                Credits();
                break;
            case "0":
                //Console.Clear();
                CLIConfig.optionsretun();
                break;
            default:
                options();
                break;
        }
    }
    public static void Credits()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("0 to go to main menu");
        Console.ForegroundColor = CLISettings.Dmcolor;
        int x = ClIMiscellaneous.Creditsdata.Count;
        for (int i = 0; i < x; i++)
        {
            switch (ClIMiscellaneous.Creditsdata[i])
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
                default:
                    Console.WriteLine(ClIMiscellaneous.Creditsdata[i]);
                    break;

            }
            void Color()
            {
                i++;
                switch (ClIMiscellaneous.Creditsdata[i])
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
        var optionsmenu = Console.ReadLine();
        switch (optionsmenu)
        {
            case "0":
                Console.Clear();
                break;
            default:
                Credits();
                break;
        }
    }
    public static void Advancedoptions()
    {
        Console.Clear();
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.WriteLine("===Advanced===");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.WriteLine("1. Consol");
        Console.Write("2. ");
        if (CLISettings.Debug == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine("Debug");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("3. ");
        if (CLISettings.moddingIsOn == true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine("Moding");
        Console.ForegroundColor = CLISettings.Dmcolor;
        Console.Write("4. Icons:");
        if (CLISettings.Icons == 1 || CLISettings.Icons == 2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (CLISettings.Icons == 1)
            {
                Console.WriteLine(" MesloLGS-NF(FONT)");
            }
            else
            {
                Console.WriteLine("📂 Emojis + Emoticon");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OFF");
        }
        Console.ForegroundColor = CLISettings.Dmcolor;
        //Console.WriteLine("5. Menu Colour");
        //Console.WriteLine("6. Save");
        Console.WriteLine("0. Exit");
        Console.ResetColor();
        Console.WriteLine("");
        Console.Write(">");
        var optionsmenu = Console.ReadLine();

        switch (optionsmenu)
        {
            case "1":
                //Console.WriteLine("demo 1");
                //debugmenu();
                CLIConfig.Consol();
                break;
            case "2":
                //Console.WriteLine("demo 1");
                if (CLISettings.Debug == true)
                {
                    CLISettings.Debug = false;
                }
                else
                {
                    CLISettings.Debug = true;
                }
                Advancedoptions();
                break;
            case "3":
                //Console.WriteLine("demo 2");
                if (CLISettings.moddingIsOn == true)
                {
                    CLISettings.moddingIsOn = false;
                }
                else
                {
                    CLISettings.moddingIsOn = true;
                }
                Advancedoptions();
                break;
            // case "3":
            //     //Console.WriteLine("demo 2");
            //     if (CLISettings.moddingIsOn == true)
            //     {
            //         CLISettings.moddingIsOn = false;
            //     }
            //     else
            //     {
            //         CLISettings.moddingIsOn = true;
            //     }
            //     options();
            //     break;
            case "4":
                if (CLISettings.Icons == 1)
                {
                    CLISettings.Icons = 2;
                }
                else if (CLISettings.Icons == 2)
                {
                    CLISettings.Icons = 0;
                }
                else
                {
                    CLISettings.Icons = 1;
                }
                Advancedoptions();
                break;
            case "0":
                //Console.Clear();
                CLIConfig.options();
                break;
            default:
                Advancedoptions();
                break;
        }
    }

    public static void MMAColoursel()
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
                CLISettings.Mcolor = ConsoleColor.Red;
                CLISettings.Dmcolor = ConsoleColor.DarkRed;
                break;
            case "2":
                CLISettings.Mcolor = ConsoleColor.Magenta;
                CLISettings.Dmcolor = ConsoleColor.DarkMagenta;
                break;
            case "3":
                CLISettings.Mcolor = ConsoleColor.Yellow;
                CLISettings.Dmcolor = ConsoleColor.DarkYellow;
                break;
            case "4":
                CLISettings.Mcolor = ConsoleColor.Green;
                CLISettings.Dmcolor = ConsoleColor.DarkGreen;
                break;
            case "5":
                CLISettings.Mcolor = ConsoleColor.Blue;
                CLISettings.Dmcolor = ConsoleColor.DarkBlue;
                break;
            case "6":
                CLISettings.Mcolor = ConsoleColor.Cyan;
                CLISettings.Dmcolor = ConsoleColor.DarkCyan;
                break;
            case "7":
                if (CLIRuntimevar.crt == true)
                {
                    CLISettings.Mcolor = ConsoleColor.White;
                    CLISettings.Dmcolor = ConsoleColor.Gray;
                }
                else
                {
                    CLISettings.Mcolor = ConsoleColor.Gray;
                    CLISettings.Dmcolor = ConsoleColor.DarkGray;
                }
                break;
            default:
                MMAColoursel();
                break;
        }
    }

    public static void Consol()
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("====Consol====");
            Console.WriteLine("You can write commands here. Enter 0 to exit.");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.Write(">");
            string ?input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    CLIConfig.Consolext();
                    return;
                case "mod=1":
                    CLISettings.moddingIsOn = true;
                    break;
                case "mod=0":
                    CLISettings.moddingIsOn = false;
                    break;
                case "mod=true":
                    CLISettings.moddingIsOn = true;
                    break;
                case "mod=false":
                    CLISettings.moddingIsOn = false;
                    break;
                case "nfsw=false":
                    CLISettings.NSFWIsOn = false;
                    break;
                case "nfsw=0":
                    CLISettings.NSFWIsOn = false;
                    break;
                case "nfsw=1":
                    CLISettings.NSFWIsOn = true;
                    break;
                case "nfsw=true":
                    CLISettings.NSFWIsOn = true;
                    break;
                case "API":
                    APImenu();
                    break;
                default:
                    Console.WriteLine("Invalid command. Please try again.");
                    break;
            }
            Console.ResetColor();
        }
        static void APImenu()
        {
            Console.Write("Api args:");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Api arg1:");
                    CLIConfig.addon(Console.ReadLine());
                    Consol();
                    break;
                case "3":
                    Console.Write("Api arg1:");
                    string? A = Console.ReadLine();
                    Console.Write("Api arg2:");
                    string? B = Console.ReadLine();
                    Console.Write("Api arg3:");
                    string? C = Console.ReadLine();
                    CLIConfig.addon(A, B, C);
                    Consol();
                    break;
                default:
                    APImenu();
                    break;
            }
        }
    }
    public static void loadgame()
    {
        // Console.WriteLine("error 404");
        // Console.Clear();
        // this is where the implementation goes :3
        // temp stop main menu
        CLISettings.mainMenuOpen = false; // make sure to set this true before EVERY return

        // test code
        // fs paf, and the path of the saves dir
        string paf = Directory.GetCurrentDirectory();
        string savpaf = Path.Combine(paf, "saves");
        // Console.WriteLine("The current directory is {0}", paf);
        // Console.WriteLine(savpaf);

        // actually do checks
        Console.WriteLine("Oh? So you have a save file? (pls don't break it)");
        if (!Directory.Exists(savpaf))
        {
            Console.WriteLine("You don't got a saves directory! You defintely don't got any saves.");
            CLISettings.mainMenuOpen = true;
            return;
        }
        // this is more useful (when I deploy it)
        string currentFileEnd = CLIGameBackup.getCurrentFileEnd();
        // gets items in the directory
        string[] items = Directory.GetFiles(savpaf);
        // adds only files to list
        List<string> files = [];
        foreach (string x in items)
        { // not used to foreach like that, rather "for(int x:y)"
            Console.WriteLine(x);
            // this already has only files, so make sure ite ends right :3
            if (x.Length > 4 && x.Substring(x.Length - currentFileEnd.Length).Equals(currentFileEnd))
            {
                // strip off the top of the file path, and the file extension
                //substring is start, then length
                files.Add(x.Substring(savpaf.Length + 1, x.Length - savpaf.Length - currentFileEnd.Length - 1)); // +1 makes it work as well as the -1
            }
        }
        int totalItems = files.Count;

        // now exit if there is no files
        if (totalItems == 0)
        {
            Console.WriteLine("No save files found qwp");
            CLISettings.mainMenuOpen = true;
            return;
        }
        Console.WriteLine("The following are your save game load options:");
        for (int x = 0; x < totalItems; x++)
        {
            Console.WriteLine((x + 1) + ". " + files.ElementAt(x)); // note, subtract one from input
        }

        Console.WriteLine("You can use either the numbers or the filename to restore. (if you fluff up, it won't work, and you have to redo it. \"exit\" to exit)");
        Console.Write(">");
        string? req = Console.ReadLine();
        if (req == string.Empty || req == null)
        {
            Console.WriteLine("Your input is empty... This will not work.");
            CLISettings.mainMenuOpen = true;
            return;
        }
        if (req.Equals("exit"))
        {
            Console.WriteLine("Exiting per user request");
            CLISettings.mainMenuOpen = true;
            return;
        }

        string fin = ""; // to be used for the final load call, assigned here even though it will get assigned anyway
        // using the weird TryParse thing, if its true, the out is an int, otherwise its a str
        if (int.TryParse(req, out int i))
        {
            // last bit of input sanitization
            if (i < 1)
            {
                Console.WriteLine("... don't go at or below zero");
                CLISettings.mainMenuOpen = true;
                return;
            }
            // taking one off of input
            if (i > totalItems - 1)
            {
                Console.WriteLine("That number is too beeg");
                CLISettings.mainMenuOpen = true;
                return;
            }
            fin = files.ElementAt(i - 1);
        }
        else
        {
            // checks to see if the exact name is in the files of each thing
            bool nFinds = true; // status of finding a value
            foreach (string x in files)
            {
                if (req.Equals(x))
                { // checks each item to see if it is in the list before using it
                    fin = x;
                    nFinds = false;
                    break; // no enable mainmenu because this is not a return, even though ourple
                }
            }
            if (nFinds)
            {
                Console.WriteLine("Your value was not found!");
                CLISettings.mainMenuOpen = true;
                return; // failure
            }
        }
        // fin now has the filename, now to add the full path back onto it
        fin = Path.Combine(savpaf, fin + currentFileEnd);

        // fin should now be set properly, so run the command
        // await Task.Run(() => YourMethod());
        // bool result = await Task.Run(() => CLIGameBackup.ReadBackup(fin));
        bool result = CLIGameBackup.ReadBackup(fin);
        if (!result)
        {
            Console.WriteLine("Something went wrong! Likely, this is an error with the save file.");
            CLISettings.mainMenuOpen = true;
            return;
        }
        Console.WriteLine("Session sucessfully restored!");
        // we're done, so now restore
        CLISettings.mainMenuOpen = true;
    }

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
                case "PLC":
                    Console.ForegroundColor = CLIPlayer.Color;
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
}