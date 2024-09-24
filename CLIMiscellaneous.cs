public class ClIMiscellaneous
{
    public string? savename { get; set; } = "none"; // this is... fines
    void Optionsave()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("error ");
        Console.ResetColor();
        Console.WriteLine("404");
    }
    void Optionload()
    {
        Console.Write(" ");
    }

    public static List<string?> Creditsdata { get; set; } = new List<string?>();
    public static void Creditsdatainfo()
    {
        int x = ClIMiscellaneous.Creditsdata.Count;
        for (int i = 0; i < x; i++)
        {
            CLILogo.logostart("Credits " + ClIMiscellaneous.Creditsdata[i]);
        }
    }
}