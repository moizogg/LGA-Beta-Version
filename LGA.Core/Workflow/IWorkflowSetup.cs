using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Core.Workflow
{
    public interface IWorkflowStep
    {
        string Name
        {
            get;
        }
        Task ExecuteAsync(
            AgentContext context
        );
    }
}
