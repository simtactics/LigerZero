using System.Text.Json.Serialization;

namespace LigerZero.Formats.tsodata;

public abstract class TSODataObject
{
    protected TSODataFile ParentFile { get; set; }
    [JsonIgnore]
    protected uint NameID { get; set; }
    public string NameString => ParentFile.Strings[NameID].Value;
}