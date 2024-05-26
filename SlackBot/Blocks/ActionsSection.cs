using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpSlackBot.Blocks
{
    public class ActionsSection : ElementBase
    {
        public override string Type => BlockTypes.Actions;
        [JsonProperty("elements")]
        public IList<ElementBase> Elements { get; set; }

        public ActionsSection()
        {
            Elements = new List<ElementBase>();
        }
    }
}
