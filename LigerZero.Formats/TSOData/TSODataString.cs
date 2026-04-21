using System.Text.Json.Serialization;

namespace LigerZero.Formats.tsodata;

public class TSODataString
{
    public TSODataString(string value, TSODataStringCategories category)
    {
        Value = value;
        Category = category;
    }

    public string Value { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TSODataStringCategories Category { get; set; }
}
