using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Blocks
{
    public class HeaderBlock : BlockBase
    {
        public override string Type => BlockTypes.Header;
        [JsonProperty("text")]
        public PlainText Elements { get; set; }
    }
}