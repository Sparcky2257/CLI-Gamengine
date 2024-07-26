public class CLIGameBackupData{
    // temp settings storage
    private bool IsCurrentCache = false; // just to make sure that something stupid doesn't happen if you write an empty cache
    // taken from CLISettings
    private bool mainenuOpen = true;
    private bool debug = false;
    private bool ModingIsOn = false;
    private bool CustomLogoIsOn = false;
    private double bootlogo = 1;
    private ConsoleColor mcolor = ConsoleColor.Gray;
    private ConsoleColor dmcolor = ConsoleColor.DarkGray;
    private bool NfswIsOn = false;
    private bool BuiltInDemoEnabled = true;
    // taken from CLIPlayer
    private string? name = "none";
    private ConsoleColor color = ConsoleColor.Gray;
    private double health = 20;
    private double handequipped = 2;
    private double smarts = 45;
    private double strength = 32;
    private double speed = 10;
    private bool Parasite = false;
    private bool Requirehost = false;
    private bool Requirepower = false;
    private double Requirepowerlev = 0;
    private bool PartTeck = false;
    private double Damageresistance = 1.0;
    private string? Speciesablaty = "";
    private double protohexnum = -1;
    private bool caneditname = true;
    private string? sex = "none";
    private string? Species = "Human";
    private bool islatex = false;
    private bool canTF = false;
    private string? latextipe = "";
    private string? PevusSpecies = "";
    private string? pronoud = "they them";

    // loads current settings into cache
    public void WriteCaches(){
        // sets the var so the item can't run off of sideways caches. or something
        IsCurrentCache=false;

        // items from clisettings
        mainenuOpen=CLISettings.MainenuOpen;
        debug=CLISettings.Debug;
        ModingIsOn=CLISettings.ModingIsOn;
        CustomLogoIsOn=CLISettings.CustomLogoIsOn;
        bootlogo=CLISettings.Bootlogo;
        mcolor=CLISettings.Mcolor;
        dmcolor=CLISettings.Dmcolor;
        NfswIsOn=CLISettings.NfswIsOn;
        BuiltInDemoEnabled=CLISettings.BuiltInDemoEnabled;

        // items from cliplayer
        name=CLIPlayer.Name;
        color=CLIPlayer.Color;
        health=CLIPlayer.Health;
        handequipped=CLIPlayer.Handequipped;
        smarts=CLIPlayer.Smarts;
        strength=CLIPlayer.Strength;
        speed=CLIPlayer.Speed;
        Parasite=CLIPlayer.Parasite;
        Requirehost=CLIPlayer.Requirehost;
        Requirepower=CLIPlayer.Requirepower;
        Requirepowerlev=CLIPlayer.Requirepowerlev;
        PartTeck=CLIPlayer.PartTeck;
        Damageresistance=CLIPlayer.Damageresistance;
        Speciesablaty=CLIPlayer.Speciesablaty;
        protohexnum=CLIPlayer.Protohexnum;
        caneditname=CLIPlayer.Caneditname;
        sex=CLIPlayer.Sex;
        Species=CLIPlayer.Species;
        islatex=CLIPlayer.Islatex;
        canTF=CLIPlayer.CanTF;
        latextipe=CLIPlayer.Latextipe;
        PevusSpecies=CLIPlayer.PevusSpecies;
        pronoud=CLIPlayer.Pronoud;

        // now that the cache is ok, now set stuff back
        IsCurrentCache=true;
    }

    // reads the backup from cache and applies it
    // DO NOT USE IT IF THE PRIOR METHOD RETURNS FALSE
    public void UseBackup(){
        // items from clisettings
        CLISettings.MainenuOpen=mainenuOpen;
        CLISettings.Debug=debug;
        CLISettings.ModingIsOn=ModingIsOn;;
        CLISettings.CustomLogoIsOn=CustomLogoIsOn;;
        CLISettings.Bootlogo=bootlogo;
        CLISettings.Mcolor=mcolor;
        CLISettings.Dmcolor=dmcolor;
        CLISettings.NfswIsOn=NfswIsOn;
        CLISettings.BuiltInDemoEnabled=BuiltInDemoEnabled;

        // items from cliplayer
        CLIPlayer.Name=name;
        CLIPlayer.Color=color;
        CLIPlayer.Health=health;
        CLIPlayer.Handequipped=handequipped;
        CLIPlayer.Smarts=smarts;
        CLIPlayer.Strength=strength;
        CLIPlayer.Speed=speed;
        CLIPlayer.Parasite=Parasite;
        CLIPlayer.Requirehost=Requirehost;
        CLIPlayer.Requirepower=Requirepower;
        CLIPlayer.Requirepowerlev=Requirepowerlev;
        CLIPlayer.PartTeck=PartTeck;
        CLIPlayer.Damageresistance=Damageresistance;
        CLIPlayer.Speciesablaty=Speciesablaty;
        CLIPlayer.Protohexnum=protohexnum;
        CLIPlayer.Caneditname=caneditname;
        CLIPlayer.Sex=sex;
        CLIPlayer.Species=Species;
        CLIPlayer.Islatex=islatex;
        CLIPlayer.CanTF=canTF;
        CLIPlayer.Latextipe=latextipe;
        CLIPlayer.PevusSpecies=PevusSpecies;
        CLIPlayer.Pronoud=pronoud;

        // invalidate the cache because why the heck not??
        IsCurrentCache = false;
    }

    // an easy way to reset all caches after an operation using them. just so everything is ok :3
    // as in it tells the program the cache is bad
    public void InvalidateCache(){
        IsCurrentCache = false;
    }

    public bool ValidateCache(){
        return IsCurrentCache;
    }
}