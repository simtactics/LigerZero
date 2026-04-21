namespace LigerZero.Common;

public static class FileManager
{
    public static string ReadTextFile(string path)
    {
        using var file = FileAccess.Open(path, FileAccess.ModeFlags.Read);
        var contents = file.GetAsText();

        file.Close();
        return contents;
    }

    public static byte[] ReadBuffer(string path, long length)
    {
        using var file = FileAccess.Open(path, FileAccess.ModeFlags.Read);
        var contents = file.GetBuffer(length);

        file.Close();
        return contents;
    }
}
