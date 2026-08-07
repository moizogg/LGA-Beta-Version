using LGA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Data.Repositories
{
    public interface ILeadRepository
    {
        Task<List<LeadEntity>> GetAllAsync();
        Task<LeadEntity?> GetByIdAsync(Guid id);
        Task AddAsync(LeadEntity lead);
        Task SaveAsync();
    }
}
