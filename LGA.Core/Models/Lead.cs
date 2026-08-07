using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Core.Models
{
    public class Lead
    {

        public Guid Id { get; set; }

        public string Name { get; set; }
            = string.Empty;

        public string Company { get; set; }
            = string.Empty;

        public string Email { get; set; }
            = string.Empty;

        public int Score { get; set; }

        public LeadStatus Status { get; set; }


    }
}
