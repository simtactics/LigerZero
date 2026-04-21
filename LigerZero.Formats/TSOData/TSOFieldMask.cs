using System.Text.Json.Serialization;

namespace LigerZero.Formats.tsodata;

public class TSOFieldMask : TSODataObject
{
    public TSOFieldMask(uint fieldMaskID, TSOFieldMaskValues value)
    {
        ParentFile = TSODataImporter.Current;
        NameID = fieldMaskID;
        Values = value;
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TSOFieldMaskValues Values { get; set; }
}