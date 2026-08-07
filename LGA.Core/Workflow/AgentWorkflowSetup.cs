using LGA.Core.Agents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Core.Workflow
{
    public class AgentWorkflowStep : IWorkflowStep
    {
        private readonly IAgent _agent;
        public string Name => _agent.Name;

        public AgentWorkflowStep(IAgent agent)
        {
            _agent = agent;
        }

        public async Task ExecuteAsync(AgentContext context)
        {
            await _agent.ExecuteAsync(
                context.Lead
            );
        }
    }
}
