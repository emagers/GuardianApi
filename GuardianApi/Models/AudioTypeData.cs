using Newtonsoft.Json;

namespace GuardianApi.Models
{
    public class AudioTypeData
    {
        public string Html { get; set; }
        public string Source { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public int? DurationMinutes { get; set; }
        public int? DurationSeconds { get; set; }
        public bool? Explicit { get; set; }
    }
}