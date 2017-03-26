using System.Collections.Generic;

namespace GuardianApi.Models.Requests
{
    /// <summary>
    /// A container for the tag filter options
    /// </summary>
    public class TagFilter
    {
        /// <summary>
        /// Filters tags by the given types
        /// </summary>
        public List<string> Type { get; set; }
        /// <summary>
        /// Filters tags in the given sections (supports boolean filtering)
        /// </summary>
        public string Section { get; set; }
        /// <summary>
        /// Filters tags with the given references (supports boolean filtering)
        /// </summary>
        public string Reference { get; set; }
        /// <summary>
        /// Filters tags with the given reference types (supports boolean filtering
        /// </summary>
        public string ReferenceType { get; set; }
        /// <summary>
        /// Specifies the additional reference information to be included
        /// </summary>
        public List<ReferenceInformationOptions> ReferenceInformation { get; set; }
        internal string FilterString
        {
            get
            {
                List<string> referenceInformation = new List<string>();
                foreach (ReferenceInformationOptions option in ReferenceInformation)
                {
                    string value = string.Empty;
                    if (Constants.ReferenceInformationStrings.TryGetValue(option, out value))
                    {
                        referenceInformation.Add(value);
                    }
                }

                return $"{(Type == null ? string.Empty : "&type=" + string.Join(",", Type))}" +
                       $"{(string.IsNullOrEmpty(Section) ? string.Empty : "&section=" + Section)}" +
                       $"{(string.IsNullOrEmpty(Reference) ? string.Empty : "&reference=" + Reference)}" +
                       $"{(string.IsNullOrEmpty(ReferenceType) ? string.Empty : "&reference-type=" + ReferenceType)}" +
                       $"{(ReferenceInformation == null ? string.Empty : "&show-references=" + string.Join(",", referenceInformation))}";
            }
        }
    }
}
