namespace LigerZero;

public static class PathResolver
{
    public static string ExecutablePath(string file) => OS.GetExecutablePath().GetBaseDir().PathJoin(file);
    public static string? ProjectDir => Directory.GetParent(Env.CurrentDirectory)?.Parent?.FullName;
}
