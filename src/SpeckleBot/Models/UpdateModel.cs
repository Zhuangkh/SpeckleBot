namespace SpeckleBot.Models
{
    public class UpdateModel
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
