public class CLIAudio
{
    public static void AudioStart()
    {
        // Initialize audio system 
        string COS; // Current Operating System
        CLIRuntimevar.OSGet(); // Get the current OS
        if (CLIRuntimevar.OS == "1") // Linux
        {
            COS = "Linux";
        }
        else if (CLIRuntimevar.OS == "2") // MacOS
        {
            COS = "MacOS";
        }
        else if (CLIRuntimevar.OS == "3") // Windows
        {
            COS = "Windows";
        }
        else if (CLIRuntimevar.OS == "0") // os get error 
        {
            COS = "[os get not run]";
        }
        else // Unknown OS
        {
            COS = "Unknown os";
        }
        // Load audio profile based on OS
        CLILogo.logostart($"Audio profile {COS} loaded.", 498);
        CLILogo.logostart("Audio system initialized.", 498);
    }

}
public class CLIAudioConfig
{
 CLIAudioSettings.ffmpeg = false; // Default to false, trun ffmpeg on if you plan on using different audio profile with the same fomat

}
public class CLIAudioSettings
{
public static bool ffmpeg { get; set; } = false;
}