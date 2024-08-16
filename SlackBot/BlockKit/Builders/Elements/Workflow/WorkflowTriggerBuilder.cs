using System;

namespace SlackBot.Blocks.Builders.Workflow
{
    public interface IWorkflowTriggerConfigurator
    {
        IWorkflowTriggerConfigurator WithUrl(string url);
        IWorkflowTriggerConfigurator WithInputParameter(string name, string value);
    }
    
    public class WorkflowTriggerBuilder:IWorkflowTriggerConfigurator
    {
        private Blocks.Elements.Workflow.WorkflowTrigger _trigger = new Blocks.Elements.Workflow.WorkflowTrigger();
        
        public IWorkflowTriggerConfigurator WithUrl(string url)
        {
            _trigger.Url = url;

            return this;
        }

        public IWorkflowTriggerConfigurator WithInputParameter(string name, string value)
        {
            _trigger.InputParameters.Add(new Blocks.Elements.Workflow.WorkflowTrigger.TriggerInputParameter()
            {
                Name = name,
                Value = value
            });

            return this;
        }

        public Blocks.Elements.Workflow.WorkflowTrigger Build()
        {
            if (string.IsNullOrWhiteSpace(_trigger.Url))
            {
                throw new Exception("Url is empty");
            }

            return _trigger;
        }
    }
}