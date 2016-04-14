using BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Infrastructure
{
    public class BugRepository : GenericRepository<Bug>
    {
        public BugRepository(ApplicationDbContext db) : base(db) { }
    }
}
