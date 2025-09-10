public class CLIText
{
    public static List<string?> stiledata { get; set; } = new List<string?>(); // example: stiledata.Add("stileName:beforetitle:aftertitle:lineformat:line1:line2:line3:line4:line5:line6..."); // : <-- section seprator ; <-- subsection     
    /* probtys
     * text fomat ex: text+time ues for prit funcion 
     * stileName: the name of the stile
     * beforetitle: the text before the title
     * aftertitle: the text after the title
     modifier: the modifier for the stile
     @modifier: same as text 
     @behening: this will be the text that will be printed at the bigaing example: @behening;Hello
     @end: this will be the text that will be printed at the end example: @end;World
     @fill : this will be the text that will be printed at the end of the line example: @fill;# out put : @b

    */
    public static List<string?> textdata { get; set; } = new List<string?>(); // List to hold text data new system 
    // example: textdata.Add("textdata:@modifier:textdata");
    /* modifer list:
    main:
     * @speed;0: if zero will insta print if not itwill print text by character with a delay default is 0
     
     * @modifier: textdata - this is a modifier that can be used to change the
    color of the text: will support all the old color that the old system had 
     * @ascii;String: this will change the color using the ascii colar code aka more colors than dotnet
     * @name;string: this will change the color using the windows suppoted format aka more colors than dotnet
     * @red            → Sets text to Red
     * @green          → Sets text to Green
     * @blue           → Sets text to Blue
     * @yellow         → Sets text to Yellow
     * @cyan           → Sets text to Cyan
     * @magenta        → Sets text to Magenta
     * @gray           → Sets text to Gray
     * @white          → Sets text to White
     * @black          → Sets text to Black
     * @darkred        → Sets text to DarkRed
     * @darkgreen      → Sets text to DarkGreen
     * @darkblue       → Sets text to DarkBlue
     * @darkyellow     → Sets text to DarkYellow
     * @darkcyan       → Sets text to DarkCyan
     * @darkmagenta    → Sets text to DarkMagenta
     * @darkgray       → Sets text to DarkGray
     * @Mcolor         → Uses CLISettings.Mcolor
     * @Dmcolor        → Uses CLISettings.Dmcolor
     * @PColor         → Uses CLIPlayer.Color 
    */
    public static void TextRender(string title, string endtype = "default", string stile = "default")
    {
        // calls the seleted stile to render the text
        // calls the text back end
        //stilePicker(stile, "top", title);
        // parse the textdata and render it
        //stilePicker(stile, endtype, title);

    }
    /*
    example of textdata:
    textdata.Add("@speed;0:hi:@PColor:@name:default");
    CLIText.TextRender("root", "next", "default");
    */
    public static void stilePicker(string stile = "default", string info = "", string title = "") // info
    {
        string beforetitle = "";  //used for stile
        string aftertitle = "";  //used for stile
        // ---
        List<string?> lines = new List<string?>(); // used for stile
        // line1 = @behening,beforetitle,title,aftertitle,@fill,@end
        // lineX = @behening,data,@fill,@end
        // line format
        // line1
        // ---
        //get stile fom stile input and ues list for stile 
        /*if (isstart)
        {
            // top more simple
            //CLIText.print($"{behening}{beforetitle}{title}{aftertitle}{fill}{end}",25, true);
        }
        else
        {
            // bootom calls next or in game controls
        }*/
    }
    public static void textBackend(string data, int linesBeforeAutoNextBox = 4, bool isAutoNext = true)
    {
        List<string> table;
        table = data.Split(':').ToList();
        int speed = 0;
        //if @ char send to modifier handler else send to print handler
        foreach (string tdata in table)
        {
            if (tdata.StartsWith("@"))
            {
                if (tdata.Contains("@speed"))
                {
                    string[] speeddata = tdata.Split(';');
                    if (speeddata.Length > 1 && int.TryParse(speeddata[1], out int parsedSpeed))
                    {
                        speed = parsedSpeed;
                    }
                }else if (tdata.Contains("@"))// the bug was here it had @modifier wen it shoud have been @
                {
                    string[] colordata = tdata.Split('@');
                    if (colordata.Length > 1)
                    {
                        CLIText.Color(true, colordata[1]);
                    }
                }
            }
            else
            {
                print(tdata, speed, false);
            }
        }
        print("", 0, true);
    }
    public static void print(string text, int speed = 0, bool treturn = false) // done for now 
    {
        if (string.IsNullOrEmpty(text))
            return;

        // Instant print
        if (speed <= 0)
        {
            if (treturn)
                Console.WriteLine(text);
            else
                Console.Write(text);
            return;
        }

        // Timed character-by-character print
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(speed);
        }

        if (treturn)
            Console.WriteLine();
    }

    public static void Color(bool uesDotnet, string Color = "Mcolor", bool isBackground = false)
    {
        if (!uesDotnet) return;

        ConsoleColor targetColor;

        switch (Color)
        {
            case "Mcolor": targetColor = CLISettings.Mcolor; break;
            case "Dmcolor": targetColor = CLISettings.Dmcolor; break;
            case "White": targetColor = ConsoleColor.White; break;
            case "Black": targetColor = ConsoleColor.Black; break;
            case "Red": targetColor = ConsoleColor.Red; break;
            case "Magenta": targetColor = ConsoleColor.Magenta; break;
            case "Yellow": targetColor = ConsoleColor.Yellow; break;
            case "Green": targetColor = ConsoleColor.Green; break;
            case "Blue": targetColor = ConsoleColor.Blue; break;
            case "Cyan": targetColor = ConsoleColor.Cyan; break;
            case "Gray": targetColor = ConsoleColor.Gray; break;
            case "DarkRed": targetColor = ConsoleColor.DarkRed; break;
            case "DarkMagenta": targetColor = ConsoleColor.DarkMagenta; break;
            case "DarkYellow": targetColor = ConsoleColor.DarkYellow; break;
            case "DarkGreen": targetColor = ConsoleColor.DarkGreen; break;
            case "DarkBlue": targetColor = ConsoleColor.DarkBlue; break;
            case "DarkCyan": targetColor = ConsoleColor.DarkCyan; break;
            case "DarkGray": targetColor = ConsoleColor.DarkGray; break;

            // Default fallback (you can customize to use Mcolor, etc.)
            default: return;
        }
        if (isBackground)
        {
            Console.BackgroundColor = targetColor;
        }
        else
        {
            Console.ForegroundColor = targetColor;
        }
    }
}
