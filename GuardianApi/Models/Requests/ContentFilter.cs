using System;
using System.Collections.Generic;

namespace GuardianApi.Models.Requests
{
    /// <summary>
    /// A container for filter and additional information
    /// </summary>
    public class ContentFilter
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
        /// <summary>
        /// A container for various filter options
        /// </summary>
        public Filter Filters { get; set; }
        /// <summary>
        /// Return only content published on or after that date
        /// </summary>
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Return only content published on or before that date
        /// </summary>
        public DateTime ToDate { get; set; }
        /// <summary>
        /// Changes which type of date is used to filter the results using from-date and to-date
        /// </summary>
        public UseDateOptions? UseDate { get; set; }
        /// <summary>
        /// Returns results in the specified order
        /// </summary>
        public OrderByOptions? OrderBy { get; set; }
        /// <summary>
        /// Changes which type of date is used to order the results
        /// </summary>
        public OrderDateOptions? OrderDate { get; set; }
        /// <summary>
        /// Add fields associated with the content
        /// </summary>
        public List<FieldOptions> ShowFields { get; set; }
        /// <summary>
        /// Add associated metadata tags
        /// </summary>
        public List<TagOptions> ShowTags { get; set; }
        /// <summary>
        /// Add associated metadata section
        /// </summary>
        public bool? ShowSection { get; set; }
        /// <summary>
        /// Add associated blocks (single block for content, one or more for liveblogs)
        /// </summary>
        public ShowBlockOptions ShowBlocks { get; set; }
        /// <summary>
        /// Add associated media elements such as images and audio
        /// </summary>
        public List<ShowElementOptions> ShowElements { get; set; }
        /// <summary>
        /// Add associated reference data such as ISBNs
        /// </summary>
        public List<ReferenceInformationOptions> ReferenceInformation { get; set; }
        /// <summary>
        /// Add associated rights
        /// </summary>
        public List<RightOptions> ShowRights { get; set; }
        /// <summary>
        /// When true display a list of content that is in the has been identified as being about the same story as the requested content item. When a content item is in a package the hasStoryPackage field has a value of true
        /// </summary>
        public bool? ShowStoryPackage { get; set; }
        /// <summary>
        /// When true display a list of content that is chosen by editors on tags, sections and the home page. This content list represents the main list of content found on the equivalent path on the site
        /// </summary>
        public bool? ShowEditorPicks { get; set; }
        /// <summary>
        /// When true display most viewed content. For overall most viewed set id to '/', for section most viewed set id to the section id  
        /// </summary>
        public bool? ShowMostViewed { get; set; }
        /// <summary>
        /// Content items can show a set of 'related' content. When true returns content items related to the main content item
        /// </summary>
        public bool? ShowRelated { get; set; }
        internal string ContentFilterString
        {
            get
            {
                string showFields = "";
                if (ShowFields != null)
                {
                    List<string> strings = new List<string>();
                    foreach (var field in ShowFields)
                    {
                        strings.Add(Constants.FilterStrings[field]);
                    }

                    showFields = string.Join(",", strings);
                }

                string showTags = "";
                if (ShowTags != null)
                {
                    List<string> strings = new List<string>();
                    foreach (var tag in ShowTags)
                    {
                        strings.Add(Constants.TagStrings[tag]);
                    }

                    showTags = string.Join(",", strings);
                }

                string showElements = "";
                if (ShowElements != null)
                {
                    List<string> strings = new List<string>();
                    foreach (var element in ShowElements)
                    {
                        strings.Add(Constants.ShowElementStrings[element]);
                    }

                    showElements = string.Join(",", strings);
                }

                string referenceInformation = "";
                if (ReferenceInformation != null)
                {
                    List<string> strings = new List<string>();
                    foreach (var reference in ReferenceInformation)
                    {
                        strings.Add(Constants.ReferenceInformationStrings[reference]);
                    }

                    referenceInformation = string.Join(",", strings);
                }

                string showRights = "";
                if (ShowRights != null)
                {
                    List<string> strings = new List<string>();
                    foreach (var right in ShowRights)
                    {
                        strings.Add(Constants.RightStrings[right]);
                    }

                    showRights = string.Join(",", strings);
                }

                return $"{(Filters == null ? "" : Filters.FilterString)}" +
                       $"{(ToDate == null ? "" : $"&to-date={ToDate}")}" +
                       $"{(FromDate == null ? "" : $"&from-date={FromDate}")}" +
                       $"{(UseDate == null ? "" : $"&use-date={UseDate}")}" +
                       $"{(OrderBy == null ? "" : $"&order-by={OrderBy}")}" +
                       $"{(OrderDate == null ? "" : $"&order-date={OrderDate}")}" +
                       $"{(string.IsNullOrEmpty(showFields) ? "" : $"&show-fields={showFields}")}" +
                       $"{(string.IsNullOrEmpty(showTags) ? "" : $"&show-tags={showTags}")}" +
                       $"{(ShowSection == null ? "" : $"&show-section={ShowSection.Value}")}" +
                       $"{(string.IsNullOrEmpty(showElements) ? "" : $"&show-elements={showElements}")}" +
                       $"{(string.IsNullOrEmpty(referenceInformation) ? "" : $"&show-references={referenceInformation}")}" +
                       $"{(string.IsNullOrEmpty(showRights) ? "" : $"&show-rights={showRights}")}" +
                       $"{(ShowBlocks == null ? "" : ShowBlocks.ShowBlockString)}" +
                       $"{(ShowStoryPackage == null ? "" : $"&show-story-package={ShowStoryPackage.Value}")}" +
                       $"{(ShowEditorPicks == null ? "" : $"&show-editor-picks={ShowEditorPicks.Value}")}" +
                       $"{(ShowMostViewed == null ? "" : $"&show-most-viewed={ShowMostViewed.Value}")}" +
                       $"{(ShowRelated == null ? "" : $"&show-related={ShowRelated.Value}")}";
            }
        }
    }
}
