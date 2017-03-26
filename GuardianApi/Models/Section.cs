using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Section
    {
        public string id { get; set; }
        public string webTitle { get; set; }
        public string webUrl { get; set; }
        public string apiUrl { get; set; }
        public List<Edition> editions { get; set; }
    }
}
