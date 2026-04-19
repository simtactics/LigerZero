namespace LigerZero;

/// <summary>
/// Automatically looks for The Sims Online.
/// </summary>
public static class FindTSO
{
    /// <summary>
    /// Detect the OS and return the correct platform ID.
    /// </summary>
    static PlatformID DetectOS
    {
        get
        {
            // You never know with Apple
            if (OperatingSystem.IsMacOS() || OperatingSystem.IsMacCatalyst())
                return PlatformID.MacOSX;

            return OperatingSystem.IsLinux() ? PlatformID.Unix : PlatformID.Win32NT;
        }
    }

    public static string TSOLocation
    {
        get
        {
            switch (DetectOS)
            {
                default:
                case PlatformID.Win32NT:
                    var progFiles = Env.GetFolderPath(Env.SpecialFolder.ProgramFilesX86);
                    return Path.Combine(progFiles, "Maxis", "The Sims Online");
                case PlatformID.Unix:
                case PlatformID.MacOSX:
                    var usrDir = Env.GetFolderPath(Env.SpecialFolder.UserProfile);
                    return Path.Combine(usrDir, "simsonline");
            }
        }
    }
}
