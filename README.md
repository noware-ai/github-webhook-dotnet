Collection of event data models to parse GitHub webhook payload.

Usage:

* Enable GitHub webhook to your .NET endpoint, use application/json format
* Capture request body, ie JSON payload
* Use generic `GitHubWebhookPayload` class for a generic data parse
* Use `GitHubWebhook.GetEventType()` to detect specific event types
* Use `.AsABCEventName()` for specific data parse

# Generic deserialization

```csharp
string json = "...request payload...";

GitHubWebhookPayload ghData = JsonSerializer.Deserialize<GitHubWebhookPayload>(json);
```

# Detecting the event type

```csharp
string eventName = req.Headers.TryGetValue("X-GitHub-Event", out var header) ? (string)header : string.Empty;
string json = "...request payload...";

// Using GitHubEvents Enum
GitHubEvents ghEventType = GitHubWebhook.GetEventType(json, eventName);
```

# Deserialize to event class

```csharp
string json = "...request payload...";
GitHubWebhookPayload data = JsonSerializer.Deserialize<GitHubWebhookPayload>(json);

string eventName = req.Headers.TryGetValue("X-GitHub-Event", out var header) ? (string)header : string.Empty;
GitHubEvents ghEventType = GitHubWebhook.GetEventType(json, eventName);

if (ghEventType == GitHubEvents.IssueOpened)
{
    // Extract relevant data from GitHubWebhookPayload
    IssueOpened ghEventData = data.AsIssueOpened();
}
```

# Note

The collection of data models does not cover 100% of scenarios. PRs with
additional classes and parsing are welcome.