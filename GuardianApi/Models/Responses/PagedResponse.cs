namespace GuardianApi.Models.Responses
{
    public class PagedResponse : BaseResponse
    {
        public int? StartIndex { get; set; }
        public int? PageSize { get; set; }
        public int? CurrentPage { get; set; }
        public int? Pages { get; set; }
    }
}
