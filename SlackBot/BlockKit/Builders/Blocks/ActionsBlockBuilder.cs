using System;
using SlackBotDotNet.BlockKit.Blocks;
using SlackBotDotNet.BlockKit.Builders.Elements;
using SlackBotDotNet.BlockKit.Builders.Elements.Checkboxes;
using SlackBotDotNet.BlockKit.Builders.Elements.Workflow;

namespace SlackBotDotNet.BlockKit.Builders.Blocks
{
    public interface IActionsBlockConfigurator : IButtonContainer<IActionsBlockConfigurator>,
                                              ICheckboxesContainer<IActionsBlockConfigurator>,
                                              IDatePickerContainer<IActionsBlockConfigurator>,
                                              IDateTimePickerContainer<IActionsBlockConfigurator>,
                                              IMultiSelectMenuContainer<IActionsBlockConfigurator>,
                                              IOverflowMenuContainer<IActionsBlockConfigurator>,
                                              IRadioButtonsContainer<IActionsBlockConfigurator>,
                                              ISelectMenuContainer<IActionsBlockConfigurator>,
                                              ITimePickerContainer<IActionsBlockConfigurator>,
                                              IWorkflowButtonContainer<IActionsBlockConfigurator>
    {
        IActionsBlockConfigurator WithId(string id);
    }

    public class ActionsBlockBuilder : IActionsBlockConfigurator
    {
        private ActionsBlock _actionsBlock = new ActionsBlock();

        public IActionsBlockConfigurator WithButton(Action<IButtonConfigurator> configurator)
        {
            var builder = new ButtonBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());

            return this;
        }

        public IActionsBlockConfigurator WithCheckboxes(Action<ICheckboxesConfigurator> configurator)
        {
            var builder = new CheckboxesBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());

            return this;
        }

        public IActionsBlockConfigurator WithDatePicker(Action<IDatePickerConfigurator> configurator)
        {
            var builder = new DatePickerBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());

            return this;
        }

        public IActionsBlockConfigurator WithDateTimePicker(Action<IDateTimePickerConfigurator> configurator)
        {
            var builder = new DateTimePickerBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());

            return this;
        }

        public IActionsBlockConfigurator WithMultiSelectMenu(Action<IMultiSelectMenuConfigurator> configurator)
        {
            var builder = new MultiSelectMenuBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());

            return this;
        }

        public IActionsBlockConfigurator WithOverflowMenu(Action<IOverflowMenuConfigurator> configurator)
        {
            var builder = new OverflowMenuBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());

            return this;
        }

        public IActionsBlockConfigurator WithRadioButtons(Action<IRadioButtonsConfigurator> configurator)
        {
            var builder = new RadioButtonsBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsBlockConfigurator WithSelectMenu(Action<ISelectMenuConfigurator> configurator)
        {
            var builder = new SelectMenuBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsBlockConfigurator WithTimePicker(Action<ITimePickerConfigurator> configurator)
        {
            var builder = new TimePickerBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsBlockConfigurator WithWorkflowButton(Action<IWorkflowButtonConfigurator> configurator)
        {
            var builder = new WorkflowButtonBuilder();

            configurator.Invoke(builder);

            _actionsBlock.Elements.Add(builder.Build());
            
            return this;
        }

        public IActionsBlockConfigurator WithId(string id)
        {
            _actionsBlock.BlockId = id;

            return this;
        }

        public ActionsBlock Build()
        {
            return _actionsBlock;
        }
    }
}