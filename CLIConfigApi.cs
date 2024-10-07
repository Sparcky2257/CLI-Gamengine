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
        //galaxies
        CLISpace.Galaxy.Add("Milky Way");//id = 0
        //Solar systems
        CLISpace.Solar_System.Add("Sol");
        //Planets
        CLISpace.Planet.Add("Earth");
    }
    public static void addon(string? api1="null",string? api2="null",string? api3="null",string? api4="null",string? api5="null")
    {
        //SGCLI.api(api1,api2,api3);//sg addon
    }
    public static void bootlogo()
    {
        CLILogo.bootlogo1();
    }
}
public class CLIApi
{
    public static bool codeaddonsstartbool=false;
    public static void codeaddonsstart(){
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