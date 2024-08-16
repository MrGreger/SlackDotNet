using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SlackBotDotNet.CommandHandlers;

namespace SlackBotDotNet.Commands
{
    public class CommandDispatcher
    {
        private HandlersRegistry<ICommandHandler> _eventHandlersRegistry;
        private IServiceProvider _serviceProvider;

        public CommandDispatcher(HandlersRegistry<ICommandHandler> eventHandlersRegistry, IServiceProvider serviceProvider)
        {
            _eventHandlersRegistry = eventHandlersRegistry;
            _serviceProvider = serviceProvider;
        }

        public Task DispatchCommand(SlackCommand command)
        {
            var handler = _eventHandlersRegistry.GetHandlerForEvent(command.Command);

            var handlerService = _serviceProvider.GetRequiredService(handler) as ICommandHandler;

            return handlerService.HandleCommand(command);
        }
    }
}
