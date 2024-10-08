﻿using System.Threading.Tasks;

namespace SlackBotDotNet.Interactions
{
    public abstract class InteractionHandler
    {
        public abstract Task HandleInteraction(InteractionEvent payload);
    }

    public abstract class InteractionHandler<T> : InteractionHandler
    {
        public override Task HandleInteraction(InteractionEvent interaction)
        {
            var castedInteraction = InteractionEvent<T>.FromBaseEvent(interaction);
            return OnEvent(castedInteraction);
        }

        protected abstract Task OnEvent(InteractionEvent<T> payload);
    }
}
