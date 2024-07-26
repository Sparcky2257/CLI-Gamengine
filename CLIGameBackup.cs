using System.Text.Json;

public class CLIGameBackup{
    private static CLIGameBackupData backup = new CLIGameBackupData();
    private static readonly string fileEnd = ".json"; // in case I want to change it later
    // https://stackoverflow.com/questions/18813475/c-sharp-saving-a-txt-file-to-the-project-root
    // private string backuploc = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"GAMEDATABACKUP.json");
    // private string backuploc = Path.Combine(Environment.CurrentDirectory,"GAMEDATABACKUP.json");

    // returns false if something goes wrong (early termination)
    public static bool WriteBackup(string name){
        backup.WriteCaches();
        if(!backup.ValidateCache()){return false;} // termination before serialization
        string gamedata = JsonSerializer.Serialize(backup);
        File.WriteAllText(Path.Combine(Environment.CurrentDirectory,"saves/"+name+fileEnd),gamedata);
        return true; // everything should have run correctly
    }

    // returns false if there is an error
    // NOTE: IF IT RETURNS FALSE DO NOT USE THE BACKUP
    public static bool ReadBackup(string name){
        string paf = Path.Combine(Environment.CurrentDirectory,"saves/"+name+fileEnd);
        if(!File.Exists(paf)){return false;} // no backup file
        string filedata = File.ReadAllText(paf);
        CLIGameBackupData? temp;
        try{
            temp = JsonSerializer.Deserialize<CLIGameBackupData>(filedata);
            if(!temp.ValidateCache()){return false;} // not a valid cache
        }
        catch (Exception e){
            Console.WriteLine("SESSION RESTORE ERROR >>"+e);
            return false;
        }
        // very scawwy
        backup = temp;
        backup.UseBackup();
        return true; // this should be fine
    }

    // this is more used in another code segment
    public static string getCurrentFileEnd(){
        return fileEnd;
    }
}