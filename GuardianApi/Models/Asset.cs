namespace GuardianApi.Models
{
    public class Asset
    {
        public string Type { get; set; }
        public string MimeType { get; set; }
        public string File { get; set; }
        public TypeData TypeData { get; set; }
    }
}