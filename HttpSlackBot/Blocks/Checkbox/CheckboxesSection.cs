﻿using HttpSlackBot.Blocks.BaseBlocks;
using HttpSlackBot.Blocks.Checkbox;
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpSlackBot.Blocks
{
    public class CheckboxesSection : InputBase
    {
        public override BlockBase Element { get; } = new Checkboxes();
    }
}
