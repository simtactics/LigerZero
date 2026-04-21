namespace LigerZero.Common;

public static class FileManager
{
    public static bool TSOExists
    {
        get
        {
            var dir = DirAccess.Open(LZConsts.TSO_DIR);
            return dir != null;
        }
    }

    public static AudioStreamMP3 LoadMP3(string path)
    {
        using var file = FileAccess.Open(path, FileAccess.ModeFlags.Read);
        var sound = new AudioStreamMP3();
        sound.Data = file.GetBuffer((long)file.GetLength());
        return sound;
    }

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
