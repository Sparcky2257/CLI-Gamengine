public class CLIInt{
    public static void start(){
        //galaxies
        CLISpace.Galaxy.Add("Milky Way");//id = 0
        //Solar systems
        //Planets
        //cedites "CL" is uesd to chage colers "MC"and "DMC" are allso a way to chage the coller
        //ex: ClIMiscellaneous.Creditsdata.Add("CL");
        //ClIMiscellaneous.Creditsdata.Add($"{ConsoleColor.Green}");
        
        ClIMiscellaneous.Creditsdata.Add("MC");
        ClIMiscellaneous.Creditsdata.Add("====CLIGamengine====");
        ClIMiscellaneous.Creditsdata.Add("DMC");
        ClIMiscellaneous.Creditsdata.Add("Sparcky Ancientpack");
        ClIMiscellaneous.Creditsdata.Add("Pawos Howl");
        //Console.WriteLine(ClIMiscellaneous.Creditsdata.Count);
        //CLISettings.Debug = true; //this just for testing
    }
}