public class CLIAudio
{
    public static void AudioStart()
    {
        // Initialize audio system 
        string ACOS; // Current Operating System 
        CLIRuntimevar.OSGet(); // Get the current OS will allways return a value
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
        CLIAudio.load(); // Load the audio system based on the OS
    }
    public static void load()
    {
        // Load audio system based on OS
        if (CLIRuntimevar.OS == "1") // Linux
        {
            CLIAudioLinux.Load();
        }
        else if (CLIRuntimevar.OS == "2") // MacOS
        {
            CLIAudioMacOS.Load();
        }
        else if (CLIRuntimevar.OS == "3") // Windows
        {
            CLIAudioWindows.Load();
        }
        else if (CLIRuntimevar.OS == "0") // os get error
        {
            CLILogo.logostart("Audio system not initialized due to OS get error.", 498);
        }
    }
}
public class CLIAudioConfig
{
    public static void Load()
    {
        CLIAudioSettings.ffmpegOn = false; // Default to false, turn ffmpeg on if you plan on using different audio profile with the same format
        
    }

}
public class CLIAudioSettings
{
    public static bool ffmpegOn { get; set; } = false; // Default to false, turn ffmpeg on if you plan on using different audio profile with the same format
    // paff to ffmpeg
}
public class CLIAudioLinux
{
    public static void Load()
    {
        string selectedBackend = null;

        // Detect PipeWire
        if (CommandExists("pipewire"))
        {
            selectedBackend = "PipeWire";
            // Optionally, initialize PipeWire-related backend logic here
        }
        // If PipeWire is not available, check for PulseAudio
        else if (CommandExists("pulseaudio"))
        {
            selectedBackend = "PulseAudio";
            // Optionally, initialize PulseAudio-related backend logic here
        }

        if (selectedBackend != null)
        {
            CLILogo.logostart($"Linux audio system initialized with {selectedBackend}.", 498);
        }
        else
        {
            CLILogo.logostart("No supported Linux audio system found (PipeWire or PulseAudio missing).", 498);
        }
    }

    // Helper: Check if a command exists in PATH
    private static bool CommandExists(string command)
    {
        try
        {
            using (var process = new System.Diagnostics.Process())
            {
                process.StartInfo.FileName = "/bin/bash";
                process.StartInfo.Arguments = $"-c \"command -v {command}\"";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return !string.IsNullOrWhiteSpace(output);
            }
        }
        catch
        {
            return false;
        }
    }
}
public class CLIAudioMacOS
    {
        public static void Load()
        {
            // MacOS-specific audio initialization code
            CLILogo.logostart($"MacOS audio system initialized with ", 498);
        }
    }
public class CLIAudioWindows
{
    // Use dotnet's built-in audio libraries 
    public static void Load()
    {
        // Windows-specific audio initialization code
        CLILogo.logostart($"Windows audio system initialized with ", 498);
    }

}