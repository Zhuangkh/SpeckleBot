using System.Dynamic;
using System.Text.Json.Serialization;

namespace SpeckleBot.SpeckleModels
{
    public class Event
    {
        [JsonPropertyName("event_name")]
        public EventType Name { get; set; }

        [JsonPropertyName("data")]
        public ExpandoObject Data { get; set; }
    }
}
