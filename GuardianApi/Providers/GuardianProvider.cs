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
        private HttpClient _client;
        private GuardianOptions _options;
        public GuardianProvider(HttpClient client, GuardianOptions options)
        {
            _options = options;
            _client = client;
        }

        public async Task<ContentSearchResponse> GetContent(string queryString, ContentFilter contentFilter, Pagination pagination)
        {
            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Search]}?api-key={_options.ApiKey}&q={queryString}{(contentFilter == null ? string.Empty : contentFilter.ContentFilterString)}{(pagination == null ? string.Empty : pagination.PaginationString)}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<ContentSearchResponse>();
        }

        public async Task<ContentResponse> GetContent(string id, ContentFilter contentFilter)
        {
            string url = $"{Constants.API}/{id}?api-key={_options.ApiKey}{(contentFilter == null ? string.Empty : contentFilter.ContentFilterString)}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<ContentResponse>();
        }

        public async Task<EditionResponse> GetEditions(string queryString)
        {
            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Edition]}?api-key={_options.ApiKey}&q={queryString}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<EditionResponse>();
        }

        public async Task<SectionResponse> GetSections(string queryString)
        {
            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Section]}?api-key={_options.ApiKey}&q={queryString}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<SectionResponse>();
        }

        public async Task<TagResponse> GetTags(string queryString, TagFilter filter, Pagination pagination)
        {
            string url = $"{Constants.API}/{Constants.QueryStrings[QueryType.Tag]}?api-key={_options.ApiKey}&q={queryString}{(filter == null ? string.Empty : filter.FilterString)}{(pagination == null ? string.Empty : pagination.PaginationString)}";
            string response = await GetResponse(url);

            return JObject.Parse(response).ToObject<TagResponse>();
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
