﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SlackBot.Templates
{
    public interface ITemplatesProvider
    {
        Task<SlackMessageTemplate> GetMessageTemplate(string templateName);
    }
}
