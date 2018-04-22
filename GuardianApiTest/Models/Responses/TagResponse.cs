using System.Collections.Generic;

namespace GuardianApi.Models.Responses
{
    public class TagResponse : PagedResponse
    {
        public List<Tag> Results { get; set; }
    }
}
