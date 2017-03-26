namespace GuardianApi.Models
{
    public class VideoTypeData
    {
        public string Url { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Html { get; set; }
        public string Source { get; set; }
        public string Caption { get; set; }
        public float? Duration { get; set; }
        public bool? IsInappropriateForAdverts { get; set; }
        public string MediaId { get; set; }
        public string ShortUrl { get; set; }
        public string OriginalUrl { get; set; }
        public string Credit { get; set; }
        public float? Height { get; set; }
        public float? Width { get; set; }
        public string Role { get; set; }
        public string ContentAuthSystem { get; set; }
        public bool? Embeddable { get; set; }
    }
}