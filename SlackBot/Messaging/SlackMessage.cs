using Newtonsoft.Json;

namespace SlackBotDotNet.Messaging
{
    public class SlackMessage
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }
        [JsonProperty("blocks")]
        public string Blocks { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("ts")]
        public string Ts {get;set;}
        [JsonProperty("thread_ts")]
        public string ThreadTs { get; set; }
    }
}
