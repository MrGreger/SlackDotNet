using System;

namespace SlackBotDotNet.Interactions
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
