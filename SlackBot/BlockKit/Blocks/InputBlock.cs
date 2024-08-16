using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class InputBlock : BlockBase
    {
        public override string Type => BlockTypes.Input;
        [JsonProperty("label")]
        public PlainText Label { get; set; }       
        [JsonProperty("element")]
        public IInputElement Element { get; set; }
        [JsonProperty("dispatch_action")]
        public bool DispatchAction { get; set; }     
        [JsonProperty("hint")]
        public PlainText Hint { get; set; }
        [JsonProperty("optional")]
        public bool Optional { get; set; }
    }
}