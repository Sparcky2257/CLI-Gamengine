public class CLISpecieList //: CLIGamePrep
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
        // create a list of types
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