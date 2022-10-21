using SpeckleBot.Helper;
using System.Text.Json.Serialization;

namespace SpeckleBot.SpeckleModels
{
    public class Payload
    {
        [JsonPropertyName("payload"), JsonConverter(typeof(MessageConvertor))]
        public Message Data { get; set; }
    }
}
