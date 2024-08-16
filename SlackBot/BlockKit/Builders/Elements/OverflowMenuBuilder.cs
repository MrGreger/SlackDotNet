using System;
using System.Collections.Generic;
using SlackBot.Blocks.Checkbox;
using SlackBot.Blocks.Elements;

namespace SlackBot.Blocks.Builders
{
    public interface IOverflowMenuConfigurator
    {
        IOverflowMenuConfigurator WithActionId(string actionId);
        IOverflowMenuConfigurator WithOption(Action<IOverflowMenuOptionConfigurator> builder);
        IOverflowMenuConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> builder);
    }
    
    public class OverflowMenuBuilder : IOverflowMenuConfigurator
    {
        private OverflowMenu _overflowMenu = new OverflowMenu();
        private List<InputOption> _options = new List<InputOption>();
        
        public IOverflowMenuConfigurator WithActionId(string actionId)
        {
            _overflowMenu.ActionId = actionId;
            return this;
        }

        public IOverflowMenuConfigurator WithOption(Action<IOverflowMenuOptionConfigurator> builder)
        {
            if (_options.Count >= 5)
            {
                throw new ArgumentException("Overflow menu can have up to 5 options");
            }
            
            var optionBuilder = new OverflowMenuOptionBuilder();
            
            builder.Invoke(optionBuilder);

            _options.Add(optionBuilder.Build());
            
            return this;
        }

        public IOverflowMenuConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> builder)
        {
            var confirmationDialogBuilder = new ConfirmationDialogConfiguratorBuilder();
            
            builder.Invoke(confirmationDialogBuilder);

            _overflowMenu.Confirmation = confirmationDialogBuilder.Build();
            
            return this;
        }

        public OverflowMenu Build()
        {
            _overflowMenu.Options = _options.ToArray();

            return _overflowMenu;
        }
    }
}