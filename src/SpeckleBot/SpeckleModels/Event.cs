using System.Text.Json.Serialization;

namespace SpeckleBot.SpeckleModels
{
    public class Event
    {
        [JsonPropertyName("event_name")]
        public string Name { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}
