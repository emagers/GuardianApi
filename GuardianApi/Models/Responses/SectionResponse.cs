using System.Collections.Generic;

namespace GuardianApi.Models.Responses
{
    public class SectionResponse : BaseResponse
    {
        List<Section> Results { get; set; }
    }
}
