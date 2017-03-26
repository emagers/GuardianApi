using System.Collections.Generic;

namespace GuardianApi.Models.Requests
{
    /// <summary>
    /// A container for the tag filter options
    /// </summary>
    /// <fields>
    ///     <Type>Filters tags by the given types</Type>
    ///     <Section>Filters tags in the given sections (supports boolean filtering)</Section>
    ///     <Reference>Filters tags with the given references (supports boolean filtering)</Reference>
    ///     <ReferenceType>Filters tags with the given reference types (supports boolean filtering</ReferenceType>
    ///     <ReferenceInformation>Specifies the additional reference information to be included</ReferenceInformation>
    ///     <FilterString>String representation of the tag filters in a query parameter format</FilterString>
    /// </fields>
    public class TagFilter
    {
        public List<string> Type { get; set; }
        public string Section { get; set; }
        public string Reference { get; set; }
        public string ReferenceType { get; set; }
        public List<ReferenceInformationOptions> ReferenceInformation { get; set; }
        public string FilterString
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
