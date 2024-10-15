public class CLISpace
{
    public static List<string?> input { get; set; } = new List<string?>();

    public static List<string?> Galaxy { get; set; } = new List<string?>();
    public static List<string?> Solar_System { get; set; } = new List<string?>();
    public static List<string?> Planet { get; set; } = new List<string?>();
    public static void inputrun()
    {
        int x = CLISpace.input.Count;
        if (x > 0)
        {
            string currentGalaxy = null;       // Track current Galaxy
            string currentSolarSystem = null;  // Track current Solar System

            for (int i = 0; i < x; i++)
            {
                string tstring = CLISpace.input[i];
                var temp = tstring.Split(":");

                int c = 0; // Keeps track of the current operation state based on G, S, P
                foreach (var part in temp)
                {
                    switch (part)
                    {
                        case "G":
                            c = 1;
                            break;
                        case "S":
                            c = 2;
                            break;
                        case "P":
                            c = 3;
                            break;
                        default:
                            // Handle commands based on the state of 'c'
                            switch (c)
                            {
                                case 1:
                                    // Handle 'G' specific logic here (Galaxy)
                                    CLISpace.Galaxy.Add(part);
                                    currentGalaxy = part; // Update current galaxy
                                    break;
                                case 2:
                                    // Handle 'S' specific logic here (Solar System)
                                    if (currentGalaxy != null)
                                    {
                                        CLISpace.Solar_System.Add($"{part}:{currentGalaxy}");
                                        currentSolarSystem = part; // Update current solar system
                                    }
                                    else
                                    {
                                        CLIRuntimevar.rerror(); // Error if no Galaxy has been defined
                                    }
                                    break;
                                case 3:
                                    // Handle 'P' specific logic here (Planet)
                                    if (currentSolarSystem != null)
                                    {
                                        CLISpace.Planet.Add($"{part}:{currentSolarSystem}");
                                    }
                                    else
                                    {
                                        CLIRuntimevar.rerror(); // Error if no Solar System has been defined
                                    }
                                    break;
                                default:
                                    CLIRuntimevar.rerror(); // General error for unknown state
                                    break;
                            }
                            break;
                    }
                }
            }
        }
    }



    /*public static void inputrun()
    {
        int x = CLISpace.input.Count;
        if (CLISpace.input.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                //List<string> temp = new List<string?>();
                string tstring = CLISpace.input[i];
                var temp = tstring.Split(":");
                int a = temp.Count;
                int c = 0;
                if (temp.Any() == true)
                {
                    for (int b = 0; b < a; b++)
                    {
                        switch (temp[b])
                        {
                            case "G":
                                c=1;
                                break;
                            case "S":
                                c=2;
                                break;    
                            case "P":
                                c=3;
                                break;    
                            default:

                                break;
                        }
                    }
                }

            }
        }
    }*/
    public static void init()
    {
        int x = CLISpace.Galaxy.Count;
        if (CLISpace.Galaxy.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                var line = CLISpace.Galaxy[i].Split(":");
                CLILogo.logostart("Config " + line[0]);
            }
        }
        x = CLISpace.Solar_System.Count;
        if (CLISpace.Solar_System.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                var line = CLISpace.Solar_System[i].Split(":");
                CLILogo.logostart("Config " + line[0]);
            }
        }
        x = CLISpace.Planet.Count;
        if (CLISpace.Planet.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                var line = CLISpace.Planet[i].Split(":");
                CLILogo.logostart("Config " + line[0]);
            }
        }
    }
     public static void print()
    {
        int x = CLISpace.Galaxy.Count;
        if (CLISpace.Galaxy.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(CLISpace.Galaxy[i]);
                
            }
        }
        x = CLISpace.Solar_System.Count;
        if (CLISpace.Solar_System.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(CLISpace.Solar_System[i]);
            }
        }
        x = CLISpace.Planet.Count;
        if (CLISpace.Planet.Any() == true)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(CLISpace.Planet[i]);
            }
        }
    }
}