using System.Security.Cryptography.X509Certificates;

public class CLIInt
{
    public static void start()
    {
        CLILogo.logostart("Credits", 498);
        //cedites "CL" is uesd to chage colers "MC"and "DMC" are allso a way to chage the coller
        //ex: ClIMiscellaneous.Creditsdata.Add("CL");
        //ClIMiscellaneous.Creditsdata.Add($"{ConsoleColor.Green}");
        ClIMiscellaneous.Creditsdata.Add("MC");
        ClIMiscellaneous.Creditsdata.Add("====CLIGamengine====");
        ClIMiscellaneous.Creditsdata.Add("DMC");
        ClIMiscellaneous.Creditsdata.Add("Sparcky Ancientpack");
        ClIMiscellaneous.Creditsdata.Add("Pawos Howl");
        ClIMiscellaneous.checkelist();
        //dont edit top
        //replace text by your game name and name by yores
        ClIMiscellaneous.Creditsdata.Add("MC");
        //ClIMiscellaneous.Creditsdata.Add("====text====");
        ClIMiscellaneous.Creditsdata.Add("DMC");
        //ClIMiscellaneous.Creditsdata.Add("name");

        //Console.WriteLine(ClIMiscellaneous.Creditsdata.Count);
        //CLISettings.Debug = true; //this just for testing
        //api
        CLIApi.codeaddonsstart();
        //config
        CLIConfig.load();
        //infostart
        ClIMiscellaneous.Creditsdatainfo();
        CLILogo.logostart("Config", 498);
        CLISpace.init();


    }
}
public class CLIConfig
{
    public static void load()
    {
        CLISpace.input.Add("G:Milky Way:S:Sol:P:Earth:Mars");
        CLISpace.inputrun();
        // do not use this system does not include IDs system still public because of add-ons
        //galaxies
        //CLISpace.Galaxy.Add("Milky Way");//id = 0
        //Solar systems
        //CLISpace.Solar_System.Add("Sol");
        //Planets
        //CLISpace.Planet.Add("Earth");
    }
    public static void addon(string? api1 = "null", string? api2 = "null", string? api3 = "null", string? api4 = "null", string? api5 = "null")
    {
        //SGCLI.api(api1,api2,api3);//sg addon
    }
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // these functions only exists so you can use the code in different modules. For example, if you wanted to make your own module, he could override it here.
    //-------------------------------------------------------------------------------------------------------------------------------------------------------------------  
    public static void bootlogo()
    {
        CLILogo.bootlogo1();
    }
    // main menu
    public static void MainMenu()
    {
        //CLIMenu.MainMenu();
        CLITest.MainMenu();
    }
    // new game
    public static void newgame()
    {
        CLIGamePrep.newgame();
    }
    //Cli new game setings
    public static void GPsavename()
    {
        CLIGamePrep.savename();
    }
    public static void GPPlayerinfo()
    {
        //CLIGamePrep.Playerinfo();
        CLITest.Playerinfo();
    }
    public static void GPPlayerName()
    {
        CLIGamePrep.PlayerName();
    }
     public static void GPColour()
    {
        CLIGamePrep.Colour();
    }
    // load game
    public static void loadgame()
    {
        CLIMenu.loadgame();
    }
    //options
    public static void options()
    {
        //CLIMenu.options();
        CLITest.Options();
    }
    //cli options settings 
    public static void optionsretun()
    {
        Console.Clear();
    }
    public static void Advancedoptions()
    {
        //CLIMenu.Advancedoptions();
        CLITest.Advancedoptions();
    }
    //Consol
    public static void Consol()
    {
        CLIMenu.Consol();
    }
    //Cli Consol settings
    public static void Consolext()
    {
        
    }
     public static void Demo()
    {
        CLIDemo.Play();
    }
    public static void PlayMain()
    {
        //XX.play();
        CLISettings.mainMenuOpen = true;
        CLIMenu.MainMenu();
    }
    //MMAColoursel ui color settings
    public static void MMAColoursel()
    {
        //CLIMenu.MMAColoursel();
        CLITest.MMAColoursel();
    }
}
public class CLIApi
{
    public static bool codeaddonsstartbool = false;
    public static void codeaddonsstart()
    {
        codeaddonsstartbool = true;
        ClIMiscellaneous.Creditsdata.Add("MC");
        ClIMiscellaneous.Creditsdata.Add("=======Addons=======");
        ClIMiscellaneous.Creditsdata.Add("DMC");
        CLIConfig.addon();
        codeaddonsstartbool = false;
    }
    //public static List<string?> codeaddonsnames { get; set; } = new List<string?>();
    public static List<string?> codeaddonspecies { get; set; } = new List<string?>();
}