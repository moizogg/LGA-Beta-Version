using LGA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Core.Workflow
{
    public class AgentContext
    {
        public Lead Lead { get; set; }
        public DateTime CreatedAt { get; set; }
        public AgentContext(Lead lead)
        {
            Lead = lead;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
