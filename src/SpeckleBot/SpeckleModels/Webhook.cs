using System.Text.Json.Serialization;

namespace SpeckleBot.SpeckleModels
{
    public class Webhook
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("streamId")]
        public string StreamId { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("triggers")]
        public List<string> Triggers { get; set; }

        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
