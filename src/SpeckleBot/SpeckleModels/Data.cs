using System.Text.Json.Serialization;

namespace SpeckleBot.SpeckleModels
{
    public class Data
    {
        [JsonPropertyName("branch")]
        public Branch Branch { get; set; }
    }
}
