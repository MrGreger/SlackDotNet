using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Options
{
    public class InputOptionGroup : IOptionPayload
    {
        [JsonProperty("label")]
        public PlainText Label { get; set; }
        [JsonProperty("options")]
        public IList<InputOption> Options { get; set; } 
    }
}