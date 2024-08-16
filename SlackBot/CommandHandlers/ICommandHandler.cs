using System.Threading.Tasks;
using SlackBotDotNet.Commands;

namespace SlackBotDotNet.CommandHandlers
{
    public interface ICommandHandler
    {
        Task HandleCommand(SlackCommand payload);
    }
}
