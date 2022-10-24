using SpeckleBot.SpeckleModels;
using System.Text.Json;

namespace SpeckleBot.Helper
{
    public class MessageConvertor : System.Text.Json.Serialization.JsonConverter<SpeckleModels.Message>
    {
        public override SpeckleModels.Message Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<SpeckleModels.Message>(reader.GetString(),options);
        }

        public override void Write(Utf8JsonWriter writer, SpeckleModels.Message value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
