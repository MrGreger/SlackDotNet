using System;
using SlackBotDotNet.BlockKit.Elements;
using SlackBotDotNet.BlockKit.Text;

namespace SlackBotDotNet.BlockKit.Builders.Elements.Workflow
{
    public interface IWorkflowButtonConfigurator
    {
        IWorkflowButtonConfigurator WithActionId(string actionId);
        IWorkflowButtonConfigurator WithText(string text, bool emoji = true);
        IWorkflowButtonConfigurator WithWorkflow(Action<IWorkflowTriggerConfigurator> configurator);
        IWorkflowButtonConfigurator Primary();
        IWorkflowButtonConfigurator Danger();
        IWorkflowButtonConfigurator Default();
        IWorkflowButtonConfigurator WithAccessibilityLabel(string text);
    }
    
    public class WorkflowButtonBuilder :IWorkflowButtonConfigurator
    {
        private WorkflowButton _workflowButton = new WorkflowButton();
        
        public IWorkflowButtonConfigurator WithActionId(string actionId)
        {
            _workflowButton.ActionId = actionId;

            return this;
        }

        public IWorkflowButtonConfigurator WithText(string text, bool emoji = true)
        {
            _workflowButton.Text = new PlainText(emoji)
            {
                Value = text
            };

            return this;
        }

        public IWorkflowButtonConfigurator WithWorkflow(Action<IWorkflowTriggerConfigurator> configurator)
        {
            var builder = new WorkflowTriggerBuilder();
            
            configurator.Invoke(builder);

            _workflowButton.Workflow = new BlockKit.Elements.Workflow()
            {
                Trigger = builder.Build()
            };

            return this;
        }

        public IWorkflowButtonConfigurator Primary()
        {
            _workflowButton.Style = WorkflowButton.Styles.Primary;

            return this;
        }

        public IWorkflowButtonConfigurator Danger()
        {
            _workflowButton.Style = WorkflowButton.Styles.Danger;

            return this;
        }

        public IWorkflowButtonConfigurator Default()
        {
            _workflowButton.Style = null;

            return this;
        }

        public IWorkflowButtonConfigurator WithAccessibilityLabel(string text)
        {
            _workflowButton.AccessibilityLabel = text;

            return this;
        }

        public WorkflowButton Build()
        {
            if (string.IsNullOrWhiteSpace(_workflowButton.ActionId))
            {
                throw new Exception("Action is empty");
            }
            
            if(_workflowButton.Text == null)
            {
                throw new Exception("Text is empty");
            }
            
            if(_workflowButton.Workflow == null)
            {
                throw new Exception("Workflow is empty");
            }

            return _workflowButton;
        }
    }
}