using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Fiorello_MVC.Models
{
    public partial class Temperatures
    {
        [JsonProperty("seo_category_infos")]
        public string[][] SeoCategoryInfos { get; set; }

        [JsonProperty("logging_page_id")]
        public string LoggingPageId { get; set; }

        [JsonProperty("show_suggested_profiles")]
        public bool ShowSuggestedProfiles { get; set; }

        [JsonProperty("show_follow_dialog")]
        public bool ShowFollowDialog { get; set; }

        [JsonProperty("graphql")]
        public Graphql Graphql { get; set; }

        [JsonProperty("toast_content_on_load")]
        public object ToastContentOnLoad { get; set; }

        [JsonProperty("show_view_shop")]
        public bool ShowViewShop { get; set; }

        [JsonProperty("profile_pic_edit_sync_props")]
        public ProfilePicEditSyncProps ProfilePicEditSyncProps { get; set; }

        [JsonProperty("always_show_message_button_to_pro_account")]
        public bool AlwaysShowMessageButtonToProAccount { get; set; }
    }

    public partial class Graphql
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }

    public partial class User
    {
        [JsonProperty("biography")]
        public string Biography { get; set; }

        [JsonProperty("blocked_by_viewer")]
        public bool BlockedByViewer { get; set; }

        [JsonProperty("restricted_by_viewer")]
        public object RestrictedByViewer { get; set; }

        [JsonProperty("country_block")]
        public bool CountryBlock { get; set; }

        [JsonProperty("external_url")]
        public Uri ExternalUrl { get; set; }

        [JsonProperty("external_url_linkshimmed")]
        public Uri ExternalUrlLinkshimmed { get; set; }

        [JsonProperty("edge_followed_by")]
        public EdgeFollowClass EdgeFollowedBy { get; set; }

        [JsonProperty("fbid")]
        public string Fbid { get; set; }

        [JsonProperty("followed_by_viewer")]
        public bool FollowedByViewer { get; set; }

        [JsonProperty("edge_follow")]
        public EdgeFollowClass EdgeFollow { get; set; }

        [JsonProperty("follows_viewer")]
        public bool FollowsViewer { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("has_ar_effects")]
        public bool HasArEffects { get; set; }

        [JsonProperty("has_clips")]
        public bool HasClips { get; set; }

        [JsonProperty("has_guides")]
        public bool HasGuides { get; set; }

        [JsonProperty("has_channel")]
        public bool HasChannel { get; set; }

        [JsonProperty("has_blocked_viewer")]
        public bool HasBlockedViewer { get; set; }

        [JsonProperty("highlight_reel_count")]
        public long HighlightReelCount { get; set; }

        [JsonProperty("has_requested_viewer")]
        public bool HasRequestedViewer { get; set; }

        [JsonProperty("hide_like_and_view_counts")]
        public bool HideLikeAndViewCounts { get; set; }

        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("is_business_account")]
        public bool IsBusinessAccount { get; set; }

        [JsonProperty("is_professional_account")]
        public bool IsProfessionalAccount { get; set; }

        [JsonProperty("is_embeds_disabled")]
        public bool IsEmbedsDisabled { get; set; }

        [JsonProperty("is_joined_recently")]
        public bool IsJoinedRecently { get; set; }

        [JsonProperty("business_address_json")]
        public object BusinessAddressJson { get; set; }

        [JsonProperty("business_contact_method")]
        public object BusinessContactMethod { get; set; }

        [JsonProperty("business_email")]
        public object BusinessEmail { get; set; }

        [JsonProperty("business_phone_number")]
        public object BusinessPhoneNumber { get; set; }

        [JsonProperty("business_category_name")]
        public string BusinessCategoryName { get; set; }

        [JsonProperty("overall_category_name")]
        public object OverallCategoryName { get; set; }

        [JsonProperty("category_enum")]
        public string CategoryEnum { get; set; }

        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("edge_mutual_followed_by")]
        public EdgeMutualFollowedBy EdgeMutualFollowedBy { get; set; }

        [JsonProperty("profile_pic_url")]
        public Uri ProfilePicUrl { get; set; }

        [JsonProperty("profile_pic_url_hd")]
        public Uri ProfilePicUrlHd { get; set; }

        [JsonProperty("requested_by_viewer")]
        public bool RequestedByViewer { get; set; }

        [JsonProperty("should_show_category")]
        public bool ShouldShowCategory { get; set; }

        [JsonProperty("should_show_public_contacts")]
        public bool ShouldShowPublicContacts { get; set; }

        [JsonProperty("username")]
        public Username Username { get; set; }

        [JsonProperty("connected_fb_page")]
        public object ConnectedFbPage { get; set; }

        [JsonProperty("pronouns")]
        public object[] Pronouns { get; set; }

        [JsonProperty("edge_felix_video_timeline")]
        public EdgeFelixVideoTimelineClass EdgeFelixVideoTimeline { get; set; }

        [JsonProperty("edge_owner_to_timeline_media")]
        public EdgeFelixVideoTimelineClass EdgeOwnerToTimelineMedia { get; set; }

        [JsonProperty("edge_saved_media")]
        public EdgeFelixVideoTimelineClass EdgeSavedMedia { get; set; }

        [JsonProperty("edge_media_collections")]
        public EdgeFelixVideoTimelineClass EdgeMediaCollections { get; set; }

        [JsonProperty("edge_related_profiles")]
        public EdgeRelatedProfiles EdgeRelatedProfiles { get; set; }
    }

    public partial class EdgeFelixVideoTimelineClass
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("page_info")]
        public PageInfo PageInfo { get; set; }

        [JsonProperty("edges")]
        public EdgeFelixVideoTimelineEdge[] Edges { get; set; }
    }

    public partial class EdgeFelixVideoTimelineEdge
    {
        [JsonProperty("node")]
        public PurpleNode Node { get; set; }
    }

    public partial class PurpleNode
    {
        [JsonProperty("__typename")]
        public Typename Typename { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shortcode")]
        public string Shortcode { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("display_url")]
        public Uri DisplayUrl { get; set; }

        [JsonProperty("edge_media_to_tagged_user")]
        public EdgeMediaToTaggedUser EdgeMediaToTaggedUser { get; set; }

        [JsonProperty("fact_check_overall_rating")]
        public object FactCheckOverallRating { get; set; }

        [JsonProperty("fact_check_information")]
        public object FactCheckInformation { get; set; }

        [JsonProperty("gating_info")]
        public object GatingInfo { get; set; }

        [JsonProperty("sharing_friction_info")]
        public SharingFrictionInfo SharingFrictionInfo { get; set; }

        [JsonProperty("media_overlay_info")]
        public object MediaOverlayInfo { get; set; }

        [JsonProperty("media_preview")]
        public string MediaPreview { get; set; }

        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("is_video")]
        public bool IsVideo { get; set; }

        [JsonProperty("has_upcoming_event")]
        public bool HasUpcomingEvent { get; set; }

        [JsonProperty("accessibility_caption")]
        public string AccessibilityCaption { get; set; }

        [JsonProperty("edge_media_to_caption")]
        public EdgeMediaToCaption EdgeMediaToCaption { get; set; }

        [JsonProperty("edge_media_to_comment")]
        public EdgeFollowClass EdgeMediaToComment { get; set; }

        [JsonProperty("comments_disabled")]
        public bool CommentsDisabled { get; set; }

        [JsonProperty("taken_at_timestamp")]
        public long TakenAtTimestamp { get; set; }

        [JsonProperty("edge_liked_by")]
        public EdgeFollowClass EdgeLikedBy { get; set; }

        [JsonProperty("edge_media_preview_like")]
        public EdgeFollowClass EdgeMediaPreviewLike { get; set; }

        [JsonProperty("location")]
        public object Location { get; set; }

        [JsonProperty("thumbnail_src")]
        public Uri ThumbnailSrc { get; set; }

        [JsonProperty("thumbnail_resources")]
        public ThumbnailResource[] ThumbnailResources { get; set; }

        [JsonProperty("coauthor_producers")]
        public object[] CoauthorProducers { get; set; }
    }

    public partial class Dimensions
    {
        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }
    }

    public partial class EdgeFollowClass
    {
        [JsonProperty("count")]
        public long Count { get; set; }
    }

    public partial class EdgeMediaToCaption
    {
        [JsonProperty("edges")]
        public EdgeMediaToCaptionEdge[] Edges { get; set; }
    }

    public partial class EdgeMediaToCaptionEdge
    {
        [JsonProperty("node")]
        public FluffyNode Node { get; set; }
    }

    public partial class FluffyNode
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class EdgeMediaToTaggedUser
    {
        [JsonProperty("edges")]
        public EdgeMediaToTaggedUserEdge[] Edges { get; set; }
    }

    public partial class EdgeMediaToTaggedUserEdge
    {
        [JsonProperty("node")]
        public TentacledNode Node { get; set; }
    }

    public partial class TentacledNode
    {
        [JsonProperty("user")]
        public UserClass User { get; set; }

        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public partial class UserClass
    {
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("followed_by_viewer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FollowedByViewer { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("profile_pic_url")]
        public Uri ProfilePicUrl { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("is_private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrivate { get; set; }
    }

    public partial class Owner
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("username")]
        public Username Username { get; set; }
    }

    public partial class SharingFrictionInfo
    {
        [JsonProperty("should_have_sharing_friction")]
        public bool ShouldHaveSharingFriction { get; set; }

        [JsonProperty("bloks_app_url")]
        public object BloksAppUrl { get; set; }
    }

    public partial class ThumbnailResource
    {
        [JsonProperty("src")]
        public Uri Src { get; set; }

        [JsonProperty("config_width")]
        public long ConfigWidth { get; set; }

        [JsonProperty("config_height")]
        public long ConfigHeight { get; set; }
    }

    public partial class PageInfo
    {
        [JsonProperty("has_next_page")]
        public bool HasNextPage { get; set; }

        [JsonProperty("end_cursor")]
        public string EndCursor { get; set; }
    }

    public partial class EdgeMutualFollowedBy
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("edges")]
        public object[] Edges { get; set; }
    }

    public partial class EdgeRelatedProfiles
    {
        [JsonProperty("edges")]
        public EdgeRelatedProfilesEdge[] Edges { get; set; }
    }

    public partial class EdgeRelatedProfilesEdge
    {
        [JsonProperty("node")]
        public UserClass Node { get; set; }
    }

    public partial class ProfilePicEditSyncProps
    {
        [JsonProperty("show_change_profile_pic_confirm_dialog")]
        public bool ShowChangeProfilePicConfirmDialog { get; set; }

        [JsonProperty("show_profile_pic_sync_reminders")]
        public bool ShowProfilePicSyncReminders { get; set; }

        [JsonProperty("identity_id")]
        public string IdentityId { get; set; }

        [JsonProperty("remove_profile_pic_header")]
        public object RemoveProfilePicHeader { get; set; }

        [JsonProperty("remove_profile_pic_subtext")]
        public object RemoveProfilePicSubtext { get; set; }

        [JsonProperty("remove_profile_pic_confirm_cta")]
        public object RemoveProfilePicConfirmCta { get; set; }

        [JsonProperty("remove_profile_pic_cancel_cta")]
        public object RemoveProfilePicCancelCta { get; set; }

        [JsonProperty("is_business_central_identity")]
        public bool IsBusinessCentralIdentity { get; set; }

        [JsonProperty("change_profile_pic_actions_screen_header")]
        public string[] ChangeProfilePicActionsScreenHeader { get; set; }

        [JsonProperty("change_profile_pic_actions_screen_subheader")]
        public string[] ChangeProfilePicActionsScreenSubheader { get; set; }

        [JsonProperty("change_profile_pic_actions_screen_upload_cta")]
        public string[] ChangeProfilePicActionsScreenUploadCta { get; set; }

        [JsonProperty("change_profile_pic_actions_screen_remove_cta")]
        public string[] ChangeProfilePicActionsScreenRemoveCta { get; set; }

        [JsonProperty("change_profile_pic_actions_screen_cancel_cta")]
        public string[] ChangeProfilePicActionsScreenCancelCta { get; set; }
    }

    public enum Username { Flowers };

    public enum Typename { GraphImage };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypenameConverter.Singleton,
                UsernameConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypenameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Typename) || t == typeof(Typename?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "GraphImage")
            {
                return Typename.GraphImage;
            }
            throw new Exception("Cannot unmarshal type Typename");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Typename)untypedValue;
            if (value == Typename.GraphImage)
            {
                serializer.Serialize(writer, "GraphImage");
                return;
            }
            throw new Exception("Cannot marshal type Typename");
        }

        public static readonly TypenameConverter Singleton = new TypenameConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class UsernameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Username) || t == typeof(Username?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "flowers")
            {
                return Username.Flowers;
            }
            throw new Exception("Cannot unmarshal type Username");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Username)untypedValue;
            if (value == Username.Flowers)
            {
                serializer.Serialize(writer, "flowers");
                return;
            }
            throw new Exception("Cannot marshal type Username");
        }

        public static readonly UsernameConverter Singleton = new UsernameConverter();
    }
}
