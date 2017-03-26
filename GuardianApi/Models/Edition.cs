using Newtonsoft.Json;

namespace GuardianApi.Models
{
    public class Edition
    {
        public string Id { get; set; }
        public string WebTitle { get; set; }
        public string WebUrl { get; set; }
        public string ApiUrl { get; set; }
        public string Path { get; set; }
        [JsonProperty("edition")]
        public string Type { get; set; }
        public string Code { get; set; }
    }
}
