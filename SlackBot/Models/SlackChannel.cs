using Newtonsoft.Json;

namespace SlackBotDotNet.Models
{
    public class SlackChannel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("is_im")]
        public bool IsIM { get; set; }
        [JsonProperty("user")]
        public string UserId { get; set; }
    }
}
