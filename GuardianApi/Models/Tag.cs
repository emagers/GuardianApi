using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Tag
    {
        public string id { get; set; }
        public string Type { get; set; }
        public string WebTitle { get; set; }
        public string WebUrl { get; set; }
        public string ApiUrl { get; set; }
        public List<Reference> References { get; set; }
        public string SectionId { get; set; }
        public string SectionName { get; set; }
        public string Bio { get; set; }
        public string BylineImageUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ByLineLargeImageUrl { get; set; }
        public string TwitterHandle { get; set; }
        public List<ActiveSponsorship> ActiveSponsorships { get; set; }
        public string PaidContentType { get; set; }
        public string EmailAddress { get; set; }
        public Podcast Podcast { get; set; }
    }
}
