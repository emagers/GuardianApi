using System;
using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Body
    {
        public string Id { get; set; }
        public string BodyHtml { get; set; }
        public string BodyTextSummary { get; set; }
        public Attribute Attributes { get; set; }
        public bool? Published { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public List<string> Contributers { get; set; }
        public List<Element> Elements { get; set; }
        public DateTime FirstPublishedDate { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Title { get; set; }
    }
}