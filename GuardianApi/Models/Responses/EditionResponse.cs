using System.Collections.Generic;

namespace GuardianApi.Models.Responses
{
    public class EditionResponse : BaseResponse
    {
        public List<Edition> results { get; set; }
    }
}

