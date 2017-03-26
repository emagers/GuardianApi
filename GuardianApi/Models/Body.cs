using System;
using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Body
    {
        public string id { get; set; }
        public string bodyHtml { get; set; }
        public string bodyTextSummary { get; set; }
        public Attribute attributes { get; set; }
        public bool published { get; set; }
        public DateTime createdDate { get; set; }
        public DateTime lastModifiedDate { get; set; }
        public List<string> contributers { get; set; }
        public List<Element> elements { get; set; }
        public DateTime firstPublishedDate { get; set; }
        public DateTime publishedDate { get; set; }
        public string title { get; set; }
    }
}