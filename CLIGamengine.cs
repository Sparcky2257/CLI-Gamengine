// See https://aka.ms/new-console-template for more information
// CLIPlayer player = new CLIPlayer();
// CLISettings settings = new CLISettings();
//ClIMiscellaneous miscellaneous = new ClIMiscellaneous();
//CLIGamePrep gameprep= new CLIGamePrep();
//CLILogo logo = new CLILogo();
CLIMenu menu = new CLIMenu();
//CLIConfig config = new CLIConfig();
//clear
Console.Clear();
//int
CLIInt.start();
//term test
if (Environment.GetEnvironmentVariable("TERM") == "xterm")
{
    CLIRuntimevar.crt = true;
    CLISettings.Dmcolor = ConsoleColor.Gray;
    CLISettings.Mcolor = ConsoleColor.White;
    menu.textboxvarold = "0";
    menu.textboxnameold = "warn";
    menu.textboxnamecold = ConsoleColor.Yellow;
    menu.TextBoxstartold();
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("256 not deteted");
    CLIRuntimevar.rwarns();
    Console.ResetColor();
    Console.WriteLine("adjusted colours");
    menu.TextBoxsendold();
}
//os test
CLIRuntimevar.OSGet();
//os warn
if (CLIRuntimevar.OS == "4")
{
    menu.textboxvarold = "0";
    menu.textboxnameold = "warn";
    menu.textboxnamecold = ConsoleColor.Yellow;
    menu.TextBoxstartold();
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("OS not recognized");
    CLIRuntimevar.rwarns();
    Console.ResetColor();
    Console.WriteLine($"OS:{CLIRuntimevar.OSName()}");
    menu.TextBoxsendold();
}
//test zone
CLISpecieList.SelectionMenu();
//ghvftyu
//
// CLIGameBackup.ReadBackup(string.Empty); //don't instantly call this, not meant for it
//i nead help
//menu.MainMenu();
CLIConfig.MainMenu();
//end
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("exiting...");
Console.ResetColor();
Thread.Sleep(999);
Console.Clear();
if (CLISettings.Debug == true)
{
    Console.WriteLine("debug:");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(CLISettings.Debug);
    Console.ResetColor();
    Console.WriteLine("ModingIsOn:");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(CLISettings.moddingIsOn);
    Console.ResetColor();
    Console.WriteLine("error count: ");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(CLIRuntimevar.errors);
    Console.ResetColor();
    Console.WriteLine("warn count: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(CLIRuntimevar.warns);
    Console.ResetColor();
    Console.WriteLine("bootlogo: ");
    Console.ForegroundColor = ConsoleColor.Blue;
    /*Console.Write(CLISettings.Bootlogo);
    switch (CLISettings.Bootlogo)
    {
        case 1:
            Console.WriteLine(" bootlogo");
            break;
        case 2:
            Console.WriteLine(" moded menu");
            break;
        default:
            Console.WriteLine(" no logo");
            break;
    }
    Console.ResetColor();*/
    //Console.WriteLine("moded logo:");
    //logo.bootlogo2();
    Console.WriteLine("default logo:");
    //logo.bootlogo1();
    CLIConfig.bootlogo();
    Console.WriteLine($"{CLIPlayer.species} HP{CLIPlayer.Health} SM:{CLIPlayer.Smarts} ST:{CLIPlayer.Strength} SP:{CLIPlayer.Speed} DR;{CLIPlayer.damageResistance} handequipped:{CLIPlayer.Handequipped} Parasite:{CLIPlayer.parasite} Requirehost:{CLIPlayer.requireHost} Requirepower:{CLIPlayer.requirePower} Requirepowerlev:{CLIPlayer.requirePowerLevel} PartTeck:{CLIPlayer.partTech} ");//Speciesablaty:{CLIPlayer.speciesAbility}
    //SharedVariables sharedVars = new SharedVariables();
    //sharedVars.Sharedname = name;
    //Console.WriteLine(sharedVars.Sharedname);
    CLISpace.print();
}

