using System.Collections;

public class CLIInventory
{
    public static List<string?> Inventoryplace { get; set; } = new List<string?>(); // "place"
    public static List<string?> Inventorystore { get; set; } = new List<string?>(); // "place:itemid:itemid:itemid..."
    public static List<string?> SouceId { get; set; } = new List<string?>(); // "souceid:itemid:itemid:itemid..." its an id uesd for adons and system
    public static List<string?> items { get; set; } = new List<string?>(); // "itemid:name:description:data"
    //check string
    public static void Inventory(string place = "null", string func1 = "null", string func2 = "null", string func3 = "null") //place ex player: func1 inv fucunk: func2 itemid
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
                    Inventoryfuncall(Inventoryplace[z], func1, func2, func3);
                }
            }
        }
    }
    //main inv sellte
    static void Inventoryfuncall(string place = "null", string func1 = "null", string func2 = "null", string func3 = "null")
    {

        switch (func1)
        {
            case "null":
            break;
            case "Use":
            UseCH(place,func2,func3);
            break;
            case "Add":
            break;
            case "Remove":
            break;
            case "RM":
            break;
            case "Move":
            break;
            case "MV":
            break;
            default:
            break;
        }
    }
    //ues check
    static void UseCH(string place = "null", string func2 = "null", string func3 = "null")
    {
        string souceid = "null";
                    var x = SouceId.Count;
            var z = -1;
            for (int i = 0; i < x; i++)
            {
                if (SouceId[i] == place)
                {
                    z = i;
                }
                if (z == -1)
                {
                    CLIRuntimevar.rwarns();
                }
                else
                {
                 
                }
            }
    }
    public static void setup()
    {

    }
}