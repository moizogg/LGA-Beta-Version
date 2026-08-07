using Microsoft.EntityFrameworkCore;
using LGA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGA.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<LeadEntity> Leads
        {
            get;
            set;
        }

        public DatabaseContext(
            DbContextOptions<DatabaseContext> options
        )
            : base(options)
        {

        }
    }
}
