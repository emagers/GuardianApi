using System.Collections.Generic;

namespace GuardianApi.Models.Responses
{
    public class ContentSearchResponse : PagedResponse
    {
        public List<Content> Results { get; set; }
        public Content Content { get; set; }
    }
}
