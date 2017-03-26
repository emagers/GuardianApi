using System;

namespace GuardianApi.Models
{
    public class WitnessTypeData
    {
        public string Url { get; set; }
        public string OriginalUrl { get; set; }
        public string WitnessEmbedType { get; set; }
        public string Source { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AuthorName { get; set; }
        public string AuthorUsername { get; set; }
        public string AuthorWitnessProfileUrl { get; set; }
        public string AuthorGuardianProfileUrl { get; set; }
        public string Html { get; set; }
        public string ApiUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public string MediaId { get; set; }
        public string Caption { get; set; }
        public string Alt { get; set; }
        public string Photographer { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public string YoutubeUrl { get; set; }
        public string YoutubeSource { get; set; }
        public string YoutubeTitle { get; set; }
        public string YoutubeDescription { get; set; }
        public string YoutubeAuthorName { get; set; }
        public string YoutubeHtml { get; set; }
    }
}