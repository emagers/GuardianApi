namespace GuardianApi.Models.Responses
{
    public class BaseResponse
    {
        public string Status { get; set; }
        public string UserTier { get; set; }
        public int? Total { get; set; }
    }
}
