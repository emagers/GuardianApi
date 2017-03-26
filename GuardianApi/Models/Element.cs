using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Element
    {
        public string Type { get; set; }
        public List<Asset> Assets { get; set; }
        public ImageTypeData ImageTypeData { get; set; }
        public VideoTypeData VideoTypeData { get; set; }
        public EmbedTypeData EmbedTypeData { get; set; }
        public AudioTypeData AudioTypeData { get; set; }
        public InteractiveTypeData InteractiveTypeData { get; set; }
        public WitnessTypeData WitnessTypeData { get; set; }
        public TextTypeData TextTypeData { get; set; }
        public RichLinkTypeData RichLinkTypeData { get; set; }
        public PollquoteTypeData PollquoteTypeData { get; set; }
        public InstagramTypeData InstagramTypeData { get; set; }
        public TweetTypeData TweetTypeData { get; set; }
        public ContentAtomTypeData ContentAtomTypeData { get; set; }
        public CommentTypeData CommentTypeData { get; set; }
        public MembershipTypeData MembershipTypeData { get; set; }
        public TableTypeData TableTypeData { get; set; }
        public MapTypeData MapTypeData { get; set; }
    }
}