namespace GuardianApi.Models
{
    public class Asset
    {
        public string type { get; set; }
        public string mimeType { get; set; }
        public string file { get; set; }
        public TypeData typeData { get; set; }
    }
}