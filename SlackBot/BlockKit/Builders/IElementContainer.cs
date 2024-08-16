using System;
using SlackBotDotNet.BlockKit.Builders.Elements;
using SlackBotDotNet.BlockKit.Builders.Elements.Checkboxes;
using SlackBotDotNet.BlockKit.Builders.Elements.Workflow;
using SlackBotDotNet.BlockKit.Builders.Text;

namespace SlackBotDotNet.BlockKit.Builders
{
    public interface IElementContainer<T>
    {
    }

    public interface IButtonContainer<T> : IElementContainer<T>
    {
        T WithButton(Action<IButtonConfigurator> configurator);
    }

    public interface ICheckboxesContainer<T> : IElementContainer<T>
    {
        T WithCheckboxes(Action<ICheckboxesConfigurator> configurator);
    }

    public interface IDatePickerContainer<T> : IElementContainer<T>
    {
        T WithDatePicker(Action<IDatePickerConfigurator> configurator);
    }
    
    public interface IDateTimePickerContainer<T> : IElementContainer<T>
    {
        T WithDateTimePicker(Action<IDateTimePickerConfigurator> configurator);
    }

    public interface IEmailInputContainer<T> : IElementContainer<T>
    {
        T WithEmailInputPicker(Action<IEmailInputConfigurator> configurator);
    }
    
    public interface IFileInputContainer<T> : IElementContainer<T>
    {
        T WithFileInputPicker(Action<IFileInputConfigurator> configurator);
    }
    
    public interface IImageContainer<T> : IElementContainer<T>
    {
        T WithImage(Action<IImageConfigurator> configurator);
    }

    public interface IMultiSelectMenuContainer<T> : IElementContainer<T>
    {
        T WithMultiSelectMenu(Action<IMultiSelectMenuConfigurator> configurator);
    }
    
    public interface INumberInputContainer<T> : IElementContainer<T>
    {
        T WithNumberInput(Action<INumberInputConfigurator> configurator);
    }
    
    public interface IOverflowMenuContainer<T> : IElementContainer<T>
    {
        T WithOverflowMenu(Action<IOverflowMenuConfigurator> configurator);
    }
    
    public interface IPlainTextInputContainer<T> : IElementContainer<T>
    {
        T WithPlainTextInput(Action<IPlainTextInputConfigurator> configurator);
    }
    
    public interface ITextContainer<T> : IElementContainer<T>
    {
        T WithText(Action<ITextObjectConfigurator> configurator);
    }
    
    public interface IRadioButtonsContainer<T> : IElementContainer<T>
    {
        T WithRadioButtons(Action<IRadioButtonsConfigurator> configurator);
    }
    
    public interface IRichTextInputContainer<T> : IElementContainer<T>
    {
        T WithRichTextInput(Action<IRichTextInputConfigurator> configurator);
    }
    
    public interface ISelectMenuContainer<T> : IElementContainer<T>
    {
        T WithSelectMenu(Action<ISelectMenuConfigurator> configurator);
    }
    
    public interface ITimePickerContainer<T> : IElementContainer<T>
    {
        T WithTimePicker(Action<ITimePickerConfigurator> configurator);
    }
    
    public interface IUrlInputContainer<T> : IElementContainer<T>
    {
        T WithUrlInput(Action<IUrlInputElementConfigurator> configurator);
    }
    
    public interface IWorkflowButtonContainer<T> : IElementContainer<T>
    {
        T WithWorkflowButton(Action<IWorkflowButtonConfigurator> configurator);
    }
}