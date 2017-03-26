namespace GuardianApi.Models
{
    public class TypeData
    {
        public string AspectRatio { get; set; }
        public float? Width { get; set; }
        public float? Height { get; set; }
        public bool? IsMaster { get; set; }
        public bool? IsInappropriateForAdverts { get; set; }
        public bool? Embeddable { get; set; }
        public string Source { get; set; }
        public string Name { get; set; }
        public string AltText { get; set; }
        public string Caption { get; set; }
        public string Credit { get; set; }
        public long? SizeInBytes { get; set; }
        public string Photographer { get; set; }
    }
}