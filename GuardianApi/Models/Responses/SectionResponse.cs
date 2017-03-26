using System.Collections.Generic;

namespace GuardianApi.Models.Responses
{
    public class SectionResponse : BaseResponse
    {
        List<Section> results { get; set; }
    }
}
