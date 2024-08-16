using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace SlackBotDotNet.Interactions
{
    public class InteractionDispatcher
    {
        private HandlersRegistry<InteractionHandler> _interactionHandlersRegistry;
        private IServiceProvider _serviceProvider;

        public InteractionDispatcher(HandlersRegistry<InteractionHandler> interactionHandlersRegistry, IServiceProvider serviceProvider)
        {
            _interactionHandlersRegistry = interactionHandlersRegistry;
            _serviceProvider = serviceProvider;
        }

        public Task DispatchCommand(InteractionEvent interaction)
        {
            var handler = _interactionHandlersRegistry.GetHandlerForEvent(interaction.Action.ActionId);

            if(handler == null)
            {
                return Task.CompletedTask;
            }

            var handlerService = _serviceProvider.GetRequiredService(handler) as InteractionHandler;

            if(handlerService == null)
            {
                return Task.CompletedTask;
            }

            return handlerService.HandleInteraction(interaction);
        } 
    }
}
