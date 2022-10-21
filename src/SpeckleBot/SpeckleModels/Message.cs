using System.Text.Json.Serialization;

namespace SpeckleBot.SpeckleModels
{
    public class Message
    {
        [JsonPropertyName("streamId")]
        public string StreamId { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("activityMessage")]
        public string ActivityMessage { get; set; }

        [JsonPropertyName("event")]
        public Event Event { get; set; }

        [JsonPropertyName("server")]
        public Server Server { get; set; }

        [JsonPropertyName("stream")]
        public Stream Stream { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("webhook")]
        public Webhook Webhook { get; set; }
    }
}
