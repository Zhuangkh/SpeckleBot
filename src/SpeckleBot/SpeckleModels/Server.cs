using System.Text.Json.Serialization;

namespace SpeckleBot.SpeckleModels
{
    public class Server
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("company")]
        public string Company { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("adminContact")]
        public string AdminContact { get; set; }

        [JsonPropertyName("termsOfService")]
        public string TermsOfService { get; set; }

        [JsonPropertyName("canonicalUrl")]
        public string CanonicalUrl { get; set; }

        [JsonPropertyName("completed")]
        public bool Completed { get; set; }

        [JsonPropertyName("inviteOnly")]
        public bool InviteOnly { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}
