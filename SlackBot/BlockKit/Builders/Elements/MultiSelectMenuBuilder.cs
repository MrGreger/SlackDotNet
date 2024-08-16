using System;
using System.Linq;
using SlackBotDotNet.BlockKit.Builders.Elements.Options;
using SlackBotDotNet.BlockKit.Elements;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Builders.Elements
{
    public interface IMultiSelectMenuConfigurator
    {
        IMultiSelectMenuConfigurator AddOption(Action<ISelectMenuOptionConfigurator> builder);
        IMultiSelectMenuConfigurator AddOptionGroups(Action<ISelectMenuOptionGroupConfigurator> builder);
        IMultiSelectMenuConfigurator WithActionId(string id);
        IMultiSelectMenuConfigurator WithConfirmDialog(Action<IConfirmationDialogConfigurator> builder);
        IMultiSelectMenuConfigurator FocusOnLoad(bool focus);
        IMultiSelectMenuConfigurator WithPlaceholder(string text, bool emoji = true);
    }
    
    public class MultiSelectMenuBuilder : IMultiSelectMenuConfigurator
    {
        private MultiSelectMenu _menu = new MultiSelectMenu();
        
        public IMultiSelectMenuConfigurator AddOption(Action<ISelectMenuOptionConfigurator> builder)
        {
            if (_menu.OptionGroups.Any())
            {
                throw new InvalidOperationException("You can add either options or option groups");
            }

            var optionBuilder = new SelectMenuOptionBuilder();

            builder.Invoke(optionBuilder);

            var option = optionBuilder.Build();
            
            _menu.Options.Add(option.Option);

            if (option.Initial)
            {
                _menu.InitialOption = option.Option;
            }
            
            return this;
        }

        public IMultiSelectMenuConfigurator AddOptionGroups(Action<ISelectMenuOptionGroupConfigurator> builder)
        {
            if (_menu.Options.Any())
            {
                throw new InvalidOperationException("You can add either options or option groups");
            }
            
            var optionGroupBuilder = new SelectMenuOptionGroupBuilder();

            builder.Invoke(optionGroupBuilder);

            var optionGroup = optionGroupBuilder.Build();
            
            _menu.OptionGroups.Add(optionGroup.Group);

            if (optionGroup.Initial)
            {
                _menu.InitialOptionGroup = optionGroup.Group;
            }

            return this;
        }

        public IMultiSelectMenuConfigurator WithActionId(string id)
        {
            _menu.ActionId = id;
            
            return this;
        }

        public IMultiSelectMenuConfigurator WithConfirmDialog(Action<IConfirmationDialogConfigurator> builder)
        {
            var dialogBuilder = new ConfirmationDialogConfiguratorBuilder();
            
            builder.Invoke(dialogBuilder);

            _menu.ConfirmationDialog = dialogBuilder.Build();

            return this;
        }

        public IMultiSelectMenuConfigurator FocusOnLoad(bool focus)
        {
            _menu.FocusOnLoad = focus;

            return this;
        }

        public IMultiSelectMenuConfigurator WithPlaceholder(string text, bool emoji = true)
        {
            _menu.Placeholder = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public MultiSelectMenu Build()
        {
            return _menu;
        }
    }
}