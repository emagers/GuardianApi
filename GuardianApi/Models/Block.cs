using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Block
    {
        public Body main { get; set; }
        public List<Body> body { get; set; }
        public int totalBodyBlocks { get; set; }
    }
}
