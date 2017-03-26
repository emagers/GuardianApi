using System;

namespace GuardianApi.Models
{
    public class MembershipTypeData
    {
        public string originalUrl { get; set; }
        public string linkText { get; set; }
        public string linkPrefix { get; set; }
        public string title { get; set; }
        public string venue { get; set; }
        public string location { get; set; }
        public string identifier { get; set; }
        public string image { get; set; }
        public string price { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
    }
}