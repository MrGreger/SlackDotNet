using System.Text.Json.Serialization;

namespace SlackBot.Blocks
{
    public class SlackFile
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("id")]
        public string Id { get; set; }

        public static SlackFile FromUrl(string url)
        {
            return new SlackFile()
            {
                Url = url
            };
        }
        
        public static SlackFile FromId(string id)
        {
            return new SlackFile()
            {
                Id = id
            };
        }
    }
}