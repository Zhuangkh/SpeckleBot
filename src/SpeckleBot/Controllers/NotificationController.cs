using SpeckleBot.Models;
using AdaptiveCards.Templating;
using Microsoft.AspNetCore.Mvc;
using Microsoft.TeamsFx.Conversation;
using Newtonsoft.Json;
using System.Dynamic;
using SpeckleBot.SpeckleModels;
using SpeckleBot.Message;

namespace SpeckleBot.Controllers
{
    [Route("api/notification")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly ConversationBot _conversation;

        public NotificationController(ConversationBot conversation)
        {
            this._conversation = conversation;
        }

        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody]Payload payload, CancellationToken cancellationToken = default)
        {
            var installations = await this._conversation.Notification.GetInstallationsAsync(cancellationToken);
            var card =await MessageFactory.CreateAdaptiveCard(payload);

            foreach (var installation in installations)
            {
                await installation.SendAdaptiveCard(card, cancellationToken);
            }

            return Ok();
        }
    }
}
