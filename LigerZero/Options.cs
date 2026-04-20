namespace LigerZero;

public class Options
{
    [Option('m', "mode")] public string Mode { get; set; } = "default";
}
