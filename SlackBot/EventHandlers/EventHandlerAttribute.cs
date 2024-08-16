using System;

namespace SlackBotDotNet.EventHandlers
{
    public class EventHandlerAttribute : Attribute
    {
        public string EventName { get; }

        public EventHandlerAttribute(string eventName)
        {
            EventName = eventName;
        }
    }
}
