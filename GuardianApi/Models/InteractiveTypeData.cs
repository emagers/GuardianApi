namespace GuardianApi.Models
{
    public class InteractiveTypeData
    {
        public string OriginalUrl { get; set; }
        public string Source { get; set; }
        public string Alt { get; set; }
        public string ScriptUrl { get; set; }
        public string Html { get; set; }
        public string ScriptName { get; set; }
        public string IframeUrl { get; set; }
        public bool? IsMandatory { get; set; }
        public string Role { get; set; }
        public string Caption { get; set; }
    }
}