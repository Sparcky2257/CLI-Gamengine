public class CLIInventory
{
    public static List<string?> Inventoryplace { get; set; } = new List<string?>(); // "place"
    public static List<string?> Inventorystore { get; set; } = new List<string?>(); // "place:itemid"
    public static List<string?> items { get; set; } = new List<string?>(); // "itemid:name:description:data"
    public static void Inventory(string place = "null", string func1 = "null", string func2 = "null") //place ex player 
    {
        if (place == "null" | func1 == "null")
        {
            CLIRuntimevar.rwarns();
        }
        else
        {
            var x = Inventoryplace.Count;
            var z = -1;
            for (int i = 0; i < x; i++)
            {
                if (Inventoryplace[i] == place)
                {
                    z = i;
                }
                if (z == -1)
                {
                    CLIRuntimevar.rwarns();
                }
                else
                {
                    Inventoryfuncall(Inventoryplace[z]);
                }
            }

        }
    }
    static void Inventoryfuncall(string place = "null", string func1 = "null", string func2 = "null")
    {

    }
    public static void setup()
    {

    }
}