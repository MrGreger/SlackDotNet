using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SlackBotDotNet.EventHandlers;
using SlackBotDotNet.Events;

namespace SlackBotDotNet
{
    public class SlackCallbackDispatcher
    {
        private HandlersRegistry<SlackEventHandler> _eventHandlersRegistry;
        private IServiceProvider _serviceProvider;

        public SlackCallbackDispatcher(HandlersRegistry<SlackEventHandler> eventHandlersRegistry, IServiceProvider serviceProvider)
        {
            _eventHandlersRegistry = eventHandlersRegistry;
            _serviceProvider = serviceProvider;
        }

        public Task DispatchCallaback(SlackCallback callback)
        {
            var handler = _eventHandlersRegistry.GetHandlerForEvent(callback.Event.Type);

            var handlerService = _serviceProvider.GetRequiredService(handler) as SlackEventHandler;

            return handlerService.HandleEvent(callback);
        }
    }
}
