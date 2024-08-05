public class CLIGameBackupData{
    // temp settings storage
    private bool IsCurrentCache = false; // just to make sure that something stupid doesn't happen if you write an empty cache
    // taken from CLISettings
    private bool mainMenuOpen = true;
    private bool debug = false;
    private bool moddingIsOn = false;
    private bool customLogoIsOn = false;
    private double bootlogo = 1;
    private ConsoleColor mcolor = ConsoleColor.Gray;
    private ConsoleColor dmcolor = ConsoleColor.DarkGray;
    private bool NSFWIsOn = false;
    private bool BuiltInDemoEnabled = true;
    // taken from CLIPlayer
    private string? name = "none";
    private ConsoleColor color = ConsoleColor.Gray;
    private double health = 20;
    private double handequipped = 2;
    private double smarts = 45;
    private double strength = 32;
    private double speed = 10;
    private bool parasite = false;
    private bool requireHost = false;
    private bool requirePower = false;
    private double requirePowerLevel = 0;
    private bool partTech = false;
    private double damageResistance = 1.0;
    //private string? speciesAbility = ""; //needs to be fixd
    private double protohexnum = -1;
    private bool canEditName = true;
    private string? sex = "none";
    private string? species = "Human";
    private bool isLatex = false;
    private bool canTF = false;
    private string? latexType = "";
    private string? previousSpecies = "";
    private string? pronouns = "they them";

    // loads current settings into cache
    public void WriteCaches(){
        // sets the var so the item can't run off of sideways caches. or something
        IsCurrentCache=false;

        // items from clisettings
        mainMenuOpen=CLISettings.mainMenuOpen;
        debug=CLISettings.Debug;
        moddingIsOn=CLISettings.moddingIsOn;
        customLogoIsOn=CLISettings.customLogoIsOn;
        bootlogo=CLISettings.Bootlogo;
        mcolor=CLISettings.Mcolor;
        dmcolor=CLISettings.Dmcolor;
        NSFWIsOn=CLISettings.NSFWIsOn;
        BuiltInDemoEnabled=CLISettings.BuiltInDemoEnabled;

        // items from cliplayer
        name=CLIPlayer.Name;
        color=CLIPlayer.Color;
        health=CLIPlayer.Health;
        handequipped=CLIPlayer.Handequipped;
        smarts=CLIPlayer.Smarts;
        strength=CLIPlayer.Strength;
        speed=CLIPlayer.Speed;
        parasite=CLIPlayer.parasite;
        requireHost=CLIPlayer.requireHost;
        requirePower=CLIPlayer.requirePower;
        requirePowerLevel=CLIPlayer.requirePowerLevel;
        partTech=CLIPlayer.partTech;
        damageResistance=CLIPlayer.damageResistance;
        //speciesAbility=CLIPlayer.speciesAbility; //needs to be fixd
        protohexnum=CLIPlayer.Protohexnum;
        canEditName=CLIPlayer.canEditName;
        sex=CLIPlayer.Sex;
        species=CLIPlayer.species;
        isLatex=CLIPlayer.isLatex;
        canTF=CLIPlayer.CanTF;
        latexType=CLIPlayer.latexType;
        previousSpecies=CLIPlayer.previousSpecies;
        pronouns=CLIPlayer.pronouns;

        // now that the cache is ok, now set stuff back
        IsCurrentCache=true;
    }

    // reads the backup from cache and applies it
    // DO NOT USE IT IF THE PRIOR METHOD RETURNS FALSE
    public void UseBackup(){
        // items from clisettings
        CLISettings.mainMenuOpen=mainMenuOpen;
        CLISettings.Debug=debug;
        CLISettings.moddingIsOn=moddingIsOn;;
        CLISettings.customLogoIsOn=customLogoIsOn;;
        CLISettings.Bootlogo=bootlogo;
        CLISettings.Mcolor=mcolor;
        CLISettings.Dmcolor=dmcolor;
        CLISettings.NSFWIsOn=NSFWIsOn;
        CLISettings.BuiltInDemoEnabled=BuiltInDemoEnabled;

        // items from cliplayer
        CLIPlayer.Name=name;
        CLIPlayer.Color=color;
        CLIPlayer.Health=health;
        CLIPlayer.Handequipped=handequipped;
        CLIPlayer.Smarts=smarts;
        CLIPlayer.Strength=strength;
        CLIPlayer.Speed=speed;
        CLIPlayer.parasite=parasite;
        CLIPlayer.requireHost=requireHost;
        CLIPlayer.requirePower=requirePower;
        CLIPlayer.requirePowerLevel=requirePowerLevel;
        CLIPlayer.partTech=partTech;
        CLIPlayer.damageResistance=damageResistance;
        //CLIPlayer.speciesAbility=speciesAbility; //needs to be fixd
        CLIPlayer.Protohexnum=protohexnum;
        CLIPlayer.canEditName=canEditName;
        CLIPlayer.Sex=sex;
        CLIPlayer.species=species;
        CLIPlayer.isLatex=isLatex;
        CLIPlayer.CanTF=canTF;
        CLIPlayer.latexType=latexType;
        CLIPlayer.previousSpecies=previousSpecies;
        CLIPlayer.pronouns=pronouns;

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