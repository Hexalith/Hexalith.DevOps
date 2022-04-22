namespace Hexalith.DevOps.ApiService;

using System.Text.Json.Serialization;

public class DevOpsWorkItemChangeEvent
{
    [JsonPropertyName("wi_id")]
    public int WorkItemId { get; set; }
}