using System.Text.Json.Serialization;

namespace SpeckleBot.SpeckleModels
{
    public class Stream
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("isPublic")]
        public bool IsPublic { get; set; }

        [JsonPropertyName("clonedFrom")]
        public string ClonedFrom { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("allowPublicComments")]
        public bool AllowPublicComments { get; set; }

        [JsonPropertyName("isDiscoverable")]
        public bool IsDiscoverable { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}
