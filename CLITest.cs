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
    public static void Options(){
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
                            CLIConfig.MMAColoursel();
                            break;
                        case 1:
                            CLIConfig.Advancedoptions();
                            break;
                        case 2:
                            CLIMenu.Credits();
                            break;
                        case 3:
                            //CLIGameBackup.WriteBackup("s");
                            break;
                        case 4:
                            CLIConfig.optionsretun();
                            return;
                    }
                    break;
            }
        }
    }
    //MMAColoursel
    public static void MMAColoursel()
    {
        Console.Clear();
        string[] colors = { "Red", "Magenta", "Yellow", "Green", "Blue", "Cyan", "Gray" };
        ConsoleColor[] colorsEnum = { ConsoleColor.Red, ConsoleColor.Magenta, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.Gray };

        int index = 0;
        while (true)
        {
            Console.Clear();
            for (int i = 0; i < colors.Length; i++)
            {
                if (i == index)
                {
                    Console.ForegroundColor = colorsEnum[i];
                    Console.Write("→ "); // Add arrow for selected item
                }
                else
                {
                    Console.ForegroundColor = CLISettings.Dmcolor;
                }
                Console.WriteLine($"{colors[i]}");
            }
            Console.ResetColor();

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    index = (index == 0) ? colors.Length - 1 : index - 1;
                    break;
                case ConsoleKey.DownArrow:
                    index = (index == colors.Length - 1) ? 0 : index + 1;
                    break;
                case ConsoleKey.Enter:
                    switch (index)
                    {
                        case 0:
                            CLISettings.Mcolor = ConsoleColor.Red;
                            CLISettings.Dmcolor = ConsoleColor.DarkRed;
                            break;
                        case 1:
                            CLISettings.Mcolor = ConsoleColor.Magenta;
                            CLISettings.Dmcolor = ConsoleColor.DarkMagenta;
                            break;
                        case 2:
                            CLISettings.Mcolor = ConsoleColor.Yellow;
                            CLISettings.Dmcolor = ConsoleColor.DarkYellow;
                            break;
                        case 3:
                            CLISettings.Mcolor = ConsoleColor.Green;
                            CLISettings.Dmcolor = ConsoleColor.DarkGreen;
                            break;
                        case 4:
                            CLISettings.Mcolor = ConsoleColor.Blue;
                            CLISettings.Dmcolor = ConsoleColor.DarkBlue;
                            break;
                        case 5:
                            CLISettings.Mcolor = ConsoleColor.Cyan;
                            CLISettings.Dmcolor = ConsoleColor.DarkCyan;
                            break;
                        case 6:
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
                    return;  // Exit function after a selection
            }
        }
    }
    //Advancedoptions
    public static void Advancedoptions(){
        Console.Clear();
        string[] options = { "Consol", "Debug", "Moding", "Icons", "Back" };
        int index = 0;

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = CLISettings.Mcolor;
            Console.WriteLine("===Advanced===");
            Console.ForegroundColor = CLISettings.Dmcolor;

            for (int i = 0; i < options.Length; i++)
            {
                if (i == index)
                {
                    Console.Write("→ ");
                    Console.ForegroundColor = (i == 1 && CLISettings.Debug) || (i == 2 && CLISettings.moddingIsOn) || (i == 3 && (CLISettings.Icons == 1 || CLISettings.Icons == 2)) ? ConsoleColor.Green : CLISettings.Mcolor;
                }
                else
                {
                    Console.ForegroundColor = CLISettings.Dmcolor;
                }

                
                if (i == 1) Console.ForegroundColor = CLISettings.Debug ? ConsoleColor.Green : ConsoleColor.Red;
                if (i == 2) Console.ForegroundColor = CLISettings.moddingIsOn ? ConsoleColor.Green : ConsoleColor.Red;
                if (i == 3)
                {
                    if (CLISettings.Icons == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Icons:  MesloLGS-NF(FONT)");
                    }
                    else if (CLISettings.Icons == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Icons: 📂 Emojis + Emoticon");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Icons: OFF");
                    }
                }
                else
                {
                    //Console.ForegroundColor= CLISettings.Mcolor;
                    Console.WriteLine(options[i]);
                }
            }
            Console.ResetColor();

            var key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    index = (index == 0) ? options.Length - 1 : index - 1;
                    break;
                case ConsoleKey.DownArrow:
                    index = (index == options.Length - 1) ? 0 : index + 1;
                    break;
                case ConsoleKey.Enter:
                    switch (index)
                    {
                        case 0:
                            CLIConfig.Consol();
                            return;
                        case 1:
                            CLISettings.Debug = !CLISettings.Debug;
                            break;
                        case 2:
                            CLISettings.moddingIsOn = !CLISettings.moddingIsOn;
                            break;
                        case 3:
                            CLISettings.Icons = (CLISettings.Icons == 1) ? 2 : (CLISettings.Icons == 2) ? 0 : 1;
                            break;
                        case 4:
                            CLIConfig.options();
                            return;
                    }
                    break;
            }
        }
    }
    // 
    public static void move(){
        
    }
}