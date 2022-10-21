using SpeckleBot.SpeckleModels;
using System.Diagnostics;
using System.Text.Json;

namespace SpeckleBot.Helper
{
    public class MessageConvertor : System.Text.Json.Serialization.JsonConverter<Message>
    {
        public override Message Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<Message>(reader.GetString(),options);
        }

        public override void Write(Utf8JsonWriter writer, Message value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
