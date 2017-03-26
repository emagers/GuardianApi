namespace GuardianApi.Models.Responses
{
    public class BaseResponse
    {
        public string status { get; set; }
        public string userTier { get; set; }
        public int total { get; set; }
    }
}
