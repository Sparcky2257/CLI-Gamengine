public class CLIAudio
{
    public static void AudioStart()
    {
        // Initialize audio system 
        string ACOS; // Current Operating System
        CLIRuntimevar.OSGet(); // Get the current OS
        CLIAudioConfig.Load(); // Load audio configuration settings
        // Determine the current operating system
        if (CLIRuntimevar.OS == "1") // Linux
        {
            ACOS = "Linux";
        }
        else if (CLIRuntimevar.OS == "2") // MacOS
        {
            ACOS = "MacOS";
        }
        else if (CLIRuntimevar.OS == "3") // Windows
        {
            ACOS = "Windows";
        }
        else if (CLIRuntimevar.OS == "0") // os get error
        {
            ACOS = "[os get not run]";
        }
        else // Unknown OS
        {
            ACOS = "Unknown os";
        }
        // Load audio profile based on OS
        CLILogo.logostart($"Audio profile {ACOS} loaded.", 498);
        CLILogo.logostart("Audio system initialized.", 498);
    }

}
public class CLIAudioConfig
{
    public static void Load()
    {
        CLIAudioSettings.ffmpeg = false; // Default to false, turn ffmpeg on if you plan on using different audio profile with the same format
        
    }

}
public class CLIAudioSettings
{
    public static bool ffmpeg { get; set; } = false; // Default to false, turn ffmpeg on if you plan on using different audio profile with the same format

}
public class CLIAudioLinux
{
    public static void Load()
    {
        // Linux-specific audio initialization code
        // detect if pipewire is installed

        // If pipewire is not installed, use pulseaudio

        // if none of the above is installed, create error message
        CLILogo.logostart($"Linux audio system initialized with ", 498);
    
    }
}