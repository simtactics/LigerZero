namespace LigerZero.Formats.Json;

public record Neighborhoods(
    [property: JsonPropertyName("neighborhoods")]
    IEnumerable<NeighborhoodsItem> Nhood);

public record NeighborhoodsItem(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("windowX")]
    string WindowX,
    [property: JsonPropertyName("windowY")]
    string WindowY,
    [property: JsonPropertyName("size")] string Size
);
