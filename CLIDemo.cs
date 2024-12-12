public class CLIDemo
{
    public static void Play()
    {
        CLIMenu.textboxname = CLIPlayer.Name;
        CLIMenu.textboxvar = "1";
        CLIMenu.textdata.Add("DMC");
        CLIMenu.textdata.Add("Hello");
        CLIMenu.textdata.Add("CL");
        CLIMenu.textdata.Add($"{CLIPlayer.Color}");
        CLIMenu.textdata.Add($" {CLIPlayer.Name} ");
        CLIMenu.textdata.Add("CL");
        CLIMenu.textdata.Add($"{ConsoleColor.Red}");
        CLIMenu.textdata.Add("you");
        CLIMenu.textdata.Add("DMC");
        CLIMenu.textdata.Add(" are located in ");
        CLIMenu.textdata.Add("idk");
        CLIMenu.textdata.Add("Galaxy");
        CLIMenu.textdata.Add("NX");
        CLIMenu.textdata.Add("RS");
        CLIMenu.textbox();
    }

}