using System.Collections.Generic;
using System.Linq;
using SlackBot.Blocks.Actions;

namespace SlackBot.Blocks.Builders.Actions
{
    
    public interface IDispatchActionConfigurator
    {
        IDispatchActionConfigurator OnEnterPressed();
        IDispatchActionConfigurator OnCharacterEntered();
    }
    
    public class DispatchActionConfigurationBuilder : IDispatchActionConfigurator
    {
        private HashSet<string> _actions = new HashSet<string>();
        
        public IDispatchActionConfigurator OnEnterPressed()
        {
            _actions.Add("on_enter_pressed");
            return this;
        }

        public IDispatchActionConfigurator OnCharacterEntered()
        {
            _actions.Add("on_character_entered");
            return this;
        }

        public DispatchActionsConfig Build()
        {
            return new DispatchActionsConfig()
            {
                TriggersOn = _actions.ToArray()
            };
        }
    }
}