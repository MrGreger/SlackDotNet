using System;

namespace SlackBotDotNet.CommandHandlers
{
    public class CommandHandlerAttribute : Attribute
    {
        public string CommandName { get; }

        public CommandHandlerAttribute(string eventName)
        {
            CommandName = eventName;
        }
    }
}
