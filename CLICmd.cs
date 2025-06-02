public class CLICmd
{
    // list of commands for the console 
    public static void mod1() // enable modding not needed but is still here for compatibility
    {
        CLISettings.moddingIsOn = true;
    }
    public static void mod0() // disable modding not needed but is still here for compatibility
    {
        CLISettings.moddingIsOn = false;
    }
}