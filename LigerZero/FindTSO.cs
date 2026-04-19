using System.Runtime.InteropServices;

namespace LigerZero;

/// <summary>
/// Automatically looks for The Sims Online.
/// </summary>
public class FindTSO
{
    /// <summary>
    /// Detect the OS and return the correct platform ID.
    /// </summary>
    PlatformID DetectOS
    {
        get
        {
            // You never know with Apple
            if (OperatingSystem.IsMacOS() || OperatingSystem.IsMacCatalyst())
                return PlatformID.MacOSX;

            return OperatingSystem.IsLinux() ? PlatformID.Unix : PlatformID.Win32NT;
        }
    }
}
