namespace LigerZero.Formats.Json;

public record CityList(
    [property: JsonPropertyName("cities")] IEnumerable<CityListEntry> cities
);

public record CityListEntry(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("thumbnail")]
    string Thumbnail,
    [property: JsonPropertyName("description")]
    string Description,
    [property: JsonPropertyName("heightmap")]
    string HeightMap,
    [property: JsonPropertyName("vertexcolor")]
    string VertexColour
);
