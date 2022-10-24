namespace SpeckleBot.Models
{
    public class NotificationModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string AvatarUrl { get; set; }
        public string UserName { get; set; }
        public string ServerName { get; set; }
        public string StreamName { get; set; }
        public string DetailsUrl { get; set; }
    }
    public class StreamUpdateModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string AvatarUrl { get; set; }
        public string UserName { get; set; }
        public List<KeyValuePair<string, string>> Old { get; set; }
        public List<KeyValuePair<string, string>> New { get; set; }
        public string DetailsUrl { get; set; }
    }
}
