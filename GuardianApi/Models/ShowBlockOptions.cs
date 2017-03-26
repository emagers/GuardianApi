using GuardianApi.Models.Requests;
using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class ShowBlockOptions
    {
        /// <summary>
        /// Only adds blocks with the given IDs
        /// </summary>
        public List<string> BodyId { get; set; }
        /// <summary>
        /// Adds blocks according to the provided settings
        /// </summary>
        public Dictionary<BlockOptions, int?> BlockOptions { get; set; }
        internal string ShowBlockString
        {
            get
            {
                string queryString = string.Empty;
                if (BodyId.Count != 0 && BlockOptions.Count != 0)
                {
                    queryString = "&show-blocks=";

                    List<string> options = new List<string>();
                    if (BlockOptions.Count != 0)
                    {
                        foreach (var option in BlockOptions)
                        {
                            //Builds the string in the format 'option:number', eg 'body:latest:10'
                            queryString += $"{Constants.BlockStrings[option.Key]}{(option.Value == null ? "" : ":" + option.Value.Value )}";
                        }
                    }

                    queryString += string.Join(",", BodyId, options);
                }

                return queryString;
            }
        }
    }
}
