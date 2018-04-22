using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using GuardianApi.Models;
using GuardianApi.Models.Responses;
using GuardianApi.Models.Requests;
using Xunit;

namespace GuardianApiTest.Providers
{
    public class GuardianProviderTest
    {
        public GuardianProviderTest()
        {
        }

        #region GetContent(paged)
        [Fact]
        public async Task GetContent_WithFilterAndPaginationOptions_ProperlyBuildQueryString()
        {

        }

        [Fact]
        public async Task GetContent_WithoutFilterAndPaginationOptions_ProperlyBuildQueryString()
        {

        }

        [Fact]
        public async Task GetContent_ToObject_ProperlyBuildsResponse()
        {

        }

        [Fact]
        public async Task GetContent_ToJson_ProperlyReturnsJson()
        {

        }

        [Fact]
        public async Task GetContent_ToXml_ProperlyReturnsXml()
        {

        }
        #endregion

        #region GetContent(single)
        [Fact]
        public async Task GetSingleContent_WithFilterAndPaginationOptions_ProperlyBuildQueryString()
        {

        }

        [Fact]
        public async Task GetSingleContent_WithoutFilterAndPaginationOptions_ProperlyBuildQueryString()
        {                    
                             
        }                    
                             
        [Fact]               
        public async Task GetSingleContent_ToObject_ProperlyBuildsResponse()
        {                    
                             
        }                    
                             
        [Fact]               
        public async Task GetSingleContent_ToJson_ProperlyReturnsJson()
        {                    
                             
        }                    
                             
        [Fact]               
        public async Task GetSingleContent_ToXml_ProperlyReturnsXml()
        {

        }
        #endregion
        
        #region GetEditions
        [Fact]
        public async Task GetEditions_ProperlyBuildsQueryString()
        {

        }

        [Fact]
        public async Task GetEditions__ToObject_ProperlyBuildsResponseObject()
        {

        }

        [Fact]
        public async Task GetEditions_ToJson_ProperlyReturnsJson()
        {

        }

        [Fact]
        public async Task GetEditions_ToXml_ProperlyReturnsXml()
        {

        }
        #endregion

        #region GetTags
        [Fact]
        public async Task GetTags_WithFilterAndPagination_ProperyBuildsQueryString()
        {

        }

        [Fact]
        public async Task GetTags_WithoutFilterAndPagination_ProperyBuildsQueryString()
        {

        }

        [Fact]
        public async Task GetTags_ToObject_ProperlyBuildsResponse()
        {

        }

        [Fact]
        public async Task GetTags_ToJson_ProperlyReturnsJson()
        {

        }

        [Fact]
        public async Task GetTags_ToXml_ProperlyReturnsXml()
        {

        }
        #endregion

        #region GetSections
        [Fact]
        public async Task GetSections_ProperlyBuildsQueryString()
        {

        }

        [Fact]
        public async Task GetSections_ToObject_ProperlyBuildsResponse()
        {                 
                          
        }                 
                          
        [Fact]            
        public async Task GetSections_ToJson_ProperlyReturnsJson()
        {                 
                          
        }                 
                          
        [Fact]            
        public async Task GetSections_ToXml_ProperlyReturnsXml()
        {

        }
        #endregion
    }
}
