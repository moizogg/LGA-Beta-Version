using LGA.AI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.AI.Services
{
    public class OpenAIService : IAIService
    {
        public async Task<AIResponse> AnalyzeAsync(string input)
        {

            await Task.Delay(500);

            return new AIResponse
            {
                Score = 85,
                Category = "Hot",
                Reason =
                "Potential high value lead"
            };
        }
    }
}
