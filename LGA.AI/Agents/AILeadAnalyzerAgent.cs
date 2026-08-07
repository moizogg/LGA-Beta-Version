using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGA.Core.Agents;
using LGA.Core.Models;
using LGA.AI.Services;
using LGA.AI.Prompts;

namespace LGA.AI.Agents
{
    public class AILeadAnalyzerAgent : AgentBase
    {
        private readonly IAIService _aiService;
        private readonly PromptManager _promptManager;
        public AILeadAnalyzerAgent(
            IAIService aiService,
            PromptManager promptManager
        )
        {
            _aiService = aiService;
            _promptManager = promptManager;
        }

        public override string Name
            => "AI Lead Analyzer Agent";

        public override async Task ExecuteAsync(
            Lead lead
        )
        {
            var prompt =
                _promptManager.Get(
                    "Lead Analysis"
                );

            string input =
                $"""
            Company:
            {lead.Company}

            Contact:
            {lead.Name}

            Email:
            {lead.Email}

            Instruction:
            {prompt?.Content}
            """;

            var result = await _aiService.AnalyzeAsync(input);

            lead.Score =
                result.Score;

            if (result.Score >= 80)
            {
                lead.Status =
                    LeadStatus.Hot;
            }
            else
            {
                lead.Status = LeadStatus.Warm;
            }
        }
    }
}
