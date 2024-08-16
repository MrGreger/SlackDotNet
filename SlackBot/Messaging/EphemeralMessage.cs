using Newtonsoft.Json;

namespace SlackBotDotNet.Messaging
{
    public class EphemeralMessage : SlackMessage
    {
        [JsonProperty("attachments")]
        public object[] Attachments { get; set; }
        [JsonProperty("user")]
        public string User { get; set; }
    }
}
