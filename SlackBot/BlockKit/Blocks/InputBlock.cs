using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks
{
    public class InputBlock : BlockBase
    {
        public override string Type => BlockTypes.Input;
        [JsonPropertyName("label")]
        public PlainText Label { get; set; }       
        [JsonPropertyName("element")]
        public IInputElement Element { get; set; }
        [JsonPropertyName("dispatch_action")]
        public bool DispatchAction { get; set; }     
        [JsonPropertyName("hint")]
        public PlainText Hint { get; set; }
        [JsonPropertyName("optional")]
        public bool Optional { get; set; }
    }
}