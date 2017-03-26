using System;

namespace GuardianApi.Models
{
    public class MembershipTypeData
    {
        public string OriginalUrl { get; set; }
        public string LinkText { get; set; }
        public string LinkPrefix { get; set; }
        public string Title { get; set; }
        public string Venue { get; set; }
        public string Location { get; set; }
        public string Identifier { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}