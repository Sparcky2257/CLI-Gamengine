public class CLILogo
{
    // CLISettings settings = new CLISettings();
    public static void bootlogo1()
    {
        Console.WriteLine();
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
        Console.WriteLine("  └─┘┴ ┴┴ ┴└─┘┘└┘└─┘┴┘└┘└─┘");
        Console.ResetColor();
    }
    public void bootlogo2()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("error ");
        Console.ResetColor();
        Console.WriteLine("404");
        CLIRuntimevar.rerror();
    }
    public static void bootlogo3()
    {
        Console.WriteLine();
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
        Console.WriteLine(text);
       
        Thread.Sleep(times);//149
    }

}