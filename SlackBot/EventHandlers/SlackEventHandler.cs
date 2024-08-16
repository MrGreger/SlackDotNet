using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SlackBot.Events;
using SlackBot.Helpers;

namespace SlackBot.EventHandlers
{

    public abstract class SlackEventHandler
    {
        public abstract Task HandleEvent(SlackCallback payload);
    }

    public abstract class SlackEventHandler<T> : SlackEventHandler where T : SlackBaseEvent
    {
        public override Task HandleEvent(SlackCallback payload)
        {
            return OnEvent(payload.EventObject.Deserialize<T>(SlackSerialization.SerializerOptions));
        }

        protected abstract Task OnEvent(T payload);
    }
}
