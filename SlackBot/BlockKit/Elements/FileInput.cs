using Newtonsoft.Json;
using SlackBotDotNet.BlockKit.BaseBlocks;

namespace SlackBotDotNet.BlockKit.Elements
{
    public class FileInput : ElementBase, IInputElement
    {
        public override string Type => ElementTypes.FileInput;
        [JsonProperty("action_id")]
        public string ActionId { get; set; }
        [JsonProperty("filetypes")]
        public string[] FileTypes { get; set; }
        [JsonProperty("max_files")]
        public int MaxFiles { get; set; }
    }
}