namespace GuardianApi.Models
{
    public class TypeData
    {
        public string aspectRatio { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public bool isMaster { get; set; }
        public bool isInappropriateForAdverts { get; set; }
        public bool embeddable { get; set; }
        public string source { get; set; }
        public string name { get; set; }
        public string altText { get; set; }
        public string caption { get; set; }
        public string credit { get; set; }
        public long sizeInBytes { get; set; }
        public string photographer { get; set; }
    }
}