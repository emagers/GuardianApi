using Newtonsoft.Json;

namespace GuardianApi.Models
{
    public class AudioTypeData
    {
        public string html { get; set; }
        public string source { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public string caption { get; set; }
        public int durationMinutes { get; set; }
        public int durationSeconds { get; set; }
        [JsonProperty("explicit")]
        public bool explicitContent { get; set; }
    }
}