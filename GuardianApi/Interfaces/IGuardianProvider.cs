using GuardianApi.Models.Requests;
using GuardianApi.Models.Responses;
using System.Threading.Tasks;

namespace GuardianApi.Interfaces
{
    public interface IGuardianProvider
    {
        Task<ContentSearchResponse> GetContent(string queryString, ContentFilter filters, Pagination pagination);
        Task<string> GetContent(string queryString, ContentFilter contentFilter, Pagination pagination, string format = "json");
        Task<ContentResponse> GetContent(string id, ContentFilter filters);
        Task<string> GetContent(string id, ContentFilter filters, string format = "json");
        Task<EditionResponse> GetEditions(string queryString);
        Task<string> GetEditions(string queryString, string format = "json");
        Task<TagResponse> GetTags(string queryString, TagFilter filters, Pagination pagination);
        Task<string> GetTags(string queryString, TagFilter filters, Pagination pagination, string format = "json");
        Task<SectionResponse> GetSections(string queryString);
        Task<string> GetSections(string queryString, string format = "json");
    }
}
