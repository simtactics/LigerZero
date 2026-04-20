namespace LigerZero;

public class LZConfig
{
    public static readonly string DefaultConfigPath = Path.GetFullPath(Env.CurrentDirectory, "config.toml");
    public string InstallDir { get; set; } = FindTSO.TSOPath;
    public int Height { get; set; } = 1024;
    public int Width { get; set; } = 768;

    public static LZConfig LoadConfig()
    {
        if (!FileAccess.FileExists(DefaultConfigPath)) return new LZConfig();

        using var readCfg = FileAccess.Open(DefaultConfigPath, FileAccess.ModeFlags.Read);
        var loadCfg = TomlSerializer.Deserialize<LZConfig>(readCfg.GetAsText());
        return loadCfg;
    }
}
