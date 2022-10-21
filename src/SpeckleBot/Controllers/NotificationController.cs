using SpeckleBot.Models;
using AdaptiveCards.Templating;
using Microsoft.AspNetCore.Mvc;
using Microsoft.TeamsFx.Conversation;
using Newtonsoft.Json;
using System.Dynamic;
using SpeckleBot.SpeckleModels;

namespace SpeckleBot.Controllers
{
    [Route("api/notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ConversationBot _conversation;
        private readonly string _adaptiveCardFilePath = Path.Combine(".", "Resources", "Notification.json");

        public NotificationController(ConversationBot conversation)
        {
            this._conversation = conversation;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody]Payload payload, CancellationToken cancellationToken = default)
        {
            var cardTemplate = await System.IO.File.ReadAllTextAsync(_adaptiveCardFilePath, cancellationToken);
            var installations = await this._conversation.Notification.GetInstallationsAsync(cancellationToken);

            var title = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(payload.Data.Event.Name.Replace("_", " "));
            var detailsUrl = $"{payload.Data.Server.CanonicalUrl}/streams/{payload.Data.StreamId}";
            var cardContent = new AdaptiveCardTemplate(cardTemplate).Expand
                (
                    new NotificationModel
                    {
                        Title = title,
                        AvatarUrl = payload.Data.User.Avatar,
                        UserName = payload.Data.User.Name,
                        Description = payload.Data.ActivityMessage,
                        StreamName = payload.Data.Stream.Name,
                        ServerName = payload.Data.Server.Name,
                        DetailsUrl = detailsUrl,
                    }
                );

            foreach (var installation in installations)
            {
                await installation.SendAdaptiveCard(JsonConvert.DeserializeObject(cardContent), cancellationToken);
            }

            return Ok();
        }
    }
}
