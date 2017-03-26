using Newtonsoft.Json;
using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Podcast
    {
        public string LinkUrl { get; set; }
        public string Copyright { get; set; }
        public string Author { get; set; }
        public string SubscriptionUrl { get; set; }
        public bool? Explicit { get; set; }
        public string Image { get; set; }
        public List<Category> Categories { get; set; }
    }
}