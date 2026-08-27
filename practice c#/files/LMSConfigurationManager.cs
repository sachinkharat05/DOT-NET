namespace LMSApp.Core;

/// <summary>
/// Singleton — stores system-wide LMS settings.
/// </summary>
public sealed class LMSConfigurationManager
{
    private static LMSConfigurationManager? _instance;

    public string InstituteName { get; } 
    public string Version       { get; } 
    public string AdminContact  { get; }
    private LMSConfigurationManager() { }   // private constructor

    public static LMSConfigurationManager Instance
    {
        get
        {
            _instance ??= new LMSConfigurationManager();
            return _instance;
        }
    }

    public void DisplayConfig()
    {
        Console.WriteLine("\n====== System Configuration (Singleton) ======");
        Console.WriteLine($"  Institute Name : {InstituteName}");
        Console.WriteLine($"  Version        : {Version}");
        Console.WriteLine($"  Admin Contact  : {AdminContact}");
        Console.WriteLine("==============================================");
    }
}
