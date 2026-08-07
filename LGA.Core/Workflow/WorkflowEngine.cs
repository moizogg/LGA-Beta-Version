using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Core.Workflow
{
    public class WorkflowEngine
    {
        private readonly List<IWorkflowStep> _steps;
        public WorkflowEngine()
        {
            _steps = new List<IWorkflowStep>();
        }
        public void AddStep(IWorkflowStep step)
        {
            _steps.Add(step);
        }

        public async Task ExecuteAsync(AgentContext context)
        {
            foreach (var step in _steps)
            {
                await step.ExecuteAsync(context);
            }
        }
    }
}
