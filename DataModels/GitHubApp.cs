using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubApp
{
    [JsonPropertyName("client_id")] public string ClientId { get; set; } = string.Empty;
    [JsonPropertyName("description")] public string Description { get; set; } = string.Empty;
    [JsonPropertyName("events")] public string[]? Events { get; set; } = null;
    [JsonPropertyName("external_url")] public string ExternalUrl { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("owner")] public GitHubUser? Owner { get; set; } = null;
    [JsonPropertyName("permissions")] public object? Permissions { get; set; } = null;
    [JsonPropertyName("slug")] public string Slug { get; set; } = string.Empty;
}
