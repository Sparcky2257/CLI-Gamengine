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
        //replace text by your game name and name by yores
        ClIMiscellaneous.Creditsdata.Add("MC");
        //ClIMiscellaneous.Creditsdata.Add("====text====");
        ClIMiscellaneous.Creditsdata.Add("DMC");
        //ClIMiscellaneous.Creditsdata.Add("name");

        //Console.WriteLine(ClIMiscellaneous.Creditsdata.Count);
        //CLISettings.Debug = true; //this just for testing
        ClIMiscellaneous.Creditsdatainfo();
        CLILogo.logostart("Config", 498);
        CLIConfig.load();
        CLISpace.init();

        //api
        CLIApi.codeaddonsstart();
    }
}
public class CLIConfig
{
    public static void load()
    {
        //galaxies
        CLISpace.Galaxy.Add("Milky Way");//id = 0
        //Solar systems
        CLISpace.Solar_System.Add("Sol");
        //Planets
        CLISpace.Planet.Add("Earth");
        //codeaddons

    }
    public static void addon()
    {
        //SG.startup();//sg addon
    }
    public static void bootlogo()
    {
        CLILogo.bootlogo1();
    }
}
public class CLIApi
{
    public static void codeaddonsstart(){
        ClIMiscellaneous.Creditsdata.Add("MC");
        ClIMiscellaneous.Creditsdata.Add("=======Addons=======");
        ClIMiscellaneous.Creditsdata.Add("DMC");
        CLIConfig.addon();
    }
    public static List<string?> codeaddonsnames { get; set; } = new List<string?>();
    
}