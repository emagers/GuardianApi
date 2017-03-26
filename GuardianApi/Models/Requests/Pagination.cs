namespace GuardianApi.Models.Requests
{
    /// <summary>
    /// An container for pagination search options
    /// </summary>
    /// <fields>
    ///     <Page>The page to be returned</Page>
    ///     <PageSize>The size of the page (between 1-50, inclusive)</PageSize>
    ///     <PaginationString>The query string representation of the options</PaginationString>
    /// </fields>
    public class Pagination
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string PaginationString
        {
            get
            {
                return $"&page={Page}&page-size={PageSize}";
            }
        }
    }
}
