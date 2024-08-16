using System;
using System.Collections.Generic;
using SlackBotDotNet.BlockKit.Builders.Elements.Options;
using SlackBotDotNet.BlockKit.Elements;
using SlackBotDotNet.BlockKit.Options;

namespace SlackBotDotNet.BlockKit.Builders.Elements
{
    public interface IRadioButtonsConfigurator
    {
        IRadioButtonsConfigurator WithActionId(string actionId);
        IRadioButtonsConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> builder);
        IRadioButtonsConfigurator FocusOnLoad(bool focus);
        IRadioButtonsConfigurator AddOption(Action<IRadioButtonOptionConfigurator> builder);
    }
    
    public class RadioButtonsBuilder : IRadioButtonsConfigurator
    {
        private RadioButtons _radioButtons = new RadioButtons();
        private List<InputOption> _inputOptions = new List<InputOption>();
        
        public IRadioButtonsConfigurator WithActionId(string actionId)
        {
            _radioButtons.ActionId = actionId;
            return this;
        }

        public IRadioButtonsConfigurator WithConfirmationDialog(Action<IConfirmationDialogConfigurator> builder)
        {
            var dialogBuilder = new ConfirmationDialogConfiguratorBuilder();

            builder.Invoke(dialogBuilder);

            _radioButtons.Confirmation = dialogBuilder.Build();

            return this;
        }

        public IRadioButtonsConfigurator FocusOnLoad(bool focus)
        {
            _radioButtons.FocusOnLoad = focus;

            return this;
        }

        public IRadioButtonsConfigurator AddOption(Action<IRadioButtonOptionConfigurator> builder)
        {
            if (_inputOptions.Count >= 10)
            {
                throw new ArgumentException("radio button can have up to 10 options");
            }
            
            var optionBuilder = new RadioButtonOptionBuilder();

            builder.Invoke(optionBuilder);

            var buildResult = optionBuilder.Build();
            _inputOptions.Add(buildResult.option);

            if (buildResult.initial)
            {
                _radioButtons.InitialOption = buildResult.option;
            }
            
            return this;
        }

        public RadioButtons Build()
        {
            _radioButtons.Options = _inputOptions.ToArray();
            return _radioButtons;
        }
    }
}