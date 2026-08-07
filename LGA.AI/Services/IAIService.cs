using LGA.AI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.AI.Services
{
    public interface IAIService
    {
        Task<AIResponse> AnalyzeAsync(
            string input
        );
    }
}
