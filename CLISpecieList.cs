public class CLISpecieList //: CLIGamePrep
{
    public static List<string?> List { get; set; } = new List<string?>();// ex:"type:species:health:handequipped:smarts:speed:strength:parasite:requireHost:requirePower:requirePowerLevel:partTech:canEditName:speciesability(extra data):shown"
    public static void start()
    {
        // Initialize the species list
        List.Add("Human:Human:20:2:45:10:32:false:false:false:0:false:true:ancientGRool:true");
        List.Add("Human:Cat Boy/girl:18:3:45:15:32:false:false:false:0:false:true:ancientGRool:true");
        List.Add("K9:Wolf:22:2:47:12:32:false:false:false:0:false:true:ancientGRool:true");
        List.Add("K9:Fox:20:2:50:16:32:false:false:false:0:false:true:ancientGRool:true");
        List.Add("Feline:Cat:20:3:47:14:32:false:false:false:0:false:true:ancientGRool:true");
    }
    public static void SelectionMenu()
    {
        Console.Clear();
        Console.WriteLine("Select a species");
        // Display the list of types of species
            // excude using excud list for overide
        // call a genaraded menu of the type seleated
           // This is a placeholder for the selection menu logic
    }

    public static void SelectionMenutemp() //dont ues this is just a function as a reference for the selection menu will be removed later 
    {
        int index = 0;
        ConsoleKey key;

        do
        {
            Console.Clear();
            Console.WriteLine("Select a species using arrow keys and press Enter:");

            for (int i = 0; i < List.Count; i++)
            {
                if (i == index)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"> {List[i].Split(':')[0]}"); // Highlight selected option
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  {List[i].Split(':')[0]}");
                }
            }

            key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.UpArrow)
            {
                index = (index > 0) ? index - 1 : List.Count - 1;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                index = (index < List.Count - 1) ? index + 1 : 0;
            }

        } while (key != ConsoleKey.Enter);

        // User selected a species; display details
        DisplaySpeciesDetails(List[index]);
    }

    public static void DisplaySpeciesDetails(string speciesData)
    {
        var attributes = speciesData.Split(':');
        Console.Clear();
        Console.WriteLine($"Species: {attributes[1]}");
        Console.WriteLine($"Health: {attributes[2]}");
        Console.WriteLine($"Handequipped: {attributes[3]}");
        Console.WriteLine($"Smarts: {attributes[4]}");
        Console.WriteLine($"Speed: {attributes[5]}");
        Console.WriteLine($"Strength: {attributes[6]}");
        Console.WriteLine($"Parasite: {attributes[7]}");
        Console.WriteLine($"Require Host: {attributes[8]}");
        Console.WriteLine($"Require Power: {attributes[9]}");
        Console.WriteLine($"Require Power Level: {attributes[10]}");
        Console.WriteLine($"Part Tech: {attributes[11]}");
        Console.WriteLine($"Can Edit Name: {attributes[12]}");
        Console.WriteLine($"Species Ability: {attributes[13]}");

        Console.WriteLine("\nPress any key to return to menu...");
        Console.ReadKey();
        //SelectionMenu(); // Return to menu after viewing details
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