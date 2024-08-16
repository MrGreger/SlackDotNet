using System.Threading.Tasks;

namespace SlackBotDotNet.Templates
{
    public interface ITemplatesProvider
    {
        Task<SlackMessageTemplate> GetMessageTemplate(string templateName);
    }
}
