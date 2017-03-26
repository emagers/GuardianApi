using Newtonsoft.Json;
using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Podcast
    {
        public string linkUrl { get; set; }
        public string copyright { get; set; }
        public string author { get; set; }
        public string subscriptionUrl { get; set; }
        [JsonProperty("explicit")]
        public bool explicitContent { get; set; }
        public string image { get; set; }
        public List<Category> categories { get; set; }
    }
}