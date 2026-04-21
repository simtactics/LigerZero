namespace LigerZero.Formats.Json;

public record Lot(
    [property: JsonPropertyName("house")] House House
);

public record House(
    [property: JsonPropertyName("size")] string Size,
    [property: JsonPropertyName("category")]
    string Category,
    [property: JsonPropertyName("world")] World World,
    [property: JsonPropertyName("objects")]
    IEnumerable<ObjectsItem> Objects
);

public record World(
    [property: JsonPropertyName("floors")] IEnumerable<FloorsItem> Floors,
    [property: JsonPropertyName("walls")] IEnumerable<WallsItem> Walls
);

public record FloorsItem(
    [property: JsonPropertyName("level")] string Level,
    [property: JsonPropertyName("x")] string X,
    [property: JsonPropertyName("y")] string Y,
    [property: JsonPropertyName("value")] string Value
);

public record WallsItem(
    [property: JsonPropertyName("Segments")]
    string Segments,
    [property: JsonPropertyName("level")] string Level,
    [property: JsonPropertyName("x")] string X,
    [property: JsonPropertyName("y")] string Y,
    [property: JsonPropertyName("placement")]
    string Placement,
    [property: JsonPropertyName("tls")] string Tls,
    [property: JsonPropertyName("trs")] string Trs,
    [property: JsonPropertyName("tlp")] string Tlp,
    [property: JsonPropertyName("trp")] string Trp,
    [property: JsonPropertyName("brp")] string Brp,
    [property: JsonPropertyName("blp")] string Blp
);

public record ObjectsItem(
    [property: JsonPropertyName("guid")] string Guid,
    [property: JsonPropertyName("level")] string Level,
    [property: JsonPropertyName("x")] string X,
    [property: JsonPropertyName("y")] string Y,
    [property: JsonPropertyName("dir")] string Dir,
    [property: JsonPropertyName("group")] string Group
);
