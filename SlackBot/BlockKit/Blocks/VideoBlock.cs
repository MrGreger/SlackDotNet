using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class VideoBlock : BlockBase
    {
        public override string Type => BlockTypes.Video;
        [JsonPropertyName("alt_text")]
        public string AltText { get; set; }      
        [JsonPropertyName("author_name")]
        public string AuthorName { get; set; }       
        [JsonPropertyName("description")]
        public PlainText Description { get; set; }
        [JsonPropertyName("provider_icon_url")]
        public string ProviderIconUrl { get; set; }    
        [JsonPropertyName("provider_name")]
        public string ProviderName { get; set; }   
        [JsonPropertyName("title")]
        public PlainText Title { get; set; }
        [JsonPropertyName("title_url")]
        public string TitleUrl { get; set; }   
        [JsonPropertyName("thumbnail_url")]
        public string ThumbnailUrl { get; set; } 
        [JsonPropertyName("video_url")]
        public string VideoUrl { get; set; }   
    }
}