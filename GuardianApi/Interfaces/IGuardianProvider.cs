using GuardianApi.Models.Requests;
using GuardianApi.Models.Responses;
using System.Threading.Tasks;

namespace GuardianApi.Interfaces
{
    interface IGuardianProvider
    {
        Task<ContentSearchResponse> GetContent(string queryString, ContentFilter filters, Pagination pagination);
        Task<ContentResponse> GetContent(string id, ContentFilter filters);
        Task<EditionResponse> GetEditions(string queryString);
        Task<TagResponse> GetTags(string queryString, TagFilter filters, Pagination pagination);
        Task<SectionResponse> GetSections(string queryString);
    }
}
