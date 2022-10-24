using SpeckleBot.SpeckleModels;

namespace SpeckleBot.Message
{
    public interface IMessageCreator
    {
        public Task<object> CreateAdaptiveCard(Payload payload);
    }
}
