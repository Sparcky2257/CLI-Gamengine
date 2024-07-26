public class CLIRuntimevar
{
    public static double errors { get; set; } = 0;

    public static double warns { get; set; } = 0;
    public static bool crt { get; set; } 
     public static void rerror()
    {
        errors ++ ;
    }
    public static void rwarns()
    {
        warns ++ ;
    }
}