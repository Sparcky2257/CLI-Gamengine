public class CLISpecieList //CLISpecieList.SelectionMenu();
{
    public static List<string?> List { get; set; } = new List<string?>();// ex:"type:species:health:handequipped:smarts:speed:strength:parasite:requireHost:requirePower:requirePowerLevel:partTech:canEditName:speciesability(extra data):shown"
    public static List<string?> Typelist { get; set; } = new List<string?>();// ex:"type"
    public static void start()
    {
        // Initialize the species list
        List.Add("Human:Human:20:2:45:10:32:false:false:false:0:false:true:ancientGRool:true");
        List.Add("Human:Cat Boy/girl:18:3:45:15:32:false:false:false:0:false:true:ancientGRool:true");
        List.Add("K9:Wolf:22:2:47:12:32:false:false:false:0:false:true:ancientGRool:true");
        List.Add("K9:Fox:20:2:50:16:32:false:false:false:0:false:true:ancientGRool:true");
        List.Add("Feline:Cat:20:3:47:14:32:false:false:false:0:false:true:ancientGRool:true");
        List.Add("Avian:Avali:30:2:20:16:36:false:false:false:0:false:true:Fly:true");
        List.Add("Protogen:Protogen:22:2:57:10:32:false:false:true:0:true:true:none:true");

    }
    public static void wrapup()
    {
        foreach (var item in List)
        {
            var attributes = item.Split(':');
            if (attributes.Length > 0)
            {
                if (!Typelist.Contains(attributes[0]))
                {
                    Typelist.Add(attributes[0]);
                }
            }
        }
        UpdateMenuItems();// Update the menu items based on the species list
    }
    static string? menuitem1 = "null";
    static string? menuitem2 = "null";
    static string? menuitem3 = "null";
    static string? menuitem4 = "null";
    static int page = 0;
    public static void UpdateMenuItems()
    {
        int maxPage = (Typelist.Count - 1) / 4; // Calculate max pages correctly
        page = Math.Min(page, maxPage); // Prevent exceeding the maxPage

        int startIndex = page * 4;

        menuitem1 = (startIndex < Typelist.Count) ? Typelist[startIndex] : "null";
        menuitem2 = (startIndex + 1 < Typelist.Count) ? Typelist[startIndex + 1] : "null";
        menuitem3 = (startIndex + 2 < Typelist.Count) ? Typelist[startIndex + 2] : "null";
        menuitem4 = (startIndex + 3 < Typelist.Count) ? Typelist[startIndex + 3] : "null";
    }

    public static void SelectionMenu()
    {
        int selectedIndex = 0;
        // Define menu items

        Console.Clear();
        Console.WriteLine("");
        // Display the list of types of species

        while (true)
        {
            string[] options = { menuitem1, menuitem2, menuitem3, menuitem4, "back" };
            // Clear the console and display the menu header
            Console.Clear();
            Console.ForegroundColor = CLISettings.Mcolor;
            Console.WriteLine("Select a species");
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
                case ConsoleKey.RightArrow:
                    if (page < (Typelist.Count - 1) / 4) // Ensure page does not exceed max pages
                    {
                        page++;
                        UpdateMenuItems();
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    if (page > 0) // Prevent going below zero
                    {
                        page--;
                        UpdateMenuItems();
                    }
                    break;
                case ConsoleKey.Enter:
                    switch (selectedIndex)
                    {
                        case 0:
                            SelectionMenuSpecies(menuitem1);
                            return;
                        case 1:
                            SelectionMenuSpecies(menuitem2);
                            return;
                        case 2:
                            SelectionMenuSpecies(menuitem3);
                            return;
                        case 3:
                            SelectionMenuSpecies(menuitem4);
                            return;
                        case 4:

                            CLIConfig.GPPlayerinfo(); // Call the player info setup
                            break;
                    }
                    break;
            }
        }
        // call a genaraded menu of the type seleated
        // This is a placeholder for the selection menu logic 
    }
    public static void SelectionMenuSpecies(string type)
    {
        var matchingSpecies = List.Where(s => s.StartsWith(type + ":")).ToList();
        if (matchingSpecies.Count == 0)
        {
            Console.WriteLine("No species found for this type.");
            return;
        }

        int selectedIndex = 0;
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = CLISettings.Mcolor;
            Console.WriteLine($"Select a {type} species:");
            Console.ResetColor();
            var attributes = List[selectedIndex + 1].Split(':');
            // Display available species of the selected type
            for (int i = 0; i < matchingSpecies.Count; i++)
            {
                var speciesName = matchingSpecies[i].Split(':')[1]; // Extract name
                if (i == selectedIndex)
                {
                    Console.ForegroundColor = CLISettings.Mcolor;
                    Console.Write("→ ");
                }
                else
                {
                    Console.ForegroundColor = CLISettings.Dmcolor;
                }
                Console.WriteLine(speciesName);
                Console.ResetColor();
            }
            Console.WriteLine($"Health:{attributes[2]}");
            Console.WriteLine($"Smarts:{attributes[4]}");
            Console.WriteLine($"Speed:{attributes[5]}");
            Console.WriteLine($"Strength:{attributes[6]}");
            Console.WriteLine($"Species Ability:{attributes[13]}");
            Console.WriteLine($"Hand equipped:{attributes[3]}");
            Console.WriteLine($"Require Power:{attributes[9]}");
            Console.WriteLine($"Part Tech:{attributes[11]}");
            Console.WriteLine($"Parasite:{attributes[7]}");
            Console.WriteLine($"Require Host:{attributes[8]}");

            Console.ResetColor();
            //Console.WriteLine("\nUse [↑] [↓] to navigate, [Enter] to select, [Esc] to exit.");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex = (selectedIndex - 1 + matchingSpecies.Count) % matchingSpecies.Count;
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex = (selectedIndex + 1) % matchingSpecies.Count;
                    break;
                case ConsoleKey.Enter:
                    setspecies(List.IndexOf(matchingSpecies[selectedIndex])); // Call your existing selection system
                                                CLIConfig.GPPlayerinfo(); // Call the player info setup
                    return;
                case ConsoleKey.Escape:
                    return;
            }

        }
    }

    public static void setspecies(int index)
    {
        if (index < 0 || index >= List.Count)
        {
            Console.WriteLine("Invalid index. Please select a valid species.");
            return;
        }
        var attributes = List[index].Split(':');
        if (attributes.Length < 14)
        {
            Console.WriteLine("Invalid species data.");
            return;
        }
        // attributes[0] is is not needed here 
        CLIPlayer.species = attributes[1];
        CLIPlayer.Health = int.Parse(attributes[2]);
        CLIPlayer.Handequipped = int.Parse(attributes[3]);
        CLIPlayer.Smarts = int.Parse(attributes[4]);
        CLIPlayer.Speed = int.Parse(attributes[5]);
        CLIPlayer.Strength = int.Parse(attributes[6]);
        CLIPlayer.parasite = bool.Parse(attributes[7]);
        CLIPlayer.requireHost = bool.Parse(attributes[8]);
        CLIPlayer.requirePower = bool.Parse(attributes[9]);
        CLIPlayer.requirePowerLevel = int.Parse(attributes[10]);
        CLIPlayer.partTech = bool.Parse(attributes[11]);
        CLIPlayer.canEditName = bool.Parse(attributes[12]);
        CLIPlayer.speciesAbility = attributes[13];
    }
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