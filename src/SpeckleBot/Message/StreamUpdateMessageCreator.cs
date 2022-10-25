﻿using AdaptiveCards.Templating;
using Newtonsoft.Json;
using SpeckleBot.Helper;
using SpeckleBot.Models;
using SpeckleBot.SpeckleModels;

namespace SpeckleBot.Message
{
    public class UpdateMessageCreator : IMessageCreator
    {
        private readonly string _adaptiveCardFilePath = Path.Combine(".", "Resources", "update.json");
        public async Task<object> CreateAdaptiveCard(Payload payload)
        {
            var cardTemplate = await System.IO.File.ReadAllTextAsync(_adaptiveCardFilePath); 
            var title = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(payload.Data.Event.Name.GetEnumMemberValue().Replace("_", " "));
            var detailsUrl = $"{payload.Data.Server.CanonicalUrl}/streams/{payload.Data.StreamId}/settings";
            var eventData = payload.Data.Event.Data.ToDictionary(x => x.Key, x => ((System.Text.Json.JsonElement)x.Value).EnumerateObject().ToDictionary(d => d.Name, d => d.Value.ToString()));
            var cardContent = new AdaptiveCardTemplate(cardTemplate).Expand
                (
                    new UpdateModel
                    {
                        Title = title,
                        AvatarUrl = payload.Data.User.Avatar,
                        UserName = payload.Data.User.Name,
                        Description = payload.Data.ActivityMessage,
                        Old = eventData["old"].ToList(),
                        New = eventData["new"].ToList(),
                        DetailsUrl = detailsUrl,
                    }
                );
            return JsonConvert.DeserializeObject(cardContent);
        }
    }
}
