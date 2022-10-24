﻿using AdaptiveCards.Templating;
using Newtonsoft.Json;
using SpeckleBot.Helper;
using SpeckleBot.Models;
using SpeckleBot.SpeckleModels;

namespace SpeckleBot.Message
{
    public class BranchMessageCreator : IMessageCreator
    {
        private readonly string _adaptiveCardFilePath = Path.Combine(".", "Resources", "branch.json");
        public async Task<object> CreateAdaptiveCard(Payload payload)
        {
            var cardTemplate = await System.IO.File.ReadAllTextAsync(_adaptiveCardFilePath);
            var title = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(payload.Data.Event.Name.GetEnumMemberValue().Replace("_", " "));
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
            return JsonConvert.DeserializeObject(cardContent);
        }
    }
}
