using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

// ReSharper disable MissingLinebreak
public class GitHubAlert
{
    [JsonPropertyName("affected_package_name")] public string AffectedPackageName { get; set; } = string.Empty;
    [JsonPropertyName("affected_range")] public string AffectedRange { get; set; } = string.Empty; // e.g. "< 3.3.9"
    [JsonPropertyName("auto_dismissed_at")] public DateTimeOffset? AutoDismissedAt { get; set; }
    [JsonPropertyName("created_at")] public DateTimeOffset? CreatedAt { get; set; }
    [JsonPropertyName("dependency")] public object? Dependency { get; set; } = string.Empty; // e.g. package details
    [JsonPropertyName("dismissed_at")] public DateTimeOffset? DismissedAt { get; set; }
    [JsonPropertyName("dismissed_by")] public object? DismissedBy { get; set; }
    [JsonPropertyName("dismissed_comment")] public object? DismissedComment { get; set; }
    [JsonPropertyName("dismissed_reason")] public object? DismissedReason { get; set; }
    [JsonPropertyName("external_identifier")] public string ExternalIdentifier { get; set; } = string.Empty; // e.g. "CVE-2020-12345"
    [JsonPropertyName("external_reference")] public string ExternalReference { get; set; } = string.Empty;
    [JsonPropertyName("fix_reason")] public string FixReason { get; set; } = string.Empty;
    [JsonPropertyName("fixed_at")] public DateTimeOffset? FixedAt { get; set; }
    [JsonPropertyName("fixed_in")] public string FixedIn { get; set; } = string.Empty; // e.g. "3.3.9"
    [JsonPropertyName("ghsa_id")] public string GhsaId { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty; // can be empty
    [JsonPropertyName("id")] public long? Id { get; set; } // can be null
    [JsonPropertyName("most_recent_instance")] public object? MostRecentInstance { get; set; }
    [JsonPropertyName("number")] public long Number { get; set; }
    [JsonPropertyName("rule")] public object? Rule { get; set; }
    [JsonPropertyName("security_advisory")] public object? SecurityAdvisory { get; set; }
    [JsonPropertyName("security_vulnerability")] public object? SecurityVulnerability { get; set; }
    [JsonPropertyName("severity")] public string Severity { get; set; } = string.Empty; // e.g. "moderate"
    [JsonPropertyName("state")] public string State { get; set; } = string.Empty; // e.g. "fixed"
    [JsonPropertyName("tool")] public object? Tool { get; set; }
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
}
