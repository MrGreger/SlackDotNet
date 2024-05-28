using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class VideoSection : BlockBase
    {
        public override string Type => BlockTypes.Video;
        [JsonProperty("alt_text")]
        public string AltText { get; set; }      
        [JsonProperty("author_name")]
        public string AuthorName { get; set; }       
        [JsonProperty("description")]
        public PlainText Description { get; set; }
        [JsonProperty("provider_icon_url")]
        public string ProviderIconUrl { get; set; }    
        [JsonProperty("provider_name")]
        public string ProviderName { get; set; }   
        [JsonProperty("title")]
        public PlainText Title { get; set; }
        [JsonProperty("title_url")]
        public string TitleUrl { get; set; }   
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; } 
        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }   
    }
}