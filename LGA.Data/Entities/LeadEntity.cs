using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Data.Entities
{
    public class LeadEntity
    {
        public Guid Id { get; set; }
        public string Name
        {
            get;
            set;
        } = string.Empty;
        public string Company
        {
            get;
            set;
        } = string.Empty;
        public string Email
        {
            get;
            set;
        } = string.Empty;
        public int Score
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        } = string.Empty;
        public DateTime CreatedAt
        {
            get;
            set;
        }
    }
}
