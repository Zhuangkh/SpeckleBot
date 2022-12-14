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
                case EventType.BranchUpdate:
                    return new UpdateMessageCreator().CreateAdaptiveCard(payload);
                case EventType.StreamDelete:
                    return new StreamDeleteMessageCreator().CreateAdaptiveCard(payload);
                case EventType.BranchCreate:
                case EventType.BranchDelete:
                    return new BranchMessageCreator().CreateAdaptiveCard(payload);
                case EventType.StreamPermissionsRemove:
                case EventType.StreamPermissionsAdd:
                    return new StreamPermissionsMessageCreator().CreateAdaptiveCard(payload);
                default:
                    return null;
            }
        }
    }
}
