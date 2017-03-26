namespace GuardianApi.Models.Requests
{
    /// <summary>
    /// An container for pagination search options
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// The page to be returned
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// The size of the page (between 1-50, inclusive)
        /// </summary>
        public int PageSize { get; set; }
        internal string PaginationString
        {
            get
            {
                return $"&page={Page}&page-size={PageSize}";
            }
        }
    }
}
