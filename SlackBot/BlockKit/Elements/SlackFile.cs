using Newtonsoft.Json;

namespace SlackBotDotNet.BlockKit.Elements
{
    public class SlackFile
    {
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("id")]
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