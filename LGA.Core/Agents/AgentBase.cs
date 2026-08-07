using LGA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Core.Agents
{
    public abstract class AgentBase : IAgent
    {
        public abstract string Name
        {
            get;
        }

        public abstract Task ExecuteAsync(
            Lead lead
        );
    }
}
