using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SlackBot.Commands;

namespace SlackBot.CommandHandlers
{
    public interface ICommandHandler
    {
        Task HandleCommand(SlackCommand payload);
    }
}
