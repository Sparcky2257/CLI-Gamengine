
public class CLIItem
{
    public string? Name { get; set; }
    public string? ItemID { get; set; }
    public string? Description { get; set; }
}
public class CLIGun : CLIItem
{
    public int Ammo { get; set; }
    public int MaxAmmo { get; set; }
    public int Mag { get; set; }
    public double MaxDamage { get; set; }
    public double MinDamage { get; set; }
    public bool HasSecondary { get; set; }
    public int Ammo2 { get; set; }
    public int MaxAmmo2 { get; set; }
    public double MaxDamage2 { get; set; }
    public double MinDamage2 { get; set; }
}
public class CLIHandheldDevices : CLIItem
{

}
