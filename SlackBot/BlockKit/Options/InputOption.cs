using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Options
{
    public class InputOption : IOptionPayload
    {
        [JsonProperty("text")]
        public TextAttribute Text { get; set; }
        [JsonProperty("description")]
        public TextAttribute Description { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
