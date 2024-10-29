using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubRelease
{
    [JsonPropertyName("assets_url")] public string AssetsUrl { get; set; } = string.Empty;
    [JsonPropertyName("author")] public GitHubUser? Author { get; set; }
    [JsonPropertyName("body")] public string Body { get; set; } = string.Empty;
    [JsonPropertyName("created_at")] public DateTimeOffset CreatedAt { get; set; }
    [JsonPropertyName("draft")] public bool Draft { get; set; }
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("prerelease")] public bool Prerelease { get; set; }
    [JsonPropertyName("published_at")] public DateTimeOffset PublishedAt { get; set; }
    [JsonPropertyName("tag_name")] public string TagName { get; set; } = string.Empty;
    [JsonPropertyName("tarball_url")] public string TarballUrl { get; set; } = string.Empty;
    [JsonPropertyName("target_commitish")] public string TargetCommitish { get; set; } = string.Empty;
    [JsonPropertyName("zipball_url")] public string ZipballUrl { get; set; } = string.Empty;
}
