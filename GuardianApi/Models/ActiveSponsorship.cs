using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class ActiveSponsorship
    {
        public string SponsorshipType { get; set; }
        public string SponsorName { get; set; }
        public string SponsorLogo { get; set; }
        public string SponsorLink { get; set; }
        public Dictionary<float, float> SponsorLogoDimensions { get; set; } 
        public string HighContrastSponsorLogo { get; set; }
        public Dictionary<float, float> HighContrastSponsorLogoDimensions { get; set; }
        public string AboutLink { get; set; }
        public Target Targeting { get; set; }
    }
}