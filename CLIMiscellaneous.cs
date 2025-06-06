using System.ComponentModel;

public class ClIMiscellaneous
{
    public string? savename { get; set; } = "none"; // this is... fines
    public static void CWriteLine(string? text = "null", int Chartime=999) //broken ikd why
    {
        if (text == "null")
        {
            text = "error";
            CLIRuntimevar.rerror();
            List<char> charList = text.Select(c => c).ToList();
            var x = 0;
            x = charList.Count;

            while (x >= 0)
            {
                if (x == 0)
                {
                    Console.WriteLine(charList[x]);
                }
                else
                {
                    Console.Write(charList[x]);
                }
                Console.Write(charList[x]);
                x--;
            }
            Thread.Sleep(Chartime);
        }
    }
    public static void CWrite(string? text = "null", double Chartime = 1) //broken ikd why
    {
        if (text == "null")
        {
            text = "error";
            CLIRuntimevar.rerror();
            List<char> charList = text.Select(c => c).ToList();

            foreach (char c in charList)
            {
                //charList.
                Console.Write(c);
                System.Threading.Thread.Sleep((int)Chartime);
            }

        }
    }
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
    public static void checkelist()
    {
        bool A = false;
        bool B = false;
        int x = ClIMiscellaneous.Creditsdata.Count;
        for (int i = 0; i < x; i++)
        {
            if (ClIMiscellaneous.Creditsdata[i] == "Sparcky Ancientpack")
            {
                A = true;
            }
            if (ClIMiscellaneous.Creditsdata[i] == "Pawos Howl")
            {
                B = true;
            }
        }
        if (A == false | B == false)
        {
            CLIMenu.textboxname = "warn";
            CLIMenu.textboxvar = "1";
            CLIMenu.textdata.Add("CL");
            CLIMenu.textdata.Add($"{ConsoleColor.Yellow}");
            CLIMenu.textdata.Add("Hi i Believe That the coder did not read the CC License.");
            CLIMenu.textdata.Add("WL");
            CLIMenu.textdata.Add("if you are the coder dame it you did not crdit ");
            CLIMenu.textdata.Add("CL");
            CLIMenu.textdata.Add($"{ConsoleColor.Blue}");
            CLIMenu.textdata.Add(":(");
            CLIMenu.textdata.Add("CL");
            CLIMenu.textdata.Add($"{ConsoleColor.Red}");
            CLIMenu.textdata.Add("NX");
            CLIMenu.textdata.Add("RS");
            CLIMenu.textbox();
            Console.Clear();
            Console.WriteLine("DRM:was trigerd check mate");
            Console.WriteLine("");
            throw new Exception();
        }
    }
}