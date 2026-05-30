using System.Text.Json.Serialization;

namespace Blistro.Models;

public sealed class RestaurantModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("tagline")]
    public string Tagline { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("hero")]
    public HeroInfo Hero { get; set; } = new();

    [JsonPropertyName("contact")]
    public ContactInfo Contact { get; set; } = new();

    [JsonPropertyName("map")]
    public MapInfo Map { get; set; } = new();

    [JsonPropertyName("hours")]
    public List<HoursInfo> Hours { get; set; } = [];

    [JsonPropertyName("social")]
    public List<SocialLinkInfo> Social { get; set; } = [];
}

public sealed class HeroInfo
{
    [JsonPropertyName("image")]
    public string Image { get; set; } = string.Empty;

    [JsonPropertyName("alt")]
    public string Alt { get; set; } = string.Empty;
}

public sealed class ContactInfo
{
    [JsonPropertyName("phone")]
    public string Phone { get; set; } = string.Empty;

    [JsonPropertyName("email")]
    public string Email { get; set; } = string.Empty;

    [JsonPropertyName("address")]
    public string Address { get; set; } = string.Empty;
}

public sealed class MapInfo
{
    [JsonPropertyName("lat")]
    public decimal Lat { get; set; }

    [JsonPropertyName("lng")]
    public decimal Lng { get; set; }

    [JsonPropertyName("embedUrl")]
    public string EmbedUrl { get; set; } = string.Empty;
}

public sealed class HoursInfo
{
    [JsonPropertyName("day")]
    public string Day { get; set; } = string.Empty;

    [JsonPropertyName("open")]
    public string Open { get; set; } = string.Empty;

    [JsonPropertyName("close")]
    public string Close { get; set; } = string.Empty;

    [JsonPropertyName("closed")]
    public bool Closed { get; set; }
}

public sealed class SocialLinkInfo
{
    [JsonPropertyName("label")]
    public string Label { get; set; } = string.Empty;

    [JsonPropertyName("url")]
    public string Url { get; set; } = string.Empty;
}
