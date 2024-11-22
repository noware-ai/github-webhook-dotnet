using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubTool
{
    [JsonPropertyName("guid")] public string? Guid { get; set; } = null;
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty; // e.g. "CodeQL"
    [JsonPropertyName("version")] public string Version { get; set; } = string.Empty;
}
