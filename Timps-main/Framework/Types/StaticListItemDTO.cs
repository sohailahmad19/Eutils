using System.Text.Json.Serialization;

namespace TekTrackingCore.Framework.Types
{
    public class StaticListItemDTO
    {
        [JsonPropertyName("_id")]
        public string Id;

        [JsonPropertyName("tenantId")]
        public string TenantId;

        [JsonPropertyName("listName")]
        public string ListName;

        [JsonPropertyName("code")]
        public string Code;

        [JsonPropertyName("description")]
        public string Description;

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt;

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt;

        [JsonPropertyName("__v")]
        public int V;

        [JsonPropertyName("opt1")]
        public object Opt1;

        [JsonPropertyName("opt2")]
        public object Opt2;
    }

    public class MessageListResponseDTO
    {
        [JsonPropertyName("ts")]
        public string Ts { get; set; }

        [JsonPropertyName("result")]
        public List<List<StaticListItemDTO1>> Result { get; set; }
    }
    public class StaticListItemDTO1
    {
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }

        [JsonPropertyName("listName")]
        public string ListName { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("optParam1")]
        public string OptParam1 { get; set; }

        [JsonPropertyName("optParam2")]
        public string OptParam2 { get; set; }
    }
}
