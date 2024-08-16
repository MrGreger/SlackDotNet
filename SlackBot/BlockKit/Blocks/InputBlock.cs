using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Elements;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
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