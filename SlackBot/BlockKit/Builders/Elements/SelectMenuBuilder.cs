using System;
using System.Collections.Generic;
using System.Linq;
using SlackBotDotNet.BlockKit.Builders.Elements.Options;
using SlackBotDotNet.BlockKit.Elements;
using SlackBotDotNet.BlockKit.Options;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Builders.Elements
{
    public interface ISelectMenuConfigurator
    {
        ISelectMenuConfigurator WithActionId(string action);
        ISelectMenuConfigurator WithOption(Action<ISelectMenuOptionConfigurator> configurator);
        ISelectMenuConfigurator WithOptionGroup(Action<ISelectMenuOptionGroupConfigurator> configurator);
        ISelectMenuConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> configurator);
        ISelectMenuConfigurator FocusOnLoad(bool focus);
        ISelectMenuConfigurator WithPlaceholder(string text, bool emoji = true);
    }

    public class SelectMenuBuilder : ISelectMenuConfigurator
    {
        private SelectMenu _selectMenu = new SelectMenu()
        {
            Options = new List<InputOption>(),
            OptionGroups = new List<InputOptionGroup>()
        };

        public ISelectMenuConfigurator WithActionId(string action)
        {
            _selectMenu.ActionId = action;

            return this;
        }

        public ISelectMenuConfigurator WithOption(Action<ISelectMenuOptionConfigurator> configurator)
        {
            if (_selectMenu.OptionGroups.Any())
            {
                throw new ArgumentException("Already added option group!");
            }

            var builder = new SelectMenuOptionBuilder();

            configurator.Invoke(builder);

            var buildResult = builder.Build();
            
            _selectMenu.Options.Add(buildResult.Option);

            if (buildResult.Initial)
            {
                _selectMenu.InitialOption = buildResult.Option;
            }

            return this;
        }

        public ISelectMenuConfigurator WithOptionGroup(Action<ISelectMenuOptionGroupConfigurator> configurator)
        {
            if (_selectMenu.OptionGroups.Any())
            {
                throw new ArgumentException("Already added option!");
            }

            var builder = new SelectMenuOptionGroupBuilder();

            configurator.Invoke(builder);

            var buildResult = builder.Build();
            
            _selectMenu.OptionGroups.Add(buildResult.Group);

            if (buildResult.Initial)
            {
                _selectMenu.InitialOption = buildResult.Group;
            }

            return this;
        }

        public ISelectMenuConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> configurator)
        {
            var builder = new ConfirmationDialogConfiguratorBuilder();
            
            configurator.Invoke(builder);

            _selectMenu.ConfirmationDialog = builder.Build();

            return this;
        }

        public ISelectMenuConfigurator FocusOnLoad(bool focus)
        {
            _selectMenu.FocusOnLoad = focus;

            return this;
        }

        public ISelectMenuConfigurator WithPlaceholder(string text, bool emoji = true)
        {
            _selectMenu.Placeholder = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public SelectMenu Build()
        {
            return _selectMenu;
        }
    }
}