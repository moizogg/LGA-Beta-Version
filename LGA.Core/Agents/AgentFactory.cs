using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Core.Agents
{
    public static class AgentFactory
    {
        public static IAgent Create(
            string type
        )
        {
            switch (type)
            {
                case "Lead":
                    return new LeadQualificationAgent();

                default:
                    throw new Exception("Unknown Agent Type");
            }
        }
    }
}
