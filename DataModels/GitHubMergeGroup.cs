using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

public class GitHubMergeGroup
{
    [JsonPropertyName("base_ref")] public string BaseRef { get; set; } = string.Empty;
    [JsonPropertyName("base_sha")] public string BaseSHA { get; set; } = string.Empty;
    [JsonPropertyName("head_commit")] public GitHubCommit? HeadCommit { get; set; }
    [JsonPropertyName("head_ref")] public string HeadRef { get; set; } = string.Empty;
    [JsonPropertyName("head_sha")] public string HeadSHA { get; set; } = string.Empty;
}
