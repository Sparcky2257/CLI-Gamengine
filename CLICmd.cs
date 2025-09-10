public class CLICmd
{
    // list of commands for the console 
    public static void mod1() // enable modding not needed but is still here for compatibility
    {
        CLISettings.moddingIsOn = true;
    }
    public static void mod0() // disable modding not needed but is still here for compatibility
    {
        CLISettings.moddingIsOn = false;
    }
    public static void nfsw1()
    // enable nsfw content
    {
        CLISettings.NSFWIsOn = true;
    }
    public static void nfsw0()
     // disable nsfw content
    {
        CLISettings.NSFWIsOn = false;
    }
    public static void help()
    {
        CLIText.print("Available commands:",125,true);
        CLIText.print("0 - Exit the console",25,true);
        CLIText.print("mod=1 or mod=true - Enable modding",25,true);
        CLIText.print("mod=0 or mod=false - Disable modding",25,true);
        //Console.WriteLine("Available commands:");
        /*Console.WriteLine("0 - Exit the console");
        Console.WriteLine("mod=1 or mod=true - Enable modding");
        Console.WriteLine("mod=0 or mod=false - Disable modding");
        if (CLISettings.NSFWIsOn) // only show NSFW commands if enabled if not enabled, don't show them
        {
             Console.WriteLine("nfsw=1 or nfsw=true - Enable NSFW content");
             Console.WriteLine("nfsw=0 or nfsw=false - Disable NSFW content");
        }
        Console.WriteLine("api - Access API menu");
        Console.WriteLine("help - Show this help message");*/
     }
    // call logic for the console commands
    public static void Cmd(string input) //
    {
        switch (input)
        {
            case "0":
                CLIConfig.Consolext();
                return;
            case "mod=1":
                CLICmd.mod1();
                break;
            case "mod=0":
                CLICmd.mod0();
                break;
            case "mod=true":
                CLICmd.mod1();
                break;
            case "mod=false":
                CLICmd.mod0();
                break;
            case "nfsw=false":
                CLICmd.nfsw0();
                break;
            case "nfsw=0":
                CLICmd.nfsw0();
                break;
            case "nfsw=1":
                CLICmd.nfsw1();
                break;
            case "nfsw=true":
                CLICmd.nfsw1();
                break;
            case "API":
                Console.WriteLine("Please use the 'api' command instead. this command will be removed in a future version.");
                Thread.Sleep(1999);
                APImenu();
                break;
            case "api":
                APImenu();
                break;
            case "exit":
                CLIConfig.Consolext();
                break;
            case "help":
                CLICmd.help();
                break;
            default:
                Console.WriteLine($"Invalid command '{input}'. Please try again.");
                break;
        }

    }
    // old logic 
        static void APImenu()
        {
            Console.Clear();
            Console.ForegroundColor = CLISettings.Mcolor;
            Console.Write("put number of the api arg you want to use:");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Api arg1:");
                    CLIConfig.addon(Console.ReadLine());
                    break;
                case "3":
                    Console.Write("Api arg1:");
                    string? A = Console.ReadLine();
                    Console.Write("Api arg2:");
                    string? B = Console.ReadLine();
                    Console.Write("Api arg3:");
                    string? C = Console.ReadLine();
                    CLIConfig.addon(A, B, C);

                    break;
                default:
                    APImenu();
                    break;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("====Consol====");
            Console.WriteLine("You can write commands here. Enter 0 to exit.");
        }
}