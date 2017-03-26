using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class ActiveSponsorship
    {
        public string sponsorshipType { get; set; }
        public string sponsorName { get; set; }
        public string sponsorLogo { get; set; }
        public string sponsorLink { get; set; }
        public Dictionary<float, float> sponsorLogoDimensions { get; set; } 
        public string highContrastSponsorLogo { get; set; }
        public Dictionary<float, float> highContrastSponsorLogoDimensions { get; set; }
        public string aboutLink { get; set; }
        public Target targeting { get; set; }
    }
}