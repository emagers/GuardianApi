using System.Collections.Generic;

namespace GuardianApi.Models.Requests
{
    public enum QueryType
    {
        Content,
        Tag,
        Edition,
        Section,
        Search
    }

    public enum BlockOptions
    {
        Main,
        Body,
        All,
        Latest,
        Oldest,
    }

    public enum UseDateOptions
    {
        Published,
        FirstPublication,
        NewspaperEdition,
        LastModified
    }

    public enum OrderByOptions
    {
        Newest,
        Oldest,
        Relevance
    }

    public enum OrderDateOptions
    {
        Published,
        NewspaperEdition,
        LastModified
    }

    public enum FieldOptions
    {
        TrailText,
        Headline,
        ShowInRelatedContent,
        Body,
        LastModified,
        HasStoryPackage,
        Score,
        StandFirst,
        ShortUrl,
        Thumbnail,
        Wordcount,
        Commentable,
        IsPremoderated,
        AllowUgc,
        Byline,
        Publication,
        InternalPageCode,
        ProductionOffice,
        ShouldHideAdverts,
        LiveBloggingNow,
        CommentCloseDate,
        StarRating,
        All
    }

    public enum TagOptions
    {
        Blog,
        Contributor,
        Keyword,
        NewspaperBook,
        NewspaperBookSection,
        Publication,
        Series,
        Tone,
        Type,
        All
    }

    public enum ShowElementOptions
    {
        Audio,
        Image,
        Video,
        All
    }

    public enum RightOptions
    {
        Syndicatable,
        SubscriptionDatabases,
        All
    }

    public enum ReferenceInformationOptions
    {
        Author,
        BisacPrefix,
        EsaCricketMatch,
        EsaFootballMatch,
        EsaFootballTeam,
        EsaFootballTournament,
        ISBN,
        IMDB,
        MusicBrainz,
        MusicBrainzGenre,
        OptaCricketMatch,
        OptaFootballMatch,
        OptaFootballTeam,
        OptaFootballTournament,
        PaFootballCompentition,
        PaFootballMatch,
        PaFootballTeam,
        R1Film,
        ReutersIndexRic,
        ReutersStockRic,
        WitnessAssignment
    }

    internal class Constants
    {
        internal static readonly string API = "https://content.guardianapis.com";
        
        internal static readonly Dictionary<QueryType, string> QueryStrings = new Dictionary<QueryType, string>
        {
            { QueryType.Content, "" },
            { QueryType.Tag, "tags" },
            { QueryType.Edition, "editions" },
            { QueryType.Section, "sections" },
            { QueryType.Search, "search" }
        };

        internal static readonly Dictionary<BlockOptions, string> BlockStrings = new Dictionary<BlockOptions, string>
        {
            { BlockOptions.Main, "main" },
            { BlockOptions.Body, "body" },
            { BlockOptions.All, "all" },
            { BlockOptions.Latest, "body:latest" },
            { BlockOptions.Oldest, "body:oldest" }
        };
        
        internal static readonly Dictionary<UseDateOptions, string> UseDateStrings = new Dictionary<UseDateOptions, string>
        {
            { UseDateOptions.Published, "published" },
            { UseDateOptions.FirstPublication, "first-publication" },
            { UseDateOptions.NewspaperEdition, "newspaper-edition" },
            { UseDateOptions.LastModified, "last-modified" }
        };
        
        internal static readonly Dictionary<OrderByOptions, string> OrderByStrings = new Dictionary<OrderByOptions, string>
        {
            { OrderByOptions.Newest, "newest" },
            { OrderByOptions.Oldest, "oldest" },
            { OrderByOptions.Relevance, "relevance" }
        };
        
        internal static readonly Dictionary<OrderDateOptions, string> OrderDateStrings = new Dictionary<OrderDateOptions, string>
        {
            { OrderDateOptions.Published, "published" },
            { OrderDateOptions.NewspaperEdition, "newspaper-edition" },
            { OrderDateOptions.LastModified, "last-modified" }
        };
        
