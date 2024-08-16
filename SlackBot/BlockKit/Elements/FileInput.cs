using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks.Elements
{
    public class FileInput : ElementBase, IInputElement
    {
        public override string Type => ElementTypes.FileInput;
        [JsonPropertyName("action_id")]
        public string ActionId { get; set; }
        [JsonPropertyName("filetypes")]
        public string[] FileTypes { get; set; }
        [JsonPropertyName("max_files")]
        public int MaxFiles { get; set; }
    }
}