using System.Text.Json.Serialization;

namespace Noware.GitHub.Webhooks.Models.DataModels;

// ReSharper disable MissingLinebreak
public class GitHubRepository
{
    [JsonPropertyName("allow_forking")] public bool AllowForking { get; set; }
    [JsonPropertyName("archived")] public bool Archived { get; set; }
    [JsonPropertyName("clone_url")] public string CloneUrl { get; set; } = string.Empty;
    [JsonPropertyName("created_at")] public object? CreatedAt { get; set; } // *** Can be a long or a string :-\ ***
    [JsonPropertyName("default_branch")] public string DefaultBranch { get; set; } = string.Empty;
    [JsonPropertyName("description")] public string Description { get; set; } = string.Empty;
    [JsonPropertyName("disabled")] public bool Disabled { get; set; }
    [JsonPropertyName("fork")] public bool Fork { get; set; }
    [JsonPropertyName("forks")] public int Forks { get; set; }
    [JsonPropertyName("forks_count")] public int ForksCount { get; set; }
    [JsonPropertyName("full_name")] public string FullName { get; set; } = string.Empty;
    [JsonPropertyName("git_url")] public string GitUrl { get; set; } = string.Empty;
    [JsonPropertyName("has_discussions")] public bool HasDiscussions { get; set; }
    [JsonPropertyName("has_downloads")] public bool HasDownloads { get; set; }
    [JsonPropertyName("has_issues")] public bool HasIssues { get; set; }
    [JsonPropertyName("has_pages")] public bool HasPages { get; set; }
    [JsonPropertyName("has_projects")] public bool HasProjects { get; set; }
    [JsonPropertyName("has_wiki")] public bool HasWiki { get; set; }
    [JsonPropertyName("homepage")] public string Homepage { get; set; } = string.Empty;
    [JsonPropertyName("html_url")] public string HtmlUrl { get; set; } = string.Empty;
    [JsonPropertyName("id")] public long Id { get; set; }
    [JsonPropertyName("is_template")] public bool IsTemplate { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; } = string.Empty;
    [JsonPropertyName("open_issues")] public int OpenIssues { get; set; }
    [JsonPropertyName("open_issues_count")] public int OpenIssuesCount { get; set; }
    [JsonPropertyName("owner")] public GitHubUser? Owner { get; set; }
    [JsonPropertyName("private")] public bool Private { get; set; }
    [JsonPropertyName("pushed_at")] public object? PushedAt { get; set; } // *** Can be a long or a string :-\ ***
    [JsonPropertyName("ssh_url")] public string SshUrl { get; set; } = string.Empty;
    [JsonPropertyName("stargazers_count")] public int StargazersCount { get; set; }
    [JsonPropertyName("updated_at")] public DateTimeOffset? UpdatedAt { get; set; }
    [JsonPropertyName("visibility")] public string Visibility { get; set; } = string.Empty;
    [JsonPropertyName("watchers")] public int Watchers { get; set; }
    [JsonPropertyName("watchers_count")] public int WatchersCount { get; set; }
    [JsonPropertyName("web_commit_signoff_required")] public bool WebCommitSignoffRequired { get; set; }
}
