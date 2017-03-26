using System;

namespace GuardianApi.Models
{
    public class WitnessTypeData
    {
        public string url { get; set; }
        public string originalUrl { get; set; }
        public string witnessEmbedType { get; set; }
        public string source { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string authorName { get; set; }
        public string authorUsername { get; set; }
        public string authorWitnessProfileUrl { get; set; }
        public string authorGuardianProfileUrl { get; set; }
        public string html { get; set; }
        public string apiUrl { get; set; }
        public DateTime dateCreated { get; set; }
        public string mediaId { get; set; }
        public string caption { get; set; }
        public string alt { get; set; }
        public string photographer { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public string youtubeUrl { get; set; }
        public string youtubeSource { get; set; }
        public string youtubeTitle { get; set; }
        public string youtubeDescription { get; set; }
        public string youtubeAuthorName { get; set; }
        public string youtubeHtml { get; set; }
    }
}