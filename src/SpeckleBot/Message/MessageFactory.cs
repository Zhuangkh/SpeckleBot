using SpeckleBot.SpeckleModels;

namespace SpeckleBot.Message
{
    public class MessageFactory
    {
        public static Task<object> CreateAdaptiveCard(Payload payload)
        {
            switch (payload.Data.Event.Name)
            {
                case EventType.StreamUpdate:
                    return new StreamUpdateMessageCreator().CreateAdaptiveCard(payload);
                case EventType.BranchCreate:
                case EventType.BranchUpdate:
                case EventType.BranchDelete:
                    return new BranchMessageCreator().CreateAdaptiveCard(payload);
                default:
                    return null;
            }
        }
    }
}
