namespace GuardianApi.Models.Responses
{
    public class PagedResponse : BaseResponse
    {
        public int startIndex { get; set; }
        public int pageSize { get; set; }
        public int currentPage { get; set; }
        public int pages { get; set; }
    }
}
