using System;
using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Content
    {
        public string id { get; set; }
        public string type { get; set; }
        public string sectionId { get; set; }
        public string sectionName { get; set; }
        public DateTime webPublicationDate { get; set; }
        public string webTitle { get; set; }
        public string webUrl { get; set; }
        public string apiUrl { get; set; }
        public List<Tag> tags { get; set; }
        public List<Reference> references { get; set; }
        public Block blocks { get; set; }
        public Right rights { get; set; }
        public bool isHosted { get; set; }
        public Section section { get; set; }
    }
}
