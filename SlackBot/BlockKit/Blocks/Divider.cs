using System.Collections.Generic;
using Newtonsoft.Json;
using SlackBot.Blocks.BaseBlocks;

namespace SlackBot.Blocks
{
    public class Divider : BlockBase
    {
        public override string Type => BlockTypes.Divider;
    }
}