using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks.Elements
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