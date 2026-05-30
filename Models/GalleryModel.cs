using System.Text.Json.Serialization;

namespace Blistro.Models;

public sealed class GalleryModel
{
    [JsonPropertyName("images")]
    public List<GalleryImage> Images { get; set; } = [];
}

public sealed class GalleryImage
{
    [JsonPropertyName("src")]
    public string Src { get; set; } = string.Empty;

    [JsonPropertyName("caption")]
    public string Caption { get; set; } = string.Empty;

    [JsonPropertyName("alt")]
    public string Alt { get; set; } = string.Empty;
}
