using System.Collections.Generic;

namespace GuardianApi.Models
{
    public class Element
    {
        public string type { get; set; }
        public List<Asset> assets { get; set; }
        public ImageTypeData imageTypeData { get; set; }
        public VideoTypeData videoTypeData { get; set; }
        public EmbedTypeData embedTypeData { get; set; }
        public AudioTypeData audioTypeData { get; set; }
        public InteractiveTypeData interactiveTypeData { get; set; }
        public WitnessTypeData witnessTypeData { get; set; }
        public TextTypeData textTypeData { get; set; }
        public RichLinkTypeData richLinkTypeData { get; set; }
        public PollquoteTypeData pollquoteTypeData { get; set; }
        public InstagramTypeData instagramTypeData { get; set; }
        public TweetTypeData tweetTypeData { get; set; }
        public ContentAtomTypeData contentAtomTypeData { get; set; }
        public CommentTypeData commentTypeData { get; set; }
        public MembershipTypeData membershipTypeData { get; set; }
        public TableTypeData tableTypeData { get; set; }
        public MapTypeData mapTypeData { get; set; }

    }
}