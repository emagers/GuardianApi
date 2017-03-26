using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuardianApi.Models.Requests
{
    public class ContentFilter
    {
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
        public UseDateOptions UseDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OrderByOptions OrderBy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OrderDateOptions OrderDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<FieldOptions> ShowFields { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<TagOptions> ShowTags { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ShowSection { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ShowBlockOptions> ShowBlocks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ShowElementOptions> ShowElements { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ReferenceInformationOptions> ReferenceInformation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<RightOptions> ShowRights { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ShowStoryPackage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ShowEditorPicks { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ShowMostViewed { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ShowRelated { get; set; }
    }


    /* Filters

        Name	Description	Type	Accepted values	Boolean operators

        section	Return only content in those sections	String	e.g. football	
        reference	Return only content with those references	String	e.g. isbn/9780718178949	
        reference-type	Return only content with references of those types	String	e.g. isbn	
        tag	Return only content with those tags	String	e.g. technology/apple	
        rights	Return only content with those rights	String	syndicatable | subscription-databases	
        ids	Return only content with those IDs	String	e.g. technology/2014/feb/17/flappy-bird-clones-apple-google	
        production-office	Return only content from those production offices	String	e.g. aus	
        lang	Return only content in those languages	String	ISO language codes, e.g. en, fr	
        star-rating	Return only content with a given star rating	Integer	1 to 5	
*/
}
