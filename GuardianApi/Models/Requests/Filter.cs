using System.Collections.Generic;

namespace GuardianApi.Models.Requests
{
    public class Filter
    {
        /// <summary>
        /// Return only content in those sections (allows boolean operators)
        /// </summary>
        public string Section { get; set; }
        /// <summary>
        /// Return only content with those references (allows boolean operators)
        /// </summary>
        public string Reference { get; set; }
        /// <summary>
        /// Return only content with references of those types (allows boolean operators)
        /// </summary>
        public string ReferenceType { get; set; }
        /// <summary>
        /// Return only content with those tags (allows boolean operators)
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// Return only content with those rights
        /// </summary>
        public List<RightOptions> Rights { get; set; }
        /// <summary>
        /// Return only content with those IDs
        /// </summary>
        public string Ids { get; set; }
        /// <summary>
        /// Return only content from those production offices (allows boolean operators)
        /// </summary>
        public string ProductionOffice { get; set; }
        /// <summary>
        /// Return only content in those languages (allows boolean operators)
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// Return only content with a given star rating
        /// </summary>
        public int? StarRating { get; set; }
        internal string FilterString
        {
            get
            {
                List<string> rights = new List<string>();
                foreach (var right in Rights)
                {
                    rights.Add(Constants.RightStrings[right]);
                }

                return $"{(string.IsNullOrEmpty(Section) ? "" : $"&section={Section}")}" +
                       $"{(string.IsNullOrEmpty(Reference) ? "" : $"&reference={Reference}")}" +
                       $"{(string.IsNullOrEmpty(ReferenceType) ? "" : $"&reference-type={ReferenceType}")}" +
                       $"{(string.IsNullOrEmpty(Tag) ? "" : $"&tag={Tag}")}" +
                       $"{(rights.Count > 0 ? "&rights=" + string.Join("|", rights) : "")}" +
                       $"{(string.IsNullOrEmpty(Ids) ? "" : $"&ids={Ids}")}" +
                       $"{(string.IsNullOrEmpty(ProductionOffice) ? "" : $"&production-office={ProductionOffice}")}" +
                       $"{(string.IsNullOrEmpty(Language) ? "" : $"&lang={Language}")}" +
                       $"{(StarRating != null ? $"&star-rating={StarRating.Value}" : "")}";
            }
        }
    }
}
