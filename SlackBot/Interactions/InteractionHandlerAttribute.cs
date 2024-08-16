using System;
using System.Collections.Generic;
using System.Text;

namespace SlackBot.Interactions
{
    public class InteractionHandlerAttribute : Attribute
    {
        public string InteractionActionName { get; }

        public InteractionHandlerAttribute(string eventName)
        {
            InteractionActionName = eventName;
        }
    }
}
