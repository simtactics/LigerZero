namespace LigerZero;

public class LZConfig
{
    // Generally, we'll want to put this in res:// or user://
    public static readonly string DefaultConfigPath = Path.GetFullPath(Env.CurrentDirectory, "config.toml");
    public int Height { get; set; } = 1024;
    public int Width { get; set; } = 768;

    public static LZConfig LoadConfig => new();
}
