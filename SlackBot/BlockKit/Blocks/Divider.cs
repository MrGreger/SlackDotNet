using System.Collections.Generic;
using HttpSlackBot.Blocks.BaseBlocks;
using Newtonsoft.Json;

namespace HttpSlackBot.Blocks
{
    public class Divider : BlockBase
    {
        public override string Type => BlockTypes.Divider;
    }
}