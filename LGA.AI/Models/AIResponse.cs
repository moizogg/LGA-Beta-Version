using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.AI.Models
{
    public class AIResponse
    {
        public int Score { get; set; }
        public string Category
        {
            get; set;
        } = string.Empty;

        public string Reason
        {
            get;
            set;
        } = string.Empty;
    }
}
