using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Block
    {
        public Body Main { get; set; }
        public List<Body> Body { get; set; }
        public int? TotalBodyBlocks { get; set; }
    }
}
