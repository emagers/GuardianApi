using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using GuardianApi.Models;
using GuardianApi.Models.Responses;
using GuardianApi.Models.Requests;
using GuardianApi.Interfaces;

namespace GuardianApi.Providers
{
    public class GuardianProvider : IGuardianProvider
    {
        private readonly HttpClient _client;
        private GuardianOptions _options;
        
        /// <summary>
        /// Creates a new GuardianProvider object. 
        /// </summary>
        /// <param name="options">The configuration object for the Guardian API.</param>
        public GuardianProvider(GuardianOptions options)
        {
            _options = options;
            _client = new HttpClient();
        }

        /// <summary>
        /// Returns a list of content matching the specified parameters.
        /// </summary>
        /// <param name="queryString">The string to query on.</param>
        /// <param name="contentFilter">Filter options for the content.</param>
        /// <param name="pagination">Options to page the results by.</param>
        /// <returns>A ContentSearchResponse object which contains a list of filtered content.</returns>
        public async Task<ContentSearchResponse> GetContent(string queryString, ContentFilter contentFilter, Pagination pagination)
        {
            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Search]}?api-key={_options.ApiKey}&q={queryString}{(contentFilter == null ? string.Empty : contentFilter.ContentFilterString)}{(pagination == null ? string.Empty : pagination.PaginationString)}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<ContentSearchResponse>();
        }

        /// <summary>
        /// Returns a list of content matching the specified parameters.
        /// </summary>
        /// <param name="queryString">The string to query on.</param>
        /// <param name="contentFilter">Filter options for the content.</param>
        /// <param name="pagination">Options to page the results by.</param>
        /// <param name="format">The format the results will be returned in (json or xml). Will default to json if none specified.</param>
        /// <returns>A string in the format specified which contains a list of filtered content.</returns>
        public async Task<string> GetContent(string queryString, ContentFilter contentFilter, Pagination pagination, string format = "json")
        {
            format = format.ToLower();
            if (format != "json" || format != "xml")
                throw new ArgumentException("Invalid response format. Only 'json' or 'xml' accepted.");

            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Search]}?api-key={_options.ApiKey}&q={queryString}{(contentFilter == null ? string.Empty : contentFilter.ContentFilterString)}{(pagination == null ? string.Empty : pagination.PaginationString)}&format={format}";
            return await GetResponse(url);
        }

        /// <summary>
        /// Returns content specified by the given ID.
        /// </summary>
        /// <param name="id">The ID of the content to be returned.</param>
        /// <param name="contentFilter">Filter options for the content.</param>
        /// <returns>A ContentResponse object which contains the requested content.</returns>
        public async Task<ContentResponse> GetContent(string id, ContentFilter contentFilter)
        {
            string url = $"{Constants.API}/{id}?api-key={_options.ApiKey}{(contentFilter == null ? string.Empty : contentFilter.ContentFilterString)}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<ContentResponse>();
        }

        /// <summary>
        /// Returns content specified by the given ID.
        /// </summary>
        /// <param name="id">The ID of the content to be returned.</param>
        /// <param name="contentFilter">Filter options for the content.</param>
        /// <param name="format">The format the results will be returned in (json or xml). Will default to json if none specified.</param>
        /// <returns>A string in the format specified which contains the requested content.</returns>
        public async Task<string> GetContent(string id, ContentFilter contentFilter, string format = "json")
        {
            format = format.ToLower();
            if (format != "json" || format != "xml")
                throw new ArgumentException("Invalid response format. Only 'json' or 'xml' accepted.");

            string url = $"{Constants.API}/{id}?api-key={_options.ApiKey}{(contentFilter == null ? string.Empty : contentFilter.ContentFilterString)}&format={format}";
            return await GetResponse(url);
        }

        /// <summary>
        /// Gets all editions matching the query string.
        /// </summary>
        /// <param name="queryString">The string to query on.</param>
        /// <returns>An EditionResponse object which contains all matching editions.</returns>
        public async Task<EditionResponse> GetEditions(string queryString)
        {
            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Edition]}?api-key={_options.ApiKey}&q={queryString}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<EditionResponse>();
        }

        /// <summary>
        /// Gets all editions matching the query string.
        /// </summary>
        /// <param name="queryString">The string to query on.</param>
        /// <param name="format">The format the results will be returned in (json or xml). Will default to json if none specified.</param>
        /// <returns>A string in the specified format which contains all matching editions.</returns>
        public async Task<string> GetEditions(string queryString, string format = "json")
        {
            format = format.ToLower();
            if (format != "json" || format != "xml")
                throw new ArgumentException("Invalid response format. Only 'json' or 'xml' accepted.");

            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Edition]}?api-key={_options.ApiKey}&q={queryString}&format={format}";
            return await GetResponse(url);
        }

        /// <summary>
        /// Gets all sections matching the query string.
        /// </summary>
        /// <param name="queryString">The string to query on.</param>
        /// <returns>Returns a SectionResponse object which contains a list of matching sections.</returns>
        public async Task<SectionResponse> GetSections(string queryString)
        {
            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Section]}?api-key={_options.ApiKey}&q={queryString}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<SectionResponse>();
        }

        /// <summary>
        /// Gets all sections matching the query string.
        /// </summary>
        /// <param name="queryString">The string to query on.</param>
        /// <param name="format">The format the results will be returned in (json or xml). Will default to json if none specified.</param>
        /// <returns>A string in the specified format which contains all matching sections.</returns>
        public async Task<string> GetSections(string queryString, string format = "json")
        {
            format = format.ToLower();
            if (format != "json" || format != "xml")
                throw new ArgumentException("Invalid response format. Only 'json' or 'xml' accepted.");

            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Section]}?api-key={_options.ApiKey}&q={queryString}&format={format}";
            return await GetResponse(url);
        }

        /// <summary>
        /// Gets all tags matching the query string and filter parameters.
        /// </summary>
        /// <param name="queryString">The string to query on.</param>
        /// <param name="filter">Options to filter the results by.</param>
        /// <param name="pagination">Options to page the results by.</param>
        /// <returns>A TagResponse object containing a list of all matching tags.</returns>
        public async Task<TagResponse> GetTags(string queryString, TagFilter filter, Pagination pagination)
        {
            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Tag]}?api-key={_options.ApiKey}&q={queryString}{(filter == null ? string.Empty : filter.FilterString)}{(pagination == null ? string.Empty : pagination.PaginationString)}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<TagResponse>();
        }

        /// <summary>
        /// Gets all tags matching the query string and filter parameters.
        /// </summary>
        /// <param name="queryString">The string to query on.</param>
        /// <param name="filter">Options to filter the results by.</param>
        /// <param name="pagination">Options to page the results by.</param>
        /// <param name="format">The format the results will be returned in (json or xml). Will default to json if none specified.</param>
        /// <returns>A response string in the format specified which contains all matching tags.</returns>
        public async Task<string> GetTags(string queryString, TagFilter filter, Pagination pagination, string format = "json")
        {
            format = format.ToLower();
            if (format != "json" || format != "xml")
                throw new ArgumentException("Invalid response format. Only 'json' or 'xml' accepted.");

            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Tag]}?api-key={_options.ApiKey}&q={queryString}{(filter == null ? string.Empty : filter.FilterString)}{(pagination == null ? string.Empty : pagination.PaginationString)}&format={format}";
            return await GetResponse(url);
        }

        private async Task<string> GetResponse(string url)
        {
            string responseContent = string.Empty;

            using (HttpResponseMessage response = await _client.GetAsync(url))
            {
                response.EnsureSuccessStatusCode();
                responseContent = await response.Content.ReadAsStringAsync();
            }

            return responseContent;
        }
    }
}
