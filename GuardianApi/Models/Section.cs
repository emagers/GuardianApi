using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Section
    {
        public string Id { get; set; }
        public string WebTitle { get; set; }
        public string WebUrl { get; set; }
        public string ApiUrl { get; set; }
        public List<Edition> Editions { get; set; }
    }
}
