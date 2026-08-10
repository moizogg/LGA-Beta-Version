using Microsoft.EntityFrameworkCore;
using LGA.Data.Context;
using LGA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Data.Repositories
{
    public class LeadRepository : ILeadRepository
    {
        private readonly DatabaseContext _context;
        public LeadRepository(
            DatabaseContext context
        )
        {
            _context = context;
        }

        public async Task<List<LeadEntity>>
            GetAllAsync()
        {
            return await _context.Leads
                .ToListAsync();
        }

        public async Task<LeadEntity?>
            GetByIdAsync(Guid id)
        {
            return await _context.Leads
                .FirstOrDefaultAsync(
                    x => x.Id == id
                );
        }

        public async Task AddAsync(
            LeadEntity lead
        )
        {
            await _context.Leads.AddAsync(
                lead
            );
        }
        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
