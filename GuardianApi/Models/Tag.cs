using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Tag
    {
        public string id { get; set; }
        public string type { get; set; }
        public string webTitle { get; set; }
        public string webUrl { get; set; }
        public string apiUrl { get; set; }
        public List<Reference> references { get; set; }
        public string sectionId { get; set; }
        public string sectionName { get; set; }
        public string bio { get; set; }
        public string bylineImageUrl { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string description { get; set; }
        public string byLineLargeImageUrl { get; set; }
        public string twitterHandle { get; set; }
        public List<ActiveSponsorship> activeSponsorships { get; set; }
        public string paidContentType { get; set; }
        public string emailAddress { get; set; }
        public Podcast podcast { get; set; }
    }
}
