using System.Collections.Generic;
using System.Text.Json.Serialization;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class Divider : BlockBase
    {
        public override string Type => BlockTypes.Divider;
    }
}