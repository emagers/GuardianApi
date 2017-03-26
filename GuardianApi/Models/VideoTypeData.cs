namespace GuardianApi.Models
{
    public class VideoTypeData
    {
        public string url { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string html { get; set; }
        public string source { get; set; }
        public string caption { get; set; }
        public float duration { get; set; }
        public bool isInappropriateForAdverts { get; set; }
        public string mediaId { get; set; }
        public string shortUrl { get; set; }
        public string originalUrl { get; set; }
        public string credit { get; set; }
        public float height { get; set; }
        public float width { get; set; }
        public string role { get; set; }
        public string contentAuthSystem { get; set; }
        public bool embeddable { get; set; }
    }
}