        internal static readonly Dictionary<FieldOptions, string> FilterStrings = new Dictionary<FieldOptions, string>
        {
            { FieldOptions.TrailText, "trailText" },
            { FieldOptions.Headline, "headline" },
            { FieldOptions.ShowInRelatedContent, "showInRelatedContent" },
            { FieldOptions.Body, "body" },
            { FieldOptions.LastModified, "lastModified" },
            { FieldOptions.HasStoryPackage, "hasStoryPackage" },
            { FieldOptions.Score, "score" },
            { FieldOptions.StandFirst, "standfirst" },
            { FieldOptions.ShortUrl, "shortUrl" },
            { FieldOptions.Thumbnail, "thumbnail" },
            { FieldOptions.Wordcount, "wordcount" },
            { FieldOptions.Commentable, "commentable" },
            { FieldOptions.IsPremoderated, "isPremoderated" },
            { FieldOptions.AllowUgc, "allowUgc" },
            { FieldOptions.Byline, "byline" },
            { FieldOptions.Publication, "publication" },
            { FieldOptions.InternalPageCode, "internalPackageCode" },
            { FieldOptions.ProductionOffice, "productionOffice" },
            { FieldOptions.ShouldHideAdverts, "shouldHideAdverts" },
            { FieldOptions.LiveBloggingNow, "liveBloggingNow" },
            { FieldOptions.CommentCloseDate, "commentCloseDate" },
            { FieldOptions.StarRating, "starRating" },
            { FieldOptions.All, "all" }
        };
        
        internal static readonly Dictionary<TagOptions, string> TagStrings = new Dictionary<TagOptions, string>
        {
            { TagOptions.Blog, "blog" },
            { TagOptions.Contributor, "contributer" },
            { TagOptions.Keyword, "keyword" },
            { TagOptions.NewspaperBook, "newspaper-book" },
            { TagOptions.NewspaperBookSection, "newspaper-book-section" },
            { TagOptions.Publication, "publication" },
            { TagOptions.Series, "series" },
            { TagOptions.Tone, "tone" },
            { TagOptions.Type, "type" },
            { TagOptions.All, "all" }
        };
        
        internal static readonly Dictionary<ShowElementOptions, string> ShowElementStrings = new Dictionary<ShowElementOptions, string>
        {
            { ShowElementOptions.Audio, "audio" },
            { ShowElementOptions.Image, "image" },
            { ShowElementOptions.Video, "video" },
            { ShowElementOptions.All, "all" }
        };
        
        internal static readonly Dictionary<RightOptions, string> RightStrings = new Dictionary<RightOptions, string>
        {
            { RightOptions.Syndicatable, "syndicatable" },
            { RightOptions.SubscriptionDatabases, "subscription-databases" },
            { RightOptions.All, "all" }
        };
        
        internal static readonly Dictionary<ReferenceInformationOptions, string> ReferenceInformationStrings = new Dictionary<ReferenceInformationOptions, string>
        {
            { ReferenceInformationOptions.Author, "author" },
            { ReferenceInformationOptions.BisacPrefix, "bisac-prefix" },
            { ReferenceInformationOptions.EsaCricketMatch, "esa-cricket-match" },
            { ReferenceInformationOptions.EsaFootballMatch, "esa-football-match" },
            { ReferenceInformationOptions.EsaFootballTeam, "esa-football-team" },
            { ReferenceInformationOptions.EsaFootballTournament, "esa-football-tournament" },
            { ReferenceInformationOptions.ISBN, "isbn" },
            { ReferenceInformationOptions.IMDB, "imdb" },
            { ReferenceInformationOptions.MusicBrainz, "musicbrainz" },
            { ReferenceInformationOptions.MusicBrainzGenre, "musicbrainzgenre" },
            { ReferenceInformationOptions.OptaCricketMatch, "opta-cricket-match" },
            { ReferenceInformationOptions.OptaFootballMatch, "opta-football-match" },
            { ReferenceInformationOptions.OptaFootballTeam, "opta-football-team" },
            { ReferenceInformationOptions.OptaFootballTournament, "opta-football-tournament" },
            { ReferenceInformationOptions.PaFootballCompentition, "pa-football-competition" },
            { ReferenceInformationOptions.PaFootballMatch, "pa-football-match" },
            { ReferenceInformationOptions.PaFootballTeam, "pa-football-team" },
            { ReferenceInformationOptions.R1Film, "r1-film" },
            { ReferenceInformationOptions.ReutersIndexRic, "reuters-index-ric" },
            { ReferenceInformationOptions.ReutersStockRic, "reuters-stock-ric" },
            { ReferenceInformationOptions.WitnessAssignment, "witness-assignment" }
        };
    }
}