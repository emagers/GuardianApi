using System.Collections.Generic;

namespace GuardianApi.Models.Responses
{
    public class ContentSearchResponse : PagedResponse
    {
        public List<Content> results { get; set; }
        public Content content { get; set; }
    }
}
