using System;
using System.Linq;
using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class SectionConstraints
    {
        private static string[] _availableElements = new[]
        {
            ElementTypes.Button,
            ElementTypes.CheckBoxes,
        };

        public bool CanAdd(ElementBase element)
        {
            return _availableElements.Contains(element.Type, StringComparer.InvariantCulture);
        }
    }

    public class Section : ElementBase
    {
        public override string Type => BlockTypes.Section;

        [JsonProperty("text")]
        public TextAttribute Text { get; set; }
        [JsonProperty("fields")]
        public TextAttribute[] Fields { get; set; }
        [JsonProperty("accessory")]
        public ElementBase Acessory { get; set; }
        [JsonProperty("block_id")]
        public string BlockId { get; set; }
    }
}