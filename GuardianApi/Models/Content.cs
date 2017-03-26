using System;
using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Content
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string SectionId { get; set; }
        public string SectionName { get; set; }
        public DateTime WebPublicationDate { get; set; }
        public string WebTitle { get; set; }
        public string WebUrl { get; set; }
        public string ApiUrl { get; set; }
        public List<Tag> Tags { get; set; }
        public List<Reference> References { get; set; }
        public Block Blocks { get; set; }
        public Right Rights { get; set; }
        public bool? IsHosted { get; set; }
        public Section Section { get; set; }
    }
}
