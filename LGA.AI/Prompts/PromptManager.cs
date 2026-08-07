using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.AI.Prompts
{
    public class PromptManager
    {
        private readonly List<PromptTemplate>
            _prompts;

        public PromptManager()
        {
            _prompts =
                new List<PromptTemplate>();
            LoadDefaultPrompts();
        }

        private void LoadDefaultPrompts()
        {
            _prompts.Add(
                new PromptTemplate
                {
                    Name =
                    "Lead Analysis",
                    Content =
                    """
                        Analyze this lead.
                        Provide score from 0-100
                        and explain why.
                        """
                });
        }

        public PromptTemplate? Get(
            string name
        )
        {
            return _prompts
                .FirstOrDefault(
                    x => x.Name == name
                );
        }
    }
}
