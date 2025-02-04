public class CLITest
{
    public static void MainMenu()
    {
        int selectedIndex = 0;
        string[] options = { "New Game", "Load Game", "Options", "Exit" };

        while (CLISettings.mainMenuOpen)
        {
            if (!CLISettings.Debug)
            {
                Console.Clear();
            }

            CLIConfig.bootlogo();

            Console.ForegroundColor = CLISettings.Dmcolor;
            Console.WriteLine("=====menu=====");
            //Console.ResetColor();

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    if (options[i] == "Exit")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = CLISettings.Mcolor;
                    }
                    Console.Write("→ ");
                }
                else
                {
                    Console.ResetColor();
                    Console.ForegroundColor = CLISettings.Dmcolor;
                }

                Console.WriteLine(options[i]);
                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex = (selectedIndex + 1) % options.Length;
                    break;
                case ConsoleKey.Enter:
                    switch (selectedIndex)
                    {
                        case 0:
                            CLIConfig.newgame();
                            break;
                        case 1:
                            CLIConfig.loadgame();
                            break;
                        case 2:
                            CLIConfig.options();
                            break;
                        case 3:
                            CLISettings.mainMenuOpen = false;
                            break;
                    }
                    break;
            }
        }
    }
    //info
    public static void Playerinfo()
    {
        int selectedIndex = 0;
        string[] options = { "Name", "Colour", "Species", "Start", "Unlock", "Exit" };

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = CLISettings.Mcolor;
            Console.WriteLine("===newgame====");
            Console.ResetColor();

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    if (options[i] == "Colour")
                    {
                        Console.ForegroundColor = CLIPlayer.Color;
                    }
                    else if (options[i] == "Exit")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = CLISettings.Mcolor;
                    }
                    Console.Write("→ ");
                }
                else
                {
                    Console.ResetColor();
                    Console.ForegroundColor = CLISettings.Dmcolor;
                }
                if (options[i] != "Unlock")
                {
                    Console.WriteLine(options[i]);
                }
                else if (CLIPlayer.canEditName == false)
                {
                    Console.WriteLine(options[i]);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
                    if (CLIPlayer.canEditName == true && options[selectedIndex] == "Unlock")
                    {
                        selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex = (selectedIndex + 1) % options.Length;
                    if (CLIPlayer.canEditName == true && options[selectedIndex] == "Unlock")
                    {
                        selectedIndex = (selectedIndex + 1) % options.Length;
                    }
                    break;
                case ConsoleKey.Enter:
                    switch (selectedIndex)
                    {
                        case 0:
                            CLIConfig.GPPlayerName();
                            break;
                        case 1:
                            CLIConfig.GPColour();
                            break;
                        case 2:
                            if (CLIPlayer.canEditName)
                            {
                                CLIGamePrep.Speciessel();
                            }
                            else
                            {
                                CLIConfig.GPPlayerinfo();
                            }
                            break;
                        case 3:
                            if (CLISettings.BuiltInDemoEnabled)
                            {
                                CLIGamePrep.start();
                            }
                            break;
                        case 4:
                            if (!CLIPlayer.canEditName)
                            {
                                CLIPlayer.Name = "none";
                                CLIPlayer.canEditName = true;
                                CLIPlayer.Color = ConsoleColor.Gray;
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
                                CLIPlayer.Protohexnum = -1;
                                CLIConfig.GPPlayerinfo();
                            }
                            else
                            {
                                CLIConfig.GPPlayerinfo();
                            }
                            break;
                        case 5:
                            return;
                    }
                    break;
            }
        }
    }
    //opions
    public static void Options()
    {
        int selectedIndex = 0;
        string[] options = { "Menu Colour", "Advanced Options", "Credits", "Save", "Back" };

        while (true)
        {
            // Clear the console and display the menu header
            Console.Clear();
            Console.ForegroundColor = CLISettings.Mcolor;
            Console.WriteLine("==== Options ====");
            Console.ResetColor();

            // Display menu options
            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    if (options[i] == "Exit")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = CLISettings.Mcolor;
                    }
                    Console.Write("→ ");
                }
                else
                {
                    Console.ForegroundColor = CLISettings.Dmcolor;
                }
                Console.WriteLine(options[i]);
                Console.ResetColor();
            }

            Console.ResetColor();
            Console.WriteLine();
            Console.Write(">");

            // Handle user input for navigation and selection
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = (selectedIndex - 1 + options.Length) % options.Length;
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex = (selectedIndex + 1) % options.Length;
                    break;
                case ConsoleKey.Enter:
                    switch (selectedIndex)
                    {
                        case 0:
                            MMAColoursel();
                            break;
                        case 1:
                            CLIConfig.Advancedoptions();
                            break;
                        case 2:
                            CLIMenu.Credits();
                            break;
                        case 3:
                            CLIGameBackup.WriteBackup("s");
                            break;
                        case 4:
                            CLIConfig.optionsretun();
                            return;
                    }
                    break;
            }
        }
    }
    static void MMAColoursel()
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
}