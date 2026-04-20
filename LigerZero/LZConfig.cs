namespace LigerZero;

public class LZConfig
{
    public static readonly string DefaultConfigPath = Path.GetFullPath(Env.CurrentDirectory, "config.toml");
    public string InstallDir { get; set; } = FindTSO.TSOPath;
    public int Height { get; set; } = 1024;
    public int Width { get; set; } = 768;

    public static LZConfig LoadConfig => new();
}
