public class CLILogo
{
    // CLISettings settings = new CLISettings();
    public static void bootlogo1(int speed = 0)
    {
        Console.ForegroundColor = CLISettings.Mcolor;
        CLIText.print("╔═╗╦  ╦", speed, false);
        Console.ForegroundColor = ConsoleColor.Green;
        CLIText.print("  ┌─┐┌─┐┌┬┐┌─┐┌┐┌┌─┐┬┌┐┌┌─┐", speed, true);
        Console.ForegroundColor = CLISettings.Mcolor; ;
        CLIText.print("║  ║  ║", speed, false);
        Console.ForegroundColor = ConsoleColor.Green;
        CLIText.print("  │ ┬├─┤│││├┤ ││││ ┬││││├┤ ", speed, true);
        Console.ForegroundColor = CLISettings.Mcolor; ;
        CLIText.print("╚═╝╩═╝╩", speed, false);
        Console.ForegroundColor = ConsoleColor.Green;
        CLIText.print("  └─┘┴ ┴┴ ┴└─┘┘└┘└─┘┴┘└┘└─┘", speed, true);
        Console.ResetColor();
    }
    public static void bootlogo2()
    {
        bootlogo1(25);
        Thread.Sleep(899);
    }
    public static void bootlogo3()
    {
        Console.ForegroundColor = CLISettings.Mcolor;
        Console.Write("╔═╗╦  ╦");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  ┌─┐┌─┐┌┬┐┌─┐┌┐┌┌─┐┬┌┐┌┌─┐");
        Console.ForegroundColor = CLISettings.Mcolor; ;
        Console.Write("║  ║  ║");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("  │ ┬├─┤│││├┤ ││││ ┬││││├┤ ");
        Console.ForegroundColor = CLISettings.Mcolor; ;
        Console.Write("╚═╝╩═╝╩");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("  └─┘┴ ┴┴ ┴└─┘┘└┘└─┘┴┘└┘└─┘ ");
        Console.ResetColor();
    }
    public static void logostart(string text = "error", int times = 249)
    {
        Console.Clear();
        bootlogo3();
        CLIText.print(text, 15, true);
        //Console.WriteLine(text);
       
        Thread.Sleep(times);//149
    }

}