using LGA.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Core.Agents
{
    public class LeadQualificationAgent : AgentBase
    {
        public override string Name => "Lead Qualification Agent";

        public override Task ExecuteAsync(Lead lead)
        {
            if (lead.Score >= 80)
            {
                lead.Status = LeadStatus.Hot;
            }
            else
            {
                lead.Status = LeadStatus.Warm;
            }
            return Task.CompletedTask;
        }
    }
}
