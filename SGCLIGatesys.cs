using System.ComponentModel;
using System.Net.Sockets;

public class SGCLI
{
    private static bool add_abdos;
    private static void config()
    {
        add_abdos = true;
        configlogc();
    }
    private static void configlogc()
    {
        if (add_abdos == true)
        {
            int x = CLISpace.Galaxy.Count;
            int z=0;
            bool y=false;
            if (CLISpace.Galaxy.Any() == true)
            {
                for (int i = 0; i < x; i++)
                {
                   if (CLISpace.Galaxy[i]=="Milky Way"){y=true; z=i;}
                }
            }
            if (y==false){}
            CLISpace.Solar_System.Add($"Sol_Abdos:{z}");

                        if (CLISpace.Solar_System.Any() == true)
            {
                for (int i = 0; i < x; i++)
                {
                   if (CLISpace.Solar_System[i]==$"Sol_Abdos:{z}"){ z=i;}
                }
            }
            if (y==false){}
            CLISpace.Planet.Add($"Abdos:{z}");
        }
    }
    public static void api(string local = "null", string local2 = "null", string local3 = "null")
    {
        switch (local)
        {
            case "S":
                SGCLI.SpecieList(local2, local3);
                break;
            default:
                break;
        }
        if (CLIApi.codeaddonsstartbool == true)
        {
            ClIMiscellaneous.Creditsdata.Add("MC");
            ClIMiscellaneous.Creditsdata.Add("SGCLI");
            ClIMiscellaneous.Creditsdata.Add("DMC");
            ClIMiscellaneous.Creditsdata.Add("Sparcky Ancientpack");
            CLIApi.codeaddonspecies.Add("SGCLI:ID001:H");
            CLIApi.codeaddonspecies.Add("SGCLI:ID002:H");
            SGCLI.config();
        }
    }
    static void SpecieList(string llocal2 = "null", string llocal3 = "null")
    {
        switch (llocal2)
        {
            case "SGCLI:ID001:H":
                if (llocal3 == "L")
                {
                    SGSpecieList.ID001();
                }
                break;
            default:
                break;
        }
    }
}
//    public static List<string?> codeaddonspecies { get; set; } = new List<string?>();
/*  CLIPlayer.species = "Goa'uld";
    CLIPlayer.Health = 30;
    CLIPlayer.Handequipped = 2;
    CLIPlayer.Smarts = 55;
    CLIPlayer.Speed = 12;
    CLIPlayer.Strength = 40;
    CLIPlayer.parasite = true;
    CLIPlayer.requireHost = true;
    CLIPlayer.requirePower = false;
    CLIPlayer.requirePowerLevel = 0;
    CLIPlayer.partTech = false;
    //CLIPlayer.speciesAbility = "";
    CLIPlayer.canEditName = true;*/


public class SGStargate
{
    public string? id { get; set; }
    public string? name { get; set; }
    public string? address { get; set; }
    public int type { get; set; }
    // 1 = SGU 2 = MW 3=PEG
    public int net { get; set; }
    // this is for the different networks In the show it's 1=MW 2=PEG ?=SGU

}
public class SGPDD : CLIHandheldDevices
{
    public bool isSGU { get; set; }
    public int MaxDial { get; set; }
    public bool isGoauld { get; set; }
    public bool HasAdressBase { get; set; }
    public string? AddressBase { get; set; }
}
public class SGSpecieList : CLISpecieList
{
    // ClIPlayer player = new ClIPlayer();
    // CLISettings settings = new CLISettings();
    public static void ID001()
    {
        CLIPlayer.species = "Goa'uld";
        CLIPlayer.Health = 30;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 55;
        CLIPlayer.Speed = 12;
        CLIPlayer.Strength = 40;
        CLIPlayer.parasite = true;
        CLIPlayer.requireHost = true;
        CLIPlayer.requirePower = false;
        CLIPlayer.requirePowerLevel = 0;
        CLIPlayer.partTech = false;
        //CLIPlayer.speciesAbility = "";
        CLIPlayer.canEditName = true;
    }

    public static void ID002()
    {
        CLIPlayer.species = "Tok'ra";
        CLIPlayer.Health = 30;
        CLIPlayer.Handequipped = 2;
        CLIPlayer.Smarts = 55;
        CLIPlayer.Speed = 12;
        CLIPlayer.Strength = 40;
        CLIPlayer.parasite = true;
        CLIPlayer.requireHost = true;
        CLIPlayer.requirePower = false;
        CLIPlayer.requirePowerLevel = 0;
        CLIPlayer.partTech = false;
        //CLIPlayer.speciesAbility = "";
        CLIPlayer.canEditName = true;
    }
}