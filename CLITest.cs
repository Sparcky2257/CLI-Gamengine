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
                    Console.ForegroundColor = CLISettings.Mcolor;
                    Console.Write("→ ");
                }
                else
                {
                    Console.ResetColor();
                    Console.ForegroundColor = CLISettings.Dmcolor;
                }
                
                Console.WriteLine(options[i]);
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
                    Console.ForegroundColor = CLISettings.Mcolor;
                    Console.Write("→ ");
                }
                else
                {
                    Console.ResetColor();
                    Console.ForegroundColor = CLISettings.Dmcolor;
                }

                Console.WriteLine(options[i]);
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
